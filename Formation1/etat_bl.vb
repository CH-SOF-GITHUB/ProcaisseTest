Imports FormationModel
Public Class etat_bl

    Public Sub New(num As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        Dim lis As List(Of Ligne_bon_livraison) = Ligne_bon_livraisonDAO.getInstance.Find(New LUNA.LunaSearchParameter("LG_BON_Liv_NumBon", num, "="))
        BindingSource2.DataSource = lis
        ' Ajouter une initialisation quelconque après l'appel InitializeComponent().

    End Sub


End Class