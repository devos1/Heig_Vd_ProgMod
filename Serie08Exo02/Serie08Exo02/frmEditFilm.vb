'-------------------------------------------------------------------------------
'Date		    : 21.02.2014                                                    '
'Auteur		    : Oscar                                                         '
'Nom			: Serie08Exo02                                                  '
'Description	: Form "Edit film"                                              '
'--------------------------------------------------------------------------------
Public Class frmEditFilm

    'Cet attribut contient l'instance de la classe Film que l'on est en train d'éditer   
    Public film As Film

    'SUB WHEN FORM LOAD
    Private Sub frmEditFilm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Define dialogResul for 2 buttons
        btnOk.DialogResult = Windows.Forms.DialogResult.OK
        btnCancel.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    'SUB TO CLEAR FORM
    Private Sub clearForm()
        txtTitre.Clear()
        txtRealisateur.Clear()
        txtDuree.Clear()
        txtDescription.Clear()
        PictureBox1.BackgroundImage = Nothing
    End Sub

    Public Sub afficheFilm(ByVal f As Film)
        If Not f Is Nothing Then
            txtTitre.Text = f.titre
            txtRealisateur.Text = f.realisateur
            txtDuree.Text = f.duree
            txtDescription.Text = f.description
            PictureBox1.BackgroundImage = f.affiche
        Else
            clearForm()
        End If
    End Sub

    Public Function createFilm() As Film
        clearForm()
        If ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim f As Film = New Film()
            f.titre = txtTitre.Text
            f.realisateur = txtRealisateur.Text
            f.duree = Val(txtDuree.Text)
            f.affiche = PictureBox1.BackgroundImage
            f.description = txtDescription.Text
            Return f
        End If

        Return Nothing

    End Function

    Public Function editFilm(ByVal f As Film) As DialogResult
        ' cette fonction est utilisée pour éditer un film existant
        ' si le film passé en paramètre n'est pas null, alors on va modifier ce film.
        ' cette fonction retourne en résultat le code avec lequel on a quitté le formulaire modal
        ' si on quitte le formulaire avec OK, alors le film passé en paramètre est modifié
        ' si on quitte le formulaire avec CANCEL, alors le film en paramètre n'est pas modifié

        afficheFilm(f)

        Dim res As DialogResult = Me.ShowDialog()

        If res = Windows.Forms.DialogResult.OK Then
            f.titre = txtTitre.Text
            f.realisateur = txtRealisateur.Text
            f.duree = Val(txtDuree.Text)
            f.affiche = PictureBox1.BackgroundImage
            f.description = txtDescription.Text
        End If

        Return res

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ofdAffiche.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                PictureBox1.BackgroundImage = Image.FromFile(ofdAffiche.FileName)
            Catch
                MsgBox(" le fichier " & ofdAffiche.FileName & " n'est pas une image")
            End Try
        End If
    End Sub


End Class