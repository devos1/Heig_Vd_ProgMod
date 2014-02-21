'-------------------------------------------------------------------------------
'Date		    : 21.02.2014                                                    '
'Auteur		    : Oscar                                                         '
'Nom			: Serie08Exo01                                                  '
'Description	: Main form                                                     '
'--------------------------------------------------------------------------------
Public Class Serie08Exo01

    'SUB WHEN FORM LOAD
    Private Sub Serie08Exo01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Sorted = True
        ListBox1.Sorted = True
        PictureBox1.BackgroundImageLayout = ImageLayout.Center

        For Each c In InitCountries.init()
            ComboBox1.Items.Add(c)
        Next
    End Sub

    'SUB TO OBTAIN ITEM FROM COMBOBOX
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBox1.Items.Clear()

        Dim c As country = CType(ComboBox1.SelectedItem, country)
        For Each t As Town In c.towns
            ListBox1.Items.Add(t)
        Next
        displayTown(Nothing)
    End Sub

    'SUB TO OBTAIN ITEM FROM LISTBOX
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim t As Town = CType(ListBox1.SelectedItem, Town)
        displayTown(t)
    End Sub

    'SUB TO DISPLAY TOWNS
    Private Sub displayTown(ByVal t As Town)
        If (t Is Nothing) Then
            GroupBox1.Text = ""
            PictureBox1.BackgroundImage = Nothing
            TextBox1.Text = ""
        Else
            GroupBox1.Text = t.name
            PictureBox1.BackgroundImage = t.picture
            TextBox1.Text = t.description
        End If
    End Sub

End Class
