'Owen Fujii
'RCET 2265
'Spring 2024
'SayYourName
'https://github.com/Masaharu41/SayMyNameAgain.git

Option Explicit On
Option Strict On
Module SayMyNameAgain
    Sub Main()

        Dim userName As String
        'ask user for name
        Console.Write("What is your name?")
        Console.WriteLine()
        'Take user input
        userName = Console.ReadLine()
        'give specific outputs depending on the name input
        If userName = "Emily" Then
            Console.Write($"Pleasure to meet you {userName}!")
        ElseIf userName = "Joe" Then
            Console.Write($"Pleasure to meet you {userName}!")
        ElseIf userName = "Owen" Then
            Console.WriteLine("What kind of name is that!")
        ElseIf userName = "Tim" Then
            Console.Write("Which one, LoL!")
        Else
            Console.Write("Your name is not even worth mentioning >_<")
        End If

        Console.Read()

    End Sub

End Module
