Public Class FrmFatura

    Private Sub limparFatura()
        txtNumero.ResetText()
        txtCliente.ResetText()
        dataFatura.Value = Now
        txtTotal.ResetText()
    End Sub

    Private Sub limparDetalheFatura()
        txtCodProduto.ResetText()
        txtProduto.ResetText()
        txtUnidade.ResetText()
        txtQTD.ResetText()
        txtIVA.ResetText()
        txtPreco.ResetText()
    End Sub

    Private Sub atualizarGrid(ByVal nrFatura As String)

        Dim cmdSql As String = "SELECT DetalheFatura.codigoProduto, " &
            "Produtos.Descricao, Produtos.Unidade, DetalheFatura.Quantidade, " &
            "DetalheFatura.ValorUnitario, DetalheFatura.taxaIVA, " &
            "DetalheFatura.ValorTotal FROM Produtos INNER JOIN " &
            "DetalheFatura ON Produtos.Codigo = DetalheFatura.codigoProduto " &
            "WHERE NumeroFatura = " & CInt(nrFatura)

        Dim dsDetalhe As DataSet = GerirLigacao.obterDados(cmdSql)
        GrelhaProdutos.DataSource = dsDetalhe.Tables(0)

        If GrelhaProdutos.Rows.Count > 0 Then
            txtCodProduto.Text = dsDetalhe.Tables(0).Rows(0).Item("CodigoProduto")
            txtProduto.Text = dsDetalhe.Tables(0).Rows(0).Item("Descricao")
            txtUnidade.Text = dsDetalhe.Tables(0).Rows(0).Item("Unidade")
            txtQTD.Text = dsDetalhe.Tables(0).Rows(0).Item("Quantidade")
            txtPreco.Text = dsDetalhe.Tables(0).Rows(0).Item("ValorUnitario")
            txtIVA.Text = dsDetalhe.Tables(0).Rows(0).Item("TaxaIVA")
            txtValorTotal.Text = dsDetalhe.Tables(0).Rows(0).Item("ValorTotal")
        Else
            limparDetalheFatura()
        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        limparFatura()
        limparDetalheFatura()
        GrelhaProdutos.DataSource = Nothing
        txtCliente.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click



        Dim cmdSql As String


        'If txtNumero.Text = "1" Then
        cmdSql = "INSERT INTO Fatura (Cliente, Data, ValorTotal) " &
                "VALUES ('" & txtCliente.Text & "', #" &
                dataFatura.Value.ToString("dd/MM/yyyy") & "#, " &
                Replace(txtValorTotal.Text.ToString, ",", ".") & ")"

        GerirLigacao.ExecutarCmdSQL(cmdSql)



        cmdSql = "SELECT TOP 1 Numero FROM Fatura ORDER BY Numero DESC"
        Dim r As DataSet = GerirLigacao.obterDados(cmdSql)
            txtNumero.Text = r.Tables(0).Rows(0).Item("Numero")
            txtNrFatura.Text = txtNumero.Text
            Dim msg = "Fatura guardada com sucesso"
            Dim titulo = "Guardar"
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Information
            MessageBox.Show(msg, titulo, botoes, icone)

        'Else
        '    Beep()
        '    MsgBox("Não deu")

        'End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim msg = "Confirma a eliminação deste registo de Fatura?"
        Dim titulo = "Eliminar Fatura"
        Dim botoes = MessageBoxButtons.YesNo
        Dim icone = MessageBoxIcon.Question

        If MessageBox.Show(msg, titulo, botoes, icone) = DialogResult.Yes Then

            Dim cmdSql = "DELETE FROM DetalheFatura WHERE NumeroFatura =" &
                txtNrFatura.Text & " AND CodigoProduto = " & txtCodProduto.Text

            GerirLigacao.ExecutarCmdSQL(cmdSql)

            limparFatura()
            limparDetalheFatura()
            GrelhaProdutos.DataSource = Nothing
        End If
    End Sub




    Private Sub btnAdicionarItem_Click(sender As Object, e As EventArgs) Handles btnAdicionarItem.Click

        limparDetalheFatura()
        txtCodProduto.Focus()

    End Sub

    Private Sub btnProcurarProduto_Click(sender As Object, e As EventArgs) Handles btnProcurarProduto.Click
        Dim cmdSql As String = "SELECT * FROM Produtos WHERE Codigo = " &
            CInt(txtCodProduto.Text)

        Dim ds As DataSet = GerirLigacao.obterDados(cmdSql)

        If ds.Tables(0).Rows.Count > 0 Then

            txtProduto.Text = ds.Tables(0).Rows(0).Item("Descricao")
            txtUnidade.Text = ds.Tables(0).Rows(0).Item("Unidade")
            txtIVA.Text = ds.Tables(0).Rows(0).Item("TaxaIVA")
            txtPreco.Text = ds.Tables(0).Rows(0).Item("ValorUnitario")
            txtQTD.Text = 0
            txtValorTotal.Text = 0
        Else
            Dim msg = "Código de produto não existente."
            Dim titulo = "Procurar"
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Information
            MessageBox.Show(msg, titulo, botoes, icone)
        End If
    End Sub

    Private Sub btnProcuraFatura_Click(sender As Object, e As EventArgs) Handles btnProcuraFatura.Click
        Dim cmdSql As String = "SELECT * FROM Fatura WHERE Numero = " &
            CInt(txtNrFatura.Text)

        Dim ds As DataSet = GerirLigacao.obterDados(cmdSql)

        If ds.Tables(0).Rows.Count > 0 Then

            txtNumero.Text = ds.Tables(0).Rows(0).Item("Numero")
            txtCliente.Text = ds.Tables(0).Rows(0).Item("Cliente")
            dataFatura.Value = ds.Tables(0).Rows(0).Item("Data")
            txtTotal.Text = ds.Tables(0).Rows(0).Item("ValorTotal")

            atualizarGrid(txtNumero.Text)
        Else
            limparFatura()
            limparDetalheFatura()
            Dim msg = "Número de Fatura não encontrada"
            Dim titulo = "Procurar"
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Information
            MessageBox.Show(msg, titulo, botoes, icone)
        End If
    End Sub



    Private Sub GrelhaProdutos_SelectionChanged(sender As Object, e As EventArgs) Handles GrelhaProdutos.SelectionChanged

        If GrelhaProdutos.RowCount <> 0 Then
            If GrelhaProdutos.SelectedRows.Count > 0 Then
                txtCodProduto.Text = GrelhaProdutos.SelectedRows(0).Cells("CodigoProduto").Value
                txtProduto.Text = GrelhaProdutos.SelectedRows(0).Cells("Descricao").Value
                txtUnidade.Text = GrelhaProdutos.SelectedRows(0).Cells("Unidade").Value
                txtQTD.Text = GrelhaProdutos.SelectedRows(0).Cells("Quantidade").Value
                txtPreco.Text = GrelhaProdutos.SelectedRows(0).Cells("ValorUnitario").Value
                txtIVA.Text = GrelhaProdutos.SelectedRows(0).Cells("TaxaIVA").Value
                txtTotal.Text = GrelhaProdutos.SelectedRows(0).Cells("ValorTotal").Value
            Else
            txtCodProduto.Text = GrelhaProdutos.Rows(0).Cells("CodigoProduto").Value
            txtProduto.Text = GrelhaProdutos.Rows(0).Cells("Descricao").Value
            txtUnidade.Text = GrelhaProdutos.Rows(0).Cells("Unidade").Value
            txtQTD.Text = GrelhaProdutos.Rows(0).Cells("Quantidade").Value
            txtPreco.Text = GrelhaProdutos.Rows(0).Cells("ValorUnitario").Value
            txtIVA.Text = GrelhaProdutos.Rows(0).Cells("TaxaIVA").Value
            txtTotal.Text = GrelhaProdutos.Rows(0).Cells("ValorTotal").Value
        End If
        End If



    End Sub

    Private Sub txtQTD_TextChanged(sender As Object, e As EventArgs) Handles txtQTD.TextChanged

        Dim q = CDbl(Replace(txtQTD.Text, ".", ","))
        Dim p = CDbl(Replace(txtPreco.Text, ".", ","))
        txtTotal.Text = (q) * (p)

    End Sub

    Private Sub btnGuardarItem_Click(sender As Object, e As EventArgs) Handles btnGuardarItem.Click

        Dim existe As Boolean
        Dim sSQL As String

        If IsNumeric(txtNrFatura.Text) Then
            For i = 0 To GrelhaProdutos.Rows.Count - 1

                If txtCodProduto.Text =
                        GrelhaProdutos.Rows(i).Cells("CodigoProduto").Value Then

                    existe = True
                    Exit For

                End If

            Next

            If existe Then
                sSQL = "UPDATE DetalheFatura SET " &
                    "Quantidade = " & Replace(txtQTD.Text, ",", ".") &
                    ", TaxaIVA = " & CInt(txtIVA.Text) &
                    ", ValorUnitario = " & Replace(txtPreco.Text, ",", ".") &
                    ", ValorTotal = " & Replace(txtValorTotal.Text, ",", ".") &
                    " WHERE NumeroFatura = " & Val(txtNumero.Text) &
                    " AND CodigoProduto = " & Val(txtCodProduto.Text)
            Else

                sSQL = "INSERT INTO DetalheFatura (NumeroFatura, CodigoProduto, " &
                    " Quantidade, ValorUnitario, TaxaIVA, ValorTotal) VALUES (" &
                    CInt(txtNumero.Text) & ", " &
                    CInt(txtCodProduto.Text) & ", " &
                    CInt(txtQTD.Text) & ", " &
                    Replace(CDbl(txtPreco.Text), ",", ".") & ", " &
                    CInt(txtIVA.Text) & ", " &
                    Replace(CDbl(txtValorTotal.Text), ",", ".") & ")"
            End If

            GerirLigacao.ExecutarCmdSQL(sSQL)

            sSQL = "SELECT SUM(ValorTotal) FROM DetalheFatura WHERE NumeroFatura = " &
                CInt(txtNumero.Text)

            Dim r As DataSet = GerirLigacao.obterDados(sSQL)

            sSQL = "UPDATE Fatura SET ValorTotal = " &
                Replace(r.Tables(0).Rows(0).Item(0).ToString, ",", ".") &
                " WHERE Numero = " & CInt(txtNumero.Text)

            GerirLigacao.ExecutarCmdSQL(sSQL)

            txtTotal.Text = r.Tables(0).Rows(0).Item(0)
            atualizarGrid(txtNumero.Text)
            Dim msg = "Item Guardado com sucesso."
            Dim titulo = "Guardar"
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Information
            MessageBox.Show(msg, titulo, botoes, icone)
        Else
            Beep()

        End If



    End Sub

    Private Sub btnRemoverItem_Click(sender As Object, e As EventArgs) Handles btnRemoverItem.Click

        Dim msg = "Remover este produto do registo de compra?"
        Dim titulo = "Remover"
        Dim botoes = MessageBoxButtons.YesNo
        Dim icone = MessageBoxIcon.Question

        If MessageBox.Show(msg, titulo, botoes, icone) = DialogResult.Yes Then
            Dim sSQL As String
            sSQL = "DELETE FROM DetalheFatura WHERE CodigoProduto = " &
                CInt(txtCodProduto.Text) & " AND NumeroFatura = " &
                CInt(txtNumero.Text)

            GerirLigacao.ExecutarCmdSQL(sSQL)

            sSQL = "SELECT SUM(ValorTotal) FROM DetalheFatura " &
                "WHERE NumeroFatura = " & CInt(txtNumero.Text)

            Dim r As DataSet = GerirLigacao.obterDados(sSQL)

            sSQL = "UPDATE Fatura SET ValorTotal = " &
                Replace(r.Tables(0).Rows(0).Item(0), ",", ".") &
                " WHERE Numero = " & CInt(txtNumero.Text)

            GerirLigacao.ExecutarCmdSQL(sSQL)

            txtTotal.Text = r.Tables(0).Rows(0).Item(0)
            atualizarGrid(txtNumero.Text)


        End If

    End Sub
End Class