Public Class Demineur
    Dim jeuG As jeugrille
    Dim temp As Integer = LesOptions.getoption.temp
    Dim colonne As Integer = LesOptions.getoption.colonne
    Dim ligne As Integer = LesOptions.getoption.ligne
    Dim nbmine As Integer = LesOptions.getoption.nbmine
    Dim tabbutton(colonne, ligne) As Button
    Dim personne As Personne

    Private Sub Demineur_Load() Handles MyBase.Load

        If temp = 0 And colonne = 0 And ligne = 0 And nbmine = 0 Then
            temp = 60
            colonne = 8
            ligne = 8
            nbmine = 10
        End If

        tabbutton = New Button(colonne, ligne) {}
        jeuG = New jeugrille()

        nomjoueur.Text = FormInscri.nomjoueur.Text
        interfacedejeu.BackColor = Color.White
        jeuG = Jeudemineur.initGrille(colonne, ligne, nbmine)
        Timer1.Interval = 1000
        Timer1.Start()

        For i As Integer = 0 To jeuG.colonne - 1
            For j As Integer = 0 To jeuG.ligne - 1
                Dim b As Button = New Button()
                b.Width = 40
                b.Height = 40
                b.TabStop = False

                b.Location = New System.Drawing.Point(40 * i, 40 * j)
                interfacedejeu.Width = interfacedejeu.Height + 40
                AddHandler b.Click, AddressOf Onbutton_click
                tabbutton(i, j) = b
                interfacedejeu.Controls.Add(tabbutton(i, j))
            Next
            interfacedejeu.Height = interfacedejeu.Height + 40
        Next

    End Sub


    Private Sub abandon_Click(sender As Object, e As EventArgs) Handles abandon.Click
        Me.Close()
        FormInscri.Show()
    End Sub


    Private Sub Onbutton_click(sender As Button, e As EventArgs)
        Dim jeuperdu As Boolean = False
        For i As Integer = 0 To jeuG.colonne - 1
            For j As Integer = 0 To jeuG.ligne - 1
                If sender Is tabbutton(i, j) Then
                    If jeuG.grille(i, j).mine = True Then
                        sender.BackColor = Color.Red
                        sender.Enabled = False
                        sender.Text = "X"
                        Timer1.Stop()
                        personne = initpersonne(FormInscri.nomjoueur.Text, getNbcase(jeuG), 1, temp)
                        Ajouterjoueur(Enregistrement.getListpers, personne)
                        jeuperdu = True
                        perdu(tabbutton, jeuG)
                        Me.Close()
                        FormInscri.Show()
                    Else
                        If gagner(jeuG, nbmine) = True And jeuperdu = False Then
                            personne = initpersonne(FormInscri.nomjoueur.Text, getNbcase(jeuG), 1, temp)
                            Ajouterjoueur(Enregistrement.getListpers, personne)
                            MsgBox("Vous avez gagner", vbOKOnly, "Bien joué à vous !")
                            Me.Close()
                            FormInscri.Show()
                        End If
                        If jeuG.grille(i, j).nbmineautour > 0 Then
                            sender.BackColor = Color.LightBlue
                            jeuG.grille(i, j).decouverte = True
                            sender.Text = jeuG.grille(i, j).nbmineautour
                            sender.Enabled = False
                        Else
                            sender.BackColor = Color.LightBlue
                            sender.Enabled = False
                            demasquer(tabbutton, jeuG, i, j)
                        End If
                    End If
                End If
            Next
        Next
    End Sub


    Private Sub afficheHeure(sender As Object, e As EventArgs) Handles Timer1.Tick
        temp = temp - 1
        LabelChro.Text = temp
        If temp = 0 Then
            Timer1.Stop()
            personne = initpersonne(FormInscri.nomjoueur.Text, getNbcase(jeuG), 1, temp)
            Ajouterjoueur(Enregistrement.getListpers, personne)
            perdu(tabbutton, jeuG)
        End If
    End Sub



    Private Sub Pause_Click(sender As Object, e As EventArgs) Handles Pause.Click
        If Pause.Text = "Pause" Then
            Timer1.Stop()
            For i As Integer = 0 To colonne - 1
                For j As Integer = 0 To ligne - 1
                    tabbutton(i, j).Enabled = False
                Next
            Next
            Pause.Text = "Continuer"
        Else
            Timer1.Start()
            For i As Integer = 0 To colonne - 1
                For j As Integer = 0 To ligne - 1
                    tabbutton(i, j).Enabled = True
                Next
            Next
            Pause.Text = "Pause"
        End If

    End Sub

    Private Sub Demineur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class