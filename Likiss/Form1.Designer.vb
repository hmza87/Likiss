<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.captchatxt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Plogin = New System.Windows.Forms.Panel()
        Me.pcp = New System.Windows.Forms.PictureBox()
        Me.pPost = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.postID = New System.Windows.Forms.TextBox()
        Me.waittxt = New System.Windows.Forms.Label()
        Me.tim = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Plogin.SuspendLayout()
        CType(Me.pcp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pPost.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 54)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'captchatxt
        '
        Me.captchatxt.Location = New System.Drawing.Point(68, 110)
        Me.captchatxt.Name = "captchatxt"
        Me.captchatxt.Size = New System.Drawing.Size(100, 20)
        Me.captchatxt.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(81, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "send"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Plogin
        '
        Me.Plogin.Controls.Add(Me.pcp)
        Me.Plogin.Controls.Add(Me.Button2)
        Me.Plogin.Controls.Add(Me.captchatxt)
        Me.Plogin.Location = New System.Drawing.Point(9, 26)
        Me.Plogin.Name = "Plogin"
        Me.Plogin.Size = New System.Drawing.Size(243, 203)
        Me.Plogin.TabIndex = 7
        Me.Plogin.Visible = False
        '
        'pcp
        '
        Me.pcp.BackColor = System.Drawing.Color.Black
        Me.pcp.Location = New System.Drawing.Point(21, 26)
        Me.pcp.Name = "pcp"
        Me.pcp.Size = New System.Drawing.Size(189, 67)
        Me.pcp.TabIndex = 7
        Me.pcp.TabStop = False
        '
        'pPost
        '
        Me.pPost.Controls.Add(Me.Label1)
        Me.pPost.Controls.Add(Me.Button3)
        Me.pPost.Controls.Add(Me.postID)
        Me.pPost.Location = New System.Drawing.Point(9, 12)
        Me.pPost.Name = "pPost"
        Me.pPost.Size = New System.Drawing.Size(235, 225)
        Me.pPost.TabIndex = 8
        Me.pPost.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Post ID :"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(68, 84)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Kiss"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'postID
        '
        Me.postID.Location = New System.Drawing.Point(23, 49)
        Me.postID.Name = "postID"
        Me.postID.Size = New System.Drawing.Size(169, 20)
        Me.postID.TabIndex = 5
        '
        'waittxt
        '
        Me.waittxt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waittxt.Location = New System.Drawing.Point(4, 12)
        Me.waittxt.Name = "waittxt"
        Me.waittxt.Size = New System.Drawing.Size(259, 235)
        Me.waittxt.TabIndex = 9
        Me.waittxt.Tag = "Please wait {0} for the next kiss"
        Me.waittxt.Text = "Please wait 0 for the next kiss"
        Me.waittxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.waittxt.Visible = False
        '
        'tim
        '
        Me.tim.Enabled = True
        Me.tim.Interval = 1000
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 235)
        Me.Label2.TabIndex = 10
        Me.Label2.Tag = ""
        Me.Label2.Text = "Loading .."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 4000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 292)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.waittxt)
        Me.Controls.Add(Me.pPost)
        Me.Controls.Add(Me.Plogin)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Plogin.ResumeLayout(False)
        Me.Plogin.PerformLayout()
        CType(Me.pcp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pPost.ResumeLayout(False)
        Me.pPost.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents captchatxt As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Plogin As System.Windows.Forms.Panel
    Friend WithEvents pPost As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents postID As System.Windows.Forms.TextBox
    Friend WithEvents waittxt As System.Windows.Forms.Label
    Friend WithEvents pcp As System.Windows.Forms.PictureBox
    Friend WithEvents tim As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
