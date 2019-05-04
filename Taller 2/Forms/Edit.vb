Public Class Edit

    Private equipoEdit As Equipo
    Private homeInstance As Home
    Dim path As String

    Sub New(idEquipo, home)
        ' This call is required by the designer.
        InitializeComponent()
        Console.WriteLine(idEquipo)
        equipoEdit = Equipo.obtenerEquipo(idEquipo)
        equipoEdit.id = idEquipo
        homeInstance = home
        ' Add any initialization after the InitializeComponent() call.
        ComboBox1.Text = equipoEdit.conferencia
        TextBox1.Text = equipoEdit.ciudad
        TextBox2.Text = equipoEdit.nombreEquipo
        PictureBox1.ImageLocation = equipoEdit.rutaImagen
        DataGridView1.DataSource = Equipo.obtenerJugadoresEquipo(idEquipo)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Completa todos los campos.")
        Else
            equipoEdit.nombreEquipo = TextBox2.Text
            equipoEdit.conferencia = ComboBox1.Text
            equipoEdit.ciudad = TextBox1.Text
            equipoEdit.actualizarEquipo()
            homeInstance.updateTeams()
            MsgBox("Equipo actualizado xd.")
            Me.Close()
        End If
    End Sub

    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

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
                equipoEdit.rutaImagen = fd.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class