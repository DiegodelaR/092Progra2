Public Class Form2
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.compraDolar.Checked Then
            Label2.Text = Str(calcularCompra(Form1.txtCompra.Text, tcDolar))
            Label1.Text = "La cantidad de compra es: "
        End If

        If Form1.compraPesos.Checked Then
            Label2.Text = Str(calcularCompra(Form1.txtCompra.Text, tcPesos))
            Label1.Text = "La cantidad de compra es: "
        End If

        If Form1.compraEuros.Checked Then
            Label2.Text = Str(calcularCompra(Form1.txtCompra.Text, tcEuros))
            Label1.Text = "La cantidad de compra es: "
        End If

        If Form1.compraCCR.Checked Then
            Label2.Text = Str(calcularCompra(Form1.txtCompra.Text, tcCCR))
            Label1.Text = "La cantidad de compra es: "
        End If

        If Form1.ventaDolar.Checked Then
            Label3.Text = Str(calcularVenta(Form1.txtVenta.Text, tcDolar))
            Label4.Text = "La cantidad de venta es: "
        End If

        If Form1.ventaPesos.Checked Then
            Label3.Text = Str(calcularVenta(Form1.txtVenta.Text, tcPesos))
            Label4.Text = "La cantidad de venta es: "
        End If

        If Form1.ventaEuros.Checked Then
            Label3.Text = Str(calcularVenta(Form1.txtVenta.Text, tcEuros))
            Label4.Text = "La cantidad de venta es: "
        End If

        If Form1.ventaCCR.Checked Then
            Label3.Text = Str(calcularVenta(Form1.txtVenta.Text, tcCCR))
            Label4.Text = "La cantidad de venta es: "
        End If

    End Sub
End Class