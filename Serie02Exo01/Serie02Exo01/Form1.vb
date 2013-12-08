'-------------------------------------------------------------------------------
'Date		    : 08.12.2013                                                    '
'Auteur		    : DevOs                                                         '
'Nom			: Serie02Exo01                                                  '
'Description	: Exercice de base pour commencer à utiliser un WinForm         '
'--------------------------------------------------------------------------------
Public Class Form1

    'AU LANCEMENT DU FORMULAIRE,SELECTION DE LA CASE DU NOM
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNom.Select()
    End Sub

    'CALCUL DU NOMBRE DE PATINS COMMANDÉS ET DU COUT TOTAL
    Private Sub btnCalculer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculer.Click
        txtNbPatinsCommand.Text = Val(txtPatinsBlCommand.Text) + Val(txtPatinsJaCommand.Text)
        txtTotal.Text = Val(txtNbPatinsCommand.Text) * Val(txtPrixUnit.Text)
        btnImprimer.Focus()
    End Sub

    'PASSE SIMPLEMENT LE FOCUS AU BOUTON EFFACER
    Private Sub btnImprimer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImprimer.GotFocus
        btnEffacer.Focus()
    End Sub

    'EFFACE LES TEXTBOX SAUF LE CELUI DU PRIX UNITAIRE
    Private Sub btnEffacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEffacer.Click

        For Each c In GroupBox1.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next

        For Each c In GroupBox2.Controls
            If TypeOf c Is TextBox Then
                If c.Name <> "txtPrixUnit" Then
                    c.clear() 'plus élégant que c.Text = ""
                End If
            End If
        Next

    End Sub

    'BOUTON POUR QUITTER L'APPLICATION
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitter.Click
        Application.Exit()
    End Sub
End Class
