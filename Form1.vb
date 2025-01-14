Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class Form1
    'module pour ovriri une interface dans la meme fenetre'
    Public Sub ShowForm(formToShow As Form)
        Panel1.Controls.Clear()
        formToShow.TopLevel = False
        formToShow.FormBorderStyle = FormBorderStyle.None
        formToShow.Dock = DockStyle.Fill
        Panel1.Controls.Add(formToShow)
        formToShow.Show()
    End Sub

    'structure pour vols'
    <Serializable> Public Structure vol
        Dim vol As Integer
        Dim depart As String
        Dim destination As String
        Dim temp As DateTime
        Dim places_dispo As Integer
    End Structure




    'Structure pour comptes
    <Serializable> Public Structure compte
        Dim Adress As String
        Dim password As String
    End Structure

    ' structure pour reservation
    <Serializable> Public Structure reserve
        Dim ID_Vol As Integer
        Dim ID_CL As String
    End Structure

    'creation de fichier pour stocker les vols
    Dim file1 As String = "vol.bin"

    ' Write the vol instances to a binary file
    Dim file2 As String = "compte.bin"
    ' Write the vol instances to a binary file
    Dim file3 As String = "reserve.bin"

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowForm(Connexion)
        'Using fileStream As New FileStream(file1, FileMode.Create)
        'End Using
        ' Using fileStream As New FileStream(file2, FileMode.Create)
        'End Using
        ' Using fileStream As New FileStream(file3, FileMode.Create)
        ' End Using
    End Sub
End Class
