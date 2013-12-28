Public Class Form1
    '-------------------------------------------------------------------------------
    'Date		    : 28.12.2013                                                    '
    'Auteur		    : Oscar                                                         '
    'Nom			: Serie05Exo01                                                  '
    'Description	: Parcours d'un tableau à une dimension                         '
    '--------------------------------------------------------------------------------

    'CONSTANTES
    Const MAX_TAB = 10

    'GLOBAL_VAR POUR CETTE CLASSE
    Dim tab(MAX_TAB) As String
    Dim indiceEnCours As Integer

    'INIT DU FORMULAIRE
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer

        'REMPLISSAGE DU TABLEAU
        For i = 1 To MAX_TAB
            If i = 1 Then
                tab(i) = "Contenu du 1er élément"
            Else
                tab(i) = "Contenu du " & i & "ème élément"
            End If
        Next

        'DONNE LE FOCUS AU BOUTON "PREMIER"
        btnPremier.Focus()

        'MODIFICATION PROPRIETES PAR DEFAUT
        txtContenu.ReadOnly = True
        txtContenu.TabStop = False
    End Sub

    '1ER ELEMENT
    Private Sub btnPremier_Click(sender As Object, e As EventArgs) Handles btnPremier.Click

        indiceEnCours = 1
        modifieTextBox()
        activeBtn()

    End Sub

    'ELEMENT PRECEDENT
    Private Sub btnPrecedent_Click(sender As Object, e As EventArgs) Handles btnPrecedent.Click

        indiceEnCours = indiceEnCours - 1
        modifieTextBox()
        activeBtn()

    End Sub

    'ELEMENT SUIVANT
    Private Sub btnSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivant.Click

        indiceEnCours = indiceEnCours + 1
        modifieTextBox()
        activeBtn()

    End Sub

    'DERNIER ELEMENT
    Private Sub btnDernier_Click(sender As Object, e As EventArgs) Handles btnDernier.Click

        indiceEnCours = MAX_TAB
        modifieTextBox()
        activeBtn()

    End Sub

    'Insère dans le textbox l'élément du tableau concerné par l'indice
    Private Sub modifieTextBox()

        txtContenu.Text = tab(indiceEnCours)

    End Sub

    'Désactive les boutons quand on ne devrait plus pouvoir cliquer dessus
    Private Sub activeBtn()

        btnPremier.Enabled = indiceEnCours > 1
        btnPrecedent.Enabled = indiceEnCours > 1
        btnSuivant.Enabled = indiceEnCours < MAX_TAB
        btnDernier.Enabled = indiceEnCours < MAX_TAB

    End Sub
End Class
