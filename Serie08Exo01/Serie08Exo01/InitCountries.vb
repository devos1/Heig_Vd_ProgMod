Public Class InitCountries

    Public Shared Function init() As List(Of country)
        Dim c As country
        Dim t As Town
        Dim r As New List(Of country)

        c = New country()
        c.name = "Suisse"
        t = New Town()
        t.name = "Laussane"
        t.description = "au bord du lac Léman"
        c.addTown(t)

        t = New Town()
        t.name = "Berne"
        t.description = "capitale administrative"
        c.addTown(t)
        r.Add(c)

        c = New country()
        c.name = "Italie"
        t = New Town()
        t.name = "Rome"
        t.description = "capitale"
        c.addTown(t)
        t = New Town()
        t.name = "Florence"
        t.description = "capitale de la Toscane"
        c.addTown(t)
        r.Add(c)

        Return r
    End Function

End Class
