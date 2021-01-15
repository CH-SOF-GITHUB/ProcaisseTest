#Region "Author"
'Class created with Luna 3.0.12.18
'Author: Diego Lunadei
'Date: 1/4/2021
#End Region

Public Class Client

#Region "Logic Field"

    Private _Actif As Boolean

    Public Property Actif() As Boolean
        Get
            If CLI_Etat = "Actif" Then
                Return True
            Else
                Return False
            End If
        End Get
        Set(ByVal value As Boolean)
            If value Then
                CLI_Etat = "Actif"
            Else
                CLI_Etat = "Bloquer"

            End If
        End Set
    End Property

#End Region

#Region "Method"

#End Region

End Class

Public Class ClientDAO

#Region "Method"

#End Region

End Class

