Imports FigurasEntidades
Module FiguraTest
    Sub Main()
        Dim figura_1 As New Figura

        figura_1.Nombre = "Figura 1"

        Console.WriteLine("Nombre: " & figura_1.Nombre)
        Console.WriteLine("Area: " & figura_1.CalcularArea)

        Console.ReadKey()
    End Sub
End Module
