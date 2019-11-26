﻿Public MustInherit Class Operacao

    Private _valor1 As Integer
    Private _valor2 As Integer

    Sub New()
        _valor1 = 0
        _valor2 = 0
    End Sub

    Sub New(ByVal v1 As Integer, ByVal v2 As Integer)
        _valor1 = v1
        _valor2 = v2
    End Sub

    Public Property Valor1() As Integer
        Get
            Return _valor1
        End Get
        Set(ByVal value As Integer)
            _valor1 = value
        End Set
    End Property

    Public Property Valor2() As Integer
        Get
            Return _valor2
        End Get
        Set(ByVal value As Integer)
            _valor2 = value
        End Set
    End Property

    Public MustOverride Function Calcular() As Integer

End Class