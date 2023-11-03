Public Class Program
    Public Shared Sub Main(ByVal args As String())
        Console.WriteLine(MinCostClimbingStairs(New Integer() {10, 15, 20}))
    End Sub

    Public Shared Function MinCostClimbingStairs(ByVal cost As Integer()) As Integer
        Dim nums As List(Of Integer) = cost.ToList()
        Dim start = 0
        Dim skip = False
        Dim totalCost = 0

        While nums.Count > 2
            If Not skip Then
                If nums(1) < nums(0) Then
                    totalCost += nums(1)
                    nums.RemoveAt(0)
                    nums.RemoveAt(0)
                    skip = True
                Else
                    totalCost += nums(0)
                    nums.RemoveAt(0)
                    skip = False
                End If
            Else
                totalCost += nums(0)
                nums.RemoveAt(0)
                skip = False
            End If
        End While

        Return totalCost
    End Function
End Class