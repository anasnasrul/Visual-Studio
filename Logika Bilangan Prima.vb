Module Module4
    Sub Main()
        Dim input As String = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49"

        Console.WriteLine(input)
        For Each kata In input.Split(", ")
            If kata Mod kata = 0 And kata Mod 2 = 0 And kata <> 2 Then
                Console.WriteLine(kata)
                Console.WriteLine("bukan bilangan prima")
            End If
            If kata Mod kata = 0 And kata Mod 2 <> 0 And kata Mod 3 = 0 And kata <> 3 Then
                Console.WriteLine(kata)
                Console.WriteLine("bukan bilangan prima")
            End If
            If kata Mod kata = 0 And kata Mod 2 <> 0 And kata Mod 5 = 0 And kata <> 5 Then
                Console.WriteLine(kata)
                Console.WriteLine("bukan bilangan prima")
            End If
            If kata Mod kata = 0 And kata Mod 2 <> 0 And kata Mod 7 = 0 And kata <> 7 Then
                Console.WriteLine(kata)
                Console.WriteLine("bukan bilangan prima")
            End If
        Next
        Console.ReadLine()
    End Sub
End Module
