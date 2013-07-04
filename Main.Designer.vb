<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NustatymaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagalbaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PraneštiBugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrmosKodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PajungtiFunkcijaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PridėtiServeriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PašalintiServerisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(544, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Jungtis"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NustatymaiToolStripMenuItem, Me.PagalbaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(603, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NustatymaiToolStripMenuItem
        '
        Me.NustatymaiToolStripMenuItem.Name = "NustatymaiToolStripMenuItem"
        Me.NustatymaiToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.NustatymaiToolStripMenuItem.Text = "Nustatymai"
        '
        'PagalbaToolStripMenuItem
        '
        Me.PagalbaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PraneštiBugToolStripMenuItem, Me.ProgrmosKodasToolStripMenuItem, Me.PajungtiFunkcijaToolStripMenuItem, Me.PridėtiServeriToolStripMenuItem, Me.PašalintiServerisToolStripMenuItem})
        Me.PagalbaToolStripMenuItem.Name = "PagalbaToolStripMenuItem"
        Me.PagalbaToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PagalbaToolStripMenuItem.Text = "Pagalba"
        '
        'PraneštiBugToolStripMenuItem
        '
        Me.PraneštiBugToolStripMenuItem.Name = "PraneštiBugToolStripMenuItem"
        Me.PraneštiBugToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.PraneštiBugToolStripMenuItem.Text = "Pranešti ""Bug"""
        '
        'ProgrmosKodasToolStripMenuItem
        '
        Me.ProgrmosKodasToolStripMenuItem.Name = "ProgrmosKodasToolStripMenuItem"
        Me.ProgrmosKodasToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ProgrmosKodasToolStripMenuItem.Text = "Progrmos Kodas..."
        '
        'PajungtiFunkcijaToolStripMenuItem
        '
        Me.PajungtiFunkcijaToolStripMenuItem.Name = "PajungtiFunkcijaToolStripMenuItem"
        Me.PajungtiFunkcijaToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.PajungtiFunkcijaToolStripMenuItem.Text = "Pajungti Funkcija"
        '
        'PridėtiServeriToolStripMenuItem
        '
        Me.PridėtiServeriToolStripMenuItem.Name = "PridėtiServeriToolStripMenuItem"
        Me.PridėtiServeriToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.PridėtiServeriToolStripMenuItem.Text = "Pridėti Serveri"
        '
        'PašalintiServerisToolStripMenuItem
        '
        Me.PašalintiServerisToolStripMenuItem.Name = "PašalintiServerisToolStripMenuItem"
        Me.PašalintiServerisToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.PašalintiServerisToolStripMenuItem.Text = "Resetinti Serveriu Sąraša"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(438, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(344, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Vartotojo Vardas:"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "SAMP Launcher"
        Me.NotifyIcon1.Visible = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(228, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(110, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(603, 521)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://kar27.lhosting.info/lsgnews/news.htm", System.UriKind.Absolute)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.WebBrowser1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 521)
        Me.Panel1.TabIndex = 8
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 545)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "LSG Launcheris"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NustatymaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PagalbaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PraneštiBugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgrmosKodasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PridėtiServeriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PašalintiServerisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PajungtiFunkcijaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
