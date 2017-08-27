Public Class Cuadrado
    Inherits Figura     'herencia
    'campos
    Private _lado As UShort


    'constructor
    Sub New()
        MyBase.New()
        _lado = 0
    End Sub


    'propiedaes
    Public Property Lado() As UShort
        Get
            Return _lado
        End Get
        Set(value As UShort)
            _lado = value
        End Set
    End Property

    'metodos
    Public Overrides Function CalcularArea() As Single
        Return Lado * Lado
    End Function

End Class
