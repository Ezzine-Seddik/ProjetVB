Public Class GestionVol


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Ajout_Click(sender As Object, e As EventArgs) Handles Ajout.Click
        Form1.ShowForm(Ajout_Modif_Vol)
    End Sub

    Private Sub Modif_Click(sender As Object, e As EventArgs) Handles Modif.Click
        Form1.ShowForm(Ajout_Modif_Vol)
    End Sub

    Private Sub GestionVol_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class