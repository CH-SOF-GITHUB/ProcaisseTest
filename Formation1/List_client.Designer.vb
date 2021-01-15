<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_client
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions4 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.WindowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCLI_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCLI_NomPren = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCLI_MatFisc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCLI_Date_Cre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCLI_Etat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemToggleSwitch1 = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
        Me.colCLI_Adresse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCLI_Ville = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCLI_Tel1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClt_CIN = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WindowsUIButtonPanel1
        '
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Nouveau", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Modifier", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Supprimer", True, WindowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Fermer", True, WindowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.WindowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WindowsUIButtonPanel1.Location = New System.Drawing.Point(0, 623)
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Size = New System.Drawing.Size(1022, 105)
        Me.WindowsUIButtonPanel1.TabIndex = 0
        Me.WindowsUIButtonPanel1.Text = "WindowsUIButtonPanel1"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.ClientBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemToggleSwitch1})
        Me.GridControl1.Size = New System.Drawing.Size(998, 605)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataSource = GetType(FormationModel.Client)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCLI_Code, Me.colCLI_NomPren, Me.colCLI_MatFisc, Me.colCLI_Date_Cre, Me.colCLI_Etat, Me.colCLI_Adresse, Me.colCLI_Ville, Me.colCLI_Tel1, Me.colClt_CIN})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colCLI_Code
        '
        Me.colCLI_Code.Caption = "Code"
        Me.colCLI_Code.FieldName = "CLI_Code"
        Me.colCLI_Code.MinWidth = 25
        Me.colCLI_Code.Name = "colCLI_Code"
        Me.colCLI_Code.Visible = True
        Me.colCLI_Code.VisibleIndex = 0
        Me.colCLI_Code.Width = 94
        '
        'colCLI_NomPren
        '
        Me.colCLI_NomPren.Caption = "Nom"
        Me.colCLI_NomPren.FieldName = "CLI_NomPren"
        Me.colCLI_NomPren.MinWidth = 25
        Me.colCLI_NomPren.Name = "colCLI_NomPren"
        Me.colCLI_NomPren.Visible = True
        Me.colCLI_NomPren.VisibleIndex = 1
        Me.colCLI_NomPren.Width = 94
        '
        'colCLI_MatFisc
        '
        Me.colCLI_MatFisc.Caption = "M.Fiscale"
        Me.colCLI_MatFisc.FieldName = "CLI_MatFisc"
        Me.colCLI_MatFisc.MinWidth = 25
        Me.colCLI_MatFisc.Name = "colCLI_MatFisc"
        Me.colCLI_MatFisc.Visible = True
        Me.colCLI_MatFisc.VisibleIndex = 3
        Me.colCLI_MatFisc.Width = 94
        '
        'colCLI_Date_Cre
        '
        Me.colCLI_Date_Cre.Caption = "D.Création"
        Me.colCLI_Date_Cre.FieldName = "CLI_Date_Cre"
        Me.colCLI_Date_Cre.MinWidth = 25
        Me.colCLI_Date_Cre.Name = "colCLI_Date_Cre"
        Me.colCLI_Date_Cre.Visible = True
        Me.colCLI_Date_Cre.VisibleIndex = 4
        Me.colCLI_Date_Cre.Width = 94
        '
        'colCLI_Etat
        '
        Me.colCLI_Etat.Caption = "Actif"
        Me.colCLI_Etat.ColumnEdit = Me.RepositoryItemToggleSwitch1
        Me.colCLI_Etat.FieldName = "Actif"
        Me.colCLI_Etat.MinWidth = 25
        Me.colCLI_Etat.Name = "colCLI_Etat"
        Me.colCLI_Etat.Visible = True
        Me.colCLI_Etat.VisibleIndex = 8
        Me.colCLI_Etat.Width = 94
        '
        'RepositoryItemToggleSwitch1
        '
        Me.RepositoryItemToggleSwitch1.AutoHeight = False
        Me.RepositoryItemToggleSwitch1.Name = "RepositoryItemToggleSwitch1"
        Me.RepositoryItemToggleSwitch1.OffText = "Off"
        Me.RepositoryItemToggleSwitch1.OnText = "On"
        '
        'colCLI_Adresse
        '
        Me.colCLI_Adresse.Caption = "Adresse"
        Me.colCLI_Adresse.FieldName = "CLI_Adresse"
        Me.colCLI_Adresse.MinWidth = 25
        Me.colCLI_Adresse.Name = "colCLI_Adresse"
        Me.colCLI_Adresse.Visible = True
        Me.colCLI_Adresse.VisibleIndex = 5
        Me.colCLI_Adresse.Width = 94
        '
        'colCLI_Ville
        '
        Me.colCLI_Ville.Caption = "Ville"
        Me.colCLI_Ville.FieldName = "CLI_Ville"
        Me.colCLI_Ville.MinWidth = 25
        Me.colCLI_Ville.Name = "colCLI_Ville"
        Me.colCLI_Ville.Visible = True
        Me.colCLI_Ville.VisibleIndex = 6
        Me.colCLI_Ville.Width = 94
        '
        'colCLI_Tel1
        '
        Me.colCLI_Tel1.Caption = "Tel"
        Me.colCLI_Tel1.FieldName = "CLI_Tel1"
        Me.colCLI_Tel1.MinWidth = 25
        Me.colCLI_Tel1.Name = "colCLI_Tel1"
        Me.colCLI_Tel1.Visible = True
        Me.colCLI_Tel1.VisibleIndex = 7
        Me.colCLI_Tel1.Width = 94
        '
        'colClt_CIN
        '
        Me.colClt_CIN.Caption = "CIN"
        Me.colClt_CIN.FieldName = "Clt_CIN"
        Me.colClt_CIN.MinWidth = 25
        Me.colClt_CIN.Name = "colClt_CIN"
        Me.colClt_CIN.Visible = True
        Me.colClt_CIN.VisibleIndex = 2
        Me.colClt_CIN.Width = 94
        '
        'List_client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 728)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.WindowsUIButtonPanel1)
        Me.Name = "List_client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents colCLI_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLI_NomPren As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLI_MatFisc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLI_Date_Cre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLI_Etat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLI_Adresse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLI_Ville As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLI_Tel1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClt_CIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemToggleSwitch1 As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
End Class
