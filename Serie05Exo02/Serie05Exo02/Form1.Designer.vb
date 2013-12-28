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
        Me.txtElement = New System.Windows.Forms.TextBox()
        Me.btnPremier = New System.Windows.Forms.Button()
        Me.btnPrecedent = New System.Windows.Forms.Button()
        Me.btnSuivant = New System.Windows.Forms.Button()
        Me.btnDernier = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.txtInsert = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtElement
        '
        Me.txtElement.Location = New System.Drawing.Point(13, 24)
        Me.txtElement.Multiline = True
        Me.txtElement.Name = "txtElement"
        Me.txtElement.Size = New System.Drawing.Size(380, 44)
        Me.txtElement.TabIndex = 0
        '
        'btnPremier
        '
        Me.btnPremier.Location = New System.Drawing.Point(13, 90)
        Me.btnPremier.Name = "btnPremier"
        Me.btnPremier.Size = New System.Drawing.Size(86, 45)
        Me.btnPremier.TabIndex = 1
        Me.btnPremier.Text = "Premier"
        Me.btnPremier.UseVisualStyleBackColor = True
        '
        'btnPrecedent
        '
        Me.btnPrecedent.Location = New System.Drawing.Point(111, 90)
        Me.btnPrecedent.Name = "btnPrecedent"
        Me.btnPrecedent.Size = New System.Drawing.Size(86, 45)
        Me.btnPrecedent.TabIndex = 2
        Me.btnPrecedent.Text = "Précédent"
        Me.btnPrecedent.UseVisualStyleBackColor = True
        '
        'btnSuivant
        '
        Me.btnSuivant.Location = New System.Drawing.Point(209, 90)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(86, 45)
        Me.btnSuivant.TabIndex = 3
        Me.btnSuivant.Text = "Suivant"
        Me.btnSuivant.UseVisualStyleBackColor = True
        '
        'btnDernier
        '
        Me.btnDernier.Location = New System.Drawing.Point(307, 90)
        Me.btnDernier.Name = "btnDernier"
        Me.btnDernier.Size = New System.Drawing.Size(86, 45)
        Me.btnDernier.TabIndex = 4
        Me.btnDernier.Text = "Dernier"
        Me.btnDernier.UseVisualStyleBackColor = True
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(13, 165)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(131, 56)
        Me.btnAjouter.TabIndex = 5
        Me.btnAjouter.Text = "Ajouter élément"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'txtInsert
        '
        Me.txtInsert.Location = New System.Drawing.Point(150, 165)
        Me.txtInsert.Multiline = True
        Me.txtInsert.Name = "txtInsert"
        Me.txtInsert.Size = New System.Drawing.Size(243, 56)
        Me.txtInsert.TabIndex = 6
        Me.txtInsert.Text = " "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 262)
        Me.Controls.Add(Me.txtInsert)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.btnDernier)
        Me.Controls.Add(Me.btnSuivant)
        Me.Controls.Add(Me.btnPrecedent)
        Me.Controls.Add(Me.btnPremier)
        Me.Controls.Add(Me.txtElement)
        Me.Name = "Form1"
        Me.Text = "Parcours d'un tableau dynamique"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtElement As System.Windows.Forms.TextBox
    Friend WithEvents btnPremier As System.Windows.Forms.Button
    Friend WithEvents btnPrecedent As System.Windows.Forms.Button
    Friend WithEvents btnSuivant As System.Windows.Forms.Button
    Friend WithEvents btnDernier As System.Windows.Forms.Button
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents txtInsert As System.Windows.Forms.TextBox

End Class
