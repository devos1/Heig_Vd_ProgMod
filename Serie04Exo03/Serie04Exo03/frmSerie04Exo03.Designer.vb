<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSerie04Exo03
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
        Me.txtNb1 = New System.Windows.Forms.TextBox()
        Me.txtNb2 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.lblOp = New System.Windows.Forms.Label()
        Me.lblEqual = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbOp = New System.Windows.Forms.GroupBox()
        Me.rbMultiplication = New System.Windows.Forms.RadioButton()
        Me.rbSoustraction = New System.Windows.Forms.RadioButton()
        Me.rbAddition = New System.Windows.Forms.RadioButton()
        Me.cbOp = New System.Windows.Forms.CheckBox()
        Me.cbEval = New System.Windows.Forms.CheckBox()
        Me.gbEval = New System.Windows.Forms.GroupBox()
        Me.lblMauvaisesRep = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblBonnesRep = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOp.SuspendLayout()
        Me.gbEval.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNb1
        '
        Me.txtNb1.Location = New System.Drawing.Point(18, 27)
        Me.txtNb1.Multiline = True
        Me.txtNb1.Name = "txtNb1"
        Me.txtNb1.Size = New System.Drawing.Size(68, 34)
        Me.txtNb1.TabIndex = 0
        '
        'txtNb2
        '
        Me.txtNb2.Location = New System.Drawing.Point(148, 27)
        Me.txtNb2.Multiline = True
        Me.txtNb2.Name = "txtNb2"
        Me.txtNb2.Size = New System.Drawing.Size(68, 34)
        Me.txtNb2.TabIndex = 1
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(279, 27)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(68, 34)
        Me.txtResult.TabIndex = 2
        '
        'lblOp
        '
        Me.lblOp.AutoSize = True
        Me.lblOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOp.Location = New System.Drawing.Point(105, 32)
        Me.lblOp.Name = "lblOp"
        Me.lblOp.Size = New System.Drawing.Size(0, 26)
        Me.lblOp.TabIndex = 6
        '
        'lblEqual
        '
        Me.lblEqual.AutoSize = True
        Me.lblEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEqual.Location = New System.Drawing.Point(235, 32)
        Me.lblEqual.Name = "lblEqual"
        Me.lblEqual.Size = New System.Drawing.Size(26, 26)
        Me.lblEqual.TabIndex = 4
        Me.lblEqual.Text = "="
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(366, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(414, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Vérifier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "réponse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gbOp
        '
        Me.gbOp.Controls.Add(Me.rbMultiplication)
        Me.gbOp.Controls.Add(Me.rbSoustraction)
        Me.gbOp.Controls.Add(Me.rbAddition)
        Me.gbOp.Location = New System.Drawing.Point(18, 142)
        Me.gbOp.Name = "gbOp"
        Me.gbOp.Size = New System.Drawing.Size(135, 131)
        Me.gbOp.TabIndex = 7
        Me.gbOp.TabStop = False
        Me.gbOp.Text = "Opérations"
        '
        'rbMultiplication
        '
        Me.rbMultiplication.AutoSize = True
        Me.rbMultiplication.Location = New System.Drawing.Point(7, 80)
        Me.rbMultiplication.Name = "rbMultiplication"
        Me.rbMultiplication.Size = New System.Drawing.Size(86, 17)
        Me.rbMultiplication.TabIndex = 2
        Me.rbMultiplication.TabStop = True
        Me.rbMultiplication.Text = "Multiplication"
        Me.rbMultiplication.UseVisualStyleBackColor = True
        '
        'rbSoustraction
        '
        Me.rbSoustraction.AutoSize = True
        Me.rbSoustraction.Location = New System.Drawing.Point(7, 57)
        Me.rbSoustraction.Name = "rbSoustraction"
        Me.rbSoustraction.Size = New System.Drawing.Size(84, 17)
        Me.rbSoustraction.TabIndex = 1
        Me.rbSoustraction.TabStop = True
        Me.rbSoustraction.Text = "Soustraction"
        Me.rbSoustraction.UseVisualStyleBackColor = True
        '
        'rbAddition
        '
        Me.rbAddition.AutoSize = True
        Me.rbAddition.Location = New System.Drawing.Point(7, 34)
        Me.rbAddition.Name = "rbAddition"
        Me.rbAddition.Size = New System.Drawing.Size(63, 17)
        Me.rbAddition.TabIndex = 0
        Me.rbAddition.TabStop = True
        Me.rbAddition.Text = "Addition"
        Me.rbAddition.UseVisualStyleBackColor = True
        '
        'cbOp
        '
        Me.cbOp.AutoSize = True
        Me.cbOp.Location = New System.Drawing.Point(26, 110)
        Me.cbOp.Name = "cbOp"
        Me.cbOp.Size = New System.Drawing.Size(77, 17)
        Me.cbOp.TabIndex = 8
        Me.cbOp.Text = "Opérations"
        Me.cbOp.UseVisualStyleBackColor = True
        '
        'cbEval
        '
        Me.cbEval.AutoSize = True
        Me.cbEval.Location = New System.Drawing.Point(184, 110)
        Me.cbEval.Name = "cbEval"
        Me.cbEval.Size = New System.Drawing.Size(76, 17)
        Me.cbEval.TabIndex = 9
        Me.cbEval.Text = "Evaluation"
        Me.cbEval.UseVisualStyleBackColor = True
        '
        'gbEval
        '
        Me.gbEval.Controls.Add(Me.lblMauvaisesRep)
        Me.gbEval.Controls.Add(Me.Label3)
        Me.gbEval.Controls.Add(Me.lblBonnesRep)
        Me.gbEval.Controls.Add(Me.Label1)
        Me.gbEval.Location = New System.Drawing.Point(184, 142)
        Me.gbEval.Name = "gbEval"
        Me.gbEval.Size = New System.Drawing.Size(218, 131)
        Me.gbEval.TabIndex = 10
        Me.gbEval.TabStop = False
        Me.gbEval.Text = "Evaluation"
        '
        'lblMauvaisesRep
        '
        Me.lblMauvaisesRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMauvaisesRep.Location = New System.Drawing.Point(9, 96)
        Me.lblMauvaisesRep.Name = "lblMauvaisesRep"
        Me.lblMauvaisesRep.Size = New System.Drawing.Size(146, 25)
        Me.lblMauvaisesRep.TabIndex = 3
        Me.lblMauvaisesRep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre de mauvaises réponses:"
        '
        'lblBonnesRep
        '
        Me.lblBonnesRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBonnesRep.Location = New System.Drawing.Point(9, 44)
        Me.lblBonnesRep.Name = "lblBonnesRep"
        Me.lblBonnesRep.Size = New System.Drawing.Size(146, 23)
        Me.lblBonnesRep.TabIndex = 1
        Me.lblBonnesRep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de bonnes réponses:"
        '
        'frmSerie04Exo03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 285)
        Me.Controls.Add(Me.gbEval)
        Me.Controls.Add(Me.cbEval)
        Me.Controls.Add(Me.cbOp)
        Me.Controls.Add(Me.gbOp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblEqual)
        Me.Controls.Add(Me.lblOp)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtNb2)
        Me.Controls.Add(Me.txtNb1)
        Me.Name = "frmSerie04Exo03"
        Me.Text = "Serie04Exo03"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOp.ResumeLayout(False)
        Me.gbOp.PerformLayout()
        Me.gbEval.ResumeLayout(False)
        Me.gbEval.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNb1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNb2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents lblOp As System.Windows.Forms.Label
    Friend WithEvents lblEqual As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gbOp As System.Windows.Forms.GroupBox
    Friend WithEvents rbMultiplication As System.Windows.Forms.RadioButton
    Friend WithEvents rbSoustraction As System.Windows.Forms.RadioButton
    Friend WithEvents rbAddition As System.Windows.Forms.RadioButton
    Friend WithEvents cbOp As System.Windows.Forms.CheckBox
    Friend WithEvents cbEval As System.Windows.Forms.CheckBox
    Friend WithEvents gbEval As System.Windows.Forms.GroupBox
    Friend WithEvents lblMauvaisesRep As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblBonnesRep As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
