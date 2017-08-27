Imports FigurasEntidades
Module RectanguloTest
    Sub Main()
        Dim rectangulo_1 As New Rectangulo

        rectangulo_1.Nombre = "Rectangulo"
        rectangulo_1.Base = 40
        rectangulo_1.Altura = 60

        Console.WriteLine("Nombre: " & rectangulo_1.Nombre)
        Console.WriteLine("Base: " & rectangulo_1.Base)
        Console.WriteLine("Altura: " & rectangulo_1.Altura)
        Console.WriteLine("Area: " & rectangulo_1.CalcularArea & " m" & Chr(178))

        Console.ReadKey()
    End Sub
End Module
