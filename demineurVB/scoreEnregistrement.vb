Public Class scoreEnregistrement

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Retour.Click
        Me.Close()
        FormInscri.Show()
    End Sub

    Private Sub scoreEnregistrement_Load() Handles MyBase.Load
        Nomjoueur.Items.Clear()
        nbcasetotale.Items.Clear()
        Nbpartie.Items.Clear()
        Tempstotale.Items.Clear()

        For i As Integer = 0 To Enregistrement.getNbjoueur - 1
            Nomjoueur.Items.Add(Enregistrement.getjoueur(i).nom)
            nbcasetotale.Items.Add(Enregistrement.getjoueur(i).nbcase)
            Nbpartie.Items.Add(Enregistrement.getjoueur(i).nbpartie)
            Tempstotale.Items.Add(Enregistrement.getjoueur(i).tempcumule)
        Next
    End Sub


    Private Sub Nomjoueur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Nomjoueur.SelectedIndexChanged
        ComboBox1.Text = Nomjoueur.SelectedItem
        nbcasetotale.SelectedIndex = Nomjoueur.SelectedIndex
        Nbpartie.SelectedIndex = nbcasetotale.SelectedIndex
        Tempstotale.SelectedIndex = nbcasetotale.SelectedIndex
    End Sub

    Private Sub nbcasetotale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nbcasetotale.SelectedIndexChanged
        ComboBox1.Text = Nomjoueur.SelectedItem
        Nomjoueur.SelectedIndex = nbcasetotale.SelectedIndex
        Nbpartie.SelectedIndex = nbcasetotale.SelectedIndex
        Tempstotale.SelectedIndex = nbcasetotale.SelectedIndex
    End Sub

    Private Sub Nbpartie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Nbpartie.SelectedIndexChanged
        ComboBox1.Text = Nomjoueur.SelectedItem
        Nomjoueur.SelectedIndex = nbcasetotale.SelectedIndex
        nbcasetotale.SelectedIndex = Nbpartie.SelectedIndex
        Tempstotale.SelectedIndex = nbcasetotale.SelectedIndex
    End Sub

    Private Sub Tempstotale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tempstotale.SelectedIndexChanged
        ComboBox1.Text = Nomjoueur.SelectedItem
        Nomjoueur.SelectedIndex = nbcasetotale.SelectedIndex
        nbcasetotale.SelectedIndex = Nbpartie.SelectedIndex
        nbcasetotale.SelectedIndex = Tempstotale.SelectedIndex
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        triDecroissant(getListpers)
        scoreEnregistrement_Load()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'triCroissant(getListpers)
        triDecroissant(getListpers)
        getListpers.Reverse
        scoreEnregistrement_Load()
    End Sub
End Class