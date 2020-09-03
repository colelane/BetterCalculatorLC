Option Strict On
Option Explicit On
Option Compare Text

'Lane Coleman
'RCET0265
'Fall 2020
'Simple Calculator
'https://github.com/colelane/BetterCalculatorLC.git

Module BetterCalculator

    Sub Main()
        Dim firstInput, secondInput, userResponse As String
        Dim firstNumber, secondNumber As Integer
        Dim goodData As Boolean

        Do
            Console.WriteLine("Enter q at any time to exit" & vbNewLine)
            Do
                Try
                    Console.WriteLine("Give me a number")
                    firstInput = Console.ReadLine()
                    firstNumber = CInt(firstInput)
                    Console.WriteLine("Give me another number")
                    secondInput = Console.ReadLine()
                    secondNumber = CInt(secondInput)
                    goodData = True
                Catch ex As Exception
                    If firstInput = "q" Or secondInput = "q" Then Exit Sub
                    Console.WriteLine("I asked for a number! Try again.")
                    goodData = False
                End Try

            Loop Until goodData = True

            Do
                Console.WriteLine("1.add" & vbNewLine &
                                  "2.subtract" & vbNewLine &
                                  "3.multiply" & vbNewLine &
                                  "4.divide" & vbNewLine)
                userResponse = Console.ReadLine()
                If userResponse = "q" Then
                    Exit Sub

                ElseIf userResponse = "add" Or userResponse = "1" Then
                Console.WriteLine(vbNewLine & firstNumber & " + " & secondNumber & " = " & firstNumber + secondNumber)

                ElseIf userResponse = "subtract" Or userResponse = "2" Then
                    Console.WriteLine(vbNewLine & firstNumber & " - " & secondNumber & " = " & firstNumber - secondNumber)

                ElseIf userResponse = "multiply" Or userResponse = "3" Then
                    Console.WriteLine(vbNewLine & firstNumber & " * " & secondNumber & " = " & firstNumber * secondNumber)

                ElseIf userResponse = "divide" Or userResponse = "4" Then
                    Console.WriteLine(vbNewLine & firstNumber & " / " & secondNumber & " = " & firstNumber / secondNumber)

                ElseIf userResponse <> "multiply" _
                    And userResponse <> "add" _
                    And userResponse <> "divide" _
                    And userResponse <> "Subtract" _
                    And userResponse <> "1" _
                    And userResponse <> "2" _
                    And userResponse <> "3" _
                    And userResponse <> "4" _
                    Then

                    Console.WriteLine(vbNewLine & "Only add, subtract, multiply or divide will work")
                    Console.WriteLine("Or 1, 2, 3, or 4")

                End If

            Loop Until userResponse = "add" Or userResponse = "multiply" Or userResponse = "divide" Or userResponse = "subtract" Or userResponse = "1" Or userResponse = "2" Or userResponse = "3" Or userResponse = "4"
            Console.ReadLine()
            Console.Clear()
        Loop
    End Sub

End Module





