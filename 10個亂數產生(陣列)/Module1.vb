Module Module1

    Sub Main()
        Randomize()
        Dim a(9) As Integer
        Dim x, y, j As Integer
        Dim max, min As Integer
        Dim str As String
        str = ""
        min = 100
        x = 0
        For x = 0 To 9
            a(x) = Int(Rnd() * 100) + 0
            str = a(x) & "," & str
            y = a(x) + y
            If a(x) > max Then max = a(x)
            If a(x) < min Then min = a(x)
        Next
        Console.WriteLine("[" & str & "]")
        Console.WriteLine("最大值" & max)
        Console.WriteLine("最小值" & min)
        Console.WriteLine("總和" & y)
        Console.Read()
    End Sub

End Module
