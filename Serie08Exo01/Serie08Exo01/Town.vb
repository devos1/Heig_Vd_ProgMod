'-------------------------------------------------------------------------------
'Date		    : 21.02.2014                                                    '
'Auteur		    : Oscar                                                         '
'Nom			: Serie08Exo01                                                  '
'Description	: Classe ville                                                  '
'--------------------------------------------------------------------------------

Public Class Town

    'PRIVATE VAR
    Private p_name As String
    Private p_picture As Image
    Private p_description As String

    'PROPERTY TOWN NAME
    Public Property name() As String
        Get
            Return p_name
        End Get
        Set(ByVal value As String)
            p_name = value.ToLower
        End Set
    End Property

    'PROPERTY TOWN DESCRIPTION
    Public Property description() As String
        Get
            Return p_description
        End Get
        Set(ByVal value As String)
            p_description = value
        End Set
    End Property

    'PROPERTY TOWN PICTURE
    Public Property picture() As Image
        Get
            Return p_picture
        End Get
        Set(ByVal value As Image)
            p_picture = value
        End Set
    End Property

    'FUNCTION TO RETURN NAME ONLY
    Public Overrides Function ToString() As String
        Return p_name
    End Function

End Class

