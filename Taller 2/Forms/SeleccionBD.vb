Public Class SeleccionBD
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem.ToString.Equals("Postgres") Then
            DB.db = New DBPostgres
        Else
            DB.db = New DBAccess
        End If
        Me.Dispose(false)
        Login.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox("Ganaste un ipad", , "Ganaste")
    End Sub

    Private Sub SeleccionBD_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.TopMost = True
    End Sub
End Class