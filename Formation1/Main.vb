Imports FormationModel

Public Class Main

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick


        Dim frm As New List_client
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Module_Parametrage.ChaineCNX = getChaineConnectFromXML()

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick

        Dim frm As New frm_list_bl
        frm.MdiParent = Me
        frm.Show()

    End Sub
End Class
