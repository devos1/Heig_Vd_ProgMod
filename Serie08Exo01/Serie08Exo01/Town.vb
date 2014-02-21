Public Class Town

    Private p_name As String
    Private p_picture As Image
    Private p_description As String

    Public Property name() As String
        Get
            Return p_name
        End Get
        Set(ByVal value As String)
            p_name = value.ToLower
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

    Public Property picture() As Image
        Get
            Return p_picture
        End Get
        Set(ByVal value As Image)
            p_picture = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return p_name
    End Function

End Class

