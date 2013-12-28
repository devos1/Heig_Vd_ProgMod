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
        Me.txtContenu = New System.Windows.Forms.TextBox()
        Me.btnPremier = New System.Windows.Forms.Button()
        Me.btnPrecedent = New System.Windows.Forms.Button()
        Me.btnSuivant = New System.Windows.Forms.Button()
        Me.btnDernier = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtContenu
        '
        Me.txtContenu.Location = New System.Drawing.Point(12, 12)
        Me.txtContenu.Multiline = True
        Me.txtContenu.Name = "txtContenu"
        Me.txtContenu.Size = New System.Drawing.Size(505, 44)
        Me.txtContenu.TabIndex = 0
        '
        'btnPremier
        '
        Me.btnPremier.Location = New System.Drawing.Point(12, 79)
        Me.btnPremier.Name = "btnPremier"
        Me.btnPremier.Size = New System.Drawing.Size(104, 42)
        Me.btnPremier.TabIndex = 1
        Me.btnPremier.Text = "&First"
        Me.btnPremier.UseVisualStyleBackColor = True
        '
        'btnPrecedent
        '
        Me.btnPrecedent.Location = New System.Drawing.Point(145, 79)
        Me.btnPrecedent.Name = "btnPrecedent"
        Me.btnPrecedent.Size = New System.Drawing.Size(104, 42)
        Me.btnPrecedent.TabIndex = 2
        Me.btnPrecedent.Text = "&Previous"
        Me.btnPrecedent.UseVisualStyleBackColor = True
        '
        'btnSuivant
        '
        Me.btnSuivant.Location = New System.Drawing.Point(278, 79)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(104, 42)
        Me.btnSuivant.TabIndex = 3
        Me.btnSuivant.Text = "&Next"
        Me.btnSuivant.UseVisualStyleBackColor = True
        '
        'btnDernier
        '
        Me.btnDernier.Location = New System.Drawing.Point(411, 79)
        Me.btnDernier.Name = "btnDernier"
        Me.btnDernier.Size = New System.Drawing.Size(104, 42)
        Me.btnDernier.TabIndex = 4
        Me.btnDernier.Text = "&Last"
        Me.btnDernier.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 145)
        Me.Controls.Add(Me.btnDernier)
        Me.Controls.Add(Me.btnSuivant)
        Me.Controls.Add(Me.btnPrecedent)
        Me.Controls.Add(Me.btnPremier)
        Me.Controls.Add(Me.txtContenu)
        Me.Name = "Form1"
        Me.Text = "Parcours d'un tableau statique"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContenu As System.Windows.Forms.TextBox
    Friend WithEvents btnPremier As System.Windows.Forms.Button
    Friend WithEvents btnPrecedent As System.Windows.Forms.Button
    Friend WithEvents btnSuivant As System.Windows.Forms.Button
    Friend WithEvents btnDernier As System.Windows.Forms.Button

End Class
