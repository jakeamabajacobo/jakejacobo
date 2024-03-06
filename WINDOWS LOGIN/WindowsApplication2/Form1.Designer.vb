<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.pw_txtbox = New System.Windows.Forms.TextBox()
        Me.un_txtbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 249)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 32)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 127)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 32)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Username"
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_btn.ForeColor = System.Drawing.Color.White
        Me.login_btn.Location = New System.Drawing.Point(320, 387)
        Me.login_btn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(266, 85)
        Me.login_btn.TabIndex = 9
        Me.login_btn.Text = "LOGIN"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'pw_txtbox
        '
        Me.pw_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pw_txtbox.Location = New System.Drawing.Point(56, 295)
        Me.pw_txtbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.pw_txtbox.Name = "pw_txtbox"
        Me.pw_txtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pw_txtbox.Size = New System.Drawing.Size(732, 31)
        Me.pw_txtbox.TabIndex = 8
        '
        'un_txtbox
        '
        Me.un_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.un_txtbox.Location = New System.Drawing.Point(56, 167)
        Me.un_txtbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.un_txtbox.Name = "un_txtbox"
        Me.un_txtbox.Size = New System.Drawing.Size(732, 31)
        Me.un_txtbox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(50, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 32)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "USER LOGIN"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(864, 567)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.pw_txtbox)
        Me.Controls.Add(Me.un_txtbox)
        Me.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents login_btn As Button
    Friend WithEvents pw_txtbox As TextBox
    Friend WithEvents un_txtbox As TextBox
    Friend WithEvents Label3 As Label
End Class
