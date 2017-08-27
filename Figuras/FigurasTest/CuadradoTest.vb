Imports FigurasEntidades
Module CuadradoTest
    Sub Main()
        Dim cuadrado_1 As New Cuadrado

        cuadrado_1.Nombre = "Cuadrado"
        cuadrado_1.Lado = 230

        Console.WriteLine("Nombre: " & cuadrado_1.Nombre)
        Console.WriteLine("Lado: " & cuadrado_1.Lado)
        Console.WriteLine("Area: " & cuadrado_1.CalcularArea & " m" & Chr(178))

        Console.ReadKey()
    End Sub
End Module
