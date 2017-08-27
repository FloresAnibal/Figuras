Public Class Circulo
    Inherits Figura     'herencia
    'campos
    Private _radio As UShort


    'constructor
    Sub New()
        MyBase.New()
        _radio = 0
    End Sub


    'propiedaes
    Public Property Radio() As UShort
        Get
            Return _radio
        End Get
        Set(value As UShort)
            _radio = value
        End Set
    End Property

    'metodos
    Public Overrides Function CalcularArea() As Single
        Return Math.PI * Radio ^ 2
    End Function
End Class
