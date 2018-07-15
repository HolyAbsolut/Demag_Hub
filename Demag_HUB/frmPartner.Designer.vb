<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPartner
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPartner))
        Dim Tango_IDLabel As System.Windows.Forms.Label
        Dim ICM_IDLabel As System.Windows.Forms.Label
        Dim PartnerNameLabel As System.Windows.Forms.Label
        Me.DsDemag_HUB = New Demag_HUB.dsDemag_HUB()
        Me.DsPartnerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPartnerTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsPartnerTableAdapter()
        Me.TableAdapterManager = New Demag_HUB.dsDemag_HUBTableAdapters.TableAdapterManager()
        Me.DsPartnerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.DsPartnerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tango_IDTextBox = New System.Windows.Forms.TextBox()
        Me.ICM_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PartnerNameTextBox = New System.Windows.Forms.TextBox()
        Me.DsContactBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContactTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsContactTableAdapter()
        Me.DsAddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAddressTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsAddressTableAdapter()
        Me.DsContactBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContactDataGridView = New System.Windows.Forms.DataGridView()
        Me.DsAddressBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAddressDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Tango_IDLabel = New System.Windows.Forms.Label()
        ICM_IDLabel = New System.Windows.Forms.Label()
        PartnerNameLabel = New System.Windows.Forms.Label()
        CType(Me.DsDemag_HUB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPartnerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPartnerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DsPartnerBindingNavigator.SuspendLayout()
        CType(Me.DsContactBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContactBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContactDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAddressBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAddressDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsDemag_HUB
        '
        Me.DsDemag_HUB.DataSetName = "dsDemag_HUB"
        Me.DsDemag_HUB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsPartnerBindingSource
        '
        Me.DsPartnerBindingSource.DataMember = "dsPartner"
        Me.DsPartnerBindingSource.DataSource = Me.DsDemag_HUB
        '
        'DsPartnerTableAdapter
        '
        Me.DsPartnerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CountryCodesTableAdapter = Nothing
        Me.TableAdapterManager.dsAddressTableAdapter = Me.DsAddressTableAdapter
        Me.TableAdapterManager.dsAliasTableAdapter = Nothing
        Me.TableAdapterManager.dsCommentTableAdapter = Nothing
        Me.TableAdapterManager.dsContactTableAdapter = Me.DsContactTableAdapter
        Me.TableAdapterManager.dsContainerTableAdapter = Nothing
        Me.TableAdapterManager.dsEventTableAdapter = Nothing
        Me.TableAdapterManager.dsDocumentsTableAdapter = Nothing
        Me.TableAdapterManager.dsLocTranslateTableAdapter = Nothing
        Me.TableAdapterManager.dsPartnerTableAdapter = Me.DsPartnerTableAdapter
        Me.TableAdapterManager.dsRoleTableAdapter = Nothing
        Me.TableAdapterManager.dsShipment_OrderTableAdapter = Nothing
        Me.TableAdapterManager.dsShipment_SOTableAdapter = Nothing
        Me.TableAdapterManager.dsShipmentsTableAdapter = Nothing
        Me.TableAdapterManager.IncotermTableAdapter = Nothing
        Me.TableAdapterManager.poOrderTableAdapter = Nothing
        Me.TableAdapterManager.poShipping_OrderTableAdapter = Nothing
        Me.TableAdapterManager.poSO_OrderTableAdapter = Nothing
        Me.TableAdapterManager.ptContainerTableAdapter = Nothing
        Me.TableAdapterManager.ptShipmentsTableAdapter = Nothing
        Me.TableAdapterManager.rtCarrier_RatesTableAdapter = Nothing
        Me.TableAdapterManager.rtCharge_CodeTableAdapter = Nothing
        Me.TableAdapterManager.rtRatesTableAdapter = Nothing
        Me.TableAdapterManager.rtShipments_ChargesTableAdapter = Nothing
        Me.TableAdapterManager.stSettingsTableAdapter = Nothing
        Me.TableAdapterManager.SubdivisionCodesTableAdapter = Nothing
        Me.TableAdapterManager.UNLOCTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Demag_HUB.dsDemag_HUBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DsPartnerBindingNavigator
        '
        Me.DsPartnerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DsPartnerBindingNavigator.BindingSource = Me.DsPartnerBindingSource
        Me.DsPartnerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DsPartnerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DsPartnerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DsPartnerBindingNavigatorSaveItem})
        Me.DsPartnerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DsPartnerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DsPartnerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DsPartnerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DsPartnerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DsPartnerBindingNavigator.Name = "DsPartnerBindingNavigator"
        Me.DsPartnerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DsPartnerBindingNavigator.Size = New System.Drawing.Size(869, 25)
        Me.DsPartnerBindingNavigator.TabIndex = 0
        Me.DsPartnerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Erste verschieben"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Aktuelle Position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Neu hinzufügen"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Löschen"
        '
        'DsPartnerBindingNavigatorSaveItem
        '
        Me.DsPartnerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DsPartnerBindingNavigatorSaveItem.Image = CType(resources.GetObject("DsPartnerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DsPartnerBindingNavigatorSaveItem.Name = "DsPartnerBindingNavigatorSaveItem"
        Me.DsPartnerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DsPartnerBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'Tango_IDLabel
        '
        Tango_IDLabel.AutoSize = True
        Tango_IDLabel.Location = New System.Drawing.Point(7, 57)
        Tango_IDLabel.Name = "Tango_IDLabel"
        Tango_IDLabel.Size = New System.Drawing.Size(55, 13)
        Tango_IDLabel.TabIndex = 5
        Tango_IDLabel.Text = "Tango ID:"
        '
        'Tango_IDTextBox
        '
        Me.Tango_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPartnerBindingSource, "Tango_ID", True))
        Me.Tango_IDTextBox.Location = New System.Drawing.Point(88, 54)
        Me.Tango_IDTextBox.Name = "Tango_IDTextBox"
        Me.Tango_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tango_IDTextBox.TabIndex = 6
        '
        'ICM_IDLabel
        '
        ICM_IDLabel.AutoSize = True
        ICM_IDLabel.Location = New System.Drawing.Point(7, 83)
        ICM_IDLabel.Name = "ICM_IDLabel"
        ICM_IDLabel.Size = New System.Drawing.Size(43, 13)
        ICM_IDLabel.TabIndex = 7
        ICM_IDLabel.Text = "ICM ID:"
        '
        'ICM_IDTextBox
        '
        Me.ICM_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPartnerBindingSource, "ICM_ID", True))
        Me.ICM_IDTextBox.Location = New System.Drawing.Point(88, 80)
        Me.ICM_IDTextBox.Name = "ICM_IDTextBox"
        Me.ICM_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ICM_IDTextBox.TabIndex = 8
        '
        'PartnerNameLabel
        '
        PartnerNameLabel.AutoSize = True
        PartnerNameLabel.Location = New System.Drawing.Point(7, 31)
        PartnerNameLabel.Name = "PartnerNameLabel"
        PartnerNameLabel.Size = New System.Drawing.Size(75, 13)
        PartnerNameLabel.TabIndex = 9
        PartnerNameLabel.Text = "Partner Name:"
        '
        'PartnerNameTextBox
        '
        Me.PartnerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPartnerBindingSource, "PartnerName", True))
        Me.PartnerNameTextBox.Location = New System.Drawing.Point(88, 28)
        Me.PartnerNameTextBox.Name = "PartnerNameTextBox"
        Me.PartnerNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PartnerNameTextBox.TabIndex = 10
        '
        'DsContactBindingSource
        '
        Me.DsContactBindingSource.DataMember = "dsContact"
        Me.DsContactBindingSource.DataSource = Me.DsDemag_HUB
        '
        'DsContactTableAdapter
        '
        Me.DsContactTableAdapter.ClearBeforeFill = True
        '
        'DsAddressBindingSource
        '
        Me.DsAddressBindingSource.DataMember = "dsAddress"
        Me.DsAddressBindingSource.DataSource = Me.DsDemag_HUB
        '
        'DsAddressTableAdapter
        '
        Me.DsAddressTableAdapter.ClearBeforeFill = True
        '
        'DsContactBindingSource1
        '
        Me.DsContactBindingSource1.DataMember = "dsPartnerdsContact"
        Me.DsContactBindingSource1.DataSource = Me.DsPartnerBindingSource
        '
        'DsContactDataGridView
        '
        Me.DsContactDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DsContactDataGridView.AutoGenerateColumns = False
        Me.DsContactDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsContactDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DsContactDataGridView.DataSource = Me.DsContactBindingSource1
        Me.DsContactDataGridView.Location = New System.Drawing.Point(12, 106)
        Me.DsContactDataGridView.Name = "DsContactDataGridView"
        Me.DsContactDataGridView.Size = New System.Drawing.Size(845, 171)
        Me.DsContactDataGridView.TabIndex = 10
        '
        'DsAddressBindingSource1
        '
        Me.DsAddressBindingSource1.DataMember = "dsPartnerdsAddress"
        Me.DsAddressBindingSource1.DataSource = Me.DsPartnerBindingSource
        '
        'DsAddressDataGridView
        '
        Me.DsAddressDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DsAddressDataGridView.AutoGenerateColumns = False
        Me.DsAddressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsAddressDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.DsAddressDataGridView.DataSource = Me.DsAddressBindingSource1
        Me.DsAddressDataGridView.Location = New System.Drawing.Point(10, 283)
        Me.DsAddressDataGridView.Name = "DsAddressDataGridView"
        Me.DsAddressDataGridView.Size = New System.Drawing.Size(847, 136)
        Me.DsAddressDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Contact_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Contact_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Created"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Created"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Partner_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Partner_ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ToolTipText = "M or F"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Forename"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Forename"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Surename"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Surename"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "eMail"
        Me.DataGridViewTextBoxColumn10.HeaderText = "eMail"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Telefon"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Telefon"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Mobilephone"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Mobilephone"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Fax"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fax"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Address_ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Address_ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Created"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Created"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Partner_ID"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Partner_ID"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Address_Role"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Address_Role"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Address_Name"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Address_Name"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ToolTipText = "Corresponding over"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Street1"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Street1"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Street2"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Street2"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Postal_Code"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Postal_Code"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "UNLOC"
        Me.DataGridViewTextBoxColumn19.HeaderText = "UNLOC"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'frmPartner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 431)
        Me.Controls.Add(Me.DsAddressDataGridView)
        Me.Controls.Add(Me.DsContactDataGridView)
        Me.Controls.Add(Tango_IDLabel)
        Me.Controls.Add(Me.Tango_IDTextBox)
        Me.Controls.Add(ICM_IDLabel)
        Me.Controls.Add(Me.ICM_IDTextBox)
        Me.Controls.Add(PartnerNameLabel)
        Me.Controls.Add(Me.PartnerNameTextBox)
        Me.Controls.Add(Me.DsPartnerBindingNavigator)
        Me.Name = "frmPartner"
        Me.Text = "frmPartner"
        CType(Me.DsDemag_HUB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPartnerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPartnerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DsPartnerBindingNavigator.ResumeLayout(False)
        Me.DsPartnerBindingNavigator.PerformLayout()
        CType(Me.DsContactBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContactBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContactDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAddressBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAddressDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsDemag_HUB As dsDemag_HUB
    Friend WithEvents DsPartnerBindingSource As BindingSource
    Friend WithEvents DsPartnerTableAdapter As dsDemag_HUBTableAdapters.dsPartnerTableAdapter
    Friend WithEvents TableAdapterManager As dsDemag_HUBTableAdapters.TableAdapterManager
    Friend WithEvents DsPartnerBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DsPartnerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DsContactTableAdapter As dsDemag_HUBTableAdapters.dsContactTableAdapter
    Friend WithEvents Tango_IDTextBox As TextBox
    Friend WithEvents ICM_IDTextBox As TextBox
    Friend WithEvents PartnerNameTextBox As TextBox
    Friend WithEvents DsContactBindingSource As BindingSource
    Friend WithEvents DsAddressTableAdapter As dsDemag_HUBTableAdapters.dsAddressTableAdapter
    Friend WithEvents DsAddressBindingSource As BindingSource
    Friend WithEvents DsContactBindingSource1 As BindingSource
    Friend WithEvents DsContactDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DsAddressBindingSource1 As BindingSource
    Friend WithEvents DsAddressDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
End Class
