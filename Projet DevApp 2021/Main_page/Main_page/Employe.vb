Public Class Employe
    Private Sub Employe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("ID employé(e)", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Nom et prénom", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Heure de travail", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Sex", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Responsabilité", 100, HorizontalAlignment.Center)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ListView1.Items.Add(New ListViewItem())
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Modifer_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Supprimer_Click_1(sender As Object, e As EventArgs) Handles Supprimer.Click

    End Sub
End Class