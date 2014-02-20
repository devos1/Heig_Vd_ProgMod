'-------------------------------------------------------------------------------
'Date		    : 20.02.2014                                                    '
'Auteur		    : Oscar                                                         '
'Nom			: Serie07Exo02                                                  '
'Description	: Formulaire de base                                            '
'--------------------------------------------------------------------------------
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Sorted = True
        ListBox2.Sorted = True
        ListBox1.SelectionMode = SelectionMode.MultiExtended
        ListBox2.SelectionMode = SelectionMode.MultiExtended

        ListBox1.Items.Add("Madrid")
        ListBox1.Items.Add("Rome")
        ListBox1.Items.Add("Tokyo")
        ListBox1.Items.Add("Porto")
        ListBox1.Items.Add("Paris")
        ListBox1.Items.Add("Neuchâtel")
        ListBox1.Items.Add("Lausanne")
        ListBox1.Items.Add("New York")
    End Sub

    'PROCEDURE POUR TRANSFERER LES ELEMENTS SELECTIONNES DE LA LISTE SOURCE VERS LA LISTE DESTINATION
    Private Sub transfert(ByVal lbSrc As ListBox, ByVal lbDest As ListBox)

        Dim e As Object

        While (lbSrc.SelectedItems.Count > 0)
            e = lbSrc.SelectedItems.Item(0)
            lbDest.Items.Add(e)
            lbSrc.Items.Remove(e)
        End While
    End Sub

    'TRANSFERT DE LA GAUCHE VERS LA DROITE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        transfert(ListBox1, ListBox2)
    End Sub

    'TRANSFERT DE DROITE VERS LA GAUCHE
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        transfert(ListBox2, ListBox1)
    End Sub
End Class
