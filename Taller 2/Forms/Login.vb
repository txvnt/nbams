Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ''' Boton Ingresar

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim username = textBox1.Text
        Dim password = textBox2.Text
        Dim auth As New Auth(username, password)
        If textBox1.Text = "" Or textBox2.Text = "" Then
            MsgBox("Rellena todos los campos.")
        Else
            If auth.Login() Then
                Auth.usuarioLogeado = username
                DB.db = New DBAccess
                Dim home As New Home(Auth.usuarioLogeado)
                home.Show()
            Else
                MsgBox("Usuario y/o contraseña incorrecta")
            End If
        End If
    End Sub


    ''' Boton Registro

    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
        Dim register As New Register()
        register.Show()
    End Sub

    Private Sub Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
