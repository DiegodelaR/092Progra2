Public Class Form1
    Const PrecioArroz As Double = 2.0
    Const PrecioAzucar As Double = 2.5
    Const PrecioFrijol As Double = 1.75
    Const IVA As Double = 0.12
    Dim PagoSinIVA As Double = 0
    Dim ValorIVA As Double = 0
    Dim PagoConIVA As Double = 0
    Dim Descuento As Double = 0
    Dim PagoFinal As Double = 0
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        PagoSinIVA = (Val(txtarroz.Text) * PrecioArroz) + (Val(txtazucarr.Text) * PrecioAzucar) + (Val(txtfrijol.Text) * PrecioFrijol)
        ValorIVA = PagoSinIVA * IVA
        PagoConIVA = PagoSinIVA + ValorIVA
        Descuento = PagoConIVA * 0.025
        PagoFinal = PagoConIVA - Descuento

        lblR1.Text = PagoSinIVA
        lblR2.Text = ValorIVA
        lblR3.Text = PagoConIVA
        lblR4.Text = Descuento
        lblR5.Text = PagoFinal
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtarroz.Clear()
        txtazucarr.Clear()
        txtfrijol.Clear()
        lblR1.Text = 0.0
        lblR2.Text = 0.0
        lblR3.Text = 0.0
        lblR4.Text = 0.0
        lblR5.Text = 0.0
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        MsgBox("Salir")
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
