Option Strict On
Option Explicit On
Option Compare Text

'Lane Coleman
'RCET0265
'Fall 2020
'Better Caculator
'https://github.com/colelane/BetterCalculatorLC.git

Module BetterCalculator

    Sub Main()
        Dim firstInput, secondInput, userResponse As String
        Dim firstNumber, secondNumber As Double
        Dim goodData As Boolean

        Do
            Console.WriteLine("Please enter two numbers. Enter q at any time to exit" & vbNewLine)
            Do
                Try
                    'The TryCatch is there to catch if any errors occur.  It 'tries' the inputs and if there is an error, the code moves to the catch area.
                    Console.WriteLine("Give me a number")
                    firstInput = Console.ReadLine()
                    firstNumber = CDbl(firstInput)
                    Console.WriteLine("Give me another number")
                    secondInput = Console.ReadLine()
                    secondNumber = CDbl(secondInput)
                    goodData = True
                Catch ex As Exception
                    'exit must be added here after the exception. q is caught as an exception, then the if statement handles it.
                    If firstInput = "q" Or secondInput = "q" Then
                        Quit()
                        Exit Sub
                    End If


                    Console.WriteLine("I asked for numbers! You entered: " _
                    & firstInput & " " & "&" & " " & secondInput & ". Try again.")
                    goodData = False
                    'goodData is a flag.  If there is a catch, the program loops and tries again to make it through without an error.
                End Try

            Loop Until goodData = True
            'loops until there is no catch

            Do
                Console.WriteLine("1.add" & vbNewLine &
                                  "2.subtract" & vbNewLine &
                                  "3.multiply" & vbNewLine &
                                  "4.divide" & vbNewLine)
                'vbnewline is a carriage return or enter. moves to the next line.
                userResponse = Console.ReadLine()
                If userResponse = "q" Then
                    Quit()
                    'could not put this in as an elseif, unsure why.
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

            Loop Until userResponse = "add" _
                    Or userResponse = "multiply" _
                    Or userResponse = "divide" _
                    Or userResponse = "subtract" _
                    Or userResponse = "1" _
                    Or userResponse = "2" _
                    Or userResponse = "3" _
                    Or userResponse = "4"
            Console.ReadLine()
            Console.Clear()
        Loop
        'clears the console and starts over so the calculator can be used again.

    End Sub

    Sub Quit()
        Console.WriteLine("You entered Q")
        Console.WriteLine("Have a nice day!")
        Console.WriteLine("Press enter to exit")
        Console.ReadLine()

    End Sub

End Module





