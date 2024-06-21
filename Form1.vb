Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json

Public Class Form1
    Private ReadOnly httpClient As HttpClient

    Public Sub New()
        InitializeComponent()
        httpClient = New HttpClient()
        Me.KeyPreview = True ' Ensure form captures key presses
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Any additional initialization tasks can be added here
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.ShowDialog()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.ShowDialog()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then ' Example shortcut Ctrl + V
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then ' Example shortcut Ctrl + N
            btnCreateSubmission.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then ' Example shortcut Ctrl + D
            btnDeleteSubmission.PerformClick()
        End If
    End Sub

    Private Async Sub btnDeleteSubmission_Click(sender As Object, e As EventArgs) Handles btnDeleteSubmission.Click
        Dim phoneNumber As String = txtPhoneNumberToDelete.Text

        If String.IsNullOrWhiteSpace(phoneNumber) Then
            MessageBox.Show("Please enter a phone number.")
            Return
        End If

        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:3000")
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Try
                Dim response As HttpResponseMessage = Await client.DeleteAsync($"/submissions/{phoneNumber}")

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission deleted successfully.")
                ElseIf response.StatusCode = System.Net.HttpStatusCode.NotFound Then
                    MessageBox.Show("Phone number not found.")
                Else
                    MessageBox.Show("Failed to delete submission: " & response.ReasonPhrase)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
