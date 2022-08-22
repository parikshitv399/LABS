Public MustInherit Class Sample
    Public Overridable Sub VirtualMethod()
        Console.WriteLine("Sample.VirtualMethod()")
    End Sub
    Public MustOverride Function Add() As Integer
    Public Sub Normal()
        Console.WriteLine("A normal life")
    End Sub
End Class
Public Class SubClass
    Inherits Sample
    Public n1 As Integer
    Public Property Num1() As Integer
        Get
            Return n1
        End Get
        Set(ByVal value As Integer)
            n1 = value
        End Set
    End Property
    Public n2 As Integer
    Public Property Num2() As Integer
        Get
            Return n2
        End Get
        Set(ByVal value As Integer)
            n2 = value
        End Set
    End Property
    Public Overrides Sub VirtualMethod()
        Console.WriteLine("SubClass.VirtualMethod()")
        MyBase.VirtualMethod()
    End Sub

    Public Overrides Function Add() As Integer
        Return Num1 + Num2
    End Function

    Public Shadows Sub Normal()
        Console.WriteLine("An extravagant life")
    End Sub
End Class