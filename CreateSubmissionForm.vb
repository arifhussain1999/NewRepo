Imports System.Net.Http
Imports System.Text
Imports System.Text.Json
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class CreateSubmissionForm

    Private stopwatch As Stopwatch
    Private stopwatchRunning As Boolean = False
    Private ReadOnly httpClient As HttpClient

    Public Sub New()
        InitializeComponent()
        stopwatch = New Stopwatch()
        AddHandler btnSubmit.Click, AddressOf btnSubmit_Click
        AddHandler btnToggleStopwatch.Click, AddressOf btnToggleStopwatch_Click
        AddHandler Me.KeyDown, AddressOf CreateSubmissionForm_KeyDown
        Me.KeyPreview = True ' Ensures form captures key presses
        httpClient = New HttpClient()
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs)
        If stopwatchRunning Then
            stopwatch.Stop()
            stopwatchRunning = False
        Else
            stopwatch.Start()
            stopwatchRunning = True
        End If
        UpdateStopwatchDisplay()
    End Sub

    Private Sub UpdateStopwatchDisplay()
        txtStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs)
        ' Submit the form data to the backend
        Dim submission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .PhoneNumber = txtPhoneNumber.Text,
            .GitHubLink = txtGitHubLink.Text,
            .ElapsedTime = stopwatch.Elapsed.ToString("hh\:mm\:ss")
        }

        ' Convert the submission object to JSON
        Dim json As String = JsonSerializer.Serialize(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Try
            Dim response As HttpResponseMessage = Await httpClient.PostAsync("http://localhost:3000/submit", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Form submitted successfully!")
            Else
                MessageBox.Show("Failed to submit form.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        End If
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property PhoneNumber As String
    Public Property GitHubLink As String
    Public Property ElapsedTime As String
End Class
