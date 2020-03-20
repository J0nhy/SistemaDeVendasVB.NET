Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GerirLigacao.IniciarLigacao(My.Settings.VendasDBConnectionString)
        Dim login As New LoginForm1
        login.MdiParent = Me
        login.Show()
        FATURASToolStripMenuItem.Enabled = False
        PRODUTOSToolStripMenuItem1.Enabled = False

    End Sub

    Private Sub FATURASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FATURASToolStripMenuItem.Click

        Dim f As New FrmFatura
        f.MdiParent = Me
        f.Show()

    End Sub

    Private Sub PRODUTOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PRODUTOSToolStripMenuItem1.Click
        Dim p As New FrmProduto
        p.MdiParent = Me
        p.Show()
    End Sub
End Class
