Imports System.IO
Imports System.Security.AccessControl

Public Class Main
    Public servers As New System.Collections.Specialized.StringCollection
    Public usernameeee As String
    Private Sub NustatymaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NustatymaiToolStripMenuItem.Click
        Setings.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LSGNews As New RSSChannel("http://www.lsgyvenimas.lt/index.php?option=com_content&view=category&id=1&format=feed")
        Dim doctxt As String = "<body bgcolor=""#2F3333""><font size=""2"" face=""Helvetica"" color=""#DEE9ED"">"
        For Each Arcticle As RSSItem In LSGNews.GetChannelItems()
            doctxt &= "<font size=""5"">" & Arcticle.Title & "</font><br />" & Arcticle.Description & vbNewLine & "<br />"
        Next
        doctxt &= "</font></body>"
        WebBrowser1.DocumentText = doctxt

        If My.Settings.moservers Then
            PridėtiServeriToolStripMenuItem.Visible = True
            PašalintiServerisToolStripMenuItem.Visible = True
            ComboBox1.Visible = True
        Else
            PridėtiServeriToolStripMenuItem.Visible = False
            PašalintiServerisToolStripMenuItem.Visible = False
            ComboBox1.Visible = False
        End If
        servers = My.Settings.Servers
        ComboBox1.Text = "LSG"
        Console.WriteLine(My.Settings.gtasaPath)
        If My.Settings.gtasaPath = Nothing Then ' Viskas žemiau yra skirta samp / cleo / gta patikrai
            Dim GtaSaEXEPath As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Rockstar Games\GTA San Andreas\Installation", "ExePath", "lolololoolololol")
            Dim GtaSaPath As String = GtaSaEXEPath.Substring(1)
            GtaSaPath = GtaSaPath.Substring(0, GtaSaPath.Length - "\gta_sa.exe""".Length)
            If Not File.Exists(GtaSaPath & "\gta_sa.exe") Then
                MsgBox("Jusu kompiuteryje nera ""GTA:SA""")
            ElseIf File.Exists(GtaSaPath & "\gta_sa.exe") Then
                My.Settings.gtasaPath = GtaSaPath
            End If
            TextBox1.Text = My.Settings.gtasaPath
            My.Settings.Save()
        End If
        If Not Directory.Exists("C:\LsglTemp") Then
            Directory.CreateDirectory("C:\LsglTemp")
        End If
        'If Not My.Settings.cleoExists Then
        'If Not File.Exists(My.Settings.gtasaPath & "\CLEO.asi") Then
        ' Console.WriteLine("No CLEO :(")
        'Downloader.Download("https://dl.dropboxusercontent.com/u/111217126/CLEO4.exe", "C:\LsglTemp\CLEO4.exe")
        '    Process.Start("""C:\\LsglTemp\\CLEO4.exe""", "/S")
        '   End If
        '  End If
        If Not My.Settings.sampExists Then
            If (Not File.Exists(My.Settings.gtasaPath & "\samp.exe")) And (File.Exists(My.Settings.gtasaPath & "\gta_sa.exe")) Then
                Console.WriteLine("No samp :(")
                Downloader.Download("https://dl.dropboxusercontent.com/u/111217126/samp0.3x.exe", "C:/LsglTemp/samp0.3x.exe")
                Process.Start("""C:\\LsglTemp\\samp0.3x.exe""", "/S")
            End If
        End If
        usernameeee = (My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\SAMP", "PlayerName", ""))
        TextBox1.Text = usernameeee
        NotifyIcon1.Visible = True
        If My.Settings.firtTime Then
            servers = New System.Collections.Specialized.StringCollection
            servers.Add(ServersUtils.Save(ServersUtils.OldFormatToNew(My.Settings.lsgadrres, "LSG")))
        End If
        For i As Integer = 0 To servers.Count - 1
            ComboBox1.Items.Add(ServersUtils.Load(servers.Item(i)).Item(0))
        Next
        My.Settings.firtTime = False
        My.Settings.Servers = servers
        My.Settings.Save()
    End Sub
    Dim WithEvents gta_sa As New Process
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

        gta_sa.StartInfo.WorkingDirectory = My.Settings.gtasaPath
        gta_sa.StartInfo.FileName = My.Settings.gtasaPath & "\samp.exe" 'Pakrauna i darbine atminti paleidimo komanda
        gta_sa.StartInfo.Arguments = "" & ServersUtils.Load(servers.Item(FindID(ComboBox1.Text))).Item(1) & ":" & ServersUtils.Load(servers.Item(FindID(ComboBox1.Text))).Item(2)
        'If Not File.Exists(My.Settings.gtasaPath & "\samp.asi") Then
        ' File.Copy(My.Settings.gtasaPath & "\samp.dll", My.Settings.gtasaPath & "\samp.asi") 'Parengia SAMP mod
        'End If
        'While Not FileCompare(My.Settings.gtasaPath & "\samp.dll", My.Settings.gtasaPath & "\samp.asi")
        'System.Threading.Thread.Sleep(25)

        'End While
        Me.Hide()
        NotifyIcon1.ShowBalloonTip(5000, "Informacija", "Paleidžiamas SAMP.", ToolTipIcon.Info)
        gta_sa.Start() ' Paleidžia samp
        gta_sa.EnableRaisingEvents = True ' leidžia aptikti kada buna uždarytas samp'as
        Threading.Thread.Sleep(3000)
        Timer1.Start()
    End Sub

    Private Sub PraneštiBugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PraneštiBugToolStripMenuItem.Click
        Process.Start("https://docs.google.com/forms/d/1hWA-x8cLZgHsZDfDIf7rFXIvawctdAa31H9xf9tGPTk/viewform")
    End Sub

    Private Sub ProgrmosKodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrmosKodasToolStripMenuItem.Click
        Process.Start("https://github.com/Kar27/LSGLauncher")
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Show()
    End Sub
    Private Function FileCompare(ByVal file1 As String, ByVal file2 As String) As Boolean
        Dim file1byte As Integer
        Dim file2byte As Integer
        Dim fs1 As FileStream
        Dim fs2 As FileStream

        ' Determine if the same file was referenced two times.
        If (file1 = file2) Then
            ' Return 0 to indicate that the files are the same.
            Return True
        End If

        ' Open the two files.
        fs1 = New FileStream(file1, FileMode.Open)
        fs2 = New FileStream(file2, FileMode.Open)

        ' Check the file sizes. If they are not the same, the files
        ' are not equal.
        If (fs1.Length <> fs2.Length) Then
            ' Close the file
            fs1.Close()
            fs2.Close()

            ' Return a non-zero value to indicate that the files are different.
            Return False
        End If

        ' Read and compare a byte from each file until either a
        ' non-matching set of bytes is found or until the end of
        ' file1 is reached.
        Do
            ' Read one byte from each file.
            file1byte = fs1.ReadByte()
            file2byte = fs2.ReadByte()
        Loop While ((file1byte = file2byte) And (file1byte <> -1))

        ' Close the files.
        fs1.Close()
        fs2.Close()

        ' Return the success of the comparison. "file1byte" is
        ' equal to "file2byte" at this point only if the files are 
        ' the same.
        Return ((file1byte - file2byte) = 0)
    End Function
    Function FindID(severname As String) As Integer
        Dim val As Integer
        For i = 0 To servers.Count - 1
            If ServersUtils.Load(servers.Item(i)).Item(0) = severname Then
                val = i
            End If
        Next
        Return val
    End Function
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Servers = servers
        My.Settings.Save()
    End Sub

    Private Sub PridėtiServeriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PridėtiServeriToolStripMenuItem.Click
        AddSrw.ShowDialog()
    End Sub

    Private Sub PašalintiServerisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PašalintiServerisToolStripMenuItem.Click
        servers.Clear()
        ComboBox1.Items.Clear()
        servers.Add(ServersUtils.Save(ServersUtils.OldFormatToNew(My.Settings.lsgadrres, "LSG")))
        For i As Integer = 0 To servers.Count - 1
            ComboBox1.Items.Add(ServersUtils.Load(servers.Item(i)).Item(0))
        Next
    End Sub

    Private Sub PajungtiFunkcijaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PajungtiFunkcijaToolStripMenuItem.Click
        Select Case InputBox("Iveskite Funkcijos koda:", "Funkcijos Aktyvinimas")
            Case "d7fc06a3cca9193e1887c9d498b2f26c"
                My.Settings.lsgadrres = InputBox("Iveskite Nauja LSG Serverio adresa:", "Atnaujinti Serverio Adresa")
                servers.Clear()
                ComboBox1.Items.Clear()
                servers.Add(ServersUtils.Save(ServersUtils.OldFormatToNew(My.Settings.lsgadrres, "LSG")))
                For i As Integer = 0 To servers.Count - 1
                    ComboBox1.Items.Add(ServersUtils.Load(servers.Item(i)).Item(0))
                Next
            Case "02d4beaff26ffcc3a30444ec4ccc0c56"
                My.Settings.moservers = True
                MsgBox("Paleiskite Launcheri išNaujo kad pakeitimai įsigaliotu")
        End Select
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        Me.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim p() As Process = Process.GetProcessesByName("gta_sa")
        If p.Count > 0 Then
        Else
            NotifyIcon1.ShowBalloonTip(5000, "Informacija", "SAMP buvo uždarytas." & vbNewLine & "Paspaukit Čia Kad Atidaryti Launcheri.", ToolTipIcon.Info)
            Timer1.Stop()
        End If
    End Sub
End Class
