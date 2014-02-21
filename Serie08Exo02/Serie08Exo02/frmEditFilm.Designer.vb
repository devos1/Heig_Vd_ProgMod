<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditFilm
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
        Me.txtDuree = New System.Windows.Forms.TextBox()
        Me.lblDuree = New System.Windows.Forms.Label()
        Me.txtRealisateur = New System.Windows.Forms.TextBox()
        Me.lblRealisateur = New System.Windows.Forms.Label()
        Me.txtTitre = New System.Windows.Forms.TextBox()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ofdAffiche = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDuree
        '
        Me.txtDuree.Location = New System.Drawing.Point(89, 130)
        Me.txtDuree.Name = "txtDuree"
        Me.txtDuree.Size = New System.Drawing.Size(215, 20)
        Me.txtDuree.TabIndex = 20
        '
        'lblDuree
        '
        Me.lblDuree.AutoSize = True
        Me.lblDuree.Location = New System.Drawing.Point(21, 133)
        Me.lblDuree.Name = "lblDuree"
        Me.lblDuree.Size = New System.Drawing.Size(36, 13)
        Me.lblDuree.TabIndex = 19
        Me.lblDuree.Text = "Durée"
        '
        'txtRealisateur
        '
        Me.txtRealisateur.Location = New System.Drawing.Point(89, 87)
        Me.txtRealisateur.Name = "txtRealisateur"
        Me.txtRealisateur.Size = New System.Drawing.Size(215, 20)
        Me.txtRealisateur.TabIndex = 18
        '
        'lblRealisateur
        '
        Me.lblRealisateur.AutoSize = True
        Me.lblRealisateur.Location = New System.Drawing.Point(21, 90)
        Me.lblRealisateur.Name = "lblRealisateur"
        Me.lblRealisateur.Size = New System.Drawing.Size(60, 13)
        Me.lblRealisateur.TabIndex = 17
        Me.lblRealisateur.Text = "Réalisateur"
        '
        'txtTitre
        '
        Me.txtTitre.Location = New System.Drawing.Point(89, 46)
        Me.txtTitre.Name = "txtTitre"
        Me.txtTitre.Size = New System.Drawing.Size(215, 20)
        Me.txtTitre.TabIndex = 16
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Location = New System.Drawing.Point(21, 49)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(28, 13)
        Me.lblTitre.TabIndex = 15
        Me.lblTitre.Text = "Titre"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(89, 172)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 187)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Affiche"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(314, 46)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(316, 313)
        Me.txtDescription.TabIndex = 23
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(474, 375)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 24
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(555, 375)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(314, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Choisir image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ofdAffiche
        '
        Me.ofdAffiche.FileName = "OpenFileDialog1"
        '
        'frmEditFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 410)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtDuree)
        Me.Controls.Add(Me.lblDuree)
        Me.Controls.Add(Me.txtRealisateur)
        Me.Controls.Add(Me.lblRealisateur)
        Me.Controls.Add(Me.txtTitre)
        Me.Controls.Add(Me.lblTitre)
        Me.Name = "frmEditFilm"
        Me.Text = "frmEditFilm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDuree As System.Windows.Forms.TextBox
    Friend WithEvents lblDuree As System.Windows.Forms.Label
    Friend WithEvents txtRealisateur As System.Windows.Forms.TextBox
    Friend WithEvents lblRealisateur As System.Windows.Forms.Label
    Friend WithEvents txtTitre As System.Windows.Forms.TextBox
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ofdAffiche As System.Windows.Forms.OpenFileDialog
End Class
