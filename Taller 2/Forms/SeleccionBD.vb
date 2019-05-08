Public Class SeleccionBD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem.ToString.Equals("Postgres") Then
            DB.db = New DBPostgres
        Else
            DB.db = New DBAccess
        End If
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox("Ganaste un ipad", "Ganaste")
    End Sub
End Class