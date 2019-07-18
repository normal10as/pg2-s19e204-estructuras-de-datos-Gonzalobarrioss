Imports System

Module Program
    Private alumnos As ArrayList
    Private cadena_nombres, nombre_mejores_alumnos, lista_total As String
    Sub Main(args As String())
        alumnos = New ArrayList
        Dim notas As ArrayList
        notas = New ArrayList
        Dim mejores_alumnos As ArrayList
        mejores_alumnos = New ArrayList
        Dim cant_alu, cant_notas As Integer
        Dim promedio, mejor_promedio As Single
        Do
            Console.WriteLine("Max alumnos 40-Max notas 4")
            Console.WriteLine("Ingrese cantidad de alumnos: ")
            cant_alu = Console.ReadLine()
            Console.WriteLine("Ingrese cantidad de notas: ")
            cant_notas = Console.ReadLine()
        Loop Until (cant_alu < 41 And cant_notas < 5)

        For i = 1 To cant_alu
            alumnos.Add(validarNombre())
            For x = 1 To cant_notas
                notas.Add(rangoNota(x))
            Next
        Next
        Dim y = 0
        Dim fin = cant_notas
        For Each alu In alumnos
            promedio = 0
            Console.WriteLine("Alumno: {0}", alu)
            For x = y To fin - 1
                Console.WriteLine("Nota: = {0}", notas.Item(x))
                y += 1
                promedio = promedio + notas.Item(x)
            Next
            fin += cant_notas
            promedio = Promediar(promedio, cant_notas)
            If promedio > mejor_promedio Then
                mejores_alumnos.Clear()
                mejor_promedio = promedio
                mejores_alumnos.Add(alu)
            ElseIf promedio = mejor_promedio Then
                mejores_alumnos.Add(alu)
            End If
            Console.WriteLine("su promedio: {0}", promedio)
            AprobadoDesaprobado(promedio)
        Next


        Console.WriteLine("Lista mejores Alumnos: ")
        For Each mejor_alu In mejores_alumnos
            Console.WriteLine(mejor_alu)
        Next

    End Sub

    Function nombreIgual(nombre) As String
        For Each nom In alumnos
            If nom = nombre Then
                Console.WriteLine("Ese nombre ya existe, ingrese otro.")
                nombre = validarNombre()
            End If
        Next
        Return nombre
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
        nombre = nombreIgual(nombre)
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

    Function MejoresAlumnos(lista) As String
        lista_total += lista + " "
        Return lista_total
    End Function
End Module
