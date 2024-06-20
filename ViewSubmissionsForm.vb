Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)

    Public Sub New()
        InitializeComponent()
        LoadSubmissions()
    End Sub

    Private Async Sub LoadSubmissions()
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:3000") ' Replace with your backend URL
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim response As HttpResponseMessage = Await client.GetAsync("/submissions")

            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(jsonResponse)
                If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
                    DisplaySubmission(currentIndex)
                Else
                    MessageBox.Show("No submissions found.")
                End If
            Else
                MessageBox.Show("Error loading submissions.")
            End If
        End Using
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If submissions IsNot Nothing AndAlso submissions.Count > 0 AndAlso index >= 0 AndAlso index < submissions.Count Then
            ' Display submission details
            stName.Text = submissions(index).Name
            stEmail.Text = submissions(index).Email
            stNumber.Text = submissions(index).PhoneNumber
            stGithub.Text = submissions(index).GitHubLink
            stStopwatch.Text = submissions(index).ElapsedTime.ToString("hh\:mm\:ss")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub
End Class