Imports System

Module Program
    Sub Main(args As String())
        Dim codigo_producto = New Integer() {1, 2, 3, 4, 5}
        Dim nombre_producto = New String() {"Fanta", "Tupy", "Naranpol", "cabalgata", "manaos papá"}
        Dim precio_producto = New Double() {40, 25.5, 28, 32.5, 20}
        Dim totales(4) As Double
        Dim total_general(4) As Double
        Dim codigo, bandera, cantidad As Integer

        Do
            Console.WriteLine("Ingrese codigo (0=FIN)")
            codigo = Console.ReadLine()
            If codigo = 0 Then
                Exit Do
            End If
            For i = 0 To codigo_producto.Length - 1
                If codigo_producto(i) = codigo Then
                    Console.WriteLine("Nombre producto: {0},Precio: {1} ", nombre_producto(i), precio_producto(i))
                    Console.WriteLine("Ingrese cantidad a comprar:")
                    cantidad = Console.ReadLine()
                    totales(i) = precio_producto(i) * cantidad
                    Console.WriteLine("Total producto:" & totales(i))
                    total_general(i) += totales(i)
                    bandera = 1
                    Exit For
                End If
                bandera = 0
            Next
            If bandera = 0 Then
                Console.WriteLine("Error no existe ese producto")
            End If
            Console.WriteLine("Totales generales hasta el momento:")
            For i = 0 To total_general.Length - 1
                Console.WriteLine("Producto {0}, TOTAL GENERAL: {1}", nombre_producto(i), total_general(i))
            Next
        Loop While (codigo)
    End Sub
End Module
