'-------------------------------------------------------------------------------
'Date		    : 28.12.2013                                                    '
'Auteur		    : Oscar	                                                     	'
'Nom			: Serie05Exo02                                                  '
'Description	: Affectation et consultation d'un tableau dynamique            '
'--------------------------------------------------------------------------------

Public Class Form1

    'Global Var pour cette classe
    Dim tab() As String
    Dim indiceEnCours As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Désactiver tous les boutons du Formulaire
        For Each b In Me.Controls
            If TypeOf b Is Button Then
                b.enabled = False
            End If
        Next

    End Sub

    'Procédure pour activer le bouton ajouter si le textBox n'est pas vide
    Private Sub txtInsert_TextChanged(sender As Object, e As EventArgs) Handles txtInsert.TextChanged
        btnAjouter.Enabled = True
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click

        'Activation des boutons
        btnDernier.Enabled = True
        btnPrecedent.Enabled = True
        btnPremier.Enabled = True
        btnSuivant.Enabled = True

        If IsNothing(tab) Then
            ReDim Preserve tab(0)               'ATTENTION "REDIM 0" pour une entrée complémentaire
        Else
            ReDim Preserve tab(tab.Length)
        End If

        tab(tab.GetUpperBound(0)) = txtInsert.Text
        txtElement.Text = tab(tab.GetUpperBound(0))

        'Vide le textBox d'insertion
        txtInsert.Text = ""

    End Sub

    'Affiche le premier
    Private Sub btnPremier_Click(sender As Object, e As EventArgs) Handles btnPremier.Click

        indiceEnCours = 0
        modifieTextBox()

    End Sub

    'Affiche le précédent
    Private Sub btnPrecedent_Click(sender As Object, e As EventArgs) Handles btnPrecedent.Click

        If indiceEnCours > 0 Then
            indiceEnCours = indiceEnCours - 1
        Else
            MsgBox("Début du tableau atteint.")
        End If
        modifieTextBox()

    End Sub

    'Affiche le suivant
    Private Sub btnSuivant_Click(sender As Object, e As EventArgs) Handles btnSuivant.Click

        If indiceEnCours < tab.GetUpperBound(0) Then
            indiceEnCours = indiceEnCours + 1
        Else
            MsgBox("Fin du tableau atteinte.")
        End If
        modifieTextBox()

    End Sub

    'Affiche le dernier
    Private Sub btnDernier_Click(sender As Object, e As EventArgs) Handles btnDernier.Click
        indiceEnCours = tab.GetUpperBound(0)
        modifieTextBox()
    End Sub

    'Affiche dans le textbox l'élément du tableau concerné par l'indice
    Private Sub modifieTextBox()

        txtElement.Text = tab(indiceEnCours)

    End Sub
End Class
