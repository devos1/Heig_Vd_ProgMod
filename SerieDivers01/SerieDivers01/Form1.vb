'-------------------------------------------------------------------------------
'Date		    : 29.12.2013                                                    '
'Auteur		    : Oscar	                                                     	'
'Nom			: SerieDivers01                                                 '
'Description	: Formulaire principale qui appelle les autres formulaires      '
'--------------------------------------------------------------------------------

Public Class Form1

    Dim i As Integer

    'Lance la création des 500 petits formulaires "frmBase"
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim i As Integer

        For i = 1 To 500
            Dim f As New frmBase()
            f.Show()
        Next
        Me.Close()

    End Sub

End Class
