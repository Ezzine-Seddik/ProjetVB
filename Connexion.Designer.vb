<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connexion
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
        Ad = New TextBox()
        MPD = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Ad
        ' 
        Ad.Location = New Point(378, 116)
        Ad.Name = "Ad"
        Ad.Size = New Size(125, 27)
        Ad.TabIndex = 0
        ' 
        ' MPD
        ' 
        MPD.Location = New Point(378, 226)
        MPD.Name = "MPD"
        MPD.Size = New Size(125, 27)
        MPD.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(231, 233)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 20)
        Label1.TabIndex = 4
        Label1.Text = "Mot De Passe"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(240, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 20)
        Label2.TabIndex = 5
        Label2.Text = "Adresse"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(314, 359)
        Button1.Name = "Button1"
        Button1.Size = New Size(203, 29)
        Button1.TabIndex = 6
        Button1.Text = "Se Connecter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Connexion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MPD)
        Controls.Add(Ad)
        Name = "Connexion"
        Text = "Connexion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Ad As TextBox
    Friend WithEvents MPD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
