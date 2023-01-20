Public Class LesOptions
    Public Structure options
        Dim temp As Integer
        Dim colonne As Integer
        Dim ligne As Integer
        Dim nbmine As Integer
    End Structure

    Dim opt As options = New options()

    Public Function getoption() As options
        Return opt
    End Function

    Private Sub retour_Click(sender As Object, e As EventArgs) Handles retour.Click
        Me.Hide()
        FormInscri.Show()
    End Sub

    Private Sub sauvegader_Click(sender As Object, e As EventArgs) Handles sauvegader.Click
        opt.nbmine = TextBox3.Text
        opt.colonne = TextBox1.Text
        opt.ligne = TextBox2.Text
        opt.temp = Label5.Text
    End Sub

    Private Sub defaut_Click(sender As Object, e As EventArgs) Handles defaut.Click
        TextBox3.Text = 10
        TextBox1.Text = 8
        TextBox2.Text = 8
        Label5.Text = 60
        opt.nbmine = 10
        opt.colonne = 8
        opt.ligne = 8
        opt.temp = 60
    End Sub

    Private Sub letempdejeu_Scroll(sender As Object, e As ScrollEventArgs) Handles letempdejeu.Scroll
        letempdejeu.LargeChange = 1
        letempdejeu.SmallChange = 1
        letempdejeu.Minimum = 0
        letempdejeu.Maximum = TextBox4.Text
        Label5.Text = letempdejeu.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BackColor = System.Drawing.Color.FromName("AliceBlue")
        FormInscri.BackColor = System.Drawing.Color.FromName("AliceBlue")
        scoreEnregistrement.BackColor = System.Drawing.Color.FromName("AliceBlue")
        Demineur.BackColor = System.Drawing.Color.FromName("AliceBlue")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.BackColor = System.Drawing.Color.DarkRed
        FormInscri.BackColor = System.Drawing.Color.DarkRed
        scoreEnregistrement.BackColor = System.Drawing.Color.DarkRed
        Demineur.BackColor = System.Drawing.Color.DarkRed
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.BackColor = System.Drawing.Color.Chocolate
        FormInscri.BackColor = System.Drawing.Color.Chocolate
        scoreEnregistrement.BackColor = System.Drawing.Color.Chocolate
        Demineur.BackColor = System.Drawing.Color.Chocolate
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.BackColor = System.Drawing.Color.DeepPink
        FormInscri.BackColor = System.Drawing.Color.DeepPink
        scoreEnregistrement.BackColor = System.Drawing.Color.DeepPink
        Demineur.BackColor = System.Drawing.Color.DeepPink
    End Sub
End Class