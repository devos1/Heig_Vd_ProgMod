'-------------------------------------------------------------------------------
'Date		    : 07.12.2013                                                    '
'Auteur		    : DevOs                                                         '
'Nom			: Serie06Exo01                                                  '
'Description	: Formulaire de base                                            '
'--------------------------------------------------------------------------------
Public Class Form1

    '---VAR_GLOBAL---
    'DECLARATION ET INIT D'UNE NOUVELLE COLLECTION
    Dim c As Collection = New Collection()
    Dim noItemEnCours As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer

        'CREATION DE i INSTANCES DE LA CLASSE PERSONNE ET AJOUT A LA COLLECTION C
        For i = 1 To 5
            Dim p As Personne = New Personne()
            c.Add(p)
        Next

        'INSERTION DES CONTACTS DANS LA COLLECTION
        insertContact()

    End Sub

    'PROCEDURE POUR AFFICHER LE PREMIER CONTACT DE LA COLLECTION
    Private Sub btnPremier_Click(sender As Object, e As EventArgs) Handles btnPremier.Click
        insertInfosDansForm(1)
        noItemEnCours = 1
    End Sub

    'PROCEDURE POUR AFFICHER LE DERNIER CONTACT DE LA COLLECTION
    Private Sub btnDernier_Click(sender As Object, e As EventArgs) Handles btnDernier.Click
        Dim max As Integer
        max = c.Count
        insertInfosDansForm(max)
        noItemEnCours = max
    End Sub

    'PROCEDURE POUR INSERER LES CONTACTS DANS LA COLLECTION DE PERSONNES
    Private Sub insertContact()
        c.Item(1).nom = "nom1"
        c.Item(1).prenom = "prenom1"
        c.Item(1).age = 20
        c.Item(1).image = My.Resources.Smiley_01
        c.Item(2).nom = "nom2"
        c.Item(2).prenom = "prenom2"
        c.Item(2).age = 21
        c.Item(2).image = My.Resources.Smiley_02
        c.Item(3).nom = "nom3"
        c.Item(3).prenom = "prenom3"
        c.Item(3).age = 22
        c.Item(3).image = My.Resources.Smiley_03
        c.Item(4).nom = "nom4"
        c.Item(4).prenom = "prenom4"
        c.Item(4).age = 23
        c.Item(4).image = My.Resources.Smiley_04
        c.Item(5).nom = "nom5"
        c.Item(5).prenom = "prenom5"
        c.Item(5).age = 24
        c.Item(5).image = My.Resources.Smiley_05
    End Sub

    'PROCEDURE POUR INSERER LES INFOS DES CONTACTS DANS LE FORM
    Sub insertInfosDansForm(num As Integer)
        txtNom.Text = c.Item(num).nom
        txtPrenom.Text = c.Item(num).prenom
        txtAge.Text = c.Item(num).age
        picImgContact.Image = c.Item(num).image
    End Sub

    'PRODECURE POUR AVANCER DANS LA COLLECTION
    Private Sub btnSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivant.Click
        If noItemEnCours < c.Count Then
            insertInfosDansForm(noItemEnCours + 1)
            noItemEnCours = noItemEnCours + 1
        Else
            MsgBox("Fin de la collection")
        End If
    End Sub

    'PRODECURE POUR RECULER DANS LA COLLECTION
    Private Sub btnPrecedent_Click(sender As Object, e As EventArgs) Handles btnPrecedent.Click
        If noItemEnCours > 1 Then
            insertInfosDansForm(noItemEnCours - 1)
            noItemEnCours = noItemEnCours - 1
        Else
            MsgBox("Debut de collection")
        End If

    End Sub
End Class

