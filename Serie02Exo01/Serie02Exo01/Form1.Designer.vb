<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodePostale = New System.Windows.Forms.TextBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblCodePostale = New System.Windows.Forms.Label()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtPrixUnit = New System.Windows.Forms.TextBox()
        Me.txtNbPatinsCommand = New System.Windows.Forms.TextBox()
        Me.txtPatinsJaCommand = New System.Windows.Forms.TextBox()
        Me.txtPatinsBlCommand = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPrixUnit = New System.Windows.Forms.Label()
        Me.lblNbPatinsCommand = New System.Windows.Forms.Label()
        Me.lblPatinsJaCommand = New System.Windows.Forms.Label()
        Me.lblPatinsBlCommand = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.btnImprimer = New System.Windows.Forms.Button()
        Me.btnCalculer = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtCodePostale)
        Me.GroupBox1.Controls.Add(Me.txtVille)
        Me.GroupBox1.Controls.Add(Me.txtAdresse)
        Me.GroupBox1.Controls.Add(Me.txtPrenom)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.lblCodePostale)
        Me.GroupBox1.Controls.Add(Me.lblVille)
        Me.GroupBox1.Controls.Add(Me.lblAdresse)
        Me.GroupBox1.Controls.Add(Me.lblPrenom)
        Me.GroupBox1.Controls.Add(Me.lblNom)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 253)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Données du client"
        '
        'txtCodePostale
        '
        Me.txtCodePostale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodePostale.Location = New System.Drawing.Point(105, 163)
        Me.txtCodePostale.MaxLength = 4
        Me.txtCodePostale.Name = "txtCodePostale"
        Me.txtCodePostale.Size = New System.Drawing.Size(170, 20)
        Me.txtCodePostale.TabIndex = 9
        '
        'txtVille
        '
        Me.txtVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVille.Location = New System.Drawing.Point(105, 130)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(170, 20)
        Me.txtVille.TabIndex = 7
        '
        'txtAdresse
        '
        Me.txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdresse.Location = New System.Drawing.Point(105, 99)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(170, 20)
        Me.txtAdresse.TabIndex = 5
        '
        'txtPrenom
        '
        Me.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrenom.Location = New System.Drawing.Point(105, 66)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(170, 20)
        Me.txtPrenom.TabIndex = 3
        '
        'txtNom
        '
        Me.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNom.Location = New System.Drawing.Point(105, 35)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(170, 20)
        Me.txtNom.TabIndex = 1
        '
        'lblCodePostale
        '
        Me.lblCodePostale.AutoSize = True
        Me.lblCodePostale.Location = New System.Drawing.Point(16, 166)
        Me.lblCodePostale.Name = "lblCodePostale"
        Me.lblCodePostale.Size = New System.Drawing.Size(69, 13)
        Me.lblCodePostale.TabIndex = 8
        Me.lblCodePostale.Text = "&Code postale"
        '
        'lblVille
        '
        Me.lblVille.AutoSize = True
        Me.lblVille.Location = New System.Drawing.Point(16, 133)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(26, 13)
        Me.lblVille.TabIndex = 6
        Me.lblVille.Text = "&Ville"
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Location = New System.Drawing.Point(16, 102)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(45, 13)
        Me.lblAdresse.TabIndex = 4
        Me.lblAdresse.Text = "&Adresse"
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Location = New System.Drawing.Point(16, 68)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(43, 13)
        Me.lblPrenom.TabIndex = 2
        Me.lblPrenom.Text = "&Prénom"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(16, 38)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(29, 13)
        Me.lblNom.TabIndex = 0
        Me.lblNom.Text = "&Nom"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtPrixUnit)
        Me.GroupBox2.Controls.Add(Me.txtNbPatinsCommand)
        Me.GroupBox2.Controls.Add(Me.txtPatinsJaCommand)
        Me.GroupBox2.Controls.Add(Me.txtPatinsBlCommand)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblPrixUnit)
        Me.GroupBox2.Controls.Add(Me.lblNbPatinsCommand)
        Me.GroupBox2.Controls.Add(Me.lblPatinsJaCommand)
        Me.GroupBox2.Controls.Add(Me.lblPatinsBlCommand)
        Me.GroupBox2.Location = New System.Drawing.Point(336, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(290, 253)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Données du client"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(190, 163)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(84, 20)
        Me.txtTotal.TabIndex = 19
        Me.txtTotal.TabStop = False
        '
        'txtPrixUnit
        '
        Me.txtPrixUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrixUnit.Location = New System.Drawing.Point(190, 130)
        Me.txtPrixUnit.Name = "txtPrixUnit"
        Me.txtPrixUnit.Size = New System.Drawing.Size(84, 20)
        Me.txtPrixUnit.TabIndex = 17
        '
        'txtNbPatinsCommand
        '
        Me.txtNbPatinsCommand.Location = New System.Drawing.Point(190, 99)
        Me.txtNbPatinsCommand.Name = "txtNbPatinsCommand"
        Me.txtNbPatinsCommand.ReadOnly = True
        Me.txtNbPatinsCommand.Size = New System.Drawing.Size(84, 20)
        Me.txtNbPatinsCommand.TabIndex = 15
        Me.txtNbPatinsCommand.TabStop = False
        '
        'txtPatinsJaCommand
        '
        Me.txtPatinsJaCommand.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPatinsJaCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatinsJaCommand.Location = New System.Drawing.Point(190, 66)
        Me.txtPatinsJaCommand.Name = "txtPatinsJaCommand"
        Me.txtPatinsJaCommand.Size = New System.Drawing.Size(84, 20)
        Me.txtPatinsJaCommand.TabIndex = 13
        '
        'txtPatinsBlCommand
        '
        Me.txtPatinsBlCommand.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPatinsBlCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatinsBlCommand.Location = New System.Drawing.Point(190, 35)
        Me.txtPatinsBlCommand.Name = "txtPatinsBlCommand"
        Me.txtPatinsBlCommand.Size = New System.Drawing.Size(84, 20)
        Me.txtPatinsBlCommand.TabIndex = 11
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(17, 166)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "&Total"
        '
        'lblPrixUnit
        '
        Me.lblPrixUnit.AutoSize = True
        Me.lblPrixUnit.Location = New System.Drawing.Point(17, 133)
        Me.lblPrixUnit.Name = "lblPrixUnit"
        Me.lblPrixUnit.Size = New System.Drawing.Size(61, 13)
        Me.lblPrixUnit.TabIndex = 16
        Me.lblPrixUnit.Text = "&Prix unitaire"
        '
        'lblNbPatinsCommand
        '
        Me.lblNbPatinsCommand.AutoSize = True
        Me.lblNbPatinsCommand.Location = New System.Drawing.Point(17, 102)
        Me.lblNbPatinsCommand.Name = "lblNbPatinsCommand"
        Me.lblNbPatinsCommand.Size = New System.Drawing.Size(127, 13)
        Me.lblNbPatinsCommand.TabIndex = 14
        Me.lblNbPatinsCommand.Text = "&Nb de patins commandés"
        '
        'lblPatinsJaCommand
        '
        Me.lblPatinsJaCommand.AutoSize = True
        Me.lblPatinsJaCommand.Location = New System.Drawing.Point(17, 68)
        Me.lblPatinsJaCommand.Name = "lblPatinsJaCommand"
        Me.lblPatinsJaCommand.Size = New System.Drawing.Size(161, 13)
        Me.lblPatinsJaCommand.TabIndex = 12
        Me.lblPatinsJaCommand.Text = "&Nb de patins jaunes commandés"
        '
        'lblPatinsBlCommand
        '
        Me.lblPatinsBlCommand.AutoSize = True
        Me.lblPatinsBlCommand.Location = New System.Drawing.Point(17, 38)
        Me.lblPatinsBlCommand.Name = "lblPatinsBlCommand"
        Me.lblPatinsBlCommand.Size = New System.Drawing.Size(155, 13)
        Me.lblPatinsBlCommand.TabIndex = 10
        Me.lblPatinsBlCommand.Text = "&Nb de patins bleus commandés"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnQuitter)
        Me.GroupBox3.Controls.Add(Me.btnEffacer)
        Me.GroupBox3.Controls.Add(Me.btnImprimer)
        Me.GroupBox3.Controls.Add(Me.btnCalculer)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 295)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(600, 78)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(487, 24)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(93, 35)
        Me.btnQuitter.TabIndex = 23
        Me.btnQuitter.TabStop = False
        Me.btnQuitter.Text = "&Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'btnEffacer
        '
        Me.btnEffacer.Location = New System.Drawing.Point(330, 24)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(93, 35)
        Me.btnEffacer.TabIndex = 22
        Me.btnEffacer.Text = "&Effacer"
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'btnImprimer
        '
        Me.btnImprimer.Location = New System.Drawing.Point(173, 24)
        Me.btnImprimer.Name = "btnImprimer"
        Me.btnImprimer.Size = New System.Drawing.Size(93, 35)
        Me.btnImprimer.TabIndex = 21
        Me.btnImprimer.Text = "&Imprimer"
        Me.btnImprimer.UseVisualStyleBackColor = True
        '
        'btnCalculer
        '
        Me.btnCalculer.Location = New System.Drawing.Point(16, 24)
        Me.btnCalculer.Name = "btnCalculer"
        Me.btnCalculer.Size = New System.Drawing.Size(93, 35)
        Me.btnCalculer.TabIndex = 20
        Me.btnCalculer.Text = "&Calculer"
        Me.btnCalculer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(653, 399)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vente de patins"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents btnEffacer As System.Windows.Forms.Button
    Friend WithEvents btnImprimer As System.Windows.Forms.Button
    Friend WithEvents btnCalculer As System.Windows.Forms.Button
    Friend WithEvents txtCodePostale As System.Windows.Forms.TextBox
    Friend WithEvents txtVille As System.Windows.Forms.TextBox
    Friend WithEvents txtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents txtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents lblCodePostale As System.Windows.Forms.Label
    Friend WithEvents lblVille As System.Windows.Forms.Label
    Friend WithEvents lblAdresse As System.Windows.Forms.Label
    Friend WithEvents lblPrenom As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtPrixUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtNbPatinsCommand As System.Windows.Forms.TextBox
    Friend WithEvents txtPatinsJaCommand As System.Windows.Forms.TextBox
    Friend WithEvents txtPatinsBlCommand As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblPrixUnit As System.Windows.Forms.Label
    Friend WithEvents lblNbPatinsCommand As System.Windows.Forms.Label
    Friend WithEvents lblPatinsJaCommand As System.Windows.Forms.Label
    Friend WithEvents lblPatinsBlCommand As System.Windows.Forms.Label

End Class
