Public Class Program
    Public Shared Sub Main(ByVal args As String())
        Console.WriteLine(Rob(New Integer() {1, 2, 3, 1}))
    End Sub

    Public Shared Function Rob(ByVal nums As Integer()) As Integer
        Dim len = nums.Length
        Dim memo = New Integer(len + 1 - 1) {}
        memo(0) = 0
        memo(1) = nums(0)
        For i = 1 To len - 1
            memo(i + 1) = Math.Max(memo(i), memo(i - 1) + nums(i))
        Next

        Return memo(len)
    End Function
End Class