'-------------------------------------------------------------------------------
'Date		    : 21.02.2014                                                    '
'Auteur		    : Oscar                                                         '
'Nom			: Serie08Exo01                                                  '
'Description	: Classe pays                                                   '
'--------------------------------------------------------------------------------
Public Class country

    'PRIVATE VAR
    Private p_name As String
    Private p_towns As New List(Of Town)

    'PROPERTY COUNTRY NAME
    Public Property name() As String
        Get
            Return p_name
        End Get
        Set(ByVal value As String)
            p_name = value.ToLower
        End Set
    End Property

    'SUB TO ADD TOWN TO COUNTRY
    Public Sub addTown(ByVal t As Town)
        p_towns.Add(t)
    End Sub

    'SUB TO REMOVE TOWN
    Public Sub removeTown(ByVal t As Town)
        p_towns.Remove(t)
    End Sub

    'FUNCTION "OVERRIDE" TO RETURN NAME
    Public Overrides Function ToString() As String
        Return p_name
    End Function

    'FUNCTION TO RETURN TOWN'S COLLECTION
    Public Function towns() As List(Of Town)
        Dim col As New List(Of Town)
        For Each t In p_towns
            col.Add(t)
        Next
        Return col
    End Function

End Class


