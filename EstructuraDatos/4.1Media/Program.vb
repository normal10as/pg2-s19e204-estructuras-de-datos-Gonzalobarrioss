Imports System

Module Program
    Sub Main(args As String())
        Dim sumatoria, vector(4) As Integer
        Dim media As Single
        For i = 0 To vector.Length - 1
            Console.WriteLine("Ingrese un numero")
            vector(i) = Console.ReadLine()
            sumatoria += vector(i)
        Next
        media = sumatoria / vector.Length
        Console.WriteLine("La sumatoria de todos los elementos: " & sumatoria)
        Console.WriteLine("La media: " & media)
        For i = 0 To vector.Length - 1
            Console.WriteLine("indice: {0}, valor: {1}, su desviacion: {2} ", i, vector(i), vector(i) - media)
        Next
    End Sub
End Module
