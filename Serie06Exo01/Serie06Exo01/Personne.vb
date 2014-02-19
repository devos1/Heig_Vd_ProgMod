'-------------------------------------------------------------------------------
'Date		    : 07.12.2013                                                    '
'Auteur		    : Oscar                                                         '
'Nom			: Serie06Exo01                                                  '
'Description	: Classe Personne pour contenir les informations de personnes   '
'--------------------------------------------------------------------------------
Public Class Personne

    'Attributs
    Private p_nom As String
    Private p_prenom As String
    Private p_ddn As Date
    Private p_photo As Image

#Region "CONSTRUCTEURS"
    'Création contructeur 1
    Public Sub New(ByVal n As String, ByVal p As String, ByVal ddn As String)
        nom = n
        prenom = p
        naissance = ddn
    End Sub

    'Création contructeur 2
    Public Sub New(ByVal n As String, ByVal p As String)
        nom = n
        prenom = p
        naissance = Date.Today
    End Sub

    'Création contructeur 3
    Public Sub New(ByVal n As String, ByVal p As String, ByVal ddn As String, ByVal p_photo As Image)
        nom = n
        prenom = p
        naissance = ddn
        photo = p_photo
    End Sub

    'Création contructeur 4
    Public Sub New(ByVal n As String, ByVal p As String, ByVal ddn As String, ByVal chemin As String)
        nom = n
        prenom = p
        naissance = ddn
        photo = Image.FromFile(chemin)
    End Sub
#End Region

#Region "PROPERTY"
    Public Property nom() As String
        Get
            Return p_nom
        End Get
        Set(value As String)
            p_nom = value.ToUpper()
        End Set
    End Property

    Public Property prenom() As String
        Get
            Return p_prenom
        End Get
        Set(ByVal value As String)
            p_prenom = value.ToLower
        End Set
    End Property

    'Property pour la date de naissance avec contrôle que la date soit inférieur à today!
    Public Property naissance() As Date
        Get
            Return p_ddn
        End Get
        Set(ByVal value As Date)
            If (Date.Compare(value, Date.Today) < 0) Then
                p_ddn = value
            End If
        End Set
    End Property

    Public Property photo() As Image
        Get
            Return p_photo
        End Get
        Set(ByVal value As Image)
            p_photo = value
        End Set
    End Property

    'Property pour retourner l'âge en fonction de la date de naissance
    Public ReadOnly Property age() As String
        Get
            Return Date.Now.Subtract(p_ddn).Days \ 365
        End Get
    End Property

#End Region

#Region "FONCTIONS - PROCEDURES"
    Public Overrides Function ToString() As String
        Return nom & " " & prenom
    End Function
#End Region

End Class
