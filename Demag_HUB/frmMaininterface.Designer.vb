<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaininterface
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
        Dim DtnETALabel As System.Windows.Forms.Label
        Dim DtnETDLabel As System.Windows.Forms.Label
        Dim DtnCRDLabel As System.Windows.Forms.Label
        Dim Cont40HQLabel As System.Windows.Forms.Label
        Dim Cont40DCLabel As System.Windows.Forms.Label
        Dim Cont20DCLabel As System.Windows.Forms.Label
        Dim TEULabel As System.Windows.Forms.Label
        Dim WeightLabel As System.Windows.Forms.Label
        Dim VolumeLabel As System.Windows.Forms.Label
        Dim Contract_NoLabel As System.Windows.Forms.Label
        Dim CarrierLabel As System.Windows.Forms.Label
        Dim VesselLabel As System.Windows.Forms.Label
        Dim PODLabel As System.Windows.Forms.Label
        Dim POLLabel As System.Windows.Forms.Label
        Dim ConsigneeLabel As System.Windows.Forms.Label
        Dim ShipperLabel As System.Windows.Forms.Label
        Dim PrincipalLabel As System.Windows.Forms.Label
        Dim Incoterm_LocLabel As System.Windows.Forms.Label
        Dim IncotermLabel As System.Windows.Forms.Label
        Dim ServiceLabel As System.Windows.Forms.Label
        Dim POL_NoLabel As System.Windows.Forms.Label
        Dim STT_NoLabel As System.Windows.Forms.Label
        Dim Shipment_IDLabel As System.Windows.Forms.Label
        Dim Tango_IDLabel As System.Windows.Forms.Label
        Dim ICM_IDLabel As System.Windows.Forms.Label
        Dim PartnerNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaininterface))
        Me.DsDemag_HUB = New Demag_HUB.dsDemag_HUB()
        Me.DsShipmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsShipmentsTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsShipmentsTableAdapter()
        Me.TableAdapterManager = New Demag_HUB.dsDemag_HUBTableAdapters.TableAdapterManager()
        Me.DsPartnerTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsPartnerTableAdapter()
        Me.IncotermTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.IncotermTableAdapter()
        Me.DsShipmentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DsShipmentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.subTabShipments = New System.Windows.Forms.TabControl()
        Me.tabBooking = New System.Windows.Forms.TabPage()
        Me.dtnETA = New System.Windows.Forms.TextBox()
        Me.dtnETD = New System.Windows.Forms.TextBox()
        Me.dtnCRD = New System.Windows.Forms.TextBox()
        Me.FullIncoterm_LocTextBox = New System.Windows.Forms.ComboBox()
        Me.UNLOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Incoterm_LocTextBox = New System.Windows.Forms.ComboBox()
        Me.FullPODTextBox = New System.Windows.Forms.ComboBox()
        Me.PODTextBox = New System.Windows.Forms.ComboBox()
        Me.FullPOLTextBox = New System.Windows.Forms.ComboBox()
        Me.POLTextBox = New System.Windows.Forms.ComboBox()
        Me.CarrierTextBox = New System.Windows.Forms.ComboBox()
        Me.ConsigneeTextBox = New System.Windows.Forms.ComboBox()
        Me.DsPartnerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipperTextBox = New System.Windows.Forms.ComboBox()
        Me.PrincipalTextBox = New System.Windows.Forms.ComboBox()
        Me.IncotermTextBox = New System.Windows.Forms.ComboBox()
        Me.IncotermBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiceTextBox = New System.Windows.Forms.ComboBox()
        Me.Shipment_IDTextBox = New System.Windows.Forms.TextBox()
        Me.STT_NoTextBox = New System.Windows.Forms.TextBox()
        Me.POL_NoTextBox = New System.Windows.Forms.TextBox()
        Me.VesselTextBox = New System.Windows.Forms.TextBox()
        Me.Contract_NoTextBox = New System.Windows.Forms.TextBox()
        Me.VolumeTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.TEUTextBox = New System.Windows.Forms.TextBox()
        Me.Cont20DCTextBox = New System.Windows.Forms.TextBox()
        Me.Cont40DCTextBox = New System.Windows.Forms.TextBox()
        Me.Cont40HQTextBox = New System.Windows.Forms.TextBox()
        Me.tabShipping = New System.Windows.Forms.TabPage()
        Me.tabDispo = New System.Windows.Forms.TabPage()
        Me.tabDocuments = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtSearch = New Demag_HUB.Watermark()
        Me.cmbField = New System.Windows.Forms.ComboBox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.tabShipments = New System.Windows.Forms.TabPage()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tabPartner = New System.Windows.Forms.TabPage()
        Me.btnNewPartner = New System.Windows.Forms.Button()
        Me.DsAddressDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsAddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContactDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DsContactBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tango_IDTextBox = New System.Windows.Forms.TextBox()
        Me.ICM_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PartnerNameTextBox = New System.Windows.Forms.TextBox()
        Me.DsContactTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsContactTableAdapter()
        Me.DsAddressTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsAddressTableAdapter()
        Me.UNLOCTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.UNLOCTableAdapter()
        Me.DsCommentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCommentTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsCommentTableAdapter()
        Me.DsCommentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        DtnETALabel = New System.Windows.Forms.Label()
        DtnETDLabel = New System.Windows.Forms.Label()
        DtnCRDLabel = New System.Windows.Forms.Label()
        Cont40HQLabel = New System.Windows.Forms.Label()
        Cont40DCLabel = New System.Windows.Forms.Label()
        Cont20DCLabel = New System.Windows.Forms.Label()
        TEULabel = New System.Windows.Forms.Label()
        WeightLabel = New System.Windows.Forms.Label()
        VolumeLabel = New System.Windows.Forms.Label()
        Contract_NoLabel = New System.Windows.Forms.Label()
        CarrierLabel = New System.Windows.Forms.Label()
        VesselLabel = New System.Windows.Forms.Label()
        PODLabel = New System.Windows.Forms.Label()
        POLLabel = New System.Windows.Forms.Label()
        ConsigneeLabel = New System.Windows.Forms.Label()
        ShipperLabel = New System.Windows.Forms.Label()
        PrincipalLabel = New System.Windows.Forms.Label()
        Incoterm_LocLabel = New System.Windows.Forms.Label()
        IncotermLabel = New System.Windows.Forms.Label()
        ServiceLabel = New System.Windows.Forms.Label()
        POL_NoLabel = New System.Windows.Forms.Label()
        STT_NoLabel = New System.Windows.Forms.Label()
        Shipment_IDLabel = New System.Windows.Forms.Label()
        Tango_IDLabel = New System.Windows.Forms.Label()
        ICM_IDLabel = New System.Windows.Forms.Label()
        PartnerNameLabel = New System.Windows.Forms.Label()
        CType(Me.DsDemag_HUB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsShipmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsShipmentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DsShipmentsBindingNavigator.SuspendLayout()
        Me.subTabShipments.SuspendLayout()
        Me.tabBooking.SuspendLayout()
        CType(Me.UNLOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPartnerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncotermBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl3.SuspendLayout()
        Me.tabShipments.SuspendLayout()
        Me.tabPartner.SuspendLayout()
        CType(Me.DsAddressDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContactDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContactBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCommentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCommentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtnETALabel
        '
        DtnETALabel.AutoSize = True
        DtnETALabel.Location = New System.Drawing.Point(372, 187)
        DtnETALabel.Name = "DtnETALabel"
        DtnETALabel.Size = New System.Drawing.Size(49, 13)
        DtnETALabel.TabIndex = 56
        DtnETALabel.Text = "dtn ETA:"
        '
        'DtnETDLabel
        '
        DtnETDLabel.AutoSize = True
        DtnETDLabel.Location = New System.Drawing.Point(371, 158)
        DtnETDLabel.Name = "DtnETDLabel"
        DtnETDLabel.Size = New System.Drawing.Size(50, 13)
        DtnETDLabel.TabIndex = 52
        DtnETDLabel.Text = "dtn ETD:"
        '
        'DtnCRDLabel
        '
        DtnCRDLabel.AutoSize = True
        DtnCRDLabel.Location = New System.Drawing.Point(370, 131)
        DtnCRDLabel.Name = "DtnCRDLabel"
        DtnCRDLabel.Size = New System.Drawing.Size(51, 13)
        DtnCRDLabel.TabIndex = 50
        DtnCRDLabel.Text = "dtn CRD:"
        '
        'Cont40HQLabel
        '
        Cont40HQLabel.AutoSize = True
        Cont40HQLabel.Location = New System.Drawing.Point(243, 241)
        Cont40HQLabel.Name = "Cont40HQLabel"
        Cont40HQLabel.Size = New System.Drawing.Size(35, 13)
        Cont40HQLabel.TabIndex = 48
        Cont40HQLabel.Text = "40HQ"
        '
        'Cont40DCLabel
        '
        Cont40DCLabel.AutoSize = True
        Cont40DCLabel.Location = New System.Drawing.Point(187, 241)
        Cont40DCLabel.Name = "Cont40DCLabel"
        Cont40DCLabel.Size = New System.Drawing.Size(34, 13)
        Cont40DCLabel.TabIndex = 46
        Cont40DCLabel.Text = "40DC"
        '
        'Cont20DCLabel
        '
        Cont20DCLabel.AutoSize = True
        Cont20DCLabel.Location = New System.Drawing.Point(131, 241)
        Cont20DCLabel.Name = "Cont20DCLabel"
        Cont20DCLabel.Size = New System.Drawing.Size(34, 13)
        Cont20DCLabel.TabIndex = 44
        Cont20DCLabel.Text = "20DC"
        '
        'TEULabel
        '
        TEULabel.AutoSize = True
        TEULabel.Location = New System.Drawing.Point(299, 241)
        TEULabel.Name = "TEULabel"
        TEULabel.Size = New System.Drawing.Size(32, 13)
        TEULabel.TabIndex = 42
        TEULabel.Text = "TEU:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(75, 241)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(44, 13)
        WeightLabel.TabIndex = 40
        WeightLabel.Text = "Weight:"
        '
        'VolumeLabel
        '
        VolumeLabel.AutoSize = True
        VolumeLabel.Location = New System.Drawing.Point(19, 241)
        VolumeLabel.Name = "VolumeLabel"
        VolumeLabel.Size = New System.Drawing.Size(45, 13)
        VolumeLabel.TabIndex = 38
        VolumeLabel.Text = "Volume:"
        '
        'Contract_NoLabel
        '
        Contract_NoLabel.AutoSize = True
        Contract_NoLabel.Location = New System.Drawing.Point(370, 219)
        Contract_NoLabel.Name = "Contract_NoLabel"
        Contract_NoLabel.Size = New System.Drawing.Size(67, 13)
        Contract_NoLabel.TabIndex = 36
        Contract_NoLabel.Text = "Contract No:"
        '
        'CarrierLabel
        '
        CarrierLabel.AutoSize = True
        CarrierLabel.Location = New System.Drawing.Point(19, 214)
        CarrierLabel.Name = "CarrierLabel"
        CarrierLabel.Size = New System.Drawing.Size(40, 13)
        CarrierLabel.TabIndex = 34
        CarrierLabel.Text = "Carrier:"
        '
        'VesselLabel
        '
        VesselLabel.AutoSize = True
        VesselLabel.Location = New System.Drawing.Point(372, 105)
        VesselLabel.Name = "VesselLabel"
        VesselLabel.Size = New System.Drawing.Size(41, 13)
        VesselLabel.TabIndex = 32
        VesselLabel.Text = "Vessel:"
        '
        'PODLabel
        '
        PODLabel.AutoSize = True
        PODLabel.Location = New System.Drawing.Point(19, 187)
        PODLabel.Name = "PODLabel"
        PODLabel.Size = New System.Drawing.Size(33, 13)
        PODLabel.TabIndex = 28
        PODLabel.Text = "POD:"
        '
        'POLLabel
        '
        POLLabel.AutoSize = True
        POLLabel.Location = New System.Drawing.Point(19, 157)
        POLLabel.Name = "POLLabel"
        POLLabel.Size = New System.Drawing.Size(31, 13)
        POLLabel.TabIndex = 26
        POLLabel.Text = "POL:"
        '
        'ConsigneeLabel
        '
        ConsigneeLabel.AutoSize = True
        ConsigneeLabel.Location = New System.Drawing.Point(315, 75)
        ConsigneeLabel.Name = "ConsigneeLabel"
        ConsigneeLabel.Size = New System.Drawing.Size(60, 13)
        ConsigneeLabel.TabIndex = 24
        ConsigneeLabel.Text = "Consignee:"
        '
        'ShipperLabel
        '
        ShipperLabel.AutoSize = True
        ShipperLabel.Location = New System.Drawing.Point(315, 49)
        ShipperLabel.Name = "ShipperLabel"
        ShipperLabel.Size = New System.Drawing.Size(46, 13)
        ShipperLabel.TabIndex = 22
        ShipperLabel.Text = "Shipper:"
        '
        'PrincipalLabel
        '
        PrincipalLabel.AutoSize = True
        PrincipalLabel.Location = New System.Drawing.Point(315, 23)
        PrincipalLabel.Name = "PrincipalLabel"
        PrincipalLabel.Size = New System.Drawing.Size(50, 13)
        PrincipalLabel.TabIndex = 20
        PrincipalLabel.Text = "Principal:"
        '
        'Incoterm_LocLabel
        '
        Incoterm_LocLabel.AutoSize = True
        Incoterm_LocLabel.Location = New System.Drawing.Point(19, 128)
        Incoterm_LocLabel.Name = "Incoterm_LocLabel"
        Incoterm_LocLabel.Size = New System.Drawing.Size(72, 13)
        Incoterm_LocLabel.TabIndex = 18
        Incoterm_LocLabel.Text = "Incoterm Loc:"
        '
        'IncotermLabel
        '
        IncotermLabel.AutoSize = True
        IncotermLabel.Location = New System.Drawing.Point(19, 101)
        IncotermLabel.Name = "IncotermLabel"
        IncotermLabel.Size = New System.Drawing.Size(51, 13)
        IncotermLabel.TabIndex = 16
        IncotermLabel.Text = "Incoterm:"
        '
        'ServiceLabel
        '
        ServiceLabel.AutoSize = True
        ServiceLabel.Location = New System.Drawing.Point(185, 101)
        ServiceLabel.Name = "ServiceLabel"
        ServiceLabel.Size = New System.Drawing.Size(46, 13)
        ServiceLabel.TabIndex = 14
        ServiceLabel.Text = "Service:"
        '
        'POL_NoLabel
        '
        POL_NoLabel.AutoSize = True
        POL_NoLabel.Location = New System.Drawing.Point(19, 75)
        POL_NoLabel.Name = "POL_NoLabel"
        POL_NoLabel.Size = New System.Drawing.Size(48, 13)
        POL_NoLabel.TabIndex = 12
        POL_NoLabel.Text = "POL No:"
        '
        'STT_NoLabel
        '
        STT_NoLabel.AutoSize = True
        STT_NoLabel.Location = New System.Drawing.Point(19, 49)
        STT_NoLabel.Name = "STT_NoLabel"
        STT_NoLabel.Size = New System.Drawing.Size(48, 13)
        STT_NoLabel.TabIndex = 4
        STT_NoLabel.Text = "STT No:"
        '
        'Shipment_IDLabel
        '
        Shipment_IDLabel.AutoSize = True
        Shipment_IDLabel.Enabled = False
        Shipment_IDLabel.Location = New System.Drawing.Point(19, 23)
        Shipment_IDLabel.Name = "Shipment_IDLabel"
        Shipment_IDLabel.Size = New System.Drawing.Size(68, 13)
        Shipment_IDLabel.TabIndex = 0
        Shipment_IDLabel.Text = "Shipment ID:"
        '
        'Tango_IDLabel
        '
        Tango_IDLabel.AutoSize = True
        Tango_IDLabel.Location = New System.Drawing.Point(6, 36)
        Tango_IDLabel.Name = "Tango_IDLabel"
        Tango_IDLabel.Size = New System.Drawing.Size(55, 13)
        Tango_IDLabel.TabIndex = 4
        Tango_IDLabel.Text = "Tango ID:"
        '
        'ICM_IDLabel
        '
        ICM_IDLabel.AutoSize = True
        ICM_IDLabel.Location = New System.Drawing.Point(6, 62)
        ICM_IDLabel.Name = "ICM_IDLabel"
        ICM_IDLabel.Size = New System.Drawing.Size(43, 13)
        ICM_IDLabel.TabIndex = 6
        ICM_IDLabel.Text = "ICM ID:"
        '
        'PartnerNameLabel
        '
        PartnerNameLabel.AutoSize = True
        PartnerNameLabel.Location = New System.Drawing.Point(6, 10)
        PartnerNameLabel.Name = "PartnerNameLabel"
        PartnerNameLabel.Size = New System.Drawing.Size(75, 13)
        PartnerNameLabel.TabIndex = 8
        PartnerNameLabel.Text = "Partner Name:"
        '
        'DsDemag_HUB
        '
        Me.DsDemag_HUB.DataSetName = "dsDemag_HUB"
        Me.DsDemag_HUB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsShipmentsBindingSource
        '
        Me.DsShipmentsBindingSource.DataMember = "dsShipments"
        Me.DsShipmentsBindingSource.DataSource = Me.DsDemag_HUB
        '
        'DsShipmentsTableAdapter
        '
        Me.DsShipmentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CountryCodesTableAdapter = Nothing
        Me.TableAdapterManager.dsAddressTableAdapter = Nothing
        Me.TableAdapterManager.dsAliasTableAdapter = Nothing
        Me.TableAdapterManager.dsCommentTableAdapter = Nothing
        Me.TableAdapterManager.dsContactTableAdapter = Nothing
        Me.TableAdapterManager.dsContainerTableAdapter = Nothing
        Me.TableAdapterManager.dsEventTableAdapter = Nothing
        Me.TableAdapterManager.dsInvoiceTableAdapter = Nothing
        Me.TableAdapterManager.dsLocTranslateTableAdapter = Nothing
        Me.TableAdapterManager.dsPartnerTableAdapter = Me.DsPartnerTableAdapter
        Me.TableAdapterManager.dsRoleTableAdapter = Nothing
        Me.TableAdapterManager.dsShipment_OrderTableAdapter = Nothing
        Me.TableAdapterManager.dsShipment_SOTableAdapter = Nothing
        Me.TableAdapterManager.dsShipmentsTableAdapter = Me.DsShipmentsTableAdapter
        Me.TableAdapterManager.IncotermTableAdapter = Me.IncotermTableAdapter
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
        'DsPartnerTableAdapter
        '
        Me.DsPartnerTableAdapter.ClearBeforeFill = True
        '
        'IncotermTableAdapter
        '
        Me.IncotermTableAdapter.ClearBeforeFill = True
        '
        'DsShipmentsBindingNavigator
        '
        Me.DsShipmentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DsShipmentsBindingNavigator.BindingSource = Me.DsShipmentsBindingSource
        Me.DsShipmentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DsShipmentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DsShipmentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DsShipmentsBindingNavigatorSaveItem})
        Me.DsShipmentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DsShipmentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DsShipmentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DsShipmentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DsShipmentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DsShipmentsBindingNavigator.Name = "DsShipmentsBindingNavigator"
        Me.DsShipmentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DsShipmentsBindingNavigator.Size = New System.Drawing.Size(956, 25)
        Me.DsShipmentsBindingNavigator.TabIndex = 0
        Me.DsShipmentsBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DsShipmentsBindingNavigatorSaveItem
        '
        Me.DsShipmentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DsShipmentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("DsShipmentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DsShipmentsBindingNavigatorSaveItem.Name = "DsShipmentsBindingNavigatorSaveItem"
        Me.DsShipmentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DsShipmentsBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "http://www.iconarchive.com/show/captiva-icons-by-bokehlicia/web-github-icon.html"
        '
        'subTabShipments
        '
        Me.subTabShipments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.subTabShipments.Controls.Add(Me.tabBooking)
        Me.subTabShipments.Controls.Add(Me.tabShipping)
        Me.subTabShipments.Controls.Add(Me.tabDispo)
        Me.subTabShipments.Controls.Add(Me.tabDocuments)
        Me.subTabShipments.Location = New System.Drawing.Point(145, 6)
        Me.subTabShipments.Name = "subTabShipments"
        Me.subTabShipments.SelectedIndex = 0
        Me.subTabShipments.Size = New System.Drawing.Size(773, 453)
        Me.subTabShipments.TabIndex = 2
        '
        'tabBooking
        '
        Me.tabBooking.AutoScroll = True
        Me.tabBooking.Controls.Add(Me.DsCommentDataGridView)
        Me.tabBooking.Controls.Add(Me.dtnETA)
        Me.tabBooking.Controls.Add(Me.dtnETD)
        Me.tabBooking.Controls.Add(Me.dtnCRD)
        Me.tabBooking.Controls.Add(Me.FullIncoterm_LocTextBox)
        Me.tabBooking.Controls.Add(Me.Incoterm_LocTextBox)
        Me.tabBooking.Controls.Add(Me.FullPODTextBox)
        Me.tabBooking.Controls.Add(Me.PODTextBox)
        Me.tabBooking.Controls.Add(Me.FullPOLTextBox)
        Me.tabBooking.Controls.Add(Me.POLTextBox)
        Me.tabBooking.Controls.Add(Me.CarrierTextBox)
        Me.tabBooking.Controls.Add(Me.ConsigneeTextBox)
        Me.tabBooking.Controls.Add(Me.ShipperTextBox)
        Me.tabBooking.Controls.Add(Me.PrincipalTextBox)
        Me.tabBooking.Controls.Add(Me.IncotermTextBox)
        Me.tabBooking.Controls.Add(Me.ServiceTextBox)
        Me.tabBooking.Controls.Add(Shipment_IDLabel)
        Me.tabBooking.Controls.Add(Me.Shipment_IDTextBox)
        Me.tabBooking.Controls.Add(STT_NoLabel)
        Me.tabBooking.Controls.Add(Me.STT_NoTextBox)
        Me.tabBooking.Controls.Add(POL_NoLabel)
        Me.tabBooking.Controls.Add(Me.POL_NoTextBox)
        Me.tabBooking.Controls.Add(ServiceLabel)
        Me.tabBooking.Controls.Add(IncotermLabel)
        Me.tabBooking.Controls.Add(Incoterm_LocLabel)
        Me.tabBooking.Controls.Add(PrincipalLabel)
        Me.tabBooking.Controls.Add(ShipperLabel)
        Me.tabBooking.Controls.Add(ConsigneeLabel)
        Me.tabBooking.Controls.Add(POLLabel)
        Me.tabBooking.Controls.Add(PODLabel)
        Me.tabBooking.Controls.Add(VesselLabel)
        Me.tabBooking.Controls.Add(Me.VesselTextBox)
        Me.tabBooking.Controls.Add(CarrierLabel)
        Me.tabBooking.Controls.Add(Contract_NoLabel)
        Me.tabBooking.Controls.Add(Me.Contract_NoTextBox)
        Me.tabBooking.Controls.Add(VolumeLabel)
        Me.tabBooking.Controls.Add(Me.VolumeTextBox)
        Me.tabBooking.Controls.Add(WeightLabel)
        Me.tabBooking.Controls.Add(Me.WeightTextBox)
        Me.tabBooking.Controls.Add(TEULabel)
        Me.tabBooking.Controls.Add(Me.TEUTextBox)
        Me.tabBooking.Controls.Add(Cont20DCLabel)
        Me.tabBooking.Controls.Add(Me.Cont20DCTextBox)
        Me.tabBooking.Controls.Add(Cont40DCLabel)
        Me.tabBooking.Controls.Add(Me.Cont40DCTextBox)
        Me.tabBooking.Controls.Add(Cont40HQLabel)
        Me.tabBooking.Controls.Add(Me.Cont40HQTextBox)
        Me.tabBooking.Controls.Add(DtnCRDLabel)
        Me.tabBooking.Controls.Add(DtnETDLabel)
        Me.tabBooking.Controls.Add(DtnETALabel)
        Me.tabBooking.Location = New System.Drawing.Point(4, 22)
        Me.tabBooking.Name = "tabBooking"
        Me.tabBooking.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBooking.Size = New System.Drawing.Size(765, 427)
        Me.tabBooking.TabIndex = 1
        Me.tabBooking.Text = "Booking"
        Me.tabBooking.UseVisualStyleBackColor = True
        '
        'dtnETA
        '
        Me.dtnETA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "dtnETA", True))
        Me.dtnETA.Location = New System.Drawing.Point(462, 184)
        Me.dtnETA.Name = "dtnETA"
        Me.dtnETA.Size = New System.Drawing.Size(100, 20)
        Me.dtnETA.TabIndex = 86
        '
        'dtnETD
        '
        Me.dtnETD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "dtnETD", True))
        Me.dtnETD.Location = New System.Drawing.Point(462, 154)
        Me.dtnETD.Name = "dtnETD"
        Me.dtnETD.Size = New System.Drawing.Size(100, 20)
        Me.dtnETD.TabIndex = 85
        '
        'dtnCRD
        '
        Me.dtnCRD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "dtnCRD", True))
        Me.dtnCRD.Location = New System.Drawing.Point(462, 128)
        Me.dtnCRD.Name = "dtnCRD"
        Me.dtnCRD.Size = New System.Drawing.Size(100, 20)
        Me.dtnCRD.TabIndex = 84
        '
        'FullIncoterm_LocTextBox
        '
        Me.FullIncoterm_LocTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FullIncoterm_LocTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FullIncoterm_LocTextBox.DataSource = Me.UNLOCBindingSource
        Me.FullIncoterm_LocTextBox.DisplayMember = "Name"
        Me.FullIncoterm_LocTextBox.FormattingEnabled = True
        Me.FullIncoterm_LocTextBox.Location = New System.Drawing.Point(188, 128)
        Me.FullIncoterm_LocTextBox.Name = "FullIncoterm_LocTextBox"
        Me.FullIncoterm_LocTextBox.Size = New System.Drawing.Size(178, 21)
        Me.FullIncoterm_LocTextBox.TabIndex = 83
        '
        'UNLOCBindingSource
        '
        Me.UNLOCBindingSource.DataMember = "UNLOC"
        Me.UNLOCBindingSource.DataSource = Me.DsDemag_HUB
        '
        'Incoterm_LocTextBox
        '
        Me.Incoterm_LocTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Incoterm_LocTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Incoterm_LocTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Incoterm_Loc", True))
        Me.Incoterm_LocTextBox.DataSource = Me.UNLOCBindingSource
        Me.Incoterm_LocTextBox.DisplayMember = "UNLOC"
        Me.Incoterm_LocTextBox.FormattingEnabled = True
        Me.Incoterm_LocTextBox.Location = New System.Drawing.Point(109, 125)
        Me.Incoterm_LocTextBox.Name = "Incoterm_LocTextBox"
        Me.Incoterm_LocTextBox.Size = New System.Drawing.Size(68, 21)
        Me.Incoterm_LocTextBox.TabIndex = 82
        '
        'FullPODTextBox
        '
        Me.FullPODTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FullPODTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FullPODTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.FullPODTextBox.DataSource = Me.UNLOCBindingSource
        Me.FullPODTextBox.DisplayMember = "Name"
        Me.FullPODTextBox.FormattingEnabled = True
        Me.FullPODTextBox.Location = New System.Drawing.Point(188, 184)
        Me.FullPODTextBox.Name = "FullPODTextBox"
        Me.FullPODTextBox.Size = New System.Drawing.Size(178, 21)
        Me.FullPODTextBox.TabIndex = 81
        '
        'PODTextBox
        '
        Me.PODTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PODTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PODTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "POD", True))
        Me.PODTextBox.DataSource = Me.UNLOCBindingSource
        Me.PODTextBox.DisplayMember = "UNLOC"
        Me.PODTextBox.FormattingEnabled = True
        Me.PODTextBox.Location = New System.Drawing.Point(109, 184)
        Me.PODTextBox.Name = "PODTextBox"
        Me.PODTextBox.Size = New System.Drawing.Size(68, 21)
        Me.PODTextBox.TabIndex = 80
        '
        'FullPOLTextBox
        '
        Me.FullPOLTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FullPOLTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FullPOLTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.FullPOLTextBox.DataSource = Me.UNLOCBindingSource
        Me.FullPOLTextBox.DisplayMember = "Name"
        Me.FullPOLTextBox.FormattingEnabled = True
        Me.FullPOLTextBox.Location = New System.Drawing.Point(188, 155)
        Me.FullPOLTextBox.Name = "FullPOLTextBox"
        Me.FullPOLTextBox.Size = New System.Drawing.Size(178, 21)
        Me.FullPOLTextBox.TabIndex = 79
        '
        'POLTextBox
        '
        Me.POLTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.POLTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.POLTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.POLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "POL", True))
        Me.POLTextBox.DataSource = Me.UNLOCBindingSource
        Me.POLTextBox.DisplayMember = "UNLOC"
        Me.POLTextBox.FormattingEnabled = True
        Me.POLTextBox.Location = New System.Drawing.Point(109, 155)
        Me.POLTextBox.Name = "POLTextBox"
        Me.POLTextBox.Size = New System.Drawing.Size(68, 21)
        Me.POLTextBox.TabIndex = 78
        '
        'CarrierTextBox
        '
        Me.CarrierTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CarrierTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CarrierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Carrier", True))
        Me.CarrierTextBox.DataSource = Me.DsShipmentsBindingSource
        Me.CarrierTextBox.FormattingEnabled = True
        Me.CarrierTextBox.Location = New System.Drawing.Point(109, 211)
        Me.CarrierTextBox.Name = "CarrierTextBox"
        Me.CarrierTextBox.Size = New System.Drawing.Size(256, 21)
        Me.CarrierTextBox.TabIndex = 77
        '
        'ConsigneeTextBox
        '
        Me.ConsigneeTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ConsigneeTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ConsigneeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Consignee", True))
        Me.ConsigneeTextBox.DataSource = Me.DsPartnerBindingSource
        Me.ConsigneeTextBox.DisplayMember = "PartnerName"
        Me.ConsigneeTextBox.FormattingEnabled = True
        Me.ConsigneeTextBox.Location = New System.Drawing.Point(381, 72)
        Me.ConsigneeTextBox.Name = "ConsigneeTextBox"
        Me.ConsigneeTextBox.Size = New System.Drawing.Size(281, 21)
        Me.ConsigneeTextBox.TabIndex = 76
        '
        'DsPartnerBindingSource
        '
        Me.DsPartnerBindingSource.DataMember = "dsPartner"
        Me.DsPartnerBindingSource.DataSource = Me.DsDemag_HUB
        '
        'ShipperTextBox
        '
        Me.ShipperTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ShipperTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ShipperTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Shipper", True))
        Me.ShipperTextBox.DataSource = Me.DsPartnerBindingSource
        Me.ShipperTextBox.DisplayMember = "PartnerName"
        Me.ShipperTextBox.FormattingEnabled = True
        Me.ShipperTextBox.Location = New System.Drawing.Point(381, 46)
        Me.ShipperTextBox.Name = "ShipperTextBox"
        Me.ShipperTextBox.Size = New System.Drawing.Size(281, 21)
        Me.ShipperTextBox.TabIndex = 75
        '
        'PrincipalTextBox
        '
        Me.PrincipalTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PrincipalTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PrincipalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Principal", True))
        Me.PrincipalTextBox.DataSource = Me.DsPartnerBindingSource
        Me.PrincipalTextBox.DisplayMember = "PartnerName"
        Me.PrincipalTextBox.FormattingEnabled = True
        Me.PrincipalTextBox.Location = New System.Drawing.Point(381, 20)
        Me.PrincipalTextBox.Name = "PrincipalTextBox"
        Me.PrincipalTextBox.Size = New System.Drawing.Size(281, 21)
        Me.PrincipalTextBox.TabIndex = 74
        '
        'IncotermTextBox
        '
        Me.IncotermTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.IncotermTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.IncotermTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Incoterm", True))
        Me.IncotermTextBox.DataSource = Me.IncotermBindingSource
        Me.IncotermTextBox.DisplayMember = "Incoterm"
        Me.IncotermTextBox.FormattingEnabled = True
        Me.IncotermTextBox.Location = New System.Drawing.Point(109, 98)
        Me.IncotermTextBox.Name = "IncotermTextBox"
        Me.IncotermTextBox.Size = New System.Drawing.Size(68, 21)
        Me.IncotermTextBox.TabIndex = 73
        '
        'IncotermBindingSource
        '
        Me.IncotermBindingSource.DataMember = "Incoterm"
        Me.IncotermBindingSource.DataSource = Me.DsDemag_HUB
        '
        'ServiceTextBox
        '
        Me.ServiceTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ServiceTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ServiceTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ServiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Service", True))
        Me.ServiceTextBox.FormattingEnabled = True
        Me.ServiceTextBox.Items.AddRange(New Object() {"FCL", "LCL", "AIR", "RAIL"})
        Me.ServiceTextBox.Location = New System.Drawing.Point(301, 98)
        Me.ServiceTextBox.Name = "ServiceTextBox"
        Me.ServiceTextBox.Size = New System.Drawing.Size(65, 21)
        Me.ServiceTextBox.TabIndex = 72
        '
        'Shipment_IDTextBox
        '
        Me.Shipment_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Shipment_ID", True))
        Me.Shipment_IDTextBox.Location = New System.Drawing.Point(109, 20)
        Me.Shipment_IDTextBox.Name = "Shipment_IDTextBox"
        Me.Shipment_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Shipment_IDTextBox.TabIndex = 1
        '
        'STT_NoTextBox
        '
        Me.STT_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "STT_No", True))
        Me.STT_NoTextBox.Location = New System.Drawing.Point(109, 46)
        Me.STT_NoTextBox.Name = "STT_NoTextBox"
        Me.STT_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.STT_NoTextBox.TabIndex = 5
        '
        'POL_NoTextBox
        '
        Me.POL_NoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.POL_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "POL_No", True))
        Me.POL_NoTextBox.Location = New System.Drawing.Point(109, 72)
        Me.POL_NoTextBox.Name = "POL_NoTextBox"
        Me.POL_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.POL_NoTextBox.TabIndex = 13
        '
        'VesselTextBox
        '
        Me.VesselTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VesselTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Vessel", True))
        Me.VesselTextBox.Location = New System.Drawing.Point(462, 98)
        Me.VesselTextBox.Name = "VesselTextBox"
        Me.VesselTextBox.Size = New System.Drawing.Size(200, 20)
        Me.VesselTextBox.TabIndex = 33
        '
        'Contract_NoTextBox
        '
        Me.Contract_NoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Contract_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Contract_No", True))
        Me.Contract_NoTextBox.Location = New System.Drawing.Point(462, 211)
        Me.Contract_NoTextBox.Name = "Contract_NoTextBox"
        Me.Contract_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Contract_NoTextBox.TabIndex = 37
        '
        'VolumeTextBox
        '
        Me.VolumeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Volume", True))
        Me.VolumeTextBox.Location = New System.Drawing.Point(22, 257)
        Me.VolumeTextBox.Name = "VolumeTextBox"
        Me.VolumeTextBox.Size = New System.Drawing.Size(50, 20)
        Me.VolumeTextBox.TabIndex = 39
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(78, 257)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(50, 20)
        Me.WeightTextBox.TabIndex = 41
        '
        'TEUTextBox
        '
        Me.TEUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "TEU", True))
        Me.TEUTextBox.Enabled = False
        Me.TEUTextBox.Location = New System.Drawing.Point(302, 257)
        Me.TEUTextBox.Name = "TEUTextBox"
        Me.TEUTextBox.Size = New System.Drawing.Size(50, 20)
        Me.TEUTextBox.TabIndex = 43
        '
        'Cont20DCTextBox
        '
        Me.Cont20DCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Cont20DC", True))
        Me.Cont20DCTextBox.Location = New System.Drawing.Point(134, 257)
        Me.Cont20DCTextBox.Name = "Cont20DCTextBox"
        Me.Cont20DCTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Cont20DCTextBox.TabIndex = 45
        '
        'Cont40DCTextBox
        '
        Me.Cont40DCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Cont40DC", True))
        Me.Cont40DCTextBox.Location = New System.Drawing.Point(190, 257)
        Me.Cont40DCTextBox.Name = "Cont40DCTextBox"
        Me.Cont40DCTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Cont40DCTextBox.TabIndex = 47
        '
        'Cont40HQTextBox
        '
        Me.Cont40HQTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Cont40HQ", True))
        Me.Cont40HQTextBox.Location = New System.Drawing.Point(246, 257)
        Me.Cont40HQTextBox.Name = "Cont40HQTextBox"
        Me.Cont40HQTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Cont40HQTextBox.TabIndex = 49
        '
        'tabShipping
        '
        Me.tabShipping.Location = New System.Drawing.Point(4, 22)
        Me.tabShipping.Name = "tabShipping"
        Me.tabShipping.Padding = New System.Windows.Forms.Padding(3)
        Me.tabShipping.Size = New System.Drawing.Size(765, 427)
        Me.tabShipping.TabIndex = 2
        Me.tabShipping.Text = "Shipping"
        Me.tabShipping.UseVisualStyleBackColor = True
        '
        'tabDispo
        '
        Me.tabDispo.Location = New System.Drawing.Point(4, 22)
        Me.tabDispo.Name = "tabDispo"
        Me.tabDispo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDispo.Size = New System.Drawing.Size(765, 427)
        Me.tabDispo.TabIndex = 3
        Me.tabDispo.Text = "Dispo"
        Me.tabDispo.UseVisualStyleBackColor = True
        '
        'tabDocuments
        '
        Me.tabDocuments.Location = New System.Drawing.Point(4, 22)
        Me.tabDocuments.Name = "tabDocuments"
        Me.tabDocuments.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDocuments.Size = New System.Drawing.Size(765, 427)
        Me.tabDocuments.TabIndex = 4
        Me.tabDocuments.Text = "Documents"
        Me.tabDocuments.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Status"
        '
        'tabSettings
        '
        Me.tabSettings.Location = New System.Drawing.Point(4, 4)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSettings.Size = New System.Drawing.Size(924, 465)
        Me.tabSettings.TabIndex = 0
        Me.tabSettings.Text = "Settings"
        Me.tabSettings.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(5, 98)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(134, 40)
        Me.btnSave.TabIndex = 10
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(6, 52)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(134, 40)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.TabStop = False
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Location = New System.Drawing.Point(6, 6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(134, 40)
        Me.btnNew.TabIndex = 8
        Me.btnNew.TabStop = False
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(154, 46)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(215, 20)
        Me.txtSearch.TabIndex = 11
        Me.txtSearch.WatermarkColor = System.Drawing.Color.Gray
        Me.txtSearch.WatermarkText = "Search"
        '
        'cmbField
        '
        Me.cmbField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbField.FormattingEnabled = True
        Me.cmbField.Items.AddRange(New Object() {"ShipmentID", "STT No.:", "Archive No.:", "HBL No.:", "MBL No.:", "PO No.:"})
        Me.cmbField.Location = New System.Drawing.Point(375, 45)
        Me.cmbField.Name = "cmbField"
        Me.cmbField.Size = New System.Drawing.Size(121, 21)
        Me.cmbField.TabIndex = 12
        '
        'cmbFilter
        '
        Me.cmbFilter.Enabled = False
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Location = New System.Drawing.Point(811, 46)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 21)
        Me.cmbFilter.TabIndex = 13
        Me.cmbFilter.Text = "Reports"
        '
        'TabControl3
        '
        Me.TabControl3.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl3.Controls.Add(Me.tabShipments)
        Me.TabControl3.Controls.Add(Me.tabPartner)
        Me.TabControl3.Controls.Add(Me.tabSettings)
        Me.TabControl3.Location = New System.Drawing.Point(12, 72)
        Me.TabControl3.Multiline = True
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(932, 491)
        Me.TabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl3.TabIndex = 16
        '
        'tabShipments
        '
        Me.tabShipments.Controls.Add(Me.Label2)
        Me.tabShipments.Controls.Add(Me.btnCancel)
        Me.tabShipments.Controls.Add(Me.subTabShipments)
        Me.tabShipments.Controls.Add(Me.btnNew)
        Me.tabShipments.Controls.Add(Me.btnSearch)
        Me.tabShipments.Controls.Add(Me.btnSave)
        Me.tabShipments.Location = New System.Drawing.Point(4, 4)
        Me.tabShipments.Name = "tabShipments"
        Me.tabShipments.Padding = New System.Windows.Forms.Padding(3)
        Me.tabShipments.Size = New System.Drawing.Size(924, 465)
        Me.tabShipments.TabIndex = 0
        Me.tabShipments.Text = "Shipments"
        Me.tabShipments.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(6, 415)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(134, 40)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "&Cancel Shipment"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tabPartner
        '
        Me.tabPartner.AutoScroll = True
        Me.tabPartner.Controls.Add(Me.btnNewPartner)
        Me.tabPartner.Controls.Add(Me.DsAddressDataGridView)
        Me.tabPartner.Controls.Add(Me.DsContactDataGridView)
        Me.tabPartner.Controls.Add(Tango_IDLabel)
        Me.tabPartner.Controls.Add(Me.Tango_IDTextBox)
        Me.tabPartner.Controls.Add(ICM_IDLabel)
        Me.tabPartner.Controls.Add(Me.ICM_IDTextBox)
        Me.tabPartner.Controls.Add(PartnerNameLabel)
        Me.tabPartner.Controls.Add(Me.PartnerNameTextBox)
        Me.tabPartner.Location = New System.Drawing.Point(4, 4)
        Me.tabPartner.Name = "tabPartner"
        Me.tabPartner.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPartner.Size = New System.Drawing.Size(924, 465)
        Me.tabPartner.TabIndex = 1
        Me.tabPartner.Text = "Partner"
        Me.tabPartner.UseVisualStyleBackColor = True
        '
        'btnNewPartner
        '
        Me.btnNewPartner.Location = New System.Drawing.Point(344, 25)
        Me.btnNewPartner.Name = "btnNewPartner"
        Me.btnNewPartner.Size = New System.Drawing.Size(75, 23)
        Me.btnNewPartner.TabIndex = 16
        Me.btnNewPartner.Text = "New"
        Me.btnNewPartner.UseVisualStyleBackColor = True
        '
        'DsAddressDataGridView
        '
        Me.DsAddressDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DsAddressDataGridView.AutoGenerateColumns = False
        Me.DsAddressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsAddressDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.DsAddressDataGridView.DataSource = Me.DsAddressBindingSource
        Me.DsAddressDataGridView.Location = New System.Drawing.Point(9, 321)
        Me.DsAddressDataGridView.Name = "DsAddressDataGridView"
        Me.DsAddressDataGridView.Size = New System.Drawing.Size(907, 138)
        Me.DsAddressDataGridView.TabIndex = 15
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
        'DsAddressBindingSource
        '
        Me.DsAddressBindingSource.DataMember = "dsPartnerdsAddress"
        Me.DsAddressBindingSource.DataSource = Me.DsPartnerBindingSource
        '
        'DsContactDataGridView
        '
        Me.DsContactDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DsContactDataGridView.AutoGenerateColumns = False
        Me.DsContactDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsContactDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DsContactDataGridView.DataSource = Me.DsContactBindingSource
        Me.DsContactDataGridView.Location = New System.Drawing.Point(9, 85)
        Me.DsContactDataGridView.Name = "DsContactDataGridView"
        Me.DsContactDataGridView.Size = New System.Drawing.Size(907, 230)
        Me.DsContactDataGridView.TabIndex = 14
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
        'DsContactBindingSource
        '
        Me.DsContactBindingSource.DataMember = "dsPartnerdsContact"
        Me.DsContactBindingSource.DataSource = Me.DsPartnerBindingSource
        '
        'Tango_IDTextBox
        '
        Me.Tango_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPartnerBindingSource, "Tango_ID", True))
        Me.Tango_IDTextBox.Location = New System.Drawing.Point(87, 33)
        Me.Tango_IDTextBox.Name = "Tango_IDTextBox"
        Me.Tango_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tango_IDTextBox.TabIndex = 5
        '
        'ICM_IDTextBox
        '
        Me.ICM_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPartnerBindingSource, "ICM_ID", True))
        Me.ICM_IDTextBox.Location = New System.Drawing.Point(87, 59)
        Me.ICM_IDTextBox.Name = "ICM_IDTextBox"
        Me.ICM_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ICM_IDTextBox.TabIndex = 7
        '
        'PartnerNameTextBox
        '
        Me.PartnerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPartnerBindingSource, "PartnerName", True))
        Me.PartnerNameTextBox.Location = New System.Drawing.Point(87, 7)
        Me.PartnerNameTextBox.Name = "PartnerNameTextBox"
        Me.PartnerNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PartnerNameTextBox.TabIndex = 9
        '
        'DsContactTableAdapter
        '
        Me.DsContactTableAdapter.ClearBeforeFill = True
        '
        'DsAddressTableAdapter
        '
        Me.DsAddressTableAdapter.ClearBeforeFill = True
        '
        'UNLOCTableAdapter
        '
        Me.UNLOCTableAdapter.ClearBeforeFill = True
        '
        'DsCommentBindingSource
        '
        Me.DsCommentBindingSource.DataMember = "dsShipmentsdsComment"
        Me.DsCommentBindingSource.DataSource = Me.DsShipmentsBindingSource
        '
        'DsCommentTableAdapter
        '
        Me.DsCommentTableAdapter.ClearBeforeFill = True
        '
        'DsCommentDataGridView
        '
        Me.DsCommentDataGridView.AutoGenerateColumns = False
        Me.DsCommentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsCommentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn23})
        Me.DsCommentDataGridView.DataSource = Me.DsCommentBindingSource
        Me.DsCommentDataGridView.Location = New System.Drawing.Point(381, 257)
        Me.DsCommentDataGridView.Name = "DsCommentDataGridView"
        Me.DsCommentDataGridView.Size = New System.Drawing.Size(281, 150)
        Me.DsCommentDataGridView.TabIndex = 86
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Comment_ID"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Comment_ID"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Shipment_ID"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Shipment_ID"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Created"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Created"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Public"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Public"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "txtComment"
        Me.DataGridViewTextBoxColumn23.HeaderText = "txtComment"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'frmMaininterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 575)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.cmbField)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DsShipmentsBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMaininterface"
        Me.Text = "Demag HUB"
        CType(Me.DsDemag_HUB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsShipmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsShipmentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DsShipmentsBindingNavigator.ResumeLayout(False)
        Me.DsShipmentsBindingNavigator.PerformLayout()
        Me.subTabShipments.ResumeLayout(False)
        Me.tabBooking.ResumeLayout(False)
        Me.tabBooking.PerformLayout()
        CType(Me.UNLOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPartnerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncotermBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl3.ResumeLayout(False)
        Me.tabShipments.ResumeLayout(False)
        Me.tabShipments.PerformLayout()
        Me.tabPartner.ResumeLayout(False)
        Me.tabPartner.PerformLayout()
        CType(Me.DsAddressDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContactDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContactBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCommentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCommentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsDemag_HUB As dsDemag_HUB
    Friend WithEvents DsShipmentsBindingSource As BindingSource
    Friend WithEvents DsShipmentsTableAdapter As dsDemag_HUBTableAdapters.dsShipmentsTableAdapter
    Friend WithEvents TableAdapterManager As dsDemag_HUBTableAdapters.TableAdapterManager
    Friend WithEvents DsShipmentsBindingNavigator As BindingNavigator
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
    Friend WithEvents DsShipmentsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents subTabShipments As TabControl
    Friend WithEvents tabSettings As TabPage
    Friend WithEvents tabShipping As TabPage
    Friend WithEvents tabDispo As TabPage
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents IncotermTableAdapter As dsDemag_HUBTableAdapters.IncotermTableAdapter
    Friend WithEvents tabBooking As TabPage
    Friend WithEvents IncotermTextBox As ComboBox
    Friend WithEvents ServiceTextBox As ComboBox
    Friend WithEvents Shipment_IDTextBox As TextBox
    Friend WithEvents STT_NoTextBox As TextBox
    Friend WithEvents POL_NoTextBox As TextBox
    Friend WithEvents VesselTextBox As TextBox
    Friend WithEvents Contract_NoTextBox As TextBox
    Friend WithEvents VolumeTextBox As TextBox
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents TEUTextBox As TextBox
    Friend WithEvents Cont20DCTextBox As TextBox
    Friend WithEvents Cont40DCTextBox As TextBox
    Friend WithEvents Cont40HQTextBox As TextBox
    Friend WithEvents txtSearch As Watermark
    Friend WithEvents cmbField As ComboBox
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents IncotermBindingSource As BindingSource
    Friend WithEvents DsPartnerTableAdapter As dsDemag_HUBTableAdapters.dsPartnerTableAdapter
    Friend WithEvents PrincipalTextBox As ComboBox
    Friend WithEvents DsPartnerBindingSource As BindingSource
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents tabShipments As TabPage
    Friend WithEvents tabPartner As TabPage
    Friend WithEvents Tango_IDTextBox As TextBox
    Friend WithEvents ICM_IDTextBox As TextBox
    Friend WithEvents PartnerNameTextBox As TextBox
    Friend WithEvents DsContactBindingSource As BindingSource
    Friend WithEvents DsContactTableAdapter As dsDemag_HUBTableAdapters.dsContactTableAdapter
    Friend WithEvents DsContactDataGridView As DataGridView
    Friend WithEvents DsAddressBindingSource As BindingSource
    Friend WithEvents DsAddressTableAdapter As dsDemag_HUBTableAdapters.dsAddressTableAdapter
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
    Friend WithEvents btnNewPartner As Button
    Friend WithEvents ConsigneeTextBox As ComboBox
    Friend WithEvents ShipperTextBox As ComboBox
    Friend WithEvents CarrierTextBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tabDocuments As TabPage
    Friend WithEvents FullPOLTextBox As ComboBox
    Friend WithEvents POLTextBox As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents UNLOCBindingSource As BindingSource
    Friend WithEvents UNLOCTableAdapter As dsDemag_HUBTableAdapters.UNLOCTableAdapter
    Friend WithEvents FullIncoterm_LocTextBox As ComboBox
    Friend WithEvents Incoterm_LocTextBox As ComboBox
    Friend WithEvents FullPODTextBox As ComboBox
    Friend WithEvents PODTextBox As ComboBox
    Friend WithEvents dtnCRD As TextBox
    Friend WithEvents dtnETA As TextBox
    Friend WithEvents dtnETD As TextBox
    Friend WithEvents DsCommentBindingSource As BindingSource
    Friend WithEvents DsCommentTableAdapter As dsDemag_HUBTableAdapters.dsCommentTableAdapter
    Friend WithEvents DsCommentDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
End Class
