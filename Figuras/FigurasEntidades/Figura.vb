Public Class Figura
    'campos
    Private _nombre As String


    'constructor
    Sub New()
        _nombre = ""
    End Sub


    'propiedades
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property


    'metodos
    Public Overridable Function CalcularArea() As Single
        Return 0
    End Function


End Class