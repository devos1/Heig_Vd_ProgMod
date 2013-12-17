'-------------------------------------------------------------------------------
'Date		    : 09.12.2013                                                    '
'Auteur		    : DevOs                                                         '
'Nom			: Serie03Exo05                                                  '
'Description	: Formulaire ColorChooser                                       '
'--------------------------------------------------------------------------------
Public Class frmColorChooser

    'GLOBAL_VAR
    Public color As Color

    'AFFECTER AU TEXTBOX LA VALEUR DE LA COMPOSANTE ROUGE
    Private Sub vsbRed_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbRed.Scroll
        lblRvalue.Text = vsbRed.Value
    End Sub

    'AFFECTER AU TEXTBOX LA VALEUR DE LA COMPOSANTE VERTE
    Private Sub vsbGreen_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbGreen.Scroll
        lblVvalue.Text = vsbGreen.Value
    End Sub

    'AFFECTER AU TEXTBOX LA VALEUR DE LA COMPOSANTE BLEU
    Private Sub vsbBlue_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbBlue.Scroll
        lblBvalue.Text = vsbBlue.Value
    End Sub

    'PROCEDURE POUR COLORIER LE FOND DU PICTUREBOX
    Private Sub colorPicBox(ByVal sender As Object, ByVal e As System.EventArgs) Handles vsbRed.ValueChanged, vsbGreen.ValueChanged, vsbBlue.ValueChanged
        picColor.BackColor = color.FromArgb(vsbRed.Value, vsbGreen.Value, vsbBlue.Value)
        color = picColor.BackColor
    End Sub

    'FONCTION PUBLIQUE POUR RETOURNER SA COULEUR DE FOND
    Function getColor(ByVal c As Color) As Color
        If Me.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return color
        Else
            Return c
        End If
    End Function

End Class
