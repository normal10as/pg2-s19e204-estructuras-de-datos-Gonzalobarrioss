Imports System.String

Module Program
    Public Property CompareMethod As Object
    Sub Main(args As String())
        Dim cant_alu, cant_notas As Integer
        Dim promedio As Single
        Do
            Console.WriteLine("Max alumnos 40-Max notas 4")
            Console.WriteLine("Ingrese cantidad de alumnos: ")
            cant_alu = Console.ReadLine() - 1
            Console.WriteLine("Ingrese cantidad de notas: ")
            cant_notas = Console.ReadLine() + 1
        Loop Until (cant_alu < 40 And cant_notas < 6)

        Dim matriz(cant_alu, cant_notas)
        For i = 0 To cant_alu
            matriz(i, 0) = validarNombre()
            For x = 1 To cant_notas - 1
                matriz(i, x) = rangoNota(x)
                matriz(i, cant_notas) += matriz(i, x)
            Next
        Next

        For i = 0 To cant_alu
            Console.WriteLine("Alumno: {0}", matriz(i, 0))
            For x = 1 To cant_notas - 1
                Console.WriteLine("Nota: {0} = {1}", x, matriz(i, x))
            Next
            promedio = Promediar(matriz(i, cant_notas), (cant_notas - 1))
            Console.WriteLine("su promedio: {0}", promedio)
            AprobadoDesaprobado(promedio)
        Next
    End Sub
    Dim cadena_nombres As String
    Function nombreIgual(nombre) As String
        cadena_nombres += nombre & " "
        Console.WriteLine("cadena: " & cadena_nombres)
    End Function


    Function validarNombre() As String
        Dim nombre As String
        Do
            Console.WriteLine("Ingrese nombre alumno: ")
            nombre = Console.ReadLine()
            If nombre.Length < 3 Then
                Console.WriteLine("Nombre muy corto, ingrese otro")
            Else
                Exit Do
            End If
        Loop While True
        nombreIgual(nombre)
        Return nombre
    End Function

    Function rangoNota(x) As Single
        Dim nota As Single
        Do
            Console.WriteLine("Ingrese nota {0}, entre (0 y 10)", x)
            nota = Console.ReadLine()
            If nota < 0 Or nota > 10 Then
                Console.WriteLine("Nota excede rango, ingrese nuevamente")
            Else
                Exit Do
            End If
        Loop While True
        Return nota
    End Function

    Function Promediar(suma_nota, cantidad_nota) As Single
        Return suma_nota / cantidad_nota
    End Function

    Sub AprobadoDesaprobado(promedio)
        If promedio >= 6 Then
            Console.WriteLine("El alumno está aprobado.")
        Else
            Console.WriteLine("El alumno está desaprobado.")
        End If
    End Sub

End Module
