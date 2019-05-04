Public Class Register
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim nombres = textBox1.Text
        Dim apellidos = textBox2.Text
        Dim email = textBox3.Text
        Dim contacto = textBox4.Text
        Dim nombreUsuario = TextBox7.Text
        Dim contraseña = textBox5.Text
        Dim confirm = textBox6.Text
        If contraseña <> confirm Then
            MsgBox("Las contraseñas no coinciden.")
        ElseIf nombres = "" Or apellidos = "" Or email = "" Or nombreUsuario = "" Or contraseña = "" Or confirm = "" Or contacto = "" Then
            MsgBox("Rellena todos los campos.")
        Else
            Dim usuario As New Usuario(nombreUsuario, nombres, apellidos, email, contacto, contraseña, False)
            usuario.insertarUsuario()
            MsgBox("Registrado.")
            Me.Close()
        End If
    End Sub

    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class