<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColorChooser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblRouge = New System.Windows.Forms.Label()
        Me.lblVert = New System.Windows.Forms.Label()
        Me.lblBleu = New System.Windows.Forms.Label()
        Me.vsbRed = New System.Windows.Forms.VScrollBar()
        Me.vsbGreen = New System.Windows.Forms.VScrollBar()
        Me.vsbBlue = New System.Windows.Forms.VScrollBar()
        Me.lblRvalue = New System.Windows.Forms.Label()
        Me.lblVvalue = New System.Windows.Forms.Label()
        Me.lblBvalue = New System.Windows.Forms.Label()
        Me.picColor = New System.Windows.Forms.PictureBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        CType(Me.picColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRouge
        '
        Me.lblRouge.AutoSize = True
        Me.lblRouge.Location = New System.Drawing.Point(25, 9)
        Me.lblRouge.Name = "lblRouge"
        Me.lblRouge.Size = New System.Drawing.Size(39, 13)
        Me.lblRouge.TabIndex = 0
        Me.lblRouge.Text = "Rouge"
        '
        'lblVert
        '
        Me.lblVert.AutoSize = True
        Me.lblVert.Location = New System.Drawing.Point(73, 9)
        Me.lblVert.Name = "lblVert"
        Me.lblVert.Size = New System.Drawing.Size(26, 13)
        Me.lblVert.TabIndex = 1
        Me.lblVert.Text = "Vert"
        '
        'lblBleu
        '
        Me.lblBleu.AutoSize = True
        Me.lblBleu.Location = New System.Drawing.Point(112, 9)
        Me.lblBleu.Name = "lblBleu"
        Me.lblBleu.Size = New System.Drawing.Size(28, 13)
        Me.lblBleu.TabIndex = 2
        Me.lblBleu.Text = "Bleu"
        '
        'vsbRed
        '
        Me.vsbRed.LargeChange = 1
        Me.vsbRed.Location = New System.Drawing.Point(32, 31)
        Me.vsbRed.Maximum = 255
        Me.vsbRed.Name = "vsbRed"
        Me.vsbRed.Size = New System.Drawing.Size(19, 184)
        Me.vsbRed.TabIndex = 3
        '
        'vsbGreen
        '
        Me.vsbGreen.LargeChange = 1
        Me.vsbGreen.Location = New System.Drawing.Point(74, 31)
        Me.vsbGreen.Maximum = 255
        Me.vsbGreen.Name = "vsbGreen"
        Me.vsbGreen.Size = New System.Drawing.Size(19, 184)
        Me.vsbGreen.TabIndex = 4
        '
        'vsbBlue
        '
        Me.vsbBlue.LargeChange = 1
        Me.vsbBlue.Location = New System.Drawing.Point(116, 31)
        Me.vsbBlue.Maximum = 255
        Me.vsbBlue.Name = "vsbBlue"
        Me.vsbBlue.Size = New System.Drawing.Size(19, 184)
        Me.vsbBlue.TabIndex = 5
        '
        'lblRvalue
        '
        Me.lblRvalue.AutoSize = True
        Me.lblRvalue.Location = New System.Drawing.Point(23, 224)
        Me.lblRvalue.Name = "lblRvalue"
        Me.lblRvalue.Size = New System.Drawing.Size(10, 13)
        Me.lblRvalue.TabIndex = 6
        Me.lblRvalue.Text = "-"
        '
        'lblVvalue
        '
        Me.lblVvalue.AutoSize = True
        Me.lblVvalue.Location = New System.Drawing.Point(68, 224)
        Me.lblVvalue.Name = "lblVvalue"
        Me.lblVvalue.Size = New System.Drawing.Size(10, 13)
        Me.lblVvalue.TabIndex = 7
        Me.lblVvalue.Text = "-"
        '
        'lblBvalue
        '
        Me.lblBvalue.AutoSize = True
        Me.lblBvalue.Location = New System.Drawing.Point(113, 224)
        Me.lblBvalue.Name = "lblBvalue"
        Me.lblBvalue.Size = New System.Drawing.Size(10, 13)
        Me.lblBvalue.TabIndex = 8
        Me.lblBvalue.Text = "-"
        '
        'picColor
        '
        Me.picColor.Location = New System.Drawing.Point(154, 31)
        Me.picColor.Name = "picColor"
        Me.picColor.Size = New System.Drawing.Size(186, 184)
        Me.picColor.TabIndex = 9
        Me.picColor.TabStop = False
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(175, 248)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 10
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnuler.Location = New System.Drawing.Point(265, 248)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 11
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 283)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.picColor)
        Me.Controls.Add(Me.lblBvalue)
        Me.Controls.Add(Me.lblVvalue)
        Me.Controls.Add(Me.lblRvalue)
        Me.Controls.Add(Me.vsbBlue)
        Me.Controls.Add(Me.vsbGreen)
        Me.Controls.Add(Me.vsbRed)
        Me.Controls.Add(Me.lblBleu)
        Me.Controls.Add(Me.lblVert)
        Me.Controls.Add(Me.lblRouge)
        Me.Name = "Form1"
        Me.Text = "Color chooser"
        CType(Me.picColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRouge As System.Windows.Forms.Label
    Friend WithEvents lblVert As System.Windows.Forms.Label
    Friend WithEvents lblBleu As System.Windows.Forms.Label
    Friend WithEvents vsbRed As System.Windows.Forms.VScrollBar
    Friend WithEvents vsbGreen As System.Windows.Forms.VScrollBar
    Friend WithEvents vsbBlue As System.Windows.Forms.VScrollBar
    Friend WithEvents lblRvalue As System.Windows.Forms.Label
    Friend WithEvents lblVvalue As System.Windows.Forms.Label
    Friend WithEvents lblBvalue As System.Windows.Forms.Label
    Friend WithEvents picColor As System.Windows.Forms.PictureBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button

End Class
