﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.REGISTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FATURASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUTOSToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AJUDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTOSToolStripMenuItem, Me.AJUDAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1206, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'REGISTOSToolStripMenuItem
        '
        Me.REGISTOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FATURASToolStripMenuItem, Me.PRODUTOSToolStripMenuItem1})
        Me.REGISTOSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGISTOSToolStripMenuItem.Name = "REGISTOSToolStripMenuItem"
        Me.REGISTOSToolStripMenuItem.Size = New System.Drawing.Size(95, 25)
        Me.REGISTOSToolStripMenuItem.Text = "REGISTOS"
        '
        'FATURASToolStripMenuItem
        '
        Me.FATURASToolStripMenuItem.Image = Global.Exemplo2.My.Resources.Resources.black_cart_icon_4
        Me.FATURASToolStripMenuItem.Name = "FATURASToolStripMenuItem"
        Me.FATURASToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.FATURASToolStripMenuItem.Text = "FATURAS"
        '
        'PRODUTOSToolStripMenuItem1
        '
        Me.PRODUTOSToolStripMenuItem1.Image = Global.Exemplo2.My.Resources.Resources.Shopping_Barcode_icon
        Me.PRODUTOSToolStripMenuItem1.Name = "PRODUTOSToolStripMenuItem1"
        Me.PRODUTOSToolStripMenuItem1.Size = New System.Drawing.Size(180, 26)
        Me.PRODUTOSToolStripMenuItem1.Text = "PRODUTOS"
        '
        'AJUDAToolStripMenuItem
        '
        Me.AJUDAToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AJUDAToolStripMenuItem.Name = "AJUDAToolStripMenuItem"
        Me.AJUDAToolStripMenuItem.Size = New System.Drawing.Size(76, 25)
        Me.AJUDAToolStripMenuItem.Text = "AJUDA"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Exemplo2.My.Resources.Resources.super
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1206, 746)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.Text = "Sistema de Vendas v. 01 Alpha"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents REGISTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FATURASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AJUDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRODUTOSToolStripMenuItem1 As ToolStripMenuItem
End Class
