Public Class Form1
    Private Sub cbCompra_CheckededChanged(sender As Object, e As EventArgs) Handles cbCompra.CheckedChanged
        If cbCompra.Checked = True Then
            txtCompra.Enabled = True
            GroupBox4.Enabled = True
        Else
            txtCompra.Enabled = False
            GroupBox4.Enabled = False
        End If
    End Sub

    Private Sub cbVenta_CheckedChanged(sender As Object, e As EventArgs) Handles cbVenta.CheckedChanged
        If cbVenta.Checked = True Then
            txtVenta.Enabled = True
            GroupBox5.Enabled = True
        Else
            txtVenta.Enabled = False
            GroupBox5.Enabled = False
        End If
    End Sub


    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If (MsgBox("¿Está seguro que quiere salir?", vbCritical + vbYesNo)) = vbYes Then
            End
        End If
    End Sub
End Class