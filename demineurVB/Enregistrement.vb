Imports System.IO
Imports Newtonsoft.Json
Module Enregistrement
    Public Structure Personne
        Dim nom As String
        Dim nbcase As Integer
        Dim nbpartie As Integer
        Dim tempcumule As Integer
    End Structure

    Dim Listpers() As Personne
    Dim nbP As UInteger

    Public Sub triDecroissant(listP As Personne())
        Dim temps As Personne
        For i As Integer = 0 To listP.Length - 3
            If listP(i).nbcase > listP(i + 1).nbcase Then
                temps = listP(i)
                listP(i) = listP(i + 1)
                listP(i + 1) = temps
                i = -1
            End If
        Next
    End Sub

    Public Sub triCroissant(listP As Personne())
        triDecroissant(listP)
        listP.Reverse
    End Sub

    Public Sub Deserialiser()
        Dim scr As New StreamReader("../../Enregistrement.json")
        Dim json As String = ""
        Do Until scr.EndOfStream
            json &= scr.ReadLine
        Loop
        Listpers = JsonConvert.DeserializeObject(Of Personne())(json)
        nbP = Listpers.Length - 1
        scr.Close()
    End Sub

    Public Sub serialiser()
        Dim tableau(getNbjoueur()) As Personne
        For j As Integer = 0 To nbP - 1
            tableau(j) = Listpers(j)
        Next
        Dim scr As New StreamWriter("../../Enregistrement.json")
        Dim sr As String = JsonConvert.SerializeObject(tableau, Formatting.Indented)
        scr.WriteLine(sr)
        scr.Close()
    End Sub

    Public Sub Ajouterjoueur(listpers() As Personne, personne As Personne)
        If estPresent(listpers, personne.nom) = True Then
            For i As Integer = 0 To getNbjoueur() - 1
                If listpers(i).nom = personne.nom Then
                    listpers(i).nom = personne.nom
                    listpers(i).nbcase += personne.nbcase
                    listpers(i).nbpartie += personne.nbpartie
                    listpers(i).tempcumule += personne.tempcumule
                End If
            Next
        Else
            listpers(getNbjoueur()) = personne
            nbP += 1
        End If

    End Sub

    Public Function getNbjoueur() As Integer
        Return nbP
    End Function

    Public Function getjoueur(i As Integer) As Personne
        Debug.Assert(i >= 0 And i < nbP)
        Return Listpers(i)
    End Function

    Public Function getListpers() As Personne()
        Return Listpers
    End Function

    Public Function estPresent(listpers() As Personne, nom As String) As Boolean
        For i As Integer = 0 To getNbjoueur() - 1
            If listpers(i).nom = nom Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function initpersonne(nom As String, nbcase As Integer, nbpartie As Integer, tempcumule As Integer) As Personne
        Dim personne As Personne = New Personne
        personne.nom = nom
        personne.nbcase = nbcase
        personne.nbpartie = nbpartie
        personne.tempcumule = tempcumule
        Return personne
    End Function


End Module
