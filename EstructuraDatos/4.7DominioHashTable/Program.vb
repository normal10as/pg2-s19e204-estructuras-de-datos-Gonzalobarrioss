Imports System

Module Program
    Private dominioPais As New Hashtable
    Private nombre_pais, clave_pais As String
    Sub Main()
        Console.WriteLine("Bienvenido al menu, que desea hacer:")
        dominioPais.Add("arg", "Argentina")
        dominioPais.Add("esp", "España")
        dominioPais.Add("uru", "Uruguay")
        dominioPais.Add("usa", "Estados Unidos")
        menuPaises()
    End Sub

    Sub menuPaises()
        Dim eleccion As Byte
        Console.WriteLine("Elige una opcion:")
        Console.WriteLine("1- Agregar pais")
        Console.WriteLine("2- Editar pais")
        Console.WriteLine("3- Eliminar pais")
        Console.WriteLine("4- Mostrar nombre pais")
        Console.WriteLine("5- Mostrar cantidad de paises")
        Console.WriteLine("6- Salir")
        eleccion = Console.ReadLine()
        Select Case (eleccion)
            Case 1
                agregarPais()
            Case 2
                editarPais()
            Case 3
                eliminarPais()
            Case 4
                mostrarPais()
            Case 5
                cantidadPais()
            Case 6
                Exit Select
            Case Else
                Console.WriteLine("Opcion incorrecta.")
                menuPaises()
        End Select
    End Sub

    Sub agregarPais()
        listaPaises(dominioPais)
        Console.WriteLine("Ingrese nombre pais")
        nombre_pais = Console.ReadLine()
        Console.WriteLine("Ingrese clave del pais")
        clave_pais = Console.ReadLine()
        dominioPais.Add(clave_pais, nombre_pais)
        menuPaises()
    End Sub

    Sub editarPais()
        listaPaises(dominioPais)
        Console.WriteLine("Ingrese clave del pais a editar")
        clave_pais = Console.ReadLine()
        dominioPais.Remove(clave_pais)
        Console.WriteLine("Ingrese nuevo pais")
        nombre_pais = Console.ReadLine()
        Console.WriteLine("Ingrese nueva clave")
        clave_pais = Console.ReadLine()
        dominioPais.Add(clave_pais, nombre_pais)
        menuPaises()
    End Sub

    Sub eliminarPais()
        listaPaises(dominioPais)
        Console.WriteLine("Ingrese clave del pais a eliminar")
        clave_pais = Console.ReadLine()
        dominioPais.Remove(clave_pais)
        menuPaises()
    End Sub

    Sub mostrarPais()
        For Each pais As DictionaryEntry In dominioPais
            Console.WriteLine(pais.Key)
        Next
        Do
            Console.WriteLine("Ingresar dominio de pais: ")
            clave_pais = Console.ReadLine()
            If clave_pais = "" Then
                Exit Do
            End If
            For Each dom In dominioPais
                If dominioPais.Contains(clave_pais) Then
                    Console.WriteLine("El nombre del pais es: " & dominioPais(clave_pais))
                    Exit For
                Else
                    Console.WriteLine("No existe ese dominio.")
                    Exit For
                End If
            Next
        Loop
        menuPaises()
    End Sub

    Sub cantidadPais()
        Console.WriteLine("La cantidad de paises es de: {0} paises", dominioPais.Count)
        menuPaises()
    End Sub

    Private Sub listaPaises(dominioPais As Hashtable)
        Console.WriteLine("Dominio - Pais")
        For Each pais As DictionaryEntry In dominioPais
            Console.WriteLine(pais.Key & " - " & pais.Value)
        Next
    End Sub

End Module
