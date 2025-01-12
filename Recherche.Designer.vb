<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recherche
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
        Label1 = New Label()
        Label2 = New Label()
        Dest = New TextBox()
        Button1 = New Button()
        DT = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(162, 187)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 20)
        Label1.TabIndex = 0
        Label1.Text = "Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(162, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 20)
        Label2.TabIndex = 1
        Label2.Text = "Destination"
        ' 
        ' Dest
        ' 
        Dest.Location = New Point(358, 91)
        Dest.Name = "Dest"
        Dest.Size = New Size(125, 27)
        Dest.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(358, 296)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 5
        Button1.Text = "Rechercher"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DT
        ' 
        DT.Location = New Point(358, 187)
        DT.Name = "DT"
        DT.Size = New Size(125, 27)
        DT.TabIndex = 6
        ' 
        ' Recherche
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DT)
        Controls.Add(Button1)
        Controls.Add(Dest)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Recherche"
        Text = "Recherche"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Dest As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DT As TextBox
End Class
