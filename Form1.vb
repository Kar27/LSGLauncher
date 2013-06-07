Imports System.IO

Public Class Form1

    Private Sub NustatymaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NustatymaiToolStripMenuItem.Click
        Setings.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine(My.Settings.gtasaPath)
        If My.Settings.gtasaPath = Nothing Then ' Viskas žemiau yra skirta samp / cleo / gta patikrai
            MsgBox("Nustatymuose nustatykite GTA:SA kelia.", MsgBoxStyle.Critical, "Dėmesio")
            Exit Sub
        End If
        If Not Directory.Exists("C:\LsglTemp") Then
            Directory.CreateDirectory("C:\LsglTemp")
        End If
            If Not My.Settings.cleoExists Then
                If Not File.Exists(My.Settings.gtasaPath & "\CLEO.asi") Then
                    Console.WriteLine("No CLEO :(")
                    Downloader.Download("https://dl.dropboxusercontent.com/u/111217126/CLEO4.exe", "C:\LsglTemp\CLEO4.exe")
                Process.Start("""C:\\LsglTemp\\CLEO4.exe""", "/S")
                End If
            End If
            If Not My.Settings.sampExists Then
                If Not File.Exists(My.Settings.gtasaPath & "\samp.exe") Then
                    Console.WriteLine("No samp :(")
                    Downloader.Download("https://dl.dropboxusercontent.com/u/111217126/samp0.3x.exe", "C:/LsglTemp/samp0.3x.exe")
                Process.Start("""C:\\LsglTemp\\samp0.3x.exe""", "/S")
                End If
            End If
    End Sub
    Dim WithEvents gta_sa As Process
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.gtasaPath = Nothing Then 
            MsgBox("Nustatymuose nustatykite GTA:SA kelia.", MsgBoxStyle.Critical, "Dėmesio")
            Exit Sub
        ElseIf Not File.Exists(My.Settings.gtasaPath & "\gta_sa.exe") Then
            MsgBox("Netinkamas GTA:SA kelias.", MsgBoxStyle.Critical, "Dėmesio")
            Exit Sub
        End If
        If TextBox1.Text.Length = 0 Then
            MsgBox("Negali būti paliktas tuščias ""Username"" laukas." & vbNewLine & "Žaidimas nepasileis.", MsgBoxStyle.Information, "Informacija")
            Exit Sub
        End If
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\SAMP", "PlayerName", TextBox1.Text)
        gta_sa.StartInfo = New ProcessStartInfo(My.Settings.gtasaPath & "\gta_sa.exe", "-c -h localhost -p 7777") 'Pakrauna i darbine atminti paleidimo komanda
        File.Copy(My.Settings.gtasaPath & "\samp.dll", My.Settings.gtasaPath & "\samp.asi") 'Parengia SAMP mod
        gta_sa.Start() ' Paleidžia samp
        gta_sa.EnableRaisingEvents = True ' leidžia aptikti kada buna uždarytas samp'as
        AddHandler gta_sa.Exited, AddressOf UnLoadSampAsiFile
    End Sub
    Sub UnLoadSampAsiFile()
        gta_sa.WaitForExit()
        File.Delete(My.Settings.gtasaPath & "\samp.asi") ' Unloadina samp moda, kad gta single ir papratas samp veiktu tinkamai
    End Sub

    Private Sub PraneštiBugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PraneštiBugToolStripMenuItem.Click
        Process.Start("https://docs.google.com/forms/d/1hWA-x8cLZgHsZDfDIf7rFXIvawctdAa31H9xf9tGPTk/viewform")
    End Sub
End Class
