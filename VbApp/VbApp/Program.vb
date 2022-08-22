Imports System

Module Program
    Sub Main(args As String())
        ReadWrite()
        Print(GetNames())

    End Sub

    Private Sub ReadWrite()
        Console.WriteLine("Add comma separated inputs")
        Dim input As String = Console.ReadLine()
        Dim arr As String() = input.Split(",")
        For Each item As String In arr
            If item.Contains("zzz") Then
                Exit For
            End If
            Console.WriteLine(item)
        Next
    End Sub

    Public Function GetNames() As List(Of String)
        Dim lst As New List(Of String)
        lst.Add("Eena")
        lst.Add("Meena")
        lst.Add("Deeka")
        Return lst
    End Function

    Public Sub Print(lst As List(Of String))
        For Each item As String In lst
            Console.WriteLine(item)
        Next

        Dim abc As New SubClass With {.Num1 = 100, .Num2 = 200}
        Console.WriteLine($"{abc.Add()}")
        abc.VirtualMethod()
        abc.Normal()
    End Sub
End Module
