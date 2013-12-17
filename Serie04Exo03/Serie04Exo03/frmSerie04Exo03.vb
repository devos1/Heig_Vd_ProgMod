'-------------------------------------------------------------------------------
'Date		    : 17.12.2013                                                    '
'Auteur		    : DevOs                                                         '
'Nom			: Serie04Exo03                                                  '
'Description	: Exercice de calcul                                          '
'--------------------------------------------------------------------------------

Public Class frmSerie04Exo03
    Private nbBonnesRep As Integer
    Private nbMauvaisesRep As Integer

    'Generateur aleatoire pour l'easter egg
    Dim r As New Random(System.DateTime.Now.Millisecond)

    'PROCEDURE LORS DU CHARGEMENT DU FORMULAIRE
    Private Sub frmSerie04Exo03_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Assigner des tags aux boutons radios
        rbAddition.Tag = "+"
        rbSoustraction.Tag = "-"
        rbMultiplication.Tag = "x"

        cbOp.Tag = gbOp
        cbEval.Tag = gbEval
        cbOp.Checked = gbOp.Visible
        cbEval.Checked = gbEval.Visible

        'Init des réponses bonnes et mauvaises
        nbBonnesRep = 0
        nbMauvaisesRep = 0
        miseAjourReponses()
    End Sub

    'FONCTION POUR CONTRÔLER LA VALIDITÉ DE L'OPÉRATEUR
    Private Function isValidOperator(ByVal op As String)
        Return op = "+" Or op = "-" Or op = "x"
    End Function

    'PROCEDURE POUR PERMETTRE DE VALIDER AVEC LE BOUTON
    Private Sub validationBouton(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNb1.TextChanged, txtNb2.TextAlignChanged,
        txtResult.TextChanged, lblOp.TextChanged
        Button1.Enabled = txtNb1.Text <> "" And txtNb2.Text <> "" And txtResult.Text <> "" And isValidOperator(lblOp.Text)
        txtResult.ForeColor = Color.Black
    End Sub

    'PROCEDURE POUR METTRE A JOUR LE NOMBRE DE BONNES OU MAUVAISES REPONSES
    Private Sub miseAjourReponses()
        Dim total As Integer = nbBonnesRep + nbMauvaisesRep
        lblBonnesRep.Text = nbBonnesRep & " sur " & total
        lblMauvaisesRep.Text = nbMauvaisesRep & " sur " & total
    End Sub

    'PROCEDURE POUR CHANGER OPERATEUR
    Private Sub changeOp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAddition.CheckedChanged, rbSoustraction.CheckedChanged, rbMultiplication.CheckedChanged
        If sender.checked Then
            lblOp.Text = sender.tag
        End If
    End Sub

    'PROCEDURE POUR CHANGER LA VISIBILITÉ DES GROUPBOX
    Private Sub changeGroupBoxVisibility(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEval.CheckedChanged, cbOp.CheckedChanged
        Dim cb = CType(sender, CheckBox)
        cb.Tag = CType(cb.Tag, GroupBox)
        cb.Tag.visible = cb.Checked
    End Sub

    'PROCEDURE POUR NE PAS ACCETER CERTAINS CARACTERES DANS LES TEXTBOX
    Private Sub ctrlSaisie(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtNb1.KeyPress, txtNb2.KeyPress, txtResult.KeyPress

        Dim t = CType(sender, TextBox)      'Sachant que c'est un textbox, on le cast

        e.Handled = True                    'Annule les touches entrées

        If Char.IsNumber(e.KeyChar) _
           Or e.KeyChar = ControlChars.Back _
           Or (e.KeyChar.Equals(Chr(46)) And Not t.SelectionStart = 0 And Not t.Text.Contains(".")) _
           Or (e.KeyChar.Equals(Chr(45)) And t.SelectionStart = 0) Then

            e.Handled = False               'On libère les touches

        End If

    End Sub

    'FONCTION POUR CONTROLER LE RESULTAT DE L'OPERATION
    Private Function valideResultatOp() As Boolean
        Dim op As String
        op = lblOp.Text
        If op = "+" Then
            Return Val(txtResult.Text) = Val(txtNb1.Text) + Val(txtNb2.Text)
        ElseIf op = "-" Then
            Return Val(txtResult.Text) = Val(txtNb1.Text) - Val(txtNb2.Text)
        ElseIf op = "*" Then
            Return Val(txtResult.Text) = Val(txtNb1.Text) * Val(txtNb2.Text)
        Else
            Return False
        End If
    End Function

    'PROCEDURE LORS DU CLIC SUR LE BOUTON
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If valideResultatOp() Then
            txtResult.ForeColor = Color.Green
            PictureBox1.Image = My.Resources.SmileyOk
            nbBonnesRep = nbBonnesRep + 1
        Else
            txtResult.ForeColor = Color.Red
            PictureBox1.Image = My.Resources.SmileyKo
            nbMauvaisesRep = nbMauvaisesRep + 1
        End If
        Button1.Enabled = False
        miseAjourReponses()
    End Sub

    'PROCEDURE EASTEREGG
    Private Sub easterEgg(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtNb1.KeyPress, txtNb2.KeyPress, txtResult.KeyPress
        If (e.keychar = "h") Then
            txtNb1.Text = r.Next(1, 1000)
            txtNb2.Text = r.Next(1, 1000)
            txtResult.Clear()
            Dim n As Integer = r.Next(1, 1000)
            If (n < 300) Then
                rbAddition.Checked = True
            ElseIf (n > 600) Then
                rbMultiplication.Checked = True
            Else
                rbSoustraction.Checked = True
            End If
        End If
    End Sub

End Class
