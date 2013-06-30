Imports System.Net
Public Class Downloader 'kas yra čia tai tik kodas atsiusiusti failus
    Dim WithEvents down As WebClient
    Public Event DownloadDone(ByVal FileUrl As String)
    Dim curDownUrl As String
    Dim DownTime As Integer

    Sub Download(fileurl As String, savepos As String)
        curDownUrl = fileurl
        DownTime = 0
        down = New WebClient

        down.DownloadFileAsync(New Uri(fileurl), savepos)
        Timer1.Start()
        Timer2.Start()
        Me.ShowDialog()
    End Sub

    Private Sub down_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles down.DownloadProgressChanged
        Label1.Text = e.BytesReceived & " / " & e.TotalBytesToReceive
        Label1.Location = New Point(ProgressBar1.Size.Width / 2 - Label1.Size.Width / 2, Label1.Location.Y)
        'ProgressBar1.Value = e.ProgressPercentage
        ProgressBar1.Increment(e.ProgressPercentage - ProgressBar1.Value)
        If e.ProgressPercentage = 100 Then
            Timer1.Stop()
            Timer2.Stop()
            RaiseEvent DownloadDone(curDownUrl)
            Me.Close()
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        DownTime = DownTime + 1 'second counter whic is hidden in the form
    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim SpeedFormula As Single = (ProgressBar1.Value / DownTime)
        Dim SpeedOperationK As Single = SpeedFormula * 1000
        Dim SpeedOperationM As Single = SpeedFormula
        Dim TimeFormula As Single = ((100 - ProgressBar1.Value) / ((ProgressBar1.Value / DownTime) * 1000))
        Dim TimeOperationS As Single = TimeFormula * 1000
        Dim TimeOperationM As Single = (TimeFormula * 1000) * 60
        Dim TimeOperationH As Single = (TimeFormula * 1000) * 3600

        If SpeedOperationK < 1000 Then
            Label3.Text = "Siuntimo Geritis: " & Mid(SpeedOperationK, 1, 3) & " KB/sek"
        ElseIf SpeedOperationK > 999 Then
            Label3.Text = "Siuntimo Geritis: " & Mid(SpeedOperationM, 1, 3) & " MB/sek"
        End If


        If TimeOperationS < 61 Then
            Label2.Text = "Liko: " & Mid(TimeOperationS, 1, 1) & " sekundės"
        ElseIf TimeOperationS > 60 Then
            Label2.Text = "Liko: " & Mid(TimeOperationM, 1, 1) & " min. ir " & Mid(TimeOperationM, 2, 1) & " sek"
        ElseIf TimeOperationS > 3599 Then
            Label2.Text = "Liko: " & Mid(TimeOperationH, 1, 1) & "val. ir " & Mid(TimeOperationH, 2, 1) & " min."
        End If


    End Sub

End Class
