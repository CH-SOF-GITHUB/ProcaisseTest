Imports DevExpress.XtraEditors
Imports FormationModel

Public Class EditClient
    Dim IsNew As Boolean = True

    Private Sub CLI_CodeTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles CLI_CodeTextEdit.EditValueChanged

    End Sub

    Public Sub Remplir()
        Try
            TypeclientBindingSource.DataSource = Type_clientDAO.getInstance().GetAll()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Nouveau()

        Dim cl As New Client
        cl.CLI_Etat = "Actif"
        cl.CLI_Type = "Passager"


        ClientBindingSource.DataSource = cl

    End Sub

    Public Sub Modifier(cl As Client)

        cli = cl
        ClientBindingSource.DataSource = cli
        IsNew = False

    End Sub

    Private Sub EditClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub Btn_Fermer_Click(sender As Object, e As EventArgs) Handles Btn_Fermer.Click
        Close()
    End Sub

    Public cli As Client
    Private Sub Btn_Valider_Click(sender As Object, e As EventArgs) Handles Btn_Valider.Click

        Try
            If String.IsNullOrEmpty(CLI_CodeTextEdit.EditValue) Then

                DxErrorProvider1.SetError(CLI_CodeTextEdit, "Code obligatoire")
            End If

            If DxErrorProvider1.HasErrors Then
                DxErrorProvider1 = New DXErrorProvider.DXErrorProvider()
                Return
            End If

            ClientBindingSource.EndEdit()
            cli = ClientBindingSource.Current
            cli.CLI_Date_Cre = Now
            If IsNew Then
                ClientDAO.getInstance.Save(cli)
            Else
                ClientDAO.getInstance.Update(cli)
            End If


            DialogResult = DialogResult.OK

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub EditClient_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub EditClient_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If DialogResult <> DialogResult.OK Then
            cli = ClientDAO.getInstance.Read(cli.CLI_Code)
        End If
    End Sub
End Class