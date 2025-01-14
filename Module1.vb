Module Module1
    Public Sub ShowInSameWindow(ByVal form As Form, ByVal panel As Panel, ByVal newControls As Control())
        ' Remove all existing controls from the panel
        panel.Controls.Clear()

        ' Add new controls to the panel
        For Each ctrl As Control In newControls
            panel.Controls.Add(ctrl)
        Next

        ' Show the panel
        panel.Visible = True
    End Sub


End Module
