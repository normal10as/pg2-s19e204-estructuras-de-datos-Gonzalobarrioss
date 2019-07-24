Imports System

Module Program
    Private turnos As New Queue(Of String)
    Sub Main(args As String())
        Console.WriteLine("Bienvenido al sistema de turnos")
        menuTurnos()
    End Sub

    Sub menuTurnos()
        Dim eleccion As Byte
        Console.WriteLine("Que desea hacer:")
        Console.WriteLine("1- Agregar turno")
        Console.WriteLine("2- Atender turno")
        Console.WriteLine("3- Cantidad turnos")
        Console.WriteLine("4- Salir")
        eleccion = Console.ReadLine()
        Select Case (eleccion)
            Case 1
                agregarTurno()
            Case 2
                atenderTurno()
            Case 3
                cantidadTurno()
            Case 4
                Exit Select
            Case Else
                Console.WriteLine("Opcion incorrecta.")
                menuTurnos()
        End Select
    End Sub

    Sub agregarTurno()
        Dim cliente As String
        Console.WriteLine("Ingrese nombre del cliente:")
        cliente = Console.ReadLine()
        turnos.Enqueue(cliente)
        menuTurnos()
    End Sub

    Sub atenderTurno()
        If turnos.Count = 0 Then
            Console.WriteLine("No hay clientes para atender.")
        Else
            Console.WriteLine("Llamando al cliente: {0}", turnos.Dequeue())
        End If
        menuTurnos()
    End Sub

    Sub cantidadTurno()
        Dim x = 0
        Console.WriteLine("Cantidad de clientes en espera: {0}", turnos.Count())
        If turnos.Count = 0 Then
            Console.WriteLine("Sin clientes")
        Else
            Console.WriteLine("Proximos 2 clientes:")
            For Each tur In turnos
                x += 1
                Console.WriteLine(tur)
                If x = 2 Then
                    Exit For
                End If
            Next
        End If
        menuTurnos()
    End Sub

End Module
