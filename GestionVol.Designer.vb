<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionVol
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
        DataGridView1 = New DataGridView()
        NumVol = New DataGridViewTextBoxColumn()
        Dest = New DataGridViewTextBoxColumn()
        DTE = New DataGridViewTextBoxColumn()
        Heure = New DataGridViewTextBoxColumn()
        NBPLCDispo = New DataGridViewTextBoxColumn()
        Prix = New DataGridViewTextBoxColumn()
        Ajout = New Button()
        Suppr = New Button()
        Modif = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {NumVol, Dest, DTE, Heure, NBPLCDispo, Prix})
        DataGridView1.Location = New Point(12, 47)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(803, 190)
        DataGridView1.TabIndex = 0
        ' 
        ' NumVol
        ' 
        NumVol.HeaderText = "Numero De vol"
        NumVol.MinimumWidth = 6
        NumVol.Name = "NumVol"
        NumVol.Width = 125
        ' 
        ' Dest
        ' 
        Dest.HeaderText = "Destionation"
        Dest.MinimumWidth = 6
        Dest.Name = "Dest"
        Dest.Width = 125
        ' 
        ' DTE
        ' 
        DTE.HeaderText = "Date"
        DTE.MinimumWidth = 6
        DTE.Name = "DTE"
        DTE.Width = 125
        ' 
        ' Heure
        ' 
        Heure.HeaderText = "Heure"
        Heure.MinimumWidth = 6
        Heure.Name = "Heure"
        Heure.Width = 125
        ' 
        ' NBPLCDispo
        ' 
        NBPLCDispo.HeaderText = "Nombre De Places Disponibles"
        NBPLCDispo.MinimumWidth = 6
        NBPLCDispo.Name = "NBPLCDispo"
        NBPLCDispo.Width = 125
        ' 
        ' Prix
        ' 
        Prix.HeaderText = "Prix"
        Prix.MinimumWidth = 6
        Prix.Name = "Prix"
        Prix.Width = 125
        ' 
        ' Ajout
        ' 
        Ajout.Location = New Point(149, 300)
        Ajout.Name = "Ajout"
        Ajout.Size = New Size(94, 29)
        Ajout.TabIndex = 1
        Ajout.Text = "Ajouter"
        Ajout.UseVisualStyleBackColor = True
        ' 
        ' Suppr
        ' 
        Suppr.Location = New Point(610, 300)
        Suppr.Name = "Suppr"
        Suppr.Size = New Size(94, 29)
        Suppr.TabIndex = 2
        Suppr.Text = "Supprimer"
        Suppr.UseVisualStyleBackColor = True
        ' 
        ' Modif
        ' 
        Modif.Location = New Point(370, 300)
        Modif.Name = "Modif"
        Modif.Size = New Size(94, 29)
        Modif.TabIndex = 3
        Modif.Text = "Modifier"
        Modif.UseVisualStyleBackColor = True
        ' 
        ' GestionVol
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(944, 438)
        Controls.Add(Modif)
        Controls.Add(Suppr)
        Controls.Add(Ajout)
        Controls.Add(DataGridView1)
        Name = "GestionVol"
        Text = "GestionVol"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NumVol As DataGridViewTextBoxColumn
    Friend WithEvents Dest As DataGridViewTextBoxColumn
    Friend WithEvents DTE As DataGridViewTextBoxColumn
    Friend WithEvents Heure As DataGridViewTextBoxColumn
    Friend WithEvents NBPLCDispo As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
    Friend WithEvents Ajout As Button
    Friend WithEvents Suppr As Button
    Friend WithEvents Modif As Button
End Class
