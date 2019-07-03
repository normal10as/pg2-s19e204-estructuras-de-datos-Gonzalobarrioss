Module Module1

    Sub Main()
        Dim dominioPais As New Collection
        Dim dominio As String
        dominioPais.Add("Argentina", "arg")
        dominioPais.Add("España", "esp")
        dominioPais.Add("Uruguay", "uru")
        dominioPais.Add("Estados Unidos", "usa")
        Do
            Console.WriteLine("Ingresar dominio de pais: ")
            dominio = Console.ReadLine()
            If dominio = "" Then
                Exit Do
            End If
            For Each dom In dominioPais
                If dominioPais.Contains(dominio) Then
                    Console.WriteLine("El nombre del pais es: " & dominioPais(dominio))
                    Exit For
                Else
                    Console.WriteLine("No existe ese dominio.")
                    Exit For
                End If
            Next
        Loop
    End Sub

End Module
