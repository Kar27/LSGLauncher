Public Class AddSrw

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim SrwInfo As System.Collections.Specialized.StringCollection
        SrwInfo = ServersUtils.OldFormatToNew(TextBox2.Text, TextBox1.Text)
        Main.servers.Add(ServersUtils.Save(SrwInfo))
        My.Settings.Servers = Main.servers
        Me.Close()
    End Sub

End Class
