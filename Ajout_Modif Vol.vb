Imports ProjetVB.Form1
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Ajout_Modif_Vol


    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click

        GestionVol.DataGridView1.Rows.Add(NBVol.Text, Destination.Text, D.Text, Heure.Text, Prix.Text)

        Form1.ShowForm(GestionVol)


        'ecrire l'instance del van dans un fucher binaire
        'Dim filePath As String = "vol.bin"
        'Using fileStream As New FileStream(Form1.volList, FileMode.Create)
        'Dim formatter As New BinaryFormatter()
        'For Each v In Form1.volList
        'Formatter.Serialize(fileStream, v)
        'Next
        'End Using

    End Sub

    Private Sub Ajout_Modif_Vol_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class