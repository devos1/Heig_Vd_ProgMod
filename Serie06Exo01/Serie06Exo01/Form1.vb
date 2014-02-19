'-------------------------------------------------------------------------------
'Date		    : 07.12.2013                                                    '
'Auteur		    : Oscar                                                         '
'Nom			: Serie06Exo01                                                  '
'Description	: Formulaire de base                                            '
'--------------------------------------------------------------------------------
Public Class Form1

    '---VAR_GLOBAL---
    'DECLARATION ET INIT D'UNE NOUVELLE COLLECTION
    Private col As List(Of Personne) = New List(Of Personne)
    Dim c As Collection = New Collection()
    Dim noItemEnCours As Integer

    'INIT DE LA COLLECTION DES PERSONNES
    Private Sub initCol()
        Dim p As Personne

        'Constructeur 1
        p = New Personne("nom1", "prenom1", New Date(1972, 12, 3))
        p.photo = My.Resources.Smiley_01
        col.Add(p)

        'Constructeur 2
        p = New Personne("nom2", "prenom2")
        p.naissance = New Date(1980, 10, 1)
        p.photo = My.Resources.Smiley_02
        col.Add(p)

        'Constructeur 3
        p = New Personne("nom3", "prenom3", New Date(1988, 2, 16), My.Resources.Smiley_03)
        col.Add(p)

        'Constructeur 3
        p = New Personne("nom4", "prenom4", New Date(1969, 1, 11), My.Resources.Smiley_04)
        col.Add(p)

        'Constructeur 3
        p = New Personne("nom5", "prenom5", New Date(1991, 9, 6), My.Resources.Smiley_05)
        col.Add(p)

    End Sub

    'LOAD DU FORM PAR DEFAUT
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        initCol()
        txtNom.ReadOnly = True
        txtNom.TabStop = False
        picImgContact.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

    'PROCEDURE POUR METTRE A JOUR LES BOUTONS (CLIQUABLE OU PAS)
    Private Sub updateButtons()
        btnPremier.Enabled = noItemEnCours > 0
        btnPrecedent.Enabled = noItemEnCours > 0
        btnSuivant.Enabled = noItemEnCours < col.Count - 1
        btnDernier.Enabled = noItemEnCours < col.Count - 1
    End Sub

    'PROCEDURE POUR INSERER LES INFOS DES CONTACTS DANS LE FORM
    Private Sub insertInfosDansForm(ByVal p As Personne)
        txtNom.Text = p.nom
        txtPrenom.Text = p.prenom
        txtAge.Text = p.age
        picImgContact.Image = p.photo
    End Sub

    'PROCEDURE POUR AFFICHER LE PREMIER CONTACT DE LA COLLECTION
    Private Sub btnPremier_Click(sender As Object, e As EventArgs) Handles btnPremier.Click
        noItemEnCours = 0
        updateButtons()
        insertInfosDansForm(col.Item(noItemEnCours))
    End Sub

    'PROCEDURE POUR AFFICHER LE DERNIER CONTACT DE LA COLLECTION
    Private Sub btnDernier_Click(sender As Object, e As EventArgs) Handles btnDernier.Click
        noItemEnCours = col.Count - 1
        insertInfosDansForm(col.Item(noItemEnCours))
        updateButtons()
    End Sub

    'PRODECURE POUR AVANCER DANS LA COLLECTION
    Private Sub btnSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivant.Click
            noItemEnCours = noItemEnCours + 1
            updateButtons()
            insertInfosDansForm(col.Item(noItemEnCours))
    End Sub

    'PRODECURE POUR RECULER DANS LA COLLECTION
    Private Sub btnPrecedent_Click(sender As Object, e As EventArgs) Handles btnPrecedent.Click
        If noItemEnCours > 0 Then
            noItemEnCours = noItemEnCours - 1
            updateButtons()
            insertInfosDansForm(col.Item(noItemEnCours))
        End If
    End Sub
End Class

