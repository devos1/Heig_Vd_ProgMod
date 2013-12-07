<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.picImgContact = New System.Windows.Forms.PictureBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.btnPremier = New System.Windows.Forms.Button()
        Me.btnPrecedent = New System.Windows.Forms.Button()
        Me.btnSuivant = New System.Windows.Forms.Button()
        Me.btnDernier = New System.Windows.Forms.Button()
        CType(Me.picImgContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picImgContact
        '
        Me.picImgContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImgContact.Location = New System.Drawing.Point(12, 12)
        Me.picImgContact.Name = "picImgContact"
        Me.picImgContact.Size = New System.Drawing.Size(132, 162)
        Me.picImgContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picImgContact.TabIndex = 0
        Me.picImgContact.TabStop = False
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(233, 31)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(164, 20)
        Me.txtNom.TabIndex = 1
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(177, 34)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(29, 13)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nom"
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(177, 71)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(43, 13)
        Me.lblPrenom.TabIndex = 4
        Me.lblPrenom.Text = "Prénom"
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(233, 68)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(164, 20)
        Me.txtPrenom.TabIndex = 3
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(177, 109)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(26, 13)
        Me.lblAge.TabIndex = 6
        Me.lblAge.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(233, 106)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(164, 20)
        Me.txtAge.TabIndex = 5
        '
        'btnPremier
        '
        Me.btnPremier.Location = New System.Drawing.Point(28, 212)
        Me.btnPremier.Name = "btnPremier"
        Me.btnPremier.Size = New System.Drawing.Size(97, 23)
        Me.btnPremier.TabIndex = 7
        Me.btnPremier.Text = "Premier"
        Me.btnPremier.UseVisualStyleBackColor = True
        '
        'btnPrecedent
        '
        Me.btnPrecedent.Location = New System.Drawing.Point(149, 212)
        Me.btnPrecedent.Name = "btnPrecedent"
        Me.btnPrecedent.Size = New System.Drawing.Size(97, 23)
        Me.btnPrecedent.TabIndex = 8
        Me.btnPrecedent.Text = "Précédent"
        Me.btnPrecedent.UseVisualStyleBackColor = True
        '
        'btnSuivant
        '
        Me.btnSuivant.Location = New System.Drawing.Point(270, 212)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(97, 23)
        Me.btnSuivant.TabIndex = 9
        Me.btnSuivant.Text = "Suivant"
        Me.btnSuivant.UseVisualStyleBackColor = True
        '
        'btnDernier
        '
        Me.btnDernier.Location = New System.Drawing.Point(391, 212)
        Me.btnDernier.Name = "btnDernier"
        Me.btnDernier.Size = New System.Drawing.Size(97, 23)
        Me.btnDernier.TabIndex = 10
        Me.btnDernier.Text = "Dernier"
        Me.btnDernier.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 265)
        Me.Controls.Add(Me.btnDernier)
        Me.Controls.Add(Me.btnSuivant)
        Me.Controls.Add(Me.btnPrecedent)
        Me.Controls.Add(Me.btnPremier)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.picImgContact)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picImgContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picImgContact As System.Windows.Forms.PictureBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblPrenom As System.Windows.Forms.Label
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents btnPremier As System.Windows.Forms.Button
    Friend WithEvents btnPrecedent As System.Windows.Forms.Button
    Friend WithEvents btnSuivant As System.Windows.Forms.Button
    Friend WithEvents btnDernier As System.Windows.Forms.Button

End Class
