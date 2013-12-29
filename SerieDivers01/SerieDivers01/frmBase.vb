'-------------------------------------------------------------------------------
'Date		    : 29.12.2013                                                    '
'Auteur		    : Oscar	                                                     	'
'Nom			: SerieDivers01                                                 '
'Description	: Calsse du formulaire qui sera créé plusieurs fois             '
'--------------------------------------------------------------------------------
Public Class frmBase

    Private Sub frmBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim r As New Random()

        'Paramètres du timer
        tmrClose.Interval = r.Next(1, 10000)
        tmrClose.Enabled = True

        'Personnalisation du Form
        Me.Size = New Size(20, 20)
        'Me.Location = New Point(r.Next(0, Screen.PrimaryScreen.Bounds.Width), r.Next(0, Screen.PrimaryScreen.Bounds.Height))
        Me.SetDesktopLocation(r.Next(0, Screen.PrimaryScreen.Bounds.Width), r.Next(0, Screen.PrimaryScreen.Bounds.Height))
        Me.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255))
        'Me.Opacity = r.Next(0, 100) / 100


    End Sub

    'Procédure pour fermer les Forms en fonction de la tempo
    Private Sub gestionTimer() Handles tmrClose.Tick
        Me.Close()
    End Sub

End Class