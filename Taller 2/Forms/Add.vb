Public Class Add

    Dim path As String
    Private homeInstance As Home

    Sub New(home)
        ' This call is required by the designer.
        InitializeComponent()
        homeInstance = home
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim fd As OpenFileDialog = New OpenFileDialog()
            fd.Title = "Open File Dialog"
            fd.InitialDirectory = "C:\"
            fd.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpeg)|*.jpeg"
            fd.FilterIndex = 2
            fd.RestoreDirectory = True
            If fd.ShowDialog() = DialogResult.OK Then
                PictureBox1.ImageLocation = fd.FileName
                path = fd.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = "Este"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conferencia = ComboBox1.Text
        Dim nombre = TextBox2.Text
        Dim ciudad = TextBox1.Text
        Dim rutaImagen = Me.path
        If TextBox1.Text = "" Or TextBox2.Text = "" Or rutaImagen = "" Then
            MsgBox("Rellena todos los campos.")
        Else
            Dim equipo As New Equipo(nombre, ciudad, conferencia, rutaImagen)
            equipo.agregarEquipo()
            MsgBox("Equipo agregado.")
            Me.Close()
            homeInstance.updateTeams()
        End If
    End Sub
End Class