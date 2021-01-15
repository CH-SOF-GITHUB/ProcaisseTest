<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_list_bl
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.BonlivraisonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBON_LIV_CodeClient = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBON_LIV_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBON_LIV_Etat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBON_LIV_Montant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBON_LIV_Num = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemToggleSwitch1 = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
        Me.WindowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEditAu = New DevExpress.XtraEditors.DateEdit()
        Me.DateEditDu = New DevExpress.XtraEditors.DateEdit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BonlivraisonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.DateEditAu.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditAu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditDu.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditDu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.BonlivraisonBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(10, 170)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemToggleSwitch1})
        Me.GridControl1.Size = New System.Drawing.Size(1448, 485)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'BonlivraisonBindingSource
        '
        Me.BonlivraisonBindingSource.DataSource = GetType(FormationModel.Bon_livraison)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBON_LIV_CodeClient, Me.colBON_LIV_Date, Me.colBON_LIV_Etat, Me.colBON_LIV_Montant, Me.colBON_LIV_Num})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'colBON_LIV_CodeClient
        '
        Me.colBON_LIV_CodeClient.Caption = "Client"
        Me.colBON_LIV_CodeClient.FieldName = "Clientmemebr.CLI_NomPren"
        Me.colBON_LIV_CodeClient.MinWidth = 25
        Me.colBON_LIV_CodeClient.Name = "colBON_LIV_CodeClient"
        Me.colBON_LIV_CodeClient.Visible = True
        Me.colBON_LIV_CodeClient.VisibleIndex = 2
        Me.colBON_LIV_CodeClient.Width = 94
        '
        'colBON_LIV_Date
        '
        Me.colBON_LIV_Date.Caption = "Date"
        Me.colBON_LIV_Date.FieldName = "BON_LIV_Date"
        Me.colBON_LIV_Date.MinWidth = 25
        Me.colBON_LIV_Date.Name = "colBON_LIV_Date"
        Me.colBON_LIV_Date.Visible = True
        Me.colBON_LIV_Date.VisibleIndex = 1
        Me.colBON_LIV_Date.Width = 94
        '
        'colBON_LIV_Etat
        '
        Me.colBON_LIV_Etat.Caption = "Etat"
        Me.colBON_LIV_Etat.FieldName = "BON_LIV_Etat"
        Me.colBON_LIV_Etat.MinWidth = 25
        Me.colBON_LIV_Etat.Name = "colBON_LIV_Etat"
        Me.colBON_LIV_Etat.Visible = True
        Me.colBON_LIV_Etat.VisibleIndex = 3
        Me.colBON_LIV_Etat.Width = 94
        '
        'colBON_LIV_Montant
        '
        Me.colBON_LIV_Montant.Caption = "Montant"
        Me.colBON_LIV_Montant.FieldName = "BON_LIV_Montant"
        Me.colBON_LIV_Montant.MinWidth = 25
        Me.colBON_LIV_Montant.Name = "colBON_LIV_Montant"
        Me.colBON_LIV_Montant.Visible = True
        Me.colBON_LIV_Montant.VisibleIndex = 4
        Me.colBON_LIV_Montant.Width = 94
        '
        'colBON_LIV_Num
        '
        Me.colBON_LIV_Num.Caption = "N°"
        Me.colBON_LIV_Num.FieldName = "BON_LIV_Num"
        Me.colBON_LIV_Num.MinWidth = 25
        Me.colBON_LIV_Num.Name = "colBON_LIV_Num"
        Me.colBON_LIV_Num.Visible = True
        Me.colBON_LIV_Num.VisibleIndex = 0
        Me.colBON_LIV_Num.Width = 94
        '
        'RepositoryItemToggleSwitch1
        '
        Me.RepositoryItemToggleSwitch1.AutoHeight = False
        Me.RepositoryItemToggleSwitch1.Name = "RepositoryItemToggleSwitch1"
        Me.RepositoryItemToggleSwitch1.OffText = "Off"
        Me.RepositoryItemToggleSwitch1.OnText = "On"
        '
        'WindowsUIButtonPanel1
        '
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Nouveau", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Modifier", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Supprimer", True, WindowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Fermer", True, WindowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.WindowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WindowsUIButtonPanel1.Location = New System.Drawing.Point(0, 661)
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Size = New System.Drawing.Size(1469, 105)
        Me.WindowsUIButtonPanel1.TabIndex = 2
        Me.WindowsUIButtonPanel1.Text = "WindowsUIButtonPanel1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.DateEditAu)
        Me.GroupControl1.Controls.Add(Me.DateEditDu)
        Me.GroupControl1.Location = New System.Drawing.Point(10, 57)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1448, 106)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Recherche"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(639, 60)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(142, 37)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "Actualiser"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(322, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 23)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Au"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(24, 60)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 23)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Du"
        '
        'DateEditAu
        '
        Me.DateEditAu.EditValue = Nothing
        Me.DateEditAu.Location = New System.Drawing.Point(375, 61)
        Me.DateEditAu.Name = "DateEditAu"
        Me.DateEditAu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditAu.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditAu.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI
        Me.DateEditAu.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEditAu.Size = New System.Drawing.Size(207, 22)
        Me.DateEditAu.TabIndex = 1
        '
        'DateEditDu
        '
        Me.DateEditDu.EditValue = Nothing
        Me.DateEditDu.Location = New System.Drawing.Point(77, 60)
        Me.DateEditDu.Name = "DateEditDu"
        Me.DateEditDu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditDu.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditDu.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI
        Me.DateEditDu.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEditDu.Size = New System.Drawing.Size(207, 22)
        Me.DateEditDu.TabIndex = 0
        '
        'frm_list_bl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1469, 766)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.WindowsUIButtonPanel1)
        Me.Name = "frm_list_bl"
        Me.Text = "frm_list_bl"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BonlivraisonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.DateEditAu.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditAu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditDu.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditDu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemToggleSwitch1 As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DateEditAu As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEditDu As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BonlivraisonBindingSource As BindingSource
    Friend WithEvents colBON_LIV_CodeClient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBON_LIV_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBON_LIV_Etat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBON_LIV_Montant As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBON_LIV_Num As DevExpress.XtraGrid.Columns.GridColumn
End Class
