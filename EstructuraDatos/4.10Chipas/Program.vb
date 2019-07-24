Imports System

Module Program

    Sub Main(args As String())

        Dim empleados As New SortedList(Of String, String)
        empleados.Add("pp", "pepe")
        empleados.Add("gon", "gonza")
        empleados.Add("mat", "matias")

        Dim pepe As New List(Of Integer)
        Dim gonza As New List(Of Integer)
        Dim matias As New List(Of Integer)

        For x = 0 To 6
            pepe.Add(0)
            gonza.Add(0)
            matias.Add(0)
        Next

        Dim eleccion As Byte
        Dim dia As Byte
        Dim cantidad As Integer

        Do
            Console.WriteLine("Elija un empleado (0=FIN)")
            Console.WriteLine("1-" & empleados.Item("pp"))
            Console.WriteLine("2-" & empleados.Item("gon"))
            Console.WriteLine("3-" & empleados.Item("mat"))
            eleccion = Console.ReadLine()
            If eleccion = 0 Then
                Exit Do
            End If

            Console.WriteLine("Cantidad de produccion:")
            cantidad = Console.ReadLine()

            dia = semana()

            Select Case eleccion
                Case 1
                    cantidad = cantidad + pepe.Item(dia)
                    pepe.Insert(dia, cantidad)
                    pepe.RemoveAt(dia + 1)
                Case 2
                    cantidad = cantidad + gonza.Item(dia)
                    gonza.Insert(dia, cantidad)
                    gonza.RemoveAt(dia + 1)
                Case 3
                    cantidad = cantidad + matias.Item(dia)
                    matias.Insert(dia, cantidad)
                    matias.RemoveAt(dia + 1)
            End Select

        Loop
        Console.WriteLine("Todos los empleados: ")
        MostrarTodos(empleados)
        Console.WriteLine("empleado 1")
        MostrarEmp(pepe)
        Console.WriteLine("empleado 2")
        MostrarEmp(gonza)
        Console.WriteLine("empleado 3")
        MostrarEmp(matias)
    End Sub

    Private Sub MostrarEmp(lista As List(Of Integer))
        Console.WriteLine("Lista completa")
        For Each emp In lista
            Console.WriteLine(emp)
        Next
        Console.WriteLine("")
    End Sub

    Sub MostrarTodos(lista As SortedList(Of String, String))
        Console.WriteLine("Lista completa")
        For Each kvp As KeyValuePair(Of String, String) In lista
            Console.WriteLine("Clave emp= {0}, Nombre = {1}", kvp.Key, kvp.Value)
        Next
        Console.WriteLine("")
    End Sub

    Function semana() As Byte
        Dim eleccion As Byte
        mostrarSemana()
        eleccion = Console.ReadLine()
        Select Case eleccion
            Case 0
                Return 0
            Case 1
                Return 1
            Case 2
                Return 2
            Case 3
                Return 3
            Case 4
                Return 4
            Case 5
                Return 5
            Case 6
                Return 6
            Case Else
                Console.WriteLine("Error")
                'Return semana()
        End Select
    End Function

    Sub mostrarSemana()
        Console.WriteLine("Elegir dia")
        Console.WriteLine("0- Domingo")
        Console.WriteLine("1- Lunes")
        Console.WriteLine("2- Martes")
        Console.WriteLine("3- Miercoles")
        Console.WriteLine("4- Jueves")
        Console.WriteLine("5- Viernes")
        Console.WriteLine("6- Sabado")
    End Sub
End Module
