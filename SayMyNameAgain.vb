'Owen Fujii
'RCET 2265
'Spring 2024
'SayYourName
'
Option Explicit On
Option Strict On
Module SayMyNameAgain


    Sub Main()

        Dim userName As String
        'Ask user for name
        Console.Write("What is your name?")
        Console.WriteLine()
        'Take user input
        userName = Console.ReadLine()
        'Give user output
        Console.Write($"Pleasure to meet you {userName}")

        Console.Read()
    End Sub

End Module
