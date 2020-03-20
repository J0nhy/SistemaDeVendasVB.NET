Imports System.ComponentModel
Imports System.Data.OleDb
Public Class FrmProduto

    Public ligacao As OleDbConnection
    Public despesasTabela As DataTable

    Public dadosLigacao As String
    Public comandoLigacao As String
    Public Editar As Boolean = False
    Public registo As Integer

    Private Sub FrmProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim cmdSql As String = "SELECT * FROM Produtos"

        dadosLigacao = My.Settings.VendasDBConnectionString
        ligacao = New OleDbConnection(dadosLigacao)
        ligacao.Open()
        AtualizarGrid()

    End Sub

    Private Sub AtualizarGrid()
        comandoLigacao = "SELECT * FROM Produtos"

        despesasTabela = New DataTable

        Dim adaptador As New OleDbDataAdapter(comandoLigacao, ligacao)
        adaptador.Fill(despesasTabela)
        adaptador.Dispose()
        GrelhaProdutos.DataSource = despesasTabela.DefaultView
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'Dim comandoSQL As OleDbCommand
        'Dim sSQL As String



        'If Editar = False Then
        '    sSQL = "INSERT INTO Produtos (Descricao, Unidade, TaxaIVA, ValorUnitario) VALUES (#" & DataDespesa.Value.ToString("dd/MM/yyyy") & "#, '" & txtDescricao.Text & "', " & Replace(ValorDespesa.Text, ",", ".") & ")"
        'Else
        '    sSQL = "UPDATE Produtos SET Data = #" & DataDespesa.Value.ToString("dd/MM/yyyy") & "#, Despesa = '" & txtDespesa.Text & "', Valor = '" & ValorDespesa.Text & "' WHERE Codigo = " & registo
        '    Editar = False
        'End If


        'comandoSQL = New OleDbCommand(sSQL, ligacao)
        'comandoSQL.ExecuteNonQuery()
        'AtualizarGrid()

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class