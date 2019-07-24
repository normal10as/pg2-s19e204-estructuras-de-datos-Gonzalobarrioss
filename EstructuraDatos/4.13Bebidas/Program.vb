Imports System

Module Program
    Private listaOrdenada As New SortedDictionary(Of String, String)
    Private bebidas As New Dictionary(Of String, String)
    Private precios As New List(Of Double)
    Sub Main(args As String())
        menu()
    End Sub

    Sub menu()
        Dim eleccion As Byte
        Console.WriteLine("Elige una opcion")
        opciones()
        eleccion = Console.ReadLine()
        Select Case eleccion
            Case 1
                agregarBebida()
            Case 2
                editarBebida()
            Case 3
                borrarBebida()
            Case 4
                listadoBebidas()
            Case 5
                listadoOrdenado()
            Case 6

            Case Else
                Console.WriteLine("opcion incorrecta")
                menu()
        End Select
    End Sub

    Sub agregarBebida()
        Dim codigo As String
        Dim nombre As String
        Dim precio As Double
        Console.WriteLine("Ingrese codigo de bebida")
        codigo = Console.ReadLine()
        If bebidas.ContainsKey(codigo) Then
            Console.WriteLine("Codigo ya existe")
            agregarBebida()
        Else
            Console.WriteLine("Ingrese nombre de bebida")
            nombre = Console.ReadLine()
            bebidas.Add(codigo, nombre)
            Console.WriteLine("Ingrese precio")
            precio = Console.ReadLine()
            precios.Add(precio)
        End If
        menu()
    End Sub

    Sub borrarBebida()
        Dim codigo As String
        Dim cod_precio As Byte
        Console.WriteLine("Ingrese codigo bebida para eliminar")
        codigo = Console.ReadLine()
        If bebidas.ContainsKey(codigo) Then
            bebidas.Remove(codigo)
            For x = 0 To precios.Count - 1
                Console.WriteLine("codigo = {0}, precio = ${1}", x + 1, precios(x))
            Next
            Console.WriteLine("Ingrese codigo de su precio para eliminar")
            cod_precio = Console.ReadLine()
            precios.RemoveAt(cod_precio - 1)
        Else
            Console.WriteLine("no existe ese codigo")
        End If
        menu()
    End Sub

    Sub editarBebida()
        Dim codigo As String
        Dim nuevocodigo As String
        Dim cod_precio As Byte
        Dim precio As Double
        Console.WriteLine("Ingrese codigo para editar")
        codigo = Console.ReadLine()
        If bebidas.ContainsKey(codigo) Then
            Console.WriteLine("Ingrese nuevo nombre")
            nuevocodigo = Console.ReadLine()
            bebidas(codigo) = nuevocodigo
            For x = 0 To precios.Count - 1
                Console.WriteLine("codigo = {0}, precio = ${1}", x + 1, precios(x))
            Next
            Console.WriteLine("Ingrese codigo de su precio para editar")
            cod_precio = Console.ReadLine()
            precios.RemoveAt(cod_precio - 1)
            Console.WriteLine("Ingrese nuevo precio:")
            precio = Console.ReadLine()
            precios.Insert(cod_precio - 1, precio)
        Else
            Console.WriteLine("ese codigo no existe.")
        End If
        menu()
    End Sub

    Sub listadoBebidas()
        Dim x = 0
        For Each cnb As KeyValuePair(Of String, String) In bebidas
            Console.WriteLine("codigo = {0}, Nombre = {1}, precio = ${2}", cnb.Key, cnb.Value, precios(x))
            x += 1
        Next
        Console.WriteLine("")
        menu()
    End Sub

    Sub listadoOrdenado()
        For Each cnb As KeyValuePair(Of String, String) In bebidas
            listaOrdenada(cnb.Key) = bebidas(cnb.Key)
        Next
        For Each cnb As KeyValuePair(Of String, String) In listaOrdenada
            Console.WriteLine("codigo = {0}, Nombre = {1}", cnb.Key, cnb.Value)
        Next
        Console.WriteLine("")
        menu()
    End Sub

    Sub opciones()
        Console.WriteLine("1- Agregar Bebida")
        Console.WriteLine("2- Editar Nombre Bebida")
        Console.WriteLine("3- Eliminar Bebida")
        Console.WriteLine("4- Listado Bebidas")
        Console.WriteLine("5- Listado ordenado")
        Console.WriteLine("6- Salir")
    End Sub
End Module
