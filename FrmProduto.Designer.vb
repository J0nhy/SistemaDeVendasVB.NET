<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProduto
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
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbIva = New System.Windows.Forms.ComboBox()
        Me.cbUnidade = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrelhaProdutos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GrelhaProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFechar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnNovo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(741, 86)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operações:"
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.Control
        Me.btnFechar.BackgroundImage = Global.Exemplo2.My.Resources.Resources._018_317_door_exit_logout_512
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFechar.Location = New System.Drawing.Point(585, 25)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(150, 55)
        Me.btnFechar.TabIndex = 3
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.BackgroundImage = Global.Exemplo2.My.Resources.Resources.delete_1390069_1189298
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Location = New System.Drawing.Point(319, 25)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(150, 55)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.BackgroundImage = Global.Exemplo2.My.Resources.Resources.Programming_Save_icon
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.Location = New System.Drawing.Point(163, 25)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(150, 55)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNovo.BackgroundImage = Global.Exemplo2.My.Resources.Resources.img_390313
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNovo.Location = New System.Drawing.Point(7, 25)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(150, 55)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtPreco)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbIva)
        Me.GroupBox2.Controls.Add(Me.cbUnidade)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtDescricao)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(741, 86)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Produto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(591, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Preço Unitário"
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(594, 43)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(135, 26)
        Me.txtPreco.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(525, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "IVA (%)"
        '
        'cbIva
        '
        Me.cbIva.FormattingEnabled = True
        Me.cbIva.Items.AddRange(New Object() {"5", "16", "23"})
        Me.cbIva.Location = New System.Drawing.Point(528, 43)
        Me.cbIva.Name = "cbIva"
        Me.cbIva.Size = New System.Drawing.Size(60, 28)
        Me.cbIva.TabIndex = 2
        '
        'cbUnidade
        '
        Me.cbUnidade.FormattingEnabled = True
        Me.cbUnidade.Items.AddRange(New Object() {"Unidade", "Kilo", "Litro"})
        Me.cbUnidade.Location = New System.Drawing.Point(428, 43)
        Me.cbUnidade.Name = "cbUnidade"
        Me.cbUnidade.Size = New System.Drawing.Size(94, 28)
        Me.cbUnidade.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(425, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Unidade"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(103, 43)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(293, 26)
        Me.txtDescricao.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descrição"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(23, 43)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(74, 26)
        Me.txtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'GrelhaProdutos
        '
        Me.GrelhaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrelhaProdutos.Location = New System.Drawing.Point(12, 205)
        Me.GrelhaProdutos.Name = "GrelhaProdutos"
        Me.GrelhaProdutos.Size = New System.Drawing.Size(741, 219)
        Me.GrelhaProdutos.TabIndex = 2
        '
        'FrmProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GrelhaProdutos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmProduto"
        Me.Text = "Registo de Produtos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GrelhaProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbIva As ComboBox
    Friend WithEvents cbUnidade As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GrelhaProdutos As DataGridView
End Class
