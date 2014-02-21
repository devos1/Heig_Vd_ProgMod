Public Class Serie08Exo02

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Application.Exit()
    End Sub

  
    Private Sub Serie08Exo02_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbListeFilms.Sorted = True
        mnEditFilm.Enabled = False
    End Sub

    Private Sub NouveauFilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauFilmToolStripMenuItem.Click
        ' une solution est de récupérer le contenu des controles du formulaire modal
        ' et de créer une instance de la classe Film avec ces données
        ' puis d'ajouter cette nouvelle instance dans le listbox

        'If frmEditFilm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    Dim f As Film = New Film()
        '    f.titre = frmEditFilm.txtTitre.Text
        '    f.realisateur = frmEditFilm.txtReal.Text
        '    f.affiche = frmEditFilm.picAffiche.BackgroundImage
        '    f.description = frmEditFilm.txtDescription.Text
        '    f.duree = Val(frmEditFilm.txtDuree.Text)
        '    lbFilms.Items.Add(f)
        'End If

        ' une autre solution est d'utiliser une propriété publique du formulaire modal
        'frmEditFilm.film = New Film()
        'frmEditFilm.afficheFilm(Nothing)
        'If frmEditFilm.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    lbFilms.Items.Add(frmEditFilm.film)
        'End If

        ' uen autre solution est d'utiliser une méthode publique qui retourne le film créé
        Dim f = frmEditFilm.createFilm()
        If Not f Is Nothing Then
            lbListeFilms.Items.Add(f)
        End If

    End Sub

    Private Sub displayFilm(ByVal f As Film)
        If (Not f Is Nothing) Then
            txtTitre.Text = f.titre
            txtRealisateur.Text = f.realisateur
            txtDuree.Text = f.duree
            txtDescription.Text = f.description
            PictureBox1.BackgroundImage = f.affiche
        End If
    End Sub


    Private Sub lbListeFilms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbListeFilms.SelectedIndexChanged
        displayFilm(lbListeFilms.SelectedItem)
        mnEditFilm.Enabled = Not (lbListeFilms.SelectedItem Is Nothing)
    End Sub


    Private Sub mnEditFilm_Click(sender As Object, e As EventArgs) Handles mnEditFilm.Click
        ' solution en utilisant la propriete publique film
        'Dim f As Film = lbFilms.SelectedItem
        'frmEditFilm.film = f
        'frmEditFilm.afficheFilm(f)
        'If frmEditFilm.ShowDialog() = Windows.Forms.DialogResult.OK Then             
        '    lbFilms.Items.Remove(f)            
        '    lbFilms.Items.Add(f)
        '    lbFilms.SelectedItem = f
        'End If

        Dim f As Film = lbListeFilms.SelectedItem
        frmEditFilm.editFilm(f)
        lbListeFilms.Items.Remove(f)
        lbListeFilms.Items.Add(f)
        lbListeFilms.SelectedItem = f
    End Sub

End Class
