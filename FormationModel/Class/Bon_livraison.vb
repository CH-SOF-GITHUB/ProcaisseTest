#Region "Author"
'Class created with Luna 3.0.12.18
'Author: Diego Lunadei
'Date: 1/4/2021
#End Region

Public Class Bon_livraison

#Region "Logic Field"

    Public ReadOnly Property Clientmemebr() As Client
        Get
            Return ClientDAO.getInstance.Read(BON_LIV_CodeClient)
        End Get

    End Property

#End Region

#Region "Method"

#End Region

End Class

Public Class Bon_livraisonDAO

#Region "Method"

#End Region

End Class

