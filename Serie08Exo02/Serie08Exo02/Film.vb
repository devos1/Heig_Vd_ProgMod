Public Class Film

    Private p_titre As String
    Private p_realisateur As String
    Private p_duree As Integer
    Private p_affiche As Image
    Private p_description As String

    Public Property titre() As String
        Get
            Return p_titre
        End Get
        Set(ByVal value As String)
            p_titre = value
        End Set
    End Property

    Public Property realisateur() As String
        Get
            Return p_realisateur
        End Get
        Set(ByVal value As String)
            p_realisateur = value
        End Set
    End Property

    Public Property duree() As Integer
        Get
            Return p_duree
        End Get
        Set(ByVal value As Integer)
            p_duree = value
        End Set
    End Property

    Public Property description() As String
        Get
            Return p_description
        End Get
        Set(ByVal value As String)
            p_description = value
        End Set
    End Property

    Public Property affiche() As Image
        Get
            Return p_affiche
        End Get
        Set(ByVal value As Image)
            p_affiche = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return p_titre
    End Function

End Class
