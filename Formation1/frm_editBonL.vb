Imports DevExpress.XtraEditors
Imports FormationModel

Public Class frm_editBonL

    Public Sub Remplir()

        Try
            ClientBindingSource.DataSource = ClientDAO.getInstance.Find(New LUNA.LunaSearchParameter("CLI_Etat", "Actif", "="))
            ArticleBindingSource.DataSource = ArticleDAO.getInstance.GetAll
            EtatbonBindingSource.DataSource = Etat_bonDAO.getInstance.GetAll
        Catch ex As Exception

        End Try
    End Sub



    Private Sub frm_editBonL_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Dim bon As New Bon_livraison

    Dim IsNew As Boolean = True
    Public Sub Modifier(bn As Bon_livraison)

        bon = bn
        BonlivraisonBindingSource.DataSource = bon
        LignebonlivraisonBindingSource.DataSource = Ligne_bon_livraisonDAO.getInstance.Find(New LUNA.LunaSearchParameter("LG_BON_Liv_NumBon", bon.BON_LIV_Num, "="))
        IsNew = False




    End Sub

    Public Sub Nouveau()

        bon.BON_LIV_Date = Now
        BonlivraisonBindingSource.DataSource = bon
    End Sub

    Private Sub Btn_Fermer_Click(sender As Object, e As EventArgs) Handles Btn_Fermer.Click
        Close()
    End Sub

    Dim ligne As Ligne_bon_livraison
    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        If e.Column.Equals(colLG_BON_Liv_CodeArt) Then

            For Each ln As Ligne_bon_livraison In LignebonlivraisonBindingSource.List

                If Not ln.Equals(ligne) AndAlso ln.LG_BON_Liv_CodeArt = ligne.LG_BON_Liv_CodeArt Then
                    XtraMessageBox.Show("Article existe déjà")
                    LignebonlivraisonBindingSource.CancelEdit()
                    Return
                End If

            Next

            ligne.LG_BON_Liv_NumOrdre = LignebonlivraisonBindingSource.Count
            ligne.LG_BON_Liv_Qte = 1
            ligne.LG_BON_Liv_PUHT = ligne.ArticleMember.ART_PrixUnitaireHT
            ligne.LG_BON_Liv_Tva = ligne.ArticleMember.ART_TVA
            ligne.LG_BON_Liv_Remise = RemiseSpinEdit.EditValue
            ligne.LG_BON_Liv_PUTTC = ligne.LG_BON_Liv_PUHT * (1 + ligne.LG_BON_Liv_Tva / 100)
            ligne.LG_BON_Liv_TotalTTC = ligne.LG_BON_Liv_PUHT * (1 + ligne.LG_BON_Liv_Tva / 100)

        End If

        If e.Column.Equals(colLG_BON_Liv_Qte) Then
            If String.IsNullOrEmpty(ligne.LG_BON_Liv_CodeArt) Then
                XtraMessageBox.Show("Article Invalide")
                LignebonlivraisonBindingSource.CancelEdit()
                Return
            End If
            ligne.LG_BON_Liv_TotalTTC = ligne.LG_BON_Liv_PUTTC * ligne.LG_BON_Liv_Qte

        End If

        If e.Column.Equals(colLG_BON_Liv_PUHT) Then
            If String.IsNullOrEmpty(ligne.LG_BON_Liv_CodeArt) Then
                XtraMessageBox.Show("Article Invalide")
                LignebonlivraisonBindingSource.CancelEdit()
                Return
            End If
        End If

        If e.Column.Equals(colLG_BON_Liv_PUTTC) Then
            If String.IsNullOrEmpty(ligne.LG_BON_Liv_CodeArt) Then
                XtraMessageBox.Show("Article Invalide")
                LignebonlivraisonBindingSource.CancelEdit()
                Return
            End If
        End If

        If e.Column.Equals(colLG_BON_Liv_Remise) Then
            If String.IsNullOrEmpty(ligne.LG_BON_Liv_CodeArt) Then
                XtraMessageBox.Show("Article Invalide")
                LignebonlivraisonBindingSource.CancelEdit()
                Return
            End If
        End If

        If e.Column.Equals(colLG_BON_Liv_Tva) Then
            If String.IsNullOrEmpty(ligne.LG_BON_Liv_CodeArt) Then
                XtraMessageBox.Show("Article Invalide")
                LignebonlivraisonBindingSource.CancelEdit()
                Return
            End If
        End If


    End Sub

    Private Sub LignebonlivraisonBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles LignebonlivraisonBindingSource.CurrentChanged
        If LignebonlivraisonBindingSource.Current IsNot Nothing Then
            ligne = LignebonlivraisonBindingSource.Current
        End If

    End Sub

    Private Sub GridView1_ValidatingEditor(sender As Object, e As Controls.BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor

        If GridView1.FocusedColumn.Equals(colLG_BON_Liv_Qte) Then

            If e.Value < 1 Then
                e.ErrorText = "Quantité Invalide"
                e.Valid = False
            End If
        End If
    End Sub

    Private Sub GridView1_InvalidRowException(sender As Object, e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GridView1.InvalidRowException

    End Sub

    Private Sub GridView1_InvalidValueException(sender As Object, e As Controls.InvalidValueExceptionEventArgs) Handles GridView1.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub Btn_Valider_Click(sender As Object, e As EventArgs) Handles Btn_Valider.Click

        Try
            LignebonlivraisonBindingSource.EndEdit()
            BonlivraisonBindingSource.EndEdit()

            bon.BON_LIV_Exerc = Now.Year
            bon.BON_LIV_StationOrigine = "001"

            bon.BON_LIV_Montant = 0


            Ligne_bon_livraisonDAO.getInstance.DeleteByBon(bon.BON_LIV_Num)

            For Each ln As Ligne_bon_livraison In LignebonlivraisonBindingSource.List
                bon.BON_LIV_Montant = bon.BON_LIV_Montant + ln.LG_BON_Liv_TotalTTC

            Next

            If IsNew Then
                Bon_livraisonDAO.getInstance.Save(bon)
            Else
                Bon_livraisonDAO.getInstance.Update(bon)
            End If

            For Each ln As Ligne_bon_livraison In LignebonlivraisonBindingSource.List
                ln.LG_BON_Liv_NumBon = bon.BON_LIV_Num
                ln.LG_BON_Liv_Exerc = bon.BON_LIV_Exerc
                ln.LG_BON_Liv_Unite = "Pièce "
                Ligne_bon_livraisonDAO.getInstance.Save(ln)
            Next
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)

        End Try
        DialogResult = DialogResult.OK
        Close()

    End Sub
End Class