Class user
    Private username As String = "Admin"
    Private password As String = "123"
    Private email As String = "Admin@gmail.com"
    Public userlist As Hashtable = New Hashtable()





    Public Property uname As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property

    Public Property pass As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property Uemail As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property


End Class
