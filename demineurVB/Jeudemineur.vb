Module Jeudemineur
    Public Structure casedujeu
        Dim mine As Boolean
        Dim decouverte As Boolean
        Dim nbmineautour As Integer
    End Structure
    Public Structure jeugrille
        Dim colonne, ligne As Integer
        Dim grille(,) As casedujeu
    End Structure

    Public Function initGrille(c As Integer, l As Integer, nbmine As Integer) As jeugrille
        Dim random As New Random()
        Dim nbcase = c * l
        Dim jeugrille As jeugrille
        jeugrille.colonne = c
        jeugrille.ligne = l
        jeugrille.grille = New casedujeu(c, l) {}
        For i As Integer = 0 To c - 1
            For j As Integer = 0 To l - 1
                jeugrille.grille(i, j).mine = False
                jeugrille.grille(i, j).decouverte = False
                jeugrille.grille(i, j).nbmineautour = 0
            Next
        Next
        Dim pos As Integer = 0
        While pos < nbmine
            Dim mine As Integer = random.Next(0, nbcase)
            If jeugrille.grille(mine \ jeugrille.colonne, mine Mod jeugrille.ligne).mine = False Then
                jeugrille.grille(mine \ jeugrille.colonne, mine Mod jeugrille.ligne).mine = True
                pos += 1
            End If
        End While

        For i As Integer = 0 To jeugrille.colonne - 1
            For j As Integer = 0 To jeugrille.ligne - 1
                If jeugrille.grille(i, j).mine = True Then
                    If (i + 1 >= 0 And i + 1 < jeugrille.colonne) And (j >= 0 And j < jeugrille.ligne) Then
                        jeugrille.grille(i + 1, j).nbmineautour += 1
                    End If
                    If (i - 1 >= 0 And i - 1 < jeugrille.colonne) And (j >= 0 And j < jeugrille.ligne) Then
                        jeugrille.grille(i - 1, j).nbmineautour += 1
                    End If
                    If (i >= 0 And i < jeugrille.colonne) And (j + 1 >= 0 And j + 1 < jeugrille.ligne) Then
                        jeugrille.grille(i, j + 1).nbmineautour += 1
                    End If
                    If (i >= 0 And i < jeugrille.colonne) And (j - 1 >= 0 And j - 1 < jeugrille.ligne) Then
                        jeugrille.grille(i, j - 1).nbmineautour += 1
                    End If

                    If (i + 1 >= 0 And i + 1 < jeugrille.colonne) And (j + 1 >= 0 And j + 1 < jeugrille.ligne) Then
                        jeugrille.grille(i + 1, j + 1).nbmineautour += 1
                    End If
                    If (i + 1 >= 0 And i + 1 < jeugrille.colonne) And (j - 1 >= 0 And j - 1 < jeugrille.ligne) Then
                        jeugrille.grille(i + 1, j - 1).nbmineautour += 1
                    End If
                    If (i - 1 >= 0 And i - 1 < jeugrille.colonne) And (j + 1 >= 0 And j + 1 < jeugrille.ligne) Then
                        jeugrille.grille(i - 1, j + 1).nbmineautour += 1
                    End If
                    If (i - 1 >= 0 And i - 1 < jeugrille.colonne) And (j - 1 >= 0 And j - 1 < jeugrille.ligne) Then
                        jeugrille.grille(i - 1, j - 1).nbmineautour += 1
                    End If
                End If
            Next
        Next
        Return jeugrille
    End Function

    Public Sub demasquer(tabbuton As Button(,), jeugrille As jeugrille, x As Integer, y As Integer)
        If (x < 0 Or x >= jeugrille.colonne Or y < 0 Or y >= jeugrille.ligne) Then
            Exit Sub
        End If
        If jeugrille.grille(x, y).nbmineautour <> 0 Then
            jeugrille.grille(x, y).decouverte = True
            tabbuton(x, y).PerformClick()
            Exit Sub
        End If
        If jeugrille.grille(x, y).decouverte = True Then
            Exit Sub
        End If
        jeugrille.grille(x, y).decouverte = True
        tabbuton(x, y).PerformClick()

        demasquer(tabbuton, jeugrille, x + 1, y)
        demasquer(tabbuton, jeugrille, x - 1, y)
        demasquer(tabbuton, jeugrille, x, y + 1)
        demasquer(tabbuton, jeugrille, x, y - 1)

        demasquer(tabbuton, jeugrille, x + 1, y + 1)
        demasquer(tabbuton, jeugrille, x + 1, y - 1)
        demasquer(tabbuton, jeugrille, x - 1, y + 1)
        demasquer(tabbuton, jeugrille, x - 1, y + 1)

    End Sub

    Public Sub perdu(tabbuton As Button(,), jeugrille As jeugrille)
        For i As Integer = 0 To jeugrille.colonne - 1
            For j As Integer = 0 To jeugrille.ligne - 1
                If jeugrille.grille(i, j).mine = False Then
                    tabbuton(i, j).PerformClick()
                Else
                    tabbuton(i, j).BackColor = Color.Red
                    tabbuton(i, j).Enabled = False
                    tabbuton(i, j).Text = "X"
                End If
            Next
        Next
        MsgBox("Perdu !", vbOKOnly, "Vous avez perdu, dommage ...")
    End Sub

    Public Function gagner(jeugrille As jeugrille, nbmine As Integer) As Boolean
        Dim compteurdecase As Integer = 0 'jeugrille.colonne * jeugrille.ligne - nbmine
        For i As Integer = 0 To jeugrille.colonne - 1
            For j As Integer = 0 To jeugrille.ligne - 1
                If jeugrille.grille(i, j).decouverte = True And jeugrille.grille(i, j).mine = False Then
                    compteurdecase += 1
                End If
            Next
        Next
        If compteurdecase = jeugrille.colonne * jeugrille.ligne - nbmine Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getNbcase(jeugrille As jeugrille) As Integer
        Dim compte As Integer = 0
        For i As Integer = 0 To jeugrille.colonne - 1
            For j As Integer = 0 To jeugrille.ligne - 1
                If jeugrille.grille(i, j).decouverte = True Then
                    compte += 1
                End If
            Next
        Next
        Return compte

    End Function
End Module
