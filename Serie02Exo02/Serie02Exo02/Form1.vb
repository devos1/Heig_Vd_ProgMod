'-------------------------------------------------------------------------------
'Date		    : 08.12.2013                                                    '
'Auteur		    : DevOs                                                         '
'Nom			: Serie02Exo02                                                  '
'Description	: Un simple ColorChooser qui affiche les valeur RGB             '
'--------------------------------------------------------------------------------
Public Class Form1

    Private Sub vsbRed_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbRed.Scroll
        lblRvalue.Text = vsbRed.Value
    End Sub

    Private Sub vsbGreen_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbGreen.Scroll
        lblVvalue.Text = vsbGreen.Value
    End Sub

    Private Sub vsbBlue_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbBlue.Scroll
        lblBvalue.Text = vsbBlue.Value
    End Sub

    'PROCEDURE POUR COLORIER LE FOND DU PICTUREBOX
    Private Sub colorPicBox(ByVal sender As Object, ByVal e As System.EventArgs) Handles vsbRed.ValueChanged, vsbGreen.ValueChanged, vsbBlue.ValueChanged
        picColor.BackColor = Color.FromArgb(vsbRed.Value, vsbGreen.Value, vsbBlue.Value)
    End Sub
End Class
