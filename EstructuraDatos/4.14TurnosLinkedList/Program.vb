Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
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
                opciones()
        End Select
    End Sub

    Sub agregarTurno()
        Dim nombre As String
        Dim categoria As Byte
        Console.WriteLine("Ingrese su nombre: ")
        nombre = Console.ReadLine()
        prioridad()
        categoria = Console.ReadLine()

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
