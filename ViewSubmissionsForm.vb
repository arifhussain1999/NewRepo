Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)

    Public Sub New()
        InitializeComponent()
        LoadSubmissions()
        Me.KeyPreview = True
    End Sub

    Private Async Sub LoadSubmissions()
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:3000")
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Try
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
                    MessageBox.Show("Error loading submissions: " & response.ReasonPhrase)
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading submissions: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If submissions IsNot Nothing AndAlso submissions.Count > 0 AndAlso index >= 0 AndAlso index < submissions.Count Then
            ' Display submission details
            stName.Text = submissions(index).Name
            stEmail.Text = submissions(index).Email
            stNumber.Text = submissions(index).PhoneNumber
            stGithub.Text = submissions(index).GitHubLink
            stStopwatch.Text = submissions(index).ElapsedTime
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

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then ' Example shortcut Ctrl + P
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then ' Example shortcut Ctrl + N
            btnNext.PerformClick()
        End If
    End Sub

End Class
