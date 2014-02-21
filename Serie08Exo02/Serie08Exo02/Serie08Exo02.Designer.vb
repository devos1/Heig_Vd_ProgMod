<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Serie08Exo02
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauFilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnEditFilm = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbListeFilms = New System.Windows.Forms.ListBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.gbDetail = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtDuree = New System.Windows.Forms.TextBox()
        Me.lblDuree = New System.Windows.Forms.Label()
        Me.txtRealisateur = New System.Windows.Forms.TextBox()
        Me.lblRealisateur = New System.Windows.Forms.Label()
        Me.txtTitre = New System.Windows.Forms.TextBox()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.gbDetail.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.EditionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(673, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'EditionToolStripMenuItem
        '
        Me.EditionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauFilmToolStripMenuItem, Me.mnEditFilm})
        Me.EditionToolStripMenuItem.Name = "EditionToolStripMenuItem"
        Me.EditionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.EditionToolStripMenuItem.Text = "Edition"
        '
        'NouveauFilmToolStripMenuItem
        '
        Me.NouveauFilmToolStripMenuItem.Name = "NouveauFilmToolStripMenuItem"
        Me.NouveauFilmToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NouveauFilmToolStripMenuItem.Text = "Nouveau film"
        '
        'mnEditFilm
        '
        Me.mnEditFilm.Name = "mnEditFilm"
        Me.mnEditFilm.Size = New System.Drawing.Size(152, 22)
        Me.mnEditFilm.Text = "Editer le film"
        '
        'lbListeFilms
        '
        Me.lbListeFilms.FormattingEnabled = True
        Me.lbListeFilms.Location = New System.Drawing.Point(12, 27)
        Me.lbListeFilms.Name = "lbListeFilms"
        Me.lbListeFilms.Size = New System.Drawing.Size(181, 420)
        Me.lbListeFilms.TabIndex = 1
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(6, 231)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(443, 181)
        Me.txtDescription.TabIndex = 8
        '
        'gbDetail
        '
        Me.gbDetail.Controls.Add(Me.PictureBox1)
        Me.gbDetail.Controls.Add(Me.txtDuree)
        Me.gbDetail.Controls.Add(Me.lblDuree)
        Me.gbDetail.Controls.Add(Me.txtRealisateur)
        Me.gbDetail.Controls.Add(Me.lblRealisateur)
        Me.gbDetail.Controls.Add(Me.txtTitre)
        Me.gbDetail.Controls.Add(Me.lblTitre)
        Me.gbDetail.Controls.Add(Me.txtDescription)
        Me.gbDetail.Location = New System.Drawing.Point(206, 29)
        Me.gbDetail.Name = "gbDetail"
        Me.gbDetail.Size = New System.Drawing.Size(455, 418)
        Me.gbDetail.TabIndex = 9
        Me.gbDetail.TabStop = False
        Me.gbDetail.Text = "Film sélectionné"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 187)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'txtDuree
        '
        Me.txtDuree.Location = New System.Drawing.Point(234, 145)
        Me.txtDuree.Name = "txtDuree"
        Me.txtDuree.Size = New System.Drawing.Size(215, 20)
        Me.txtDuree.TabIndex = 14
        '
        'lblDuree
        '
        Me.lblDuree.AutoSize = True
        Me.lblDuree.Location = New System.Drawing.Point(166, 148)
        Me.lblDuree.Name = "lblDuree"
        Me.lblDuree.Size = New System.Drawing.Size(36, 13)
        Me.lblDuree.TabIndex = 13
        Me.lblDuree.Text = "Durée"
        '
        'txtRealisateur
        '
        Me.txtRealisateur.Location = New System.Drawing.Point(234, 102)
        Me.txtRealisateur.Name = "txtRealisateur"
        Me.txtRealisateur.Size = New System.Drawing.Size(215, 20)
        Me.txtRealisateur.TabIndex = 12
        '
        'lblRealisateur
        '
        Me.lblRealisateur.AutoSize = True
        Me.lblRealisateur.Location = New System.Drawing.Point(166, 105)
        Me.lblRealisateur.Name = "lblRealisateur"
        Me.lblRealisateur.Size = New System.Drawing.Size(60, 13)
        Me.lblRealisateur.TabIndex = 11
        Me.lblRealisateur.Text = "Réalisateur"
        '
        'txtTitre
        '
        Me.txtTitre.Location = New System.Drawing.Point(234, 61)
        Me.txtTitre.Name = "txtTitre"
        Me.txtTitre.Size = New System.Drawing.Size(215, 20)
        Me.txtTitre.TabIndex = 10
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Location = New System.Drawing.Point(166, 64)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(28, 13)
        Me.lblTitre.TabIndex = 9
        Me.lblTitre.Text = "Titre"
        '
        'Serie08Exo02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 484)
        Me.Controls.Add(Me.lbListeFilms)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gbDetail)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Serie08Exo02"
        Me.Text = "Liste de films"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbDetail.ResumeLayout(False)
        Me.gbDetail.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauFilmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnEditFilm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbListeFilms As System.Windows.Forms.ListBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents gbDetail As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtDuree As System.Windows.Forms.TextBox
    Friend WithEvents lblDuree As System.Windows.Forms.Label
    Friend WithEvents txtRealisateur As System.Windows.Forms.TextBox
    Friend WithEvents lblRealisateur As System.Windows.Forms.Label
    Friend WithEvents txtTitre As System.Windows.Forms.TextBox
    Friend WithEvents lblTitre As System.Windows.Forms.Label

End Class
