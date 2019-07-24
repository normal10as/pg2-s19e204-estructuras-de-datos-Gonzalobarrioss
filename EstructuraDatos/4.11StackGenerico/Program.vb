Imports System

Module Program
    Sub Main(args As String())
        Dim frase As New Stack(Of String)
        Dim palabra As String
        Console.WriteLine("Ingrese una frase palabra por palabra (punto = fin)")
        Do
            palabra = Console.ReadLine()
            If palabra <> "." Then
                frase.Push(palabra)
            End If
        Loop Until palabra = "."
        mostrar(frase)

    End Sub

    Private Sub mostrar(frase As Stack(Of String))
        Console.WriteLine("Invirtiendo frase:")
        For Each elemento In frase
            Console.WriteLine(elemento)
        Next
    End Sub
End Module
