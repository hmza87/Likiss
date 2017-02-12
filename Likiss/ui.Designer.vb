<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ui
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.th_dark = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.PLogin = New System.Windows.Forms.Panel()
        Me.pcaptcha = New System.Windows.Forms.PictureBox()
        Me.tcaptcha = New Telerik.WinControls.UI.RadTextBox()
        Me.tiks = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PLogin.SuspendLayout()
        CType(Me.pcaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PLogin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(209, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(9)
        Me.Panel1.Size = New System.Drawing.Size(462, 252)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadDropDownList1)
        Me.Panel2.Controls.Add(Me.RadButton2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 293)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RadButton1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(209, 252)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(462, 41)
        Me.Panel3.TabIndex = 2
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(341, 8)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(110, 24)
        Me.RadButton1.TabIndex = 0
        Me.RadButton1.Text = "NEXT"
        Me.RadButton1.ThemeName = "VisualStudio2012Dark"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(179, 3)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(27, 24)
        Me.RadButton2.TabIndex = 1
        Me.RadButton2.Text = "R"
        Me.RadButton2.ThemeName = "VisualStudio2012Dark"
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.Location = New System.Drawing.Point(12, 33)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.Size = New System.Drawing.Size(191, 24)
        Me.RadDropDownList1.TabIndex = 2
        Me.RadDropDownList1.Text = "SELECT SERVER"
        Me.RadDropDownList1.ThemeName = "VisualStudio2012Dark"
        '
        'PLogin
        '
        Me.PLogin.Controls.Add(Me.tcaptcha)
        Me.PLogin.Controls.Add(Me.pcaptcha)
        Me.PLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PLogin.Location = New System.Drawing.Point(9, 9)
        Me.PLogin.Name = "PLogin"
        Me.PLogin.Size = New System.Drawing.Size(444, 234)
        Me.PLogin.TabIndex = 0
        Me.PLogin.Visible = False
        '
        'pcaptcha
        '
        Me.pcaptcha.Location = New System.Drawing.Point(100, 24)
        Me.pcaptcha.Name = "pcaptcha"
        Me.pcaptcha.Size = New System.Drawing.Size(247, 108)
        Me.pcaptcha.TabIndex = 0
        Me.pcaptcha.TabStop = False
        '
        'tcaptcha
        '
        Me.tcaptcha.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcaptcha.Location = New System.Drawing.Point(120, 150)
        Me.tcaptcha.MinimumSize = New System.Drawing.Size(0, 24)
        Me.tcaptcha.Name = "tcaptcha"
        Me.tcaptcha.Size = New System.Drawing.Size(197, 32)
        Me.tcaptcha.TabIndex = 1
        Me.tcaptcha.ThemeName = "VisualStudio2012Dark"
        '
        'tiks
        '
        Me.tiks.Enabled = True
        '
        'ui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 293)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ui"
        Me.Text = "ui"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PLogin.ResumeLayout(False)
        Me.PLogin.PerformLayout()
        CType(Me.pcaptcha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcaptcha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents th_dark As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents PLogin As System.Windows.Forms.Panel
    Friend WithEvents pcaptcha As System.Windows.Forms.PictureBox
    Friend WithEvents tcaptcha As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents tiks As System.Windows.Forms.Timer
End Class
