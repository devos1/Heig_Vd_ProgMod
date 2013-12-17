'-------------------------------------------------------------------------------
'Date		    : 09.12.2013                                                    '
'Auteur		    : DevOs                                                         '
'Nom			: Serie03Exo05                                                  '
'Description	: Formulaire de base pour ouvrir colorchooser                   '
'--------------------------------------------------------------------------------
Public Class frmExo3Serie3

    'PROCEDURE QUI CHANGE LA COULEUR DE FOND EN FONCTION DE LA COULEUR DU COLOR CHOOSER
    Private Sub frmExo3Serie3_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.BackColor = frmColorChooser.getColor(Me.BackColor)
    End Sub

End Class
