Public Class country

    Private p_name As String
    Private p_towns As New List(Of Town)

    Public Property name() As String
        Get
            Return p_name
        End Get
        Set(ByVal value As String)
            p_name = value.ToLower
        End Set
    End Property

    Public Sub addTown(ByVal t As Town)
        p_towns.Add(t)
    End Sub

    Public Sub removeTown(ByVal t As Town)
        p_towns.Remove(t)
    End Sub

    Public Overrides Function ToString() As String
        Return p_name
    End Function

    Public Function towns() As List(Of Town)
        Dim col As New List(Of Town)
        For Each t In p_towns
            col.Add(t)
        Next

        Return col
    End Function

End Class


