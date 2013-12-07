Public Class Personne

    'Attributs
    Private p_nom As String
    Private p_prenom As String
    Private p_age As Integer
    Private img As Image

    Public Property nom() As String
        Get
            Return p_nom
        End Get
        Set(value As String)
            p_nom = value
        End Set
    End Property

    Public Property prenom() As String
        Get
            Return p_prenom
        End Get
        Set(ByVal value As String)
            p_prenom = value
        End Set
    End Property

    Public Property age() As Integer
        Get
            Return p_age
        End Get
        Set(ByVal value As Integer)
            p_age = value
        End Set
    End Property

    Public Property image() As Image
        Get
            Return img
        End Get
        Set(ByVal value As Image)
            img = value
        End Set
    End Property



End Class
