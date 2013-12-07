'-------------------------------------------------------------------------------
'Date		    : 07.12.2013                                                    '
'Auteur		    : DevOs                                                         '
'Nom			: Serie06Exo01                                                  '
'Description	: Formulaire de base                                            '
'--------------------------------------------------------------------------------
Public Class Form1

    Dim c As Collection = New Collection()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer

        For i = 1 To 5
            Dim p As Personne = New Personne()
            c.Add(p)
        Next

        insertContact()

    End Sub

    Private Sub btnPremier_Click(sender As Object, e As EventArgs) Handles btnPremier.Click
        txtNom.Text = c.Item(1).nom
        txtPrenom.Text = c.Item(1).prenom
        txtAge.Text = c.Item(1).age
        picImgContact.Image = c.Item(1).image
    End Sub

    Private Sub btnDernier_Click(sender As Object, e As EventArgs) Handles btnDernier.Click
        Dim max As Integer
        max = c.Count
    End Sub

    Private Sub insertContact()
        c.Item(1).nom = "nom1"
        c.Item(1).prenom = "prenom1"
        c.Item(1).age = 1
        c.Item(1).image = Image.FromFile("E://1.png")
        c.Item(2).nom = "nom2"
        c.Item(2).prenom = "prenom2"
        c.Item(2).age = 1
        c.Item(3).nom = "nom3"
        c.Item(3).prenom = "prenom3"
        c.Item(3).age = 1
        c.Item(4).nom = "nom4"
        c.Item(4).prenom = "prenom4"
        c.Item(4).age = 1
        c.Item(5).nom = "nom5"
        c.Item(5).prenom = "prenom5"
        c.Item(5).age = 1

    End Sub


End Class

