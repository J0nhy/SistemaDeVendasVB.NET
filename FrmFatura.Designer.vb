<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFatura
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNrFatura = New System.Windows.Forms.TextBox()
        Me.btnProcuraFatura = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GrelhaProdutos = New System.Windows.Forms.DataGridView()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dataFatura = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRemoverItem = New System.Windows.Forms.Button()
        Me.btnGuardarItem = New System.Windows.Forms.Button()
        Me.btnAdicionarItem = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.txtQTD = New System.Windows.Forms.TextBox()
        Me.txtUnidade = New System.Windows.Forms.TextBox()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.txtCodProduto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GrelhaProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNrFatura)
        Me.GroupBox1.Controls.Add(Me.btnProcuraFatura)
        Me.GroupBox1.Controls.Add(Me.btnFechar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNovo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1104, 127)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operações:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(578, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nr. Fatura:"
        '
        'txtNrFatura
        '
        Me.txtNrFatura.Location = New System.Drawing.Point(679, 45)
        Me.txtNrFatura.Name = "txtNrFatura"
        Me.txtNrFatura.Size = New System.Drawing.Size(100, 26)
        Me.txtNrFatura.TabIndex = 5
        '
        'btnProcuraFatura
        '
        Me.btnProcuraFatura.BackgroundImage = Global.Exemplo2.My.Resources.Resources.outline_search_lupa_find_512
        Me.btnProcuraFatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProcuraFatura.Location = New System.Drawing.Point(785, 25)
        Me.btnProcuraFatura.Name = "btnProcuraFatura"
        Me.btnProcuraFatura.Size = New System.Drawing.Size(68, 66)
        Me.btnProcuraFatura.TabIndex = 4
        Me.btnProcuraFatura.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.BackgroundImage = Global.Exemplo2.My.Resources.Resources._018_317_door_exit_logout_512
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFechar.Location = New System.Drawing.Point(931, 25)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(152, 66)
        Me.btnFechar.TabIndex = 3
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.Exemplo2.My.Resources.Resources.delete_1390069_1189298
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Location = New System.Drawing.Point(342, 25)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(152, 66)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = Global.Exemplo2.My.Resources.Resources.Programming_Save_icon
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.Location = New System.Drawing.Point(174, 25)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(152, 66)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.BackgroundImage = Global.Exemplo2.My.Resources.Resources.img_390313
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNovo.Location = New System.Drawing.Point(6, 25)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(152, 66)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GrelhaProdutos)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dataFatura)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtCliente)
        Me.GroupBox2.Controls.Add(Me.txtNumero)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1104, 316)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fatura:"
        '
        'GrelhaProdutos
        '
        Me.GrelhaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrelhaProdutos.ColumnHeadersVisible = False
        Me.GrelhaProdutos.Location = New System.Drawing.Point(10, 89)
        Me.GrelhaProdutos.Name = "GrelhaProdutos"
        Me.GrelhaProdutos.Size = New System.Drawing.Size(1073, 208)
        Me.GrelhaProdutos.TabIndex = 8
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(931, 55)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(152, 26)
        Me.txtTotal.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(927, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total da Fatura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(707, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Data"
        '
        'dataFatura
        '
        Me.dataFatura.Location = New System.Drawing.Point(711, 55)
        Me.dataFatura.Name = "dataFatura"
        Me.dataFatura.Size = New System.Drawing.Size(200, 26)
        Me.dataFatura.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(129, 57)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(544, 26)
        Me.txtCliente.TabIndex = 2
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(10, 57)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(67, 26)
        Me.txtNumero.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Número"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRemoverItem)
        Me.GroupBox3.Controls.Add(Me.btnGuardarItem)
        Me.GroupBox3.Controls.Add(Me.btnAdicionarItem)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtValorTotal)
        Me.GroupBox3.Controls.Add(Me.txtPreco)
        Me.GroupBox3.Controls.Add(Me.txtIVA)
        Me.GroupBox3.Controls.Add(Me.txtQTD)
        Me.GroupBox3.Controls.Add(Me.txtUnidade)
        Me.GroupBox3.Controls.Add(Me.txtProduto)
        Me.GroupBox3.Controls.Add(Me.btnProcurarProduto)
        Me.GroupBox3.Controls.Add(Me.txtCodProduto)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 467)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1104, 159)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'btnRemoverItem
        '
        Me.btnRemoverItem.Location = New System.Drawing.Point(679, 103)
        Me.btnRemoverItem.Name = "btnRemoverItem"
        Me.btnRemoverItem.Size = New System.Drawing.Size(208, 38)
        Me.btnRemoverItem.TabIndex = 21
        Me.btnRemoverItem.Text = "REMOVER PRODUTO"
        Me.btnRemoverItem.UseVisualStyleBackColor = True
        '
        'btnGuardarItem
        '
        Me.btnGuardarItem.Location = New System.Drawing.Point(456, 103)
        Me.btnGuardarItem.Name = "btnGuardarItem"
        Me.btnGuardarItem.Size = New System.Drawing.Size(217, 38)
        Me.btnGuardarItem.TabIndex = 20
        Me.btnGuardarItem.Text = "GUARDAR PRODUTO"
        Me.btnGuardarItem.UseVisualStyleBackColor = True
        '
        'btnAdicionarItem
        '
        Me.btnAdicionarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdicionarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionarItem.Location = New System.Drawing.Point(222, 103)
        Me.btnAdicionarItem.Name = "btnAdicionarItem"
        Me.btnAdicionarItem.Size = New System.Drawing.Size(228, 38)
        Me.btnAdicionarItem.TabIndex = 7
        Me.btnAdicionarItem.Text = "ADICIONAR PRODUTO"
        Me.btnAdicionarItem.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(980, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 20)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(866, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Preço Un."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(773, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "IVA (%)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(675, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "QTD."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(553, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Unidade"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(192, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Produto"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Location = New System.Drawing.Point(984, 62)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.ReadOnly = True
        Me.txtValorTotal.Size = New System.Drawing.Size(114, 26)
        Me.txtValorTotal.TabIndex = 13
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(870, 62)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.ReadOnly = True
        Me.txtPreco.Size = New System.Drawing.Size(93, 26)
        Me.txtPreco.TabIndex = 12
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(777, 62)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(76, 26)
        Me.txtIVA.TabIndex = 11
        '
        'txtQTD
        '
        Me.txtQTD.Location = New System.Drawing.Point(679, 62)
        Me.txtQTD.Name = "txtQTD"
        Me.txtQTD.Size = New System.Drawing.Size(76, 26)
        Me.txtQTD.TabIndex = 10
        '
        'txtUnidade
        '
        Me.txtUnidade.Location = New System.Drawing.Point(557, 62)
        Me.txtUnidade.Name = "txtUnidade"
        Me.txtUnidade.Size = New System.Drawing.Size(102, 26)
        Me.txtUnidade.TabIndex = 9
        '
        'txtProduto
        '
        Me.txtProduto.Location = New System.Drawing.Point(196, 62)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.ReadOnly = True
        Me.txtProduto.Size = New System.Drawing.Size(344, 26)
        Me.txtProduto.TabIndex = 8
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.BackgroundImage = Global.Exemplo2.My.Resources.Resources.outline_search_lupa_find_512
        Me.btnProcurarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProcurarProduto.Location = New System.Drawing.Point(112, 22)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(68, 66)
        Me.btnProcurarProduto.TabIndex = 7
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'txtCodProduto
        '
        Me.txtCodProduto.Location = New System.Drawing.Point(18, 62)
        Me.txtCodProduto.Name = "txtCodProduto"
        Me.txtCodProduto.Size = New System.Drawing.Size(71, 26)
        Me.txtCodProduto.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Codigo"
        '
        'FrmFatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 629)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmFatura"
        Me.Text = "FrmFatura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GrelhaProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNrFatura As TextBox
    Friend WithEvents btnProcuraFatura As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GrelhaProdutos As DataGridView
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dataFatura As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRemoverItem As Button
    Friend WithEvents btnGuardarItem As Button
    Friend WithEvents btnAdicionarItem As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtValorTotal As TextBox
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents txtQTD As TextBox
    Friend WithEvents txtUnidade As TextBox
    Friend WithEvents txtProduto As TextBox
    Friend WithEvents btnProcurarProduto As Button
    Friend WithEvents txtCodProduto As TextBox
    Friend WithEvents Label6 As Label
End Class
