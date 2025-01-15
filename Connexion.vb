Public Class Connexion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Ad.Text = "Admin" And MPD.Text = "Admin" Then
            Form1.ShowForm(GestionVol)
        End If
    End Sub
End Class