<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajout_Modif_Vol
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        NBVol = New TextBox()
        Confirm = New Button()
        Heure = New TextBox()
        D = New TextBox()
        Destination = New TextBox()
        Prix = New TextBox()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(176, 308)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 20)
        Label2.TabIndex = 1
        Label2.Text = "Prix"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(176, 245)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 2
        Label3.Text = "Heure"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(176, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 20)
        Label4.TabIndex = 3
        Label4.Text = "Date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(176, 103)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 20)
        Label5.TabIndex = 4
        Label5.Text = "Destination"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(176, 43)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 20)
        Label6.TabIndex = 5
        Label6.Text = "Numero De Vol"
        ' 
        ' NBVol
        ' 
        NBVol.Location = New Point(357, 40)
        NBVol.Name = "NBVol"
        NBVol.Size = New Size(217, 27)
        NBVol.TabIndex = 11
        ' 
        ' Confirm
        ' 
        Confirm.Location = New Point(322, 384)
        Confirm.Name = "Confirm"
        Confirm.Size = New Size(94, 29)
        Confirm.TabIndex = 12
        Confirm.Text = "Confirmer"
        Confirm.UseVisualStyleBackColor = True
        ' 
        ' Heure
        ' 
        Heure.Location = New Point(357, 242)
        Heure.Name = "Heure"
        Heure.Size = New Size(217, 27)
        Heure.TabIndex = 13
        ' 
        ' D
        ' 
        D.Location = New Point(357, 173)
        D.Name = "D"
        D.Size = New Size(217, 27)
        D.TabIndex = 14
        ' 
        ' Destination
        ' 
        Destination.Location = New Point(357, 103)
        Destination.Name = "Destination"
        Destination.Size = New Size(217, 27)
        Destination.TabIndex = 15
        ' 
        ' Prix
        ' 
        Prix.Location = New Point(357, 301)
        Prix.Name = "Prix"
        Prix.Size = New Size(217, 27)
        Prix.TabIndex = 16
        ' 
        ' Ajout_Modif_Vol
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Prix)
        Controls.Add(Destination)
        Controls.Add(D)
        Controls.Add(Heure)
        Controls.Add(Confirm)
        Controls.Add(NBVol)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "Ajout_Modif_Vol"
        Text = "Ajout_Modif_Vol"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents NBVol As TextBox
    Friend WithEvents Confirm As Button
    Friend WithEvents Heure As TextBox
    Friend WithEvents D As TextBox
    Friend WithEvents Destination As TextBox
    Friend WithEvents Prix As TextBox
End Class
