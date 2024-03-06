Public Class form2

    'GLOBAL VARIABLE
    Dim Users As user = New user()


    Private Sub register_btn_Click(sender As Object, e As EventArgs) Handles register_btn.Click


        If Not String.IsNullOrEmpty(un_txtbox.Text) And
        Not String.IsNullOrEmpty(pass_txtbox.Text) And
                                 Not String.IsNullOrEmpty(email_txtbox.Text) And
                                 Not String.IsNullOrEmpty(conpass_txtbox.Text) Then

            If String.Compare(pass_txtbox.Text, conpass_txtbox.Text) <> 0 Then
                MsgBox("Password not match!")
                pass_txtbox.Text = ""
                conpass_txtbox.Text = ""
                pass_txtbox.Focus()

            Else
                Users.uname = un_txtbox.Text
                Users.pass = pass_txtbox.Text
                Users.Uemail = email_txtbox.Text

                ' Dim user_obj As user = New user()
                'user_obj.userlist.Add(un_txtbox.Text, pass_txtbox.Text)

                MsgBox("User Registered!")
                Me.Hide()
                Form1.Show()

            End If

        Else
            MsgBox("Please Insert All value", vbCritical, "Incomplete Data!")
        End If






    End Sub

End Class