Public Class Form1

    Dim userlist As Hashtable = New Hashtable()
    Dim user_obj As user = New user()





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        user_obj.userlist.Add("Admin", "123")

        'Dim str1 As String
        'str1 = "hello class"
        ' Console.WriteLine("data: " + str1.Contains("class").ToString())
        'If (str1.Contains("class")) Then
        '    MsgBox("The sequence 'class' was found.")
        'Else
        '    MsgBox("No class found")
        'End If


        'Dim str As String
        'str = "The quick brown fox jumps over the lazy dog"
        'Console.WriteLine(str)

        'Dim substr As String = str.Substring(20)
        'MsgBox(substr)
























        'Dim i As Integer = 1
        'While i <= 10
        '    MsgBox("i value:" + i.ToString())
        '    i += 1
        'End While

        'Dim fname, lname As String
        'fname = " Jake"
        'lname = " Jacobo"

        ''+  CONTENATE OPERATOR
        'MsgBox(fname + lname)


        ' STRING ARRAY  & STRING JOIN
        'Dim sarray() As String = {"Hello", "from", "OOP", "SUBJECT"}
        'Dim message As String = String.Join(" ", sarray)
        'MsgBox("Message:" + sarray.ToString)


        'STRING COMPARE
        'Dim str1, str2 As String
        'str1 = "This is test"
        'str2 = "This is text"

        'If (String.Compare(str1, str2) = 0) Then
        '    MsgBox(str1 + " and " + str2 + " are equal.")
        'Else
        '    MsgBox(str1 + " and " + str2 + " are not equal.")
        'End If


    End Sub
    Dim Users As user = New user()
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click





        Dim username As String = un_txtbox.Text
        Dim password As String = pw_txtbox.Text

        If Not String.IsNullOrEmpty(un_txtbox.Text) And Not String.IsNullOrEmpty(pw_txtbox.Text) Then

            'Dim k As String
            'Dim user As New user()
            'Dim key As ICollection = user.userlist.Keys

            'For Each k In key
            '    MsgBox(user.userlist(k))
            'Next k





            If user.uname = un_txtbox.Text And user.pass = pw_txtbox.Text Then

                    MsgBox("Hello " + user.Uemail, vbInformation, "WELCOME!")
                    Me.Hide()
                    form2.Show()


                Else



                    MsgBox("Please Try Again!", vbCritical, "Invalid User!")
                    un_txtbox.Text = ""
                    pw_txtbox.Text = ""
                End If

            Else

                MsgBox("Invalid!")

        End If





        'Me.Hide()
        'form2.Show()



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub un_txtbox_KeyUp(sender As Object, e As KeyEventArgs) Handles un_txtbox.KeyUp
        If e.KeyCode = Keys.Enter Then
            pw_txtbox.Focus()

        End If
    End Sub

    Private Sub pw_txtbox_KeyUp(sender As Object, e As KeyEventArgs) Handles pw_txtbox.KeyUp
        If e.KeyCode = Keys.Enter Then
            login_btn.PerformClick()

        End If
    End Sub
End Class
