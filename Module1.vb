Module Module1
    'brooks keller
    '10/10/2023
    'demo 1: use ifs to determine if a person passes a class
    Sub Main()
        Dim score As Double
        Dim input As String
        Dim valid As Boolean

        Console.Write("please enter your course score >> ")
        input = Console.ReadLine
        valid = Double.TryParse(input, score) 'at this point valid holds true or false

        If Not valid Then
            Console.WriteLine("invalid input. score set to 0")
        End If

        'if the score if greater than 69, we will say you passed
        If score > 69 AndAlso score <= 100 Then
            Console.WriteLine("you passed!!")

        ElseIf score < 0 OrElse score > 100 Then 'use or so that only one expression must be true
            Console.WriteLine("that score isnt right")

        ElseIf score = 0 Then 'this is not evaluated if the previous statement was true
            Console.WriteLine("you really REALLY failed :skull:")

        Else 'this is not executed if a previous statement was true
            Console.WriteLine("you failed..")

        End If
        Console.Write("Your score was {0}", score.ToString("N2"))
    End Sub

End Module
