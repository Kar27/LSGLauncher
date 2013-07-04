Imports System.IO
Public Class Setings

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim GtaSaEXEPath As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHIME\SOFTWARE\Rockstar Games\GTA San Andreas\Installation", "ExePath", "")
        Dim GtaSaPath As String = GtaSaEXEPath.Substring(1).Substring(0, GtaSaEXEPath.Length - "\gta_sa.exe""".Length - 1)
        If Not File.Exists(GtaSaPath & "\gta_sa.exe") Then
            MsgBox("Jusu kompiuteryje nera ""GTA:SA""")
        ElseIf File.Exists(GtaSaPath & "\gta_sa.exe") Then
            My.Settings.gtasaPath = GtaSaPath
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