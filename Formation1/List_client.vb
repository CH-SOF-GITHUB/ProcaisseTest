Imports DevExpress.XtraEditors
Imports FormationModel

Public Class List_client

    Public Sub Remplir()

        Try
            ClientBindingSource.DataSource = ClientDAO.getInstance.GetAll()
        Catch ex As Exception

            XtraMessageBox.Show(ex.Message, "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub List_client_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Remplir()

    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        Select Case e.Button.Properties.Caption
            Case "Nouveau"
                Dim frm As New EditClient
                frm.Remplir()
                frm.Nouveau()
                If frm.ShowDialog() = DialogResult.OK Then
                    ClientBindingSource.Add(frm.cli)
                    GridView1.RefreshData()
                End If

            Case "Modifier"

                If GridView1.GetFocusedRow Is Nothing Then
                    Return
                End If
                Dim frm As New EditClient
                frm.Remplir()
                Dim sss As Client = ClientBindingSource.Current
                frm.Modifier(ClientBindingSource.Current)
                ' frm.ShowDialog()
                If frm.ShowDialog() <> DialogResult.OK Then
                    ClientBindingSource.Remove(ClientBindingSource.Current)
                    ClientBindingSource.Add(frm.cli)
                    GridView1.RefreshData()
                End If
            Case "Supprimer"
                If GridView1.GetFocusedRow Is Nothing Then
                    Return
                End If
                If XtraMessageBox.Show("Voulez-Vous supprimer client", "ASM-Pos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

                    Try
                        ClientBindingSource.Remove(ClientBindingSource.Current)
                        ClientDAO.getInstance().Delete(CType(ClientBindingSource.Current, Client).CLI_Code)
                    Catch ex As Exception
                        XtraMessageBox.Show(ex.Message, "ASM-Pos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                End If

            Case "fermer"
                Close()

        End Select


    End Sub

    Private Sub WindowsUIButtonPanel1_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel1.Click

    End Sub
End Class