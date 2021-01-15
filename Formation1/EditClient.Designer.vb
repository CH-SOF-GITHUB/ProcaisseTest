<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditClient
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
        Dim CLI_CodeLabel As System.Windows.Forms.Label
        Dim CLI_AdresseLabel As System.Windows.Forms.Label
        Dim CLI_mailLabel As System.Windows.Forms.Label
        Dim CLI_ObsLabel As System.Windows.Forms.Label
        Dim CLI_Tel1Label As System.Windows.Forms.Label
        Dim CLI_VilleLabel As System.Windows.Forms.Label
        Dim ActifLabel As System.Windows.Forms.Label
        Dim Clt_CINLabel As System.Windows.Forms.Label
        Dim CLI_NomPrenLabel As System.Windows.Forms.Label
        Dim CLI_MatFiscLabel As System.Windows.Forms.Label
        Dim CLI_TypeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditClient))
        Me.CLI_CodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CLI_mailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CLI_Tel1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CLI_VilleTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Clt_CINTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CLI_NomPrenTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CLI_MatFiscTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ActifCheckEdit = New DevExpress.XtraEditors.ToggleSwitch()
        Me.CLI_AdresseTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.CLI_ObsTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.Btn_Valider = New DevExpress.XtraEditors.SimpleButton()
        Me.Btn_Fermer = New DevExpress.XtraEditors.SimpleButton()
        Me.CLI_TypeTextEdit = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTYP_Client = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypeclientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CLI_CodeLabel = New System.Windows.Forms.Label()
        CLI_AdresseLabel = New System.Windows.Forms.Label()
        CLI_mailLabel = New System.Windows.Forms.Label()
        CLI_ObsLabel = New System.Windows.Forms.Label()
        CLI_Tel1Label = New System.Windows.Forms.Label()
        CLI_VilleLabel = New System.Windows.Forms.Label()
        ActifLabel = New System.Windows.Forms.Label()
        Clt_CINLabel = New System.Windows.Forms.Label()
        CLI_NomPrenLabel = New System.Windows.Forms.Label()
        CLI_MatFiscLabel = New System.Windows.Forms.Label()
        CLI_TypeLabel = New System.Windows.Forms.Label()
        CType(Me.CLI_CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_mailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_Tel1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_VilleTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clt_CINTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_NomPrenTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_MatFiscTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_AdresseTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_ObsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLI_TypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeclientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CLI_CodeLabel
        '
        CLI_CodeLabel.AutoSize = True
        CLI_CodeLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CLI_CodeLabel.Location = New System.Drawing.Point(38, 12)
        CLI_CodeLabel.Name = "CLI_CodeLabel"
        CLI_CodeLabel.Size = New System.Drawing.Size(66, 23)
        CLI_CodeLabel.TabIndex = 1
        CLI_CodeLabel.Text = "Code"
        '
        'CLI_AdresseLabel
        '
        CLI_AdresseLabel.AutoSize = True
        CLI_AdresseLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CLI_AdresseLabel.Location = New System.Drawing.Point(38, 281)
        CLI_AdresseLabel.Name = "CLI_AdresseLabel"
        CLI_AdresseLabel.Size = New System.Drawing.Size(87, 23)
        CLI_AdresseLabel.TabIndex = 2
        CLI_AdresseLabel.Text = "Adresse"
        '
        'CLI_mailLabel
        '
        CLI_mailLabel.AutoSize = True
        CLI_mailLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CLI_mailLabel.Location = New System.Drawing.Point(423, 141)
        CLI_mailLabel.Name = "CLI_mailLabel"
        CLI_mailLabel.Size = New System.Drawing.Size(67, 23)
        CLI_mailLabel.TabIndex = 4
        CLI_mailLabel.Text = "E-Mail"
        '
        'CLI_ObsLabel
        '
        CLI_ObsLabel.AutoSize = True
        CLI_ObsLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CLI_ObsLabel.Location = New System.Drawing.Point(423, 282)
        CLI_ObsLabel.Name = "CLI_ObsLabel"
        CLI_ObsLabel.Size = New System.Drawing.Size(130, 23)
        CLI_ObsLabel.TabIndex = 6
        CLI_ObsLabel.Text = "Observation"
        '
        'CLI_Tel1Label
        '
        CLI_Tel1Label.AutoSize = True
        CLI_Tel1Label.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CLI_Tel1Label.Location = New System.Drawing.Point(38, 141)
        CLI_Tel1Label.Name = "CLI_Tel1Label"
        CLI_Tel1Label.Size = New System.Drawing.Size(36, 23)
        CLI_Tel1Label.TabIndex = 8
        CLI_Tel1Label.Text = "Tel"
        '
        'CLI_VilleLabel
        '
        CLI_VilleLabel.AutoSize = True
        CLI_VilleLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CLI_VilleLabel.Location = New System.Drawing.Point(38, 213)
        CLI_VilleLabel.Name = "CLI_VilleLabel"
        CLI_VilleLabel.Size = New System.Drawing.Size(51, 23)
        CLI_VilleLabel.TabIndex = 10
        CLI_VilleLabel.Text = "Ville"
        '
        'ActifLabel
        '
        ActifLabel.AutoSize = True
        ActifLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ActifLabel.Location = New System.Drawing.Point(423, 213)
        ActifLabel.Name = "ActifLabel"
        ActifLabel.Size = New System.Drawing.Size(59, 23)
        ActifLabel.TabIndex = 12
        ActifLabel.Text = "Actif:"
        '
        'Clt_CINLabel
        '
        Clt_CINLabel.AutoSize = True
        Clt_CINLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Clt_CINLabel.Location = New System.Drawing.Point(423, 81)
        Clt_CINLabel.Name = "Clt_CINLabel"
        Clt_CINLabel.Size = New System.Drawing.Size(46, 23)
        Clt_CINLabel.TabIndex = 14
        Clt_CINLabel.Text = "CIN"
        '
        'CLI_NomPrenLabel
        '
        CLI_NomPrenLabel.AutoSize = True
        CLI_NomPrenLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CLI_NomPrenLabel.Location = New System.Drawing.Point(38, 81)
        CLI_NomPrenLabel.Name = "CLI_NomPrenLabel"
        CLI_NomPrenLabel.Size = New System.Drawing.Size(74, 23)
        CLI_NomPrenLabel.TabIndex = 16
        CLI_NomPrenLabel.Text = "Intitulé"
        '
        'CLI_MatFiscLabel
        '
        CLI_MatFiscLabel.AutoSize = True
        CLI_MatFiscLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CLI_MatFiscLabel.Location = New System.Drawing.Point(423, 12)
        CLI_MatFiscLabel.Name = "CLI_MatFiscLabel"
        CLI_MatFiscLabel.Size = New System.Drawing.Size(115, 23)
        CLI_MatFiscLabel.TabIndex = 18
        CLI_MatFiscLabel.Text = "Matricule.F"
        '
        'CLI_TypeLabel
        '
        CLI_TypeLabel.AutoSize = True
        CLI_TypeLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        CLI_TypeLabel.Location = New System.Drawing.Point(423, 388)
        CLI_TypeLabel.Name = "CLI_TypeLabel"
        CLI_TypeLabel.Size = New System.Drawing.Size(56, 23)
        CLI_TypeLabel.TabIndex = 22
        CLI_TypeLabel.Text = "Type"
        '
        'CLI_CodeTextEdit
        '
        Me.CLI_CodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_Code", True))
        Me.CLI_CodeTextEdit.EnterMoveNextControl = True
        Me.CLI_CodeTextEdit.Location = New System.Drawing.Point(128, 12)
        Me.CLI_CodeTextEdit.Name = "CLI_CodeTextEdit"
        Me.CLI_CodeTextEdit.Size = New System.Drawing.Size(156, 22)
        Me.CLI_CodeTextEdit.TabIndex = 0
        '
        'CLI_mailTextEdit
        '
        Me.CLI_mailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_mail", True))
        Me.CLI_mailTextEdit.EnterMoveNextControl = True
        Me.CLI_mailTextEdit.Location = New System.Drawing.Point(553, 141)
        Me.CLI_mailTextEdit.Name = "CLI_mailTextEdit"
        Me.CLI_mailTextEdit.Size = New System.Drawing.Size(156, 22)
        Me.CLI_mailTextEdit.TabIndex = 5
        '
        'CLI_Tel1TextEdit
        '
        Me.CLI_Tel1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_Tel1", True))
        Me.CLI_Tel1TextEdit.EnterMoveNextControl = True
        Me.CLI_Tel1TextEdit.Location = New System.Drawing.Point(128, 141)
        Me.CLI_Tel1TextEdit.Name = "CLI_Tel1TextEdit"
        Me.CLI_Tel1TextEdit.Size = New System.Drawing.Size(156, 22)
        Me.CLI_Tel1TextEdit.TabIndex = 4
        '
        'CLI_VilleTextEdit
        '
        Me.CLI_VilleTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_Ville", True))
        Me.CLI_VilleTextEdit.EnterMoveNextControl = True
        Me.CLI_VilleTextEdit.Location = New System.Drawing.Point(128, 213)
        Me.CLI_VilleTextEdit.Name = "CLI_VilleTextEdit"
        Me.CLI_VilleTextEdit.Size = New System.Drawing.Size(156, 22)
        Me.CLI_VilleTextEdit.TabIndex = 6
        '
        'Clt_CINTextEdit
        '
        Me.Clt_CINTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "Clt_CIN", True))
        Me.Clt_CINTextEdit.EnterMoveNextControl = True
        Me.Clt_CINTextEdit.Location = New System.Drawing.Point(553, 81)
        Me.Clt_CINTextEdit.Name = "Clt_CINTextEdit"
        Me.Clt_CINTextEdit.Size = New System.Drawing.Size(156, 22)
        Me.Clt_CINTextEdit.TabIndex = 3
        '
        'CLI_NomPrenTextEdit
        '
        Me.CLI_NomPrenTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_NomPren", True))
        Me.CLI_NomPrenTextEdit.EnterMoveNextControl = True
        Me.CLI_NomPrenTextEdit.Location = New System.Drawing.Point(128, 81)
        Me.CLI_NomPrenTextEdit.Name = "CLI_NomPrenTextEdit"
        Me.CLI_NomPrenTextEdit.Size = New System.Drawing.Size(156, 22)
        Me.CLI_NomPrenTextEdit.TabIndex = 2
        '
        'CLI_MatFiscTextEdit
        '
        Me.CLI_MatFiscTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_MatFisc", True))
        Me.CLI_MatFiscTextEdit.EnterMoveNextControl = True
        Me.CLI_MatFiscTextEdit.Location = New System.Drawing.Point(553, 12)
        Me.CLI_MatFiscTextEdit.Name = "CLI_MatFiscTextEdit"
        Me.CLI_MatFiscTextEdit.Size = New System.Drawing.Size(156, 22)
        Me.CLI_MatFiscTextEdit.TabIndex = 1
        '
        'ActifCheckEdit
        '
        Me.ActifCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "Actif", True))
        Me.ActifCheckEdit.EnterMoveNextControl = True
        Me.ActifCheckEdit.Location = New System.Drawing.Point(584, 212)
        Me.ActifCheckEdit.Name = "ActifCheckEdit"
        Me.ActifCheckEdit.Properties.OffText = "Non"
        Me.ActifCheckEdit.Properties.OnText = "Oui"
        Me.ActifCheckEdit.Size = New System.Drawing.Size(94, 24)
        Me.ActifCheckEdit.TabIndex = 7
        '
        'CLI_AdresseTextEdit
        '
        Me.CLI_AdresseTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_Adresse", True))
        Me.CLI_AdresseTextEdit.Location = New System.Drawing.Point(128, 281)
        Me.CLI_AdresseTextEdit.Name = "CLI_AdresseTextEdit"
        Me.CLI_AdresseTextEdit.Size = New System.Drawing.Size(156, 88)
        Me.CLI_AdresseTextEdit.TabIndex = 8
        '
        'CLI_ObsTextEdit
        '
        Me.CLI_ObsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_Obs", True))
        Me.CLI_ObsTextEdit.Location = New System.Drawing.Point(553, 282)
        Me.CLI_ObsTextEdit.Name = "CLI_ObsTextEdit"
        Me.CLI_ObsTextEdit.Size = New System.Drawing.Size(156, 88)
        Me.CLI_ObsTextEdit.TabIndex = 9
        '
        'Btn_Valider
        '
        Me.Btn_Valider.ImageOptions.Image = CType(resources.GetObject("Btn_Valider.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Valider.Location = New System.Drawing.Point(189, 431)
        Me.Btn_Valider.Name = "Btn_Valider"
        Me.Btn_Valider.Size = New System.Drawing.Size(131, 44)
        Me.Btn_Valider.TabIndex = 19
        Me.Btn_Valider.Text = "Valider"
        '
        'Btn_Fermer
        '
        Me.Btn_Fermer.ImageOptions.Image = CType(resources.GetObject("Btn_Fermer.ImageOptions.Image"), System.Drawing.Image)
        Me.Btn_Fermer.Location = New System.Drawing.Point(445, 431)
        Me.Btn_Fermer.Name = "Btn_Fermer"
        Me.Btn_Fermer.Size = New System.Drawing.Size(131, 44)
        Me.Btn_Fermer.TabIndex = 20
        Me.Btn_Fermer.Text = "Fermer"
        '
        'CLI_TypeTextEdit
        '
        Me.CLI_TypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientBindingSource, "CLI_Type", True))
        Me.CLI_TypeTextEdit.EnterMoveNextControl = True
        Me.CLI_TypeTextEdit.Location = New System.Drawing.Point(553, 391)
        Me.CLI_TypeTextEdit.Name = "CLI_TypeTextEdit"
        Me.CLI_TypeTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CLI_TypeTextEdit.Properties.DataSource = Me.TypeclientBindingSource
        Me.CLI_TypeTextEdit.Properties.DisplayMember = "TYP_Client"
        Me.CLI_TypeTextEdit.Properties.NullText = ""
        Me.CLI_TypeTextEdit.Properties.PopupView = Me.GridLookUpEdit1View
        Me.CLI_TypeTextEdit.Properties.ValueMember = "TYP_Client"
        Me.CLI_TypeTextEdit.Size = New System.Drawing.Size(156, 22)
        Me.CLI_TypeTextEdit.TabIndex = 11
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTYP_Client})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colTYP_Client
        '
        Me.colTYP_Client.Caption = "Type"
        Me.colTYP_Client.FieldName = "TYP_Client"
        Me.colTYP_Client.Name = "colTYP_Client"
        Me.colTYP_Client.Visible = True
        Me.colTYP_Client.VisibleIndex = 0
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataSource = GetType(FormationModel.Client)
        '
        'TypeclientBindingSource
        '
        Me.TypeclientBindingSource.DataSource = GetType(FormationModel.Type_client)
        '
        'EditClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 497)
        Me.Controls.Add(CLI_TypeLabel)
        Me.Controls.Add(Me.Btn_Fermer)
        Me.Controls.Add(Me.Btn_Valider)
        Me.Controls.Add(CLI_MatFiscLabel)
        Me.Controls.Add(Me.CLI_MatFiscTextEdit)
        Me.Controls.Add(CLI_NomPrenLabel)
        Me.Controls.Add(Me.CLI_NomPrenTextEdit)
        Me.Controls.Add(Clt_CINLabel)
        Me.Controls.Add(Me.Clt_CINTextEdit)
        Me.Controls.Add(ActifLabel)
        Me.Controls.Add(CLI_VilleLabel)
        Me.Controls.Add(Me.CLI_VilleTextEdit)
        Me.Controls.Add(CLI_Tel1Label)
        Me.Controls.Add(Me.CLI_Tel1TextEdit)
        Me.Controls.Add(CLI_ObsLabel)
        Me.Controls.Add(CLI_mailLabel)
        Me.Controls.Add(Me.CLI_mailTextEdit)
        Me.Controls.Add(CLI_AdresseLabel)
        Me.Controls.Add(CLI_CodeLabel)
        Me.Controls.Add(Me.CLI_CodeTextEdit)
        Me.Controls.Add(Me.ActifCheckEdit)
        Me.Controls.Add(Me.CLI_AdresseTextEdit)
        Me.Controls.Add(Me.CLI_ObsTextEdit)
        Me.Controls.Add(Me.CLI_TypeTextEdit)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(779, 537)
        Me.MinimumSize = New System.Drawing.Size(779, 537)
        Me.Name = "EditClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditClient"
        CType(Me.CLI_CodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_mailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_Tel1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_VilleTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clt_CINTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_NomPrenTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_MatFiscTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_AdresseTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_ObsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLI_TypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeclientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents CLI_CodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CLI_mailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CLI_Tel1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CLI_VilleTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Clt_CINTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CLI_NomPrenTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CLI_MatFiscTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ActifCheckEdit As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents CLI_AdresseTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents CLI_ObsTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Btn_Valider As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Btn_Fermer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CLI_TypeTextEdit As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TypeclientBindingSource As BindingSource
    Friend WithEvents colTYP_Client As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
