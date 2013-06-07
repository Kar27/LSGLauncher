Imports System.IO
Public Class Setings

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not File.Exists(Environment.SpecialFolder.CommonProgramFilesX86 & "\Rockstar Games\GTA San Andreas\gta_sa.exe") Then
            MsgBox("Jusu kompiuteryje nera ""GTA:SA"" arba yra įrašytas kitur")
        ElseIf File.Exists(Environment.SpecialFolder.CommonProgramFilesX86 & "\Rockstar Games\GTA San Andreas\gta_sa.exe") Then
            My.Settings.gtasaPath = Environment.SpecialFolder.CommonProgramFilesX86 & "\Rockstar Games\GTA San Andreas"
        End If
        If Not File.Exists(Environment.SpecialFolder.CommonProgramFiles & "\Rockstar Games\GTA San Andreas\gta_sa.exe") Then
            MsgBox("Jusu kompiuteryje nera ""GTA:SA"" arba yra įrašytas kitur")
        ElseIf File.Exists(Environment.SpecialFolder.CommonProgramFiles & "\Rockstar Games\GTA San Andreas\gta_sa.exe") Then
            My.Settings.gtasaPath = Environment.SpecialFolder.CommonProgramFiles & "\Rockstar Games\GTA San Andreas"
        End If
        TextBox1.Text = My.Settings.gtasaPath
        My.Settings.Save()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim picker As New Windows.Forms.FolderBrowserDialog
        picker.ShowDialog()
        Console.WriteLine(picker.SelectedPath)
        If Not File.Exists(picker.SelectedPath & "\gta_sa.exe") Then
            MsgBox("Jusu pasirinktoje vietoje nera ""GTA:SA""")
        ElseIf File.Exists(picker.SelectedPath & "\gta_sa.exe") Then
            My.Settings.gtasaPath = picker.SelectedPath & ""
        End If
        TextBox1.Text = My.Settings.gtasaPath
        My.Settings.Save()
    End Sub

    Private Sub Setings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.gtasaPath
    End Sub
End Class