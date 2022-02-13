<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbVenta = New System.Windows.Forms.CheckBox()
        Me.cbCompra = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtVenta = New System.Windows.Forms.TextBox()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.compraCCR = New System.Windows.Forms.RadioButton()
        Me.compraEuros = New System.Windows.Forms.RadioButton()
        Me.compraPesos = New System.Windows.Forms.RadioButton()
        Me.compraDolar = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ventaCCR = New System.Windows.Forms.RadioButton()
        Me.ventaEuros = New System.Windows.Forms.RadioButton()
        Me.ventaPesos = New System.Windows.Forms.RadioButton()
        Me.ventaDolar = New System.Windows.Forms.RadioButton()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbVenta)
        Me.GroupBox1.Controls.Add(Me.cbCompra)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(36, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transacciones"
        '
        'cbVenta
        '
        Me.cbVenta.AutoSize = True
        Me.cbVenta.Location = New System.Drawing.Point(6, 71)
        Me.cbVenta.Name = "cbVenta"
        Me.cbVenta.Size = New System.Drawing.Size(74, 24)
        Me.cbVenta.TabIndex = 1
        Me.cbVenta.Text = "Venta"
        Me.cbVenta.UseVisualStyleBackColor = True
        '
        'cbCompra
        '
        Me.cbCompra.AutoSize = True
        Me.cbCompra.Location = New System.Drawing.Point(6, 31)
        Me.cbCompra.Name = "cbCompra"
        Me.cbCompra.Size = New System.Drawing.Size(90, 24)
        Me.cbCompra.TabIndex = 0
        Me.cbCompra.Text = "Compra"
        Me.cbCompra.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtVenta)
        Me.GroupBox3.Controls.Add(Me.txtCompra)
        Me.GroupBox3.Controls.Add(Me.lbl6)
        Me.GroupBox3.Controls.Add(Me.lbl5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(281, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(262, 118)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingrese cantidad"
        '
        'txtVenta
        '
        Me.txtVenta.Enabled = False
        Me.txtVenta.Location = New System.Drawing.Point(133, 72)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.Size = New System.Drawing.Size(100, 27)
        Me.txtVenta.TabIndex = 3
        '
        'txtCompra
        '
        Me.txtCompra.Enabled = False
        Me.txtCompra.Location = New System.Drawing.Point(133, 37)
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(100, 27)
        Me.txtCompra.TabIndex = 2
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Location = New System.Drawing.Point(22, 76)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(52, 20)
        Me.lbl6.TabIndex = 1
        Me.lbl6.Text = "Venta"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(22, 37)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(68, 20)
        Me.lbl5.TabIndex = 0
        Me.lbl5.Text = "Compra"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.compraCCR)
        Me.GroupBox4.Controls.Add(Me.compraEuros)
        Me.GroupBox4.Controls.Add(Me.compraPesos)
        Me.GroupBox4.Controls.Add(Me.compraDolar)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(42, 256)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 165)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Compra"
        '
        'compraCCR
        '
        Me.compraCCR.AutoSize = True
        Me.compraCCR.Location = New System.Drawing.Point(21, 126)
        Me.compraCCR.Name = "compraCCR"
        Me.compraCCR.Size = New System.Drawing.Size(120, 24)
        Me.compraCCR.TabIndex = 3
        Me.compraCCR.TabStop = True
        Me.compraCCR.Text = "Colones CR"
        Me.compraCCR.UseVisualStyleBackColor = True
        '
        'compraEuros
        '
        Me.compraEuros.AutoSize = True
        Me.compraEuros.Location = New System.Drawing.Point(21, 95)
        Me.compraEuros.Name = "compraEuros"
        Me.compraEuros.Size = New System.Drawing.Size(65, 24)
        Me.compraEuros.TabIndex = 2
        Me.compraEuros.TabStop = True
        Me.compraEuros.Text = "Euro"
        Me.compraEuros.UseVisualStyleBackColor = True
        '
        'compraPesos
        '
        Me.compraPesos.AutoSize = True
        Me.compraPesos.Location = New System.Drawing.Point(21, 60)
        Me.compraPesos.Name = "compraPesos"
        Me.compraPesos.Size = New System.Drawing.Size(144, 24)
        Me.compraPesos.TabIndex = 1
        Me.compraPesos.TabStop = True
        Me.compraPesos.Text = "Peso mexicano"
        Me.compraPesos.UseVisualStyleBackColor = True
        '
        'compraDolar
        '
        Me.compraDolar.AutoSize = True
        Me.compraDolar.Location = New System.Drawing.Point(21, 27)
        Me.compraDolar.Name = "compraDolar"
        Me.compraDolar.Size = New System.Drawing.Size(71, 24)
        Me.compraDolar.TabIndex = 0
        Me.compraDolar.TabStop = True
        Me.compraDolar.Text = "Dolar"
        Me.compraDolar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ventaCCR)
        Me.GroupBox5.Controls.Add(Me.ventaEuros)
        Me.GroupBox5.Controls.Add(Me.ventaPesos)
        Me.GroupBox5.Controls.Add(Me.ventaDolar)
        Me.GroupBox5.Enabled = False
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(271, 256)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 165)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Venta"
        '
        'ventaCCR
        '
        Me.ventaCCR.AutoSize = True
        Me.ventaCCR.Location = New System.Drawing.Point(21, 126)
        Me.ventaCCR.Name = "ventaCCR"
        Me.ventaCCR.Size = New System.Drawing.Size(120, 24)
        Me.ventaCCR.TabIndex = 3
        Me.ventaCCR.TabStop = True
        Me.ventaCCR.Text = "Colones CR"
        Me.ventaCCR.UseVisualStyleBackColor = True
        '
        'ventaEuros
        '
        Me.ventaEuros.AutoSize = True
        Me.ventaEuros.Location = New System.Drawing.Point(21, 95)
        Me.ventaEuros.Name = "ventaEuros"
        Me.ventaEuros.Size = New System.Drawing.Size(65, 24)
        Me.ventaEuros.TabIndex = 2
        Me.ventaEuros.TabStop = True
        Me.ventaEuros.Text = "Euro"
        Me.ventaEuros.UseVisualStyleBackColor = True
        '
        'ventaPesos
        '
        Me.ventaPesos.AutoSize = True
        Me.ventaPesos.Location = New System.Drawing.Point(21, 60)
        Me.ventaPesos.Name = "ventaPesos"
        Me.ventaPesos.Size = New System.Drawing.Size(144, 24)
        Me.ventaPesos.TabIndex = 1
        Me.ventaPesos.TabStop = True
        Me.ventaPesos.Text = "Peso mexicano"
        Me.ventaPesos.UseVisualStyleBackColor = True
        '
        'ventaDolar
        '
        Me.ventaDolar.AutoSize = True
        Me.ventaDolar.Location = New System.Drawing.Point(21, 27)
        Me.ventaDolar.Name = "ventaDolar"
        Me.ventaDolar.Size = New System.Drawing.Size(71, 24)
        Me.ventaDolar.TabIndex = 0
        Me.ventaDolar.TabStop = True
        Me.ventaDolar.Text = "Dolar"
        Me.ventaDolar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(505, 256)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(119, 36)
        Me.btnCalcular.TabIndex = 5
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(505, 312)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(119, 36)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(505, 377)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(119, 36)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(782, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbVenta As CheckBox
    Friend WithEvents cbCompra As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtVenta As TextBox
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents compraCCR As RadioButton
    Friend WithEvents compraEuros As RadioButton
    Friend WithEvents compraPesos As RadioButton
    Friend WithEvents compraDolar As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ventaCCR As RadioButton
    Friend WithEvents ventaEuros As RadioButton
    Friend WithEvents ventaPesos As RadioButton
    Friend WithEvents ventaDolar As RadioButton
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
End Class
