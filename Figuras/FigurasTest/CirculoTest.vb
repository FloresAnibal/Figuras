Imports FigurasEntidades

Module CirculoTest

    Sub Main()
        Dim circulo_1 As New Circulo

        circulo_1.Nombre = "Circulo"
        circulo_1.Radio = 35

        Console.WriteLine("Nombre: " & circulo_1.Nombre)
        Console.WriteLine("Radio: " & circulo_1.Radio)
        Console.WriteLine("Area: " & circulo_1.CalcularArea & " m" & Chr(178))

        Console.ReadKey()
    End Sub

End Module
