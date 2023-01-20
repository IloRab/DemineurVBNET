Public Class FormInscri
    Private Sub newgame_Click(sender As Object, e As EventArgs) Handles newgame.Click
        If nomjoueur.Text.Length < 3 Then
            MsgBox("Nom incorrect !", vbOKOnly)
        Else
            Me.Hide()
            Demineur.Show()
        End If
    End Sub

    Private Sub quitter_Click(sender As Object, e As EventArgs) Handles quitter.Click
        Dim ouinon As MsgBoxResult
        ouinon = MsgBox("Voulez-vous quittez ?", MsgBoxStyle.YesNo, "Exit")
        If ouinon = MsgBoxResult.Yes Then
            serialiser()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub score_Click(sender As Object, e As EventArgs) Handles score.Click
        Me.Hide()
        scoreEnregistrement.Show()
    End Sub

    Private Sub FormInscri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Deserialiser()
        For i As Integer = 0 To getNbjoueur() - 1
            nomjoueur.Items.Add(Enregistrement.getjoueur(i).nom)
        Next
    End Sub

    Private Sub lesoptions_Click(sender As Object, e As EventArgs) Handles lesoptionsbouttons.Click
        LesOptions.Show()
        Me.Hide()
    End Sub
End Class
