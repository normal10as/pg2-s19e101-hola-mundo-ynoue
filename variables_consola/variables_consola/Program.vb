Imports System

Module variable


    Sub Main()
        Dim nombre As String
        Dim apellido As String
        Dim fechadenacimiento As Date

        Console.WriteLine("ingrese nombre: ")
        nombre = Console.ReadLine()
        Console.WriteLine("ingrese apellido: ")
        apellido = Console.ReadLine()
        Console.WriteLine("ingrese fecha de nacimiento: ")
        fechadenacimiento = Console.ReadLine()

        Console.WriteLine(apellido & " " & nombre & " nacio el " & fechadenacimiento)


    End Sub
End Module
