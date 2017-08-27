Imports FigurasEntidades
Module TrianguloTest
    Sub Main()
        Dim triangulo_1 As New Triangulo

        triangulo_1.Nombre = "Triangulo"
        triangulo_1.Base = 75
        triangulo_1.Altura = 136

        Console.WriteLine("Nombre: " & triangulo_1.Nombre)
        Console.WriteLine("Base: " & triangulo_1.Base)
        Console.WriteLine("Altura: " & triangulo_1.Altura)
        Console.WriteLine("Area: " & triangulo_1.CalcularArea & " m" & Chr(178))

        Console.ReadKey()
    End Sub
End Module
