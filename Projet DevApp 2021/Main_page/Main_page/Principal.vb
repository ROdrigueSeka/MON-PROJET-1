Public Class Principal
    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click

    End Sub

    Private Sub SupprimerUnEmployerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerUnEmployerToolStripMenuItem.Click

    End Sub



    Private Sub FacturationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturationToolStripMenuItem.Click

    End Sub

    Private Sub ImprimerLaFactureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimerLaFactureToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FermerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerToolStripMenuItem.Click
        Me.Close()


    End Sub



    Private Sub ActiverToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        'Pompe2.Show()


    End Sub



    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Miseajours.Show()

    End Sub


    Private Sub DesactiverToolStripMenuItem1_Click(sender As Object, e As EventArgs)






    End Sub

    Private Sub EtatDeLaPompeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Pompe1.Show()


    End Sub

    Private Sub RapportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RapportsToolStripMenuItem.Click

    End Sub

    Private Sub ActiverToolStripMenuItem1_Click_1(sender As Object, e As EventArgs)
        Pompe2.Show()

    End Sub

    Private Sub DésactiverToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Voulez-vous Désactiver?")

    End Sub

    Private Sub DésactiverToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Voulez-vous Désactiver?")
    End Sub

    Private Sub AjouterUnEmployéToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterUnEmployéToolStripMenuItem.Click
        Employe.Show()


    End Sub

    Private Sub Pompes1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pompes1ToolStripMenuItem.Click
        frmActiverPompe.Show()

    End Sub

    Private Sub CréerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréerToolStripMenuItem.Click
        Pompe1.Show()
    End Sub

    Private Sub CréerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CréerToolStripMenuItem1.Click
        frmImpaye.Show()
    End Sub

    Private Sub Pompe2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pompe2ToolStripMenuItem.Click
        FrmDesactiverPompe.Show()

    End Sub

    Private Sub ImpayésToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImpayésToolStripMenuItem1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
