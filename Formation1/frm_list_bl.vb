Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports FormationModel

Public Class frm_list_bl

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        DateEditDu.EditValue = Now
        DateEditAu.EditValue = Now

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub Remplir()
        Try
            BonlivraisonBindingSource.DataSource = Bon_livraisonDAO.getInstance.Find(New LUNA.LunaSearchParameter("convert(date,BON_LIV_Date,103)", DateEditDu.EditValue, ">="), New LUNA.LunaSearchParameter("convert(date,BON_LIV_Date,103)", DateEditAu.EditValue, "<="))

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Remplir()
    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        Select Case e.Button.Properties.Caption
            Case "Nouveau"
                Dim frm As New frm_editBonL
                frm.Remplir()
                frm.Nouveau()
                frm.ShowDialog()
                If frm.ShowDialog() = DialogResult.OK Then
                    Remplir()
                End If

            Case "Modifier"
                Dim frm As New frm_editBonL
                Dim b As Bon_livraison = Bon_livraisonDAO.getInstance.Read(CType(BonlivraisonBindingSource.Current, Bon_livraison).BON_LIV_Num)
                frm.Remplir()
                frm.Modifier(b)
                If frm.ShowDialog() = DialogResult.OK Then
                    Remplir()
                End If
                'Dim frm As New EditClient
                'frm.Remplir()
                'Dim sss As Client = ClientBindingSource.Current
                'frm.Modifier(ClientBindingSource.Current)
                '' frm.ShowDialog()
                'If frm.ShowDialog() <> DialogResult.OK Then
                '    ClientBindingSource.Remove(ClientBindingSource.Current)
                '    ClientBindingSource.Add(frm.cli)
                '    GridView1.RefreshData()
                'End If
            Case "Supprimer"
                Dim rpt As New etat_bl(CType(BonlivraisonBindingSource.Current, Bon_livraison).BON_LIV_Num)
                rpt.ShowPreviewMarginLines = False
                rpt.ShowPrintMarginsWarning = False
                rpt.ShowPrintStatusDialog = False
                rpt.ShowPreview()
                'If XtraMessageBox.Show("Voulez-Vous supprimer client", "ASM-Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

                '    Try
                '        ClientBindingSource.Remove(ClientBindingSource.Current)
                '        ClientDAO.getInstance().Delete(CType(ClientBindingSource.Current, Client).CLI_Code)
                '    Catch ex As Exception
                '        XtraMessageBox.Show(ex.Message, "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    End Try

                'End If

            Case "fermer"
                Close()

        End Select


    End Sub

    Private Sub frm_list_bl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class