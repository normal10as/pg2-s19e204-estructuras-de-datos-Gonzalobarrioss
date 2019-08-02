Imports System

Module Program
    Private turnos As New LinkedList(Of String)
    Private ultimo_anciano, ultima_embarazada As String
    Private contador_anciano, contador_embarazada As Byte
    Sub Main(args As String())
        menu()
    End Sub

    Sub menu()
        Dim eleccion As Byte
        opciones()
        eleccion = Console.ReadLine()
        Select Case eleccion
            Case 1
                agregarTurno()
            Case 2
                atenderTurno()
            Case 3
                cantidadTurnos()
            Case 4

            Case Else
                Console.WriteLine("Opcion incorrecta")
                menu()
        End Select
    End Sub

    Sub agregarTurno()
        Dim nombre As String
        Dim categoria As Byte
        Console.WriteLine("Ingrese su nombre: ")
        nombre = Console.ReadLine()
        prioridad()
        categoria = Console.ReadLine()
        Select Case categoria
            Case 1
                turnos.AddLast(nombre)
            Case 2
                If ultima_embarazada = "" And ultimo_anciano = "" Then
                    turnos.AddFirst(nombre)
                ElseIf ultima_embarazada <> "" Then
                    turnos.AddAfter(turnos.FindLast(ultima_embarazada), nombre)
                Else
                    turnos.AddAfter(turnos.FindLast(ultimo_anciano), nombre)
                End If
                ultima_embarazada = nombre
                contador_embarazada += 1
            Case 3
                If ultimo_anciano = "" Then
                    turnos.AddFirst(nombre)
                Else
                    turnos.AddAfter(turnos.FindLast(ultimo_anciano), nombre)
                End If
                ultimo_anciano = nombre
                contador_anciano += 1
            Case Else
                Console.WriteLine("Prioridad incorrecta")
        End Select
        menu()
    End Sub

    Sub atenderTurno()
        If turnos.Count = 0 Then
            Console.WriteLine("Sin clientes")
        Else
            Console.WriteLine("Llamando a: {0}", turnos(0))
            turnos.RemoveFirst()
            If contador_anciano = 0 Then
                ultimo_anciano = ""
            Else
                contador_anciano -= 1
            End If
            If contador_embarazada = 0 Then
                ultima_embarazada = ""
            Else
                If contador_anciano = 0 Then
                    contador_embarazada -= 1
                End If
            End If
        End If
        menu()
    End Sub

    Sub cantidadTurnos()
        If turnos.Count > 0 Then
            Console.WriteLine("La cantidad de clientes en espera es de: {0}", turnos.Count)
            Console.WriteLine("El proximo en ser atendido: {0}", turnos(0))
        Else
            Console.WriteLine("Sin clientes")
        End If
        menu()
    End Sub

    Sub opciones()
        Console.WriteLine("Elige una opcion")
        Console.WriteLine("1-Agregar turno")
        Console.WriteLine("2-Atender turno")
        Console.WriteLine("3-Cantidad turnos")
        Console.WriteLine("4-Salir")
    End Sub

    Sub prioridad()
        Console.WriteLine("Ingrese prioridad:")
        Console.WriteLine("1-Sin prioridad")
        Console.WriteLine("2-Embarazada")
        Console.WriteLine("3-Anciano/a")
    End Sub

End Module
