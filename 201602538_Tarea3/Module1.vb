Module Module1
    Public Const tcDolar = 7.69
    Public Const tcPesos = 0.38
    Public Const tcEuros = 8.79
    Public Const tcCCR = 0.012

    Const comisionCompra = 2.5 / 100
    Const comisionVenta = 3 / 100

    Dim total_parcial = 0
    Dim total
    Sub limpiar()
        Form1.txtCompra.Clear()
        Form1.txtVenta.Clear()
        Form1.cbCompra.Checked = False
        Form1.cbVenta.Checked = False

        Form1.compraDolar.Checked = False
        Form1.compraPesos.Checked = False
        Form1.compraEuros.Checked = False
        Form1.compraCCR.Checked = False
        Form1.ventaDolar.Checked = False
        Form1.ventaPesos.Checked = False
        Form1.ventaEuros.Checked = False
        Form1.ventaCCR.Checked = False

        Form2.Label1.Text = "Limpio"

    End Sub

    Function calcularCompra(cantidadCompra As Double, tipoCompra As Double) As Double
        If cantidadCompra > 0 Then
            total_parcial = cantidadCompra / tipoCompra
            total = total_parcial - (total_parcial * comisionCompra)

        End If

        Return Math.Round(total, 2)
    End Function

    Function calcularVenta(cantidadVenta As Double, tipoVenta As Double) As Double
        If cantidadVenta > 0 Then
            total_parcial = cantidadVenta / tipoVenta
            total = total_parcial - (total_parcial * comisionVenta)
        End If

        Return Math.Round(total, 2)
    End Function

End Module