﻿Imports OrdenamientoXML

Public Class I_Tipos

    Private _tipos As List(Of I_Tipo)

    Public Property Tipos As List(Of I_Tipo)
        Get
            Return _tipos
        End Get
        Set(value As List(Of I_Tipo))
            _tipos = value
        End Set
    End Property

End Class