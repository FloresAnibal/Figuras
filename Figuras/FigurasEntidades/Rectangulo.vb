Public Class Rectangulo
    Inherits Figura     'herencia
    'campos
    Private _base As UShort
    Private _altura As UShort


    'constructor
    Sub New()
        MyBase.New()
        _base = 0
        _altura = 0
    End Sub


    'propiedaes
    Public Property Base() As UShort
        Get
            Return _base
        End Get
        Set(value As UShort)
            _base = value
        End Set
    End Property

    Public Property Altura() As UShort
        Get
            Return _altura
        End Get
        Set(value As UShort)
            _altura = value
        End Set
    End Property

    'metodos
    Public Overrides Function CalcularArea() As Single
        Return Base * Altura
    End Function

End Class
