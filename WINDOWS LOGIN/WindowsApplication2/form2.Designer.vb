<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form2
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.register_btn = New System.Windows.Forms.Button()
        Me.conpass_txtbox = New System.Windows.Forms.TextBox()
        Me.pass_txtbox = New System.Windows.Forms.TextBox()
        Me.email_txtbox = New System.Windows.Forms.TextBox()
        Me.un_txtbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(85, 402)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 32)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Confirm Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(86, 268)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 32)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(86, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 32)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(86, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 32)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Username"
        '
        'register_btn
        '
        Me.register_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.register_btn.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.register_btn.ForeColor = System.Drawing.Color.White
        Me.register_btn.Location = New System.Drawing.Point(280, 503)
        Me.register_btn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.register_btn.Name = "register_btn"
        Me.register_btn.Size = New System.Drawing.Size(281, 99)
        Me.register_btn.TabIndex = 13
        Me.register_btn.Text = "Register"
        Me.register_btn.UseVisualStyleBackColor = False
        '
        'conpass_txtbox
        '
        Me.conpass_txtbox.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.conpass_txtbox.Location = New System.Drawing.Point(91, 453)
        Me.conpass_txtbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.conpass_txtbox.Name = "conpass_txtbox"
        Me.conpass_txtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.conpass_txtbox.Size = New System.Drawing.Size(786, 38)
        Me.conpass_txtbox.TabIndex = 12
        '
        'pass_txtbox
        '
        Me.pass_txtbox.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.pass_txtbox.Location = New System.Drawing.Point(91, 323)
        Me.pass_txtbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.pass_txtbox.Name = "pass_txtbox"
        Me.pass_txtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass_txtbox.Size = New System.Drawing.Size(786, 38)
        Me.pass_txtbox.TabIndex = 11
        '
        'email_txtbox
        '
        Me.email_txtbox.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.email_txtbox.Location = New System.Drawing.Point(91, 193)
        Me.email_txtbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.email_txtbox.Name = "email_txtbox"
        Me.email_txtbox.Size = New System.Drawing.Size(786, 38)
        Me.email_txtbox.TabIndex = 10
        '
        'un_txtbox
        '
        Me.un_txtbox.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.un_txtbox.Location = New System.Drawing.Point(91, 79)
        Me.un_txtbox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.un_txtbox.Name = "un_txtbox"
        Me.un_txtbox.Size = New System.Drawing.Size(786, 38)
        Me.un_txtbox.TabIndex = 9
        '
        'form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(914, 610)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.register_btn)
        Me.Controls.Add(Me.conpass_txtbox)
        Me.Controls.Add(Me.pass_txtbox)
        Me.Controls.Add(Me.email_txtbox)
        Me.Controls.Add(Me.un_txtbox)
        Me.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 13.8!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "form2"
        Me.Text = "form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents register_btn As Button
    Friend WithEvents conpass_txtbox As TextBox
    Friend WithEvents pass_txtbox As TextBox
    Friend WithEvents email_txtbox As TextBox
    Friend WithEvents un_txtbox As TextBox
End Class
