<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Old
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Old))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NustatymaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagalbaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PraneštiBugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrmosKodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FixPermisionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(345, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NustatymaiToolStripMenuItem, Me.PagalbaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(460, 24)
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
        Me.PagalbaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PraneštiBugToolStripMenuItem, Me.ProgrmosKodasToolStripMenuItem, Me.FixPermisionsToolStripMenuItem})
        Me.PagalbaToolStripMenuItem.Name = "PagalbaToolStripMenuItem"
        Me.PagalbaToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PagalbaToolStripMenuItem.Text = "Pagalba"
        '
        'PraneštiBugToolStripMenuItem
        '
        Me.PraneštiBugToolStripMenuItem.Name = "PraneštiBugToolStripMenuItem"
        Me.PraneštiBugToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PraneštiBugToolStripMenuItem.Text = "Pranešti ""Bug"""
        '
        'ProgrmosKodasToolStripMenuItem
        '
        Me.ProgrmosKodasToolStripMenuItem.Name = "ProgrmosKodasToolStripMenuItem"
        Me.ProgrmosKodasToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ProgrmosKodasToolStripMenuItem.Text = "Progrmos Kodas..."
        '
        'FixPermisionsToolStripMenuItem
        '
        Me.FixPermisionsToolStripMenuItem.Name = "FixPermisionsToolStripMenuItem"
        Me.FixPermisionsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.FixPermisionsToolStripMenuItem.Text = "Fix Permisions"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(239, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(140, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(165, 40)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(36, 20)
        Me.TextBox3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "IP   :     Port"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Main_Old
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 77)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main_Old"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NustatymaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PagalbaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PraneštiBugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgrmosKodasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents FixPermisionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
