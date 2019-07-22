Imports System

Module Program

    Sub Main(args As String())
        Dim produccion As New List(Of Integer)
        Dim dia As Byte
        Dim cantidad As Integer
        For x = 0 To 6
            produccion.Add(0)
        Next
        Dim empleados As New SortedList(Of String, String)
        empleados.Add("pp", "pepe")
        empleados.Add("gon", "gonza")
        empleados.Add("mat", "matias")
        Do
            Console.WriteLine("Cuanto produjo (0=FIN)")
            cantidad = Console.ReadLine()
            If cantidad = 0 Then
                Exit Do
            End If
            dia = semana()
            produccion.Insert(dia, cantidad)
            produccion.RemoveAt(7)
        Loop
        MostrarTodos(empleados)
        MostrarEmp(produccion)
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
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value)
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
