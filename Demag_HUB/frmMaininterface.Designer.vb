<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaininterface
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaininterface))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.subTabShipments = New System.Windows.Forms.TabControl()
        Me.tabOverview = New System.Windows.Forms.TabPage()
        Me.DsShipmentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DsShipmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDemag_HUB = New Demag_HUB.dsDemag_HUB()
        Me.txtSearch = New Demag_HUB.Watermark()
        Me.cmbField = New System.Windows.Forms.ComboBox()
        Me.tabBooking = New System.Windows.Forms.TabPage()
        Me.DsShipment_SODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn82 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn83 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsShipment_SOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDeleteSO = New System.Windows.Forms.Button()
        Me.btnAddSO = New System.Windows.Forms.Button()
        Me.txtSoNo = New System.Windows.Forms.TextBox()
        Me.DsShipment_OrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsShipment_OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDeletePO = New System.Windows.Forms.Button()
        Me.btnAddPO = New System.Windows.Forms.Button()
        Me.txtPoNo = New System.Windows.Forms.TextBox()
        Me.btnaddDocument = New System.Windows.Forms.Button()
        Me.DsInvoiceDataGridView = New System.Windows.Forms.DataGridView()
        Me.InvoiceNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LinkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.CreatedDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsShipmentsdsInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCommentDataGridView = New System.Windows.Forms.DataGridView()
        Me.TxtCommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublicDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsShipmentsdsCommentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.PoShipping_OrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn80 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn81 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn84 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn85 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn86 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn87 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn88 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn89 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn90 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn91 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn92 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn93 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn94 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoShipping_OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UNLOCDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn73 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn74 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn75 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn76 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn77 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn78 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn79 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoOrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PoOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCommentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.tabShipments = New System.Windows.Forms.TabPage()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Label_Result = New System.Windows.Forms.Label()
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
        Me.dlgFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.dsInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsShipmentsTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsShipmentsTableAdapter()
        Me.TableAdapterManager = New Demag_HUB.dsDemag_HUBTableAdapters.TableAdapterManager()
        Me.DsPartnerTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsPartnerTableAdapter()
        Me.IncotermTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.IncotermTableAdapter()
        Me.DsContactTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsContactTableAdapter()
        Me.DsAddressTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsAddressTableAdapter()
        Me.UNLOCTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.UNLOCTableAdapter()
        Me.DsCommentTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsCommentTableAdapter()
        Me.DsInvoiceTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsInvoiceTableAdapter()
        Me.DsShipment_OrderTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsShipment_OrderTableAdapter()
        Me.PoOrderTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.poOrderTableAdapter()
        Me.DsShipment_SOTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsShipment_SOTableAdapter()
        Me.PoShipping_OrderTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.poShipping_OrderTableAdapter()
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
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.subTabShipments.SuspendLayout()
        Me.tabOverview.SuspendLayout()
        CType(Me.DsShipmentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsShipmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDemag_HUB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBooking.SuspendLayout()
        CType(Me.DsShipment_SODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsShipment_SOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsShipment_OrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsShipment_OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsInvoiceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsShipmentsdsInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCommentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsShipmentsdsCommentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNLOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPartnerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncotermBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDocuments.SuspendLayout()
        CType(Me.PoShipping_OrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PoShipping_OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNLOCDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PoOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PoOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCommentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl3.SuspendLayout()
        Me.tabShipments.SuspendLayout()
        Me.tabPartner.SuspendLayout()
        CType(Me.DsAddressDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContactDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContactBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(6, 346)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(47, 13)
        Label3.TabIndex = 93
        Label3.Text = "Add PO:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(355, 346)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(47, 13)
        Label4.TabIndex = 97
        Label4.Text = "Add SO:"
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
        Me.subTabShipments.Controls.Add(Me.tabOverview)
        Me.subTabShipments.Controls.Add(Me.tabBooking)
        Me.subTabShipments.Controls.Add(Me.tabShipping)
        Me.subTabShipments.Controls.Add(Me.tabDispo)
        Me.subTabShipments.Controls.Add(Me.tabDocuments)
        Me.subTabShipments.Location = New System.Drawing.Point(145, 6)
        Me.subTabShipments.Name = "subTabShipments"
        Me.subTabShipments.SelectedIndex = 0
        Me.subTabShipments.Size = New System.Drawing.Size(773, 675)
        Me.subTabShipments.TabIndex = 2
        '
        'tabOverview
        '
        Me.tabOverview.Controls.Add(Me.DsShipmentsDataGridView)
        Me.tabOverview.Controls.Add(Me.txtSearch)
        Me.tabOverview.Controls.Add(Me.cmbField)
        Me.tabOverview.Location = New System.Drawing.Point(4, 22)
        Me.tabOverview.Name = "tabOverview"
        Me.tabOverview.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOverview.Size = New System.Drawing.Size(765, 649)
        Me.tabOverview.TabIndex = 5
        Me.tabOverview.Text = "Overview"
        Me.tabOverview.UseVisualStyleBackColor = True
        '
        'DsShipmentsDataGridView
        '
        Me.DsShipmentsDataGridView.AllowUserToAddRows = False
        Me.DsShipmentsDataGridView.AllowUserToDeleteRows = False
        Me.DsShipmentsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DsShipmentsDataGridView.AutoGenerateColumns = False
        Me.DsShipmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsShipmentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2})
        Me.DsShipmentsDataGridView.DataSource = Me.DsShipmentsBindingSource
        Me.DsShipmentsDataGridView.Location = New System.Drawing.Point(6, 32)
        Me.DsShipmentsDataGridView.Name = "DsShipmentsDataGridView"
        Me.DsShipmentsDataGridView.ReadOnly = True
        Me.DsShipmentsDataGridView.Size = New System.Drawing.Size(753, 611)
        Me.DsShipmentsDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Shipment_ID"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Shipment_ID"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "STT_No"
        Me.DataGridViewTextBoxColumn26.HeaderText = "STT_No"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Archive_No"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Archive_No"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "HBL_No"
        Me.DataGridViewTextBoxColumn28.HeaderText = "HBL_No"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "MBL_No"
        Me.DataGridViewTextBoxColumn29.HeaderText = "MBL_No"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "POL_No"
        Me.DataGridViewTextBoxColumn30.HeaderText = "POL_No"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Service"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Service"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Incoterm"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Incoterm"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Incoterm_Loc"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Incoterm_Loc"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Principal"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Principal"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "Shipper"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Shipper"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "Consignee"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Consignee"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "POL"
        Me.DataGridViewTextBoxColumn37.HeaderText = "POL"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "POD"
        Me.DataGridViewTextBoxColumn38.HeaderText = "POD"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "Terminal"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Terminal"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "Vessel"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Vessel"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "Carrier"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Carrier"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "Contract_No"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Contract_No"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "Volume"
        Me.DataGridViewTextBoxColumn43.HeaderText = "Volume"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "Weight"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Weight"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "TEU"
        Me.DataGridViewTextBoxColumn45.HeaderText = "TEU"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "Cont20DC"
        Me.DataGridViewTextBoxColumn46.HeaderText = "Cont20DC"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "Cont40DC"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Cont40DC"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "Cont40HQ"
        Me.DataGridViewTextBoxColumn48.HeaderText = "Cont40HQ"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "dtnCRD"
        Me.DataGridViewTextBoxColumn49.HeaderText = "dtnCRD"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "dtnETD"
        Me.DataGridViewTextBoxColumn50.HeaderText = "dtnETD"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.ReadOnly = True
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "dtnATD"
        Me.DataGridViewTextBoxColumn51.HeaderText = "dtnATD"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "dtnETA"
        Me.DataGridViewTextBoxColumn52.HeaderText = "dtnETA"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "dtnATA"
        Me.DataGridViewTextBoxColumn53.HeaderText = "dtnATA"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "dtnETS"
        Me.DataGridViewTextBoxColumn54.HeaderText = "dtnETS"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.ReadOnly = True
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "ECO_Month"
        Me.DataGridViewTextBoxColumn55.HeaderText = "ECO_Month"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "dtnSurendered"
        Me.DataGridViewTextBoxColumn56.HeaderText = "dtnSurendered"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.ReadOnly = True
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "dtnDocuments"
        Me.DataGridViewTextBoxColumn57.HeaderText = "dtnDocuments"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Closed"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Closed"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Cancelled"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Cancelled"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        '
        'DsShipmentsBindingSource
        '
        Me.DsShipmentsBindingSource.DataMember = "dsShipments"
        Me.DsShipmentsBindingSource.DataSource = Me.DsDemag_HUB
        '
        'DsDemag_HUB
        '
        Me.DsDemag_HUB.DataSetName = "dsDemag_HUB"
        Me.DsDemag_HUB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(6, 6)
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
        Me.cmbField.Items.AddRange(New Object() {"ShipmentID", "STT No.:", "Archive No.:", "HBL No.:", "MBL No.:", "POL No.:", "PO No.:", "SO No.:", "Inv No.:"})
        Me.cmbField.Location = New System.Drawing.Point(227, 6)
        Me.cmbField.Name = "cmbField"
        Me.cmbField.Size = New System.Drawing.Size(121, 21)
        Me.cmbField.TabIndex = 12
        '
        'tabBooking
        '
        Me.tabBooking.AutoScroll = True
        Me.tabBooking.Controls.Add(Me.DsShipment_SODataGridView)
        Me.tabBooking.Controls.Add(Me.btnDeleteSO)
        Me.tabBooking.Controls.Add(Me.btnAddSO)
        Me.tabBooking.Controls.Add(Label4)
        Me.tabBooking.Controls.Add(Me.txtSoNo)
        Me.tabBooking.Controls.Add(Me.DsShipment_OrderDataGridView)
        Me.tabBooking.Controls.Add(Me.btnDeletePO)
        Me.tabBooking.Controls.Add(Me.btnAddPO)
        Me.tabBooking.Controls.Add(Label3)
        Me.tabBooking.Controls.Add(Me.txtPoNo)
        Me.tabBooking.Controls.Add(Me.btnaddDocument)
        Me.tabBooking.Controls.Add(Me.DsInvoiceDataGridView)
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
        Me.tabBooking.Size = New System.Drawing.Size(765, 649)
        Me.tabBooking.TabIndex = 1
        Me.tabBooking.Text = "Booking"
        Me.tabBooking.UseVisualStyleBackColor = True
        '
        'DsShipment_SODataGridView
        '
        Me.DsShipment_SODataGridView.AutoGenerateColumns = False
        Me.DsShipment_SODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsShipment_SODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn82, Me.DataGridViewTextBoxColumn83})
        Me.DsShipment_SODataGridView.DataSource = Me.DsShipment_SOBindingSource
        Me.DsShipment_SODataGridView.Location = New System.Drawing.Point(358, 369)
        Me.DsShipment_SODataGridView.Name = "DsShipment_SODataGridView"
        Me.DsShipment_SODataGridView.Size = New System.Drawing.Size(400, 95)
        Me.DsShipment_SODataGridView.TabIndex = 100
        '
        'DataGridViewTextBoxColumn82
        '
        Me.DataGridViewTextBoxColumn82.DataPropertyName = "Shipping_Order"
        Me.DataGridViewTextBoxColumn82.HeaderText = "Shipping_Order"
        Me.DataGridViewTextBoxColumn82.Name = "DataGridViewTextBoxColumn82"
        '
        'DataGridViewTextBoxColumn83
        '
        Me.DataGridViewTextBoxColumn83.DataPropertyName = "Created"
        Me.DataGridViewTextBoxColumn83.HeaderText = "Created"
        Me.DataGridViewTextBoxColumn83.Name = "DataGridViewTextBoxColumn83"
        '
        'DsShipment_SOBindingSource
        '
        Me.DsShipment_SOBindingSource.DataMember = "dsShipmentsdsShipment_SO"
        Me.DsShipment_SOBindingSource.DataSource = Me.DsShipmentsBindingSource
        '
        'btnDeleteSO
        '
        Me.btnDeleteSO.Location = New System.Drawing.Point(545, 340)
        Me.btnDeleteSO.Name = "btnDeleteSO"
        Me.btnDeleteSO.Size = New System.Drawing.Size(25, 25)
        Me.btnDeleteSO.TabIndex = 100
        Me.btnDeleteSO.TabStop = False
        Me.btnDeleteSO.Text = "-"
        Me.btnDeleteSO.UseVisualStyleBackColor = True
        Me.btnDeleteSO.Visible = False
        '
        'btnAddSO
        '
        Me.btnAddSO.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddSO.Location = New System.Drawing.Point(514, 340)
        Me.btnAddSO.Name = "btnAddSO"
        Me.btnAddSO.Size = New System.Drawing.Size(25, 25)
        Me.btnAddSO.TabIndex = 98
        Me.btnAddSO.TabStop = False
        Me.btnAddSO.Text = "+"
        Me.btnAddSO.UseVisualStyleBackColor = True
        '
        'txtSoNo
        '
        Me.txtSoNo.Location = New System.Drawing.Point(408, 343)
        Me.txtSoNo.Name = "txtSoNo"
        Me.txtSoNo.Size = New System.Drawing.Size(100, 20)
        Me.txtSoNo.TabIndex = 96
        '
        'DsShipment_OrderDataGridView
        '
        Me.DsShipment_OrderDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DsShipment_OrderDataGridView.AutoGenerateColumns = False
        Me.DsShipment_OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsShipment_OrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.DsShipment_OrderDataGridView.DataSource = Me.DsShipment_OrderBindingSource
        Me.DsShipment_OrderDataGridView.Location = New System.Drawing.Point(9, 369)
        Me.DsShipment_OrderDataGridView.Name = "DsShipment_OrderDataGridView"
        Me.DsShipment_OrderDataGridView.Size = New System.Drawing.Size(343, 95)
        Me.DsShipment_OrderDataGridView.TabIndex = 95
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Shipment_Order_ID"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Shipment_Order_ID"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Shipment_ID"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Shipment_ID"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Purchase_Order"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Purchase_Order"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Created"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Created"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DsShipment_OrderBindingSource
        '
        Me.DsShipment_OrderBindingSource.DataMember = "dsShipmentsdsShipment_Order"
        Me.DsShipment_OrderBindingSource.DataSource = Me.DsShipmentsBindingSource
        '
        'btnDeletePO
        '
        Me.btnDeletePO.Location = New System.Drawing.Point(196, 340)
        Me.btnDeletePO.Name = "btnDeletePO"
        Me.btnDeletePO.Size = New System.Drawing.Size(25, 25)
        Me.btnDeletePO.TabIndex = 95
        Me.btnDeletePO.TabStop = False
        Me.btnDeletePO.Text = "-"
        Me.btnDeletePO.UseVisualStyleBackColor = True
        Me.btnDeletePO.Visible = False
        '
        'btnAddPO
        '
        Me.btnAddPO.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddPO.Location = New System.Drawing.Point(165, 340)
        Me.btnAddPO.Name = "btnAddPO"
        Me.btnAddPO.Size = New System.Drawing.Size(25, 25)
        Me.btnAddPO.TabIndex = 94
        Me.btnAddPO.TabStop = False
        Me.btnAddPO.Text = "+"
        Me.btnAddPO.UseVisualStyleBackColor = True
        '
        'txtPoNo
        '
        Me.txtPoNo.Location = New System.Drawing.Point(59, 343)
        Me.txtPoNo.Name = "txtPoNo"
        Me.txtPoNo.Size = New System.Drawing.Size(100, 20)
        Me.txtPoNo.TabIndex = 92
        '
        'btnaddDocument
        '
        Me.btnaddDocument.AllowDrop = True
        Me.btnaddDocument.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnaddDocument.Location = New System.Drawing.Point(673, 470)
        Me.btnaddDocument.Name = "btnaddDocument"
        Me.btnaddDocument.Size = New System.Drawing.Size(86, 89)
        Me.btnaddDocument.TabIndex = 90
        Me.btnaddDocument.Text = "Add Document"
        Me.btnaddDocument.UseVisualStyleBackColor = True
        '
        'DsInvoiceDataGridView
        '
        Me.DsInvoiceDataGridView.AllowUserToAddRows = False
        Me.DsInvoiceDataGridView.AllowUserToDeleteRows = False
        Me.DsInvoiceDataGridView.AutoGenerateColumns = False
        Me.DsInvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsInvoiceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InvoiceNoDataGridViewTextBoxColumn, Me.LinkDataGridViewTextBoxColumn, Me.CreatedDataGridViewTextBoxColumn1})
        Me.DsInvoiceDataGridView.DataSource = Me.DsShipmentsdsInvoiceBindingSource
        Me.DsInvoiceDataGridView.Location = New System.Drawing.Point(9, 470)
        Me.DsInvoiceDataGridView.Name = "DsInvoiceDataGridView"
        Me.DsInvoiceDataGridView.ReadOnly = True
        Me.DsInvoiceDataGridView.Size = New System.Drawing.Size(658, 89)
        Me.DsInvoiceDataGridView.TabIndex = 88
        '
        'InvoiceNoDataGridViewTextBoxColumn
        '
        Me.InvoiceNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.InvoiceNoDataGridViewTextBoxColumn.DataPropertyName = "Invoice_No"
        Me.InvoiceNoDataGridViewTextBoxColumn.HeaderText = "Invoice_No"
        Me.InvoiceNoDataGridViewTextBoxColumn.Name = "InvoiceNoDataGridViewTextBoxColumn"
        Me.InvoiceNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LinkDataGridViewTextBoxColumn
        '
        Me.LinkDataGridViewTextBoxColumn.DataPropertyName = "Link"
        Me.LinkDataGridViewTextBoxColumn.HeaderText = "Link"
        Me.LinkDataGridViewTextBoxColumn.Name = "LinkDataGridViewTextBoxColumn"
        Me.LinkDataGridViewTextBoxColumn.ReadOnly = True
        Me.LinkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LinkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CreatedDataGridViewTextBoxColumn1
        '
        Me.CreatedDataGridViewTextBoxColumn1.DataPropertyName = "Created"
        Me.CreatedDataGridViewTextBoxColumn1.HeaderText = "Created"
        Me.CreatedDataGridViewTextBoxColumn1.Name = "CreatedDataGridViewTextBoxColumn1"
        Me.CreatedDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DsShipmentsdsInvoiceBindingSource
        '
        Me.DsShipmentsdsInvoiceBindingSource.DataMember = "dsShipmentsdsInvoice"
        Me.DsShipmentsdsInvoiceBindingSource.DataSource = Me.DsShipmentsBindingSource
        '
        'DsCommentDataGridView
        '
        Me.DsCommentDataGridView.AllowUserToDeleteRows = False
        Me.DsCommentDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DsCommentDataGridView.AutoGenerateColumns = False
        Me.DsCommentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsCommentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TxtCommentDataGridViewTextBoxColumn, Me.PublicDataGridViewCheckBoxColumn, Me.CreatedDataGridViewTextBoxColumn})
        Me.DsCommentDataGridView.DataSource = Me.DsShipmentsdsCommentBindingSource
        Me.DsCommentDataGridView.Location = New System.Drawing.Point(9, 565)
        Me.DsCommentDataGridView.Name = "DsCommentDataGridView"
        Me.DsCommentDataGridView.Size = New System.Drawing.Size(749, 78)
        Me.DsCommentDataGridView.TabIndex = 89
        '
        'TxtCommentDataGridViewTextBoxColumn
        '
        Me.TxtCommentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TxtCommentDataGridViewTextBoxColumn.DataPropertyName = "txtComment"
        Me.TxtCommentDataGridViewTextBoxColumn.HeaderText = "txtComment"
        Me.TxtCommentDataGridViewTextBoxColumn.Name = "TxtCommentDataGridViewTextBoxColumn"
        '
        'PublicDataGridViewCheckBoxColumn
        '
        Me.PublicDataGridViewCheckBoxColumn.DataPropertyName = "Public"
        Me.PublicDataGridViewCheckBoxColumn.HeaderText = "Public"
        Me.PublicDataGridViewCheckBoxColumn.Name = "PublicDataGridViewCheckBoxColumn"
        '
        'CreatedDataGridViewTextBoxColumn
        '
        Me.CreatedDataGridViewTextBoxColumn.DataPropertyName = "Created"
        Me.CreatedDataGridViewTextBoxColumn.HeaderText = "Created"
        Me.CreatedDataGridViewTextBoxColumn.Name = "CreatedDataGridViewTextBoxColumn"
        '
        'DsShipmentsdsCommentBindingSource
        '
        Me.DsShipmentsdsCommentBindingSource.DataMember = "dsShipmentsdsComment"
        Me.DsShipmentsdsCommentBindingSource.DataSource = Me.DsShipmentsBindingSource
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
        Me.tabShipping.Size = New System.Drawing.Size(765, 649)
        Me.tabShipping.TabIndex = 2
        Me.tabShipping.Text = "Shipping"
        Me.tabShipping.UseVisualStyleBackColor = True
        '
        'tabDispo
        '
        Me.tabDispo.Location = New System.Drawing.Point(4, 22)
        Me.tabDispo.Name = "tabDispo"
        Me.tabDispo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDispo.Size = New System.Drawing.Size(765, 649)
        Me.tabDispo.TabIndex = 3
        Me.tabDispo.Text = "Dispo"
        Me.tabDispo.UseVisualStyleBackColor = True
        '
        'tabDocuments
        '
        Me.tabDocuments.AutoScroll = True
        Me.tabDocuments.Controls.Add(Me.PoShipping_OrderDataGridView)
        Me.tabDocuments.Controls.Add(Me.UNLOCDataGridView)
        Me.tabDocuments.Controls.Add(Me.PoOrderDataGridView)
        Me.tabDocuments.Location = New System.Drawing.Point(4, 22)
        Me.tabDocuments.Name = "tabDocuments"
        Me.tabDocuments.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDocuments.Size = New System.Drawing.Size(765, 649)
        Me.tabDocuments.TabIndex = 4
        Me.tabDocuments.Text = "Documents"
        Me.tabDocuments.UseVisualStyleBackColor = True
        '
        'PoShipping_OrderDataGridView
        '
        Me.PoShipping_OrderDataGridView.AutoGenerateColumns = False
        Me.PoShipping_OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PoShipping_OrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn80, Me.DataGridViewTextBoxColumn81, Me.DataGridViewTextBoxColumn84, Me.DataGridViewTextBoxColumn85, Me.DataGridViewTextBoxColumn86, Me.DataGridViewTextBoxColumn87, Me.DataGridViewTextBoxColumn88, Me.DataGridViewTextBoxColumn89, Me.DataGridViewTextBoxColumn90, Me.DataGridViewTextBoxColumn91, Me.DataGridViewTextBoxColumn92, Me.DataGridViewTextBoxColumn93, Me.DataGridViewTextBoxColumn94})
        Me.PoShipping_OrderDataGridView.DataSource = Me.PoShipping_OrderBindingSource
        Me.PoShipping_OrderDataGridView.Location = New System.Drawing.Point(379, 256)
        Me.PoShipping_OrderDataGridView.Name = "PoShipping_OrderDataGridView"
        Me.PoShipping_OrderDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.PoShipping_OrderDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn80
        '
        Me.DataGridViewTextBoxColumn80.DataPropertyName = "Shipping_Order"
        Me.DataGridViewTextBoxColumn80.HeaderText = "Shipping_Order"
        Me.DataGridViewTextBoxColumn80.Name = "DataGridViewTextBoxColumn80"
        '
        'DataGridViewTextBoxColumn81
        '
        Me.DataGridViewTextBoxColumn81.DataPropertyName = "Created"
        Me.DataGridViewTextBoxColumn81.HeaderText = "Created"
        Me.DataGridViewTextBoxColumn81.Name = "DataGridViewTextBoxColumn81"
        '
        'DataGridViewTextBoxColumn84
        '
        Me.DataGridViewTextBoxColumn84.DataPropertyName = "SO_Created"
        Me.DataGridViewTextBoxColumn84.HeaderText = "SO_Created"
        Me.DataGridViewTextBoxColumn84.Name = "DataGridViewTextBoxColumn84"
        '
        'DataGridViewTextBoxColumn85
        '
        Me.DataGridViewTextBoxColumn85.DataPropertyName = "Transport_Mode"
        Me.DataGridViewTextBoxColumn85.HeaderText = "Transport_Mode"
        Me.DataGridViewTextBoxColumn85.Name = "DataGridViewTextBoxColumn85"
        '
        'DataGridViewTextBoxColumn86
        '
        Me.DataGridViewTextBoxColumn86.DataPropertyName = "Incoterm"
        Me.DataGridViewTextBoxColumn86.HeaderText = "Incoterm"
        Me.DataGridViewTextBoxColumn86.Name = "DataGridViewTextBoxColumn86"
        '
        'DataGridViewTextBoxColumn87
        '
        Me.DataGridViewTextBoxColumn87.DataPropertyName = "Supplier"
        Me.DataGridViewTextBoxColumn87.HeaderText = "Supplier"
        Me.DataGridViewTextBoxColumn87.Name = "DataGridViewTextBoxColumn87"
        '
        'DataGridViewTextBoxColumn88
        '
        Me.DataGridViewTextBoxColumn88.DataPropertyName = "Volume"
        Me.DataGridViewTextBoxColumn88.HeaderText = "Volume"
        Me.DataGridViewTextBoxColumn88.Name = "DataGridViewTextBoxColumn88"
        '
        'DataGridViewTextBoxColumn89
        '
        Me.DataGridViewTextBoxColumn89.DataPropertyName = "Weight"
        Me.DataGridViewTextBoxColumn89.HeaderText = "Weight"
        Me.DataGridViewTextBoxColumn89.Name = "DataGridViewTextBoxColumn89"
        '
        'DataGridViewTextBoxColumn90
        '
        Me.DataGridViewTextBoxColumn90.DataPropertyName = "POL"
        Me.DataGridViewTextBoxColumn90.HeaderText = "POL"
        Me.DataGridViewTextBoxColumn90.Name = "DataGridViewTextBoxColumn90"
        '
        'DataGridViewTextBoxColumn91
        '
        Me.DataGridViewTextBoxColumn91.DataPropertyName = "Shipping_Order_Status"
        Me.DataGridViewTextBoxColumn91.HeaderText = "Shipping_Order_Status"
        Me.DataGridViewTextBoxColumn91.Name = "DataGridViewTextBoxColumn91"
        '
        'DataGridViewTextBoxColumn92
        '
        Me.DataGridViewTextBoxColumn92.DataPropertyName = "Last_Update"
        Me.DataGridViewTextBoxColumn92.HeaderText = "Last_Update"
        Me.DataGridViewTextBoxColumn92.Name = "DataGridViewTextBoxColumn92"
        '
        'DataGridViewTextBoxColumn93
        '
        Me.DataGridViewTextBoxColumn93.DataPropertyName = "ETD"
        Me.DataGridViewTextBoxColumn93.HeaderText = "ETD"
        Me.DataGridViewTextBoxColumn93.Name = "DataGridViewTextBoxColumn93"
        '
        'DataGridViewTextBoxColumn94
        '
        Me.DataGridViewTextBoxColumn94.DataPropertyName = "Comment"
        Me.DataGridViewTextBoxColumn94.HeaderText = "Comment"
        Me.DataGridViewTextBoxColumn94.Name = "DataGridViewTextBoxColumn94"
        '
        'PoShipping_OrderBindingSource
        '
        Me.PoShipping_OrderBindingSource.DataMember = "poShipping_Order"
        Me.PoShipping_OrderBindingSource.DataSource = Me.DsDemag_HUB
        '
        'UNLOCDataGridView
        '
        Me.UNLOCDataGridView.AutoGenerateColumns = False
        Me.UNLOCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UNLOCDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn67, Me.DataGridViewTextBoxColumn68, Me.DataGridViewTextBoxColumn69, Me.DataGridViewTextBoxColumn70, Me.DataGridViewTextBoxColumn71, Me.DataGridViewTextBoxColumn72, Me.DataGridViewTextBoxColumn73, Me.DataGridViewTextBoxColumn74, Me.DataGridViewTextBoxColumn75, Me.DataGridViewTextBoxColumn76, Me.DataGridViewTextBoxColumn77, Me.DataGridViewTextBoxColumn78, Me.DataGridViewTextBoxColumn79})
        Me.UNLOCDataGridView.DataSource = Me.UNLOCBindingSource
        Me.UNLOCDataGridView.Location = New System.Drawing.Point(31, 251)
        Me.UNLOCDataGridView.Name = "UNLOCDataGridView"
        Me.UNLOCDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.UNLOCDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "UNLOC"
        Me.DataGridViewTextBoxColumn67.HeaderText = "UNLOC"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.DataPropertyName = "Change"
        Me.DataGridViewTextBoxColumn68.HeaderText = "Change"
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
        '
        'DataGridViewTextBoxColumn69
        '
        Me.DataGridViewTextBoxColumn69.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn69.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
        '
        'DataGridViewTextBoxColumn70
        '
        Me.DataGridViewTextBoxColumn70.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn70.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
        '
        'DataGridViewTextBoxColumn71
        '
        Me.DataGridViewTextBoxColumn71.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn71.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
        '
        'DataGridViewTextBoxColumn72
        '
        Me.DataGridViewTextBoxColumn72.DataPropertyName = "NameWoDiacritics"
        Me.DataGridViewTextBoxColumn72.HeaderText = "NameWoDiacritics"
        Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
        '
        'DataGridViewTextBoxColumn73
        '
        Me.DataGridViewTextBoxColumn73.DataPropertyName = "Subdivision"
        Me.DataGridViewTextBoxColumn73.HeaderText = "Subdivision"
        Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
        '
        'DataGridViewTextBoxColumn74
        '
        Me.DataGridViewTextBoxColumn74.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn74.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74"
        '
        'DataGridViewTextBoxColumn75
        '
        Me.DataGridViewTextBoxColumn75.DataPropertyName = "Function"
        Me.DataGridViewTextBoxColumn75.HeaderText = "Function"
        Me.DataGridViewTextBoxColumn75.Name = "DataGridViewTextBoxColumn75"
        '
        'DataGridViewTextBoxColumn76
        '
        Me.DataGridViewTextBoxColumn76.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn76.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn76.Name = "DataGridViewTextBoxColumn76"
        '
        'DataGridViewTextBoxColumn77
        '
        Me.DataGridViewTextBoxColumn77.DataPropertyName = "IATA"
        Me.DataGridViewTextBoxColumn77.HeaderText = "IATA"
        Me.DataGridViewTextBoxColumn77.Name = "DataGridViewTextBoxColumn77"
        '
        'DataGridViewTextBoxColumn78
        '
        Me.DataGridViewTextBoxColumn78.DataPropertyName = "Coordinates"
        Me.DataGridViewTextBoxColumn78.HeaderText = "Coordinates"
        Me.DataGridViewTextBoxColumn78.Name = "DataGridViewTextBoxColumn78"
        '
        'DataGridViewTextBoxColumn79
        '
        Me.DataGridViewTextBoxColumn79.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn79.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn79.Name = "DataGridViewTextBoxColumn79"
        '
        'PoOrderDataGridView
        '
        Me.PoOrderDataGridView.AutoGenerateColumns = False
        Me.PoOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PoOrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62, Me.DataGridViewTextBoxColumn63, Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn65, Me.DataGridViewTextBoxColumn66, Me.DataGridViewCheckBoxColumn3})
        Me.PoOrderDataGridView.DataSource = Me.PoOrderBindingSource
        Me.PoOrderDataGridView.Location = New System.Drawing.Point(6, 41)
        Me.PoOrderDataGridView.Name = "PoOrderDataGridView"
        Me.PoOrderDataGridView.Size = New System.Drawing.Size(753, 188)
        Me.PoOrderDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Purchase_Order"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Purchase_Order"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "Alias_Purchase_Order"
        Me.DataGridViewTextBoxColumn58.HeaderText = "Alias_Purchase_Order"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "Created"
        Me.DataGridViewTextBoxColumn59.HeaderText = "Created"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "Supplier"
        Me.DataGridViewTextBoxColumn60.HeaderText = "Supplier"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "Service"
        Me.DataGridViewTextBoxColumn61.HeaderText = "Service"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "Incoterm"
        Me.DataGridViewTextBoxColumn62.HeaderText = "Incoterm"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "Incoterm_Location"
        Me.DataGridViewTextBoxColumn63.HeaderText = "Incoterm_Location"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "Latest_On_Board"
        Me.DataGridViewTextBoxColumn64.HeaderText = "Latest_On_Board"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "Latest_Arrival"
        Me.DataGridViewTextBoxColumn65.HeaderText = "Latest_Arrival"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "Forwarding_Agent"
        Me.DataGridViewTextBoxColumn66.HeaderText = "Forwarding_Agent"
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Acceptance_Status"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Acceptance_Status"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'PoOrderBindingSource
        '
        Me.PoOrderBindingSource.DataMember = "poOrder"
        Me.PoOrderBindingSource.DataSource = Me.DsDemag_HUB
        '
        'DsCommentBindingSource
        '
        Me.DsCommentBindingSource.DataMember = "dsShipmentsdsComment"
        Me.DsCommentBindingSource.DataSource = Me.DsShipmentsBindingSource
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
        Me.tabSettings.Size = New System.Drawing.Size(924, 687)
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
        Me.TabControl3.Size = New System.Drawing.Size(932, 713)
        Me.TabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl3.TabIndex = 16
        '
        'tabShipments
        '
        Me.tabShipments.Controls.Add(Me.ProgressBar)
        Me.tabShipments.Controls.Add(Me.Label_Result)
        Me.tabShipments.Controls.Add(Me.Label2)
        Me.tabShipments.Controls.Add(Me.btnCancel)
        Me.tabShipments.Controls.Add(Me.subTabShipments)
        Me.tabShipments.Controls.Add(Me.btnNew)
        Me.tabShipments.Controls.Add(Me.btnSearch)
        Me.tabShipments.Controls.Add(Me.btnSave)
        Me.tabShipments.Location = New System.Drawing.Point(4, 4)
        Me.tabShipments.Name = "tabShipments"
        Me.tabShipments.Padding = New System.Windows.Forms.Padding(3)
        Me.tabShipments.Size = New System.Drawing.Size(924, 687)
        Me.tabShipments.TabIndex = 0
        Me.tabShipments.Text = "Shipments"
        Me.tabShipments.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(7, 624)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(133, 11)
        Me.ProgressBar.TabIndex = 81
        '
        'Label_Result
        '
        Me.Label_Result.AutoSize = True
        Me.Label_Result.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Result.Location = New System.Drawing.Point(6, 608)
        Me.Label_Result.Name = "Label_Result"
        Me.Label_Result.Size = New System.Drawing.Size(69, 13)
        Me.Label_Result.TabIndex = 80
        Me.Label_Result.Text = "Import Status"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(6, 641)
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
        Me.tabPartner.Size = New System.Drawing.Size(924, 687)
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
        'dlgFileDialog
        '
        Me.dlgFileDialog.FileName = "x"
        '
        'dsInvoiceBindingSource
        '
        Me.dsInvoiceBindingSource.DataMember = "dsShipmentsdsInvoice"
        Me.dsInvoiceBindingSource.DataSource = Me.DsShipmentsBindingSource
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
        'DsCommentTableAdapter
        '
        Me.DsCommentTableAdapter.ClearBeforeFill = True
        '
        'DsInvoiceTableAdapter
        '
        Me.DsInvoiceTableAdapter.ClearBeforeFill = True
        '
        'DsShipment_OrderTableAdapter
        '
        Me.DsShipment_OrderTableAdapter.ClearBeforeFill = True
        '
        'PoOrderTableAdapter
        '
        Me.PoOrderTableAdapter.ClearBeforeFill = True
        '
        'DsShipment_SOTableAdapter
        '
        Me.DsShipment_SOTableAdapter.ClearBeforeFill = True
        '
        'PoShipping_OrderTableAdapter
        '
        Me.PoShipping_OrderTableAdapter.ClearBeforeFill = True
        '
        'frmMaininterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 797)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMaininterface"
        Me.Text = "Demag HUB"
        Me.subTabShipments.ResumeLayout(False)
        Me.tabOverview.ResumeLayout(False)
        Me.tabOverview.PerformLayout()
        CType(Me.DsShipmentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsShipmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDemag_HUB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBooking.ResumeLayout(False)
        Me.tabBooking.PerformLayout()
        CType(Me.DsShipment_SODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsShipment_SOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsShipment_OrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsShipment_OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsInvoiceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsShipmentsdsInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCommentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsShipmentsdsCommentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNLOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPartnerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncotermBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDocuments.ResumeLayout(False)
        CType(Me.PoShipping_OrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PoShipping_OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNLOCDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PoOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PoOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCommentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl3.ResumeLayout(False)
        Me.tabShipments.ResumeLayout(False)
        Me.tabShipments.PerformLayout()
        Me.tabPartner.ResumeLayout(False)
        Me.tabPartner.PerformLayout()
        CType(Me.DsAddressDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContactDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContactBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsDemag_HUB As dsDemag_HUB
    Friend WithEvents DsShipmentsBindingSource As BindingSource
    Friend WithEvents DsShipmentsTableAdapter As dsDemag_HUBTableAdapters.dsShipmentsTableAdapter
    Friend WithEvents TableAdapterManager As dsDemag_HUBTableAdapters.TableAdapterManager
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
    Friend WithEvents btnaddDocument As Button
    Friend WithEvents DsInvoiceDataGridView As DataGridView
    Friend WithEvents DsCommentDataGridView As DataGridView
    Friend WithEvents DsShipmentsdsCommentBindingSource As BindingSource
    Friend WithEvents DsShipmentsdsInvoiceBindingSource As BindingSource
    Friend WithEvents DsInvoiceTableAdapter As dsDemag_HUBTableAdapters.dsInvoiceTableAdapter
    Friend WithEvents InvoiceNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LinkDataGridViewTextBoxColumn As DataGridViewLinkColumn
    Friend WithEvents CreatedDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TxtCommentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublicDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CreatedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDeletePO As Button
    Friend WithEvents btnAddPO As Button
    Friend WithEvents txtPoNo As TextBox
    Friend WithEvents dlgFileDialog As OpenFileDialog
    Friend WithEvents dsInvoiceBindingSource As BindingSource
    Friend WithEvents DsShipment_OrderBindingSource As BindingSource
    Friend WithEvents DsShipment_OrderTableAdapter As dsDemag_HUBTableAdapters.dsShipment_OrderTableAdapter
    Friend WithEvents DsShipment_OrderDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents PoOrderBindingSource As BindingSource
    Friend WithEvents PoOrderTableAdapter As dsDemag_HUBTableAdapters.poOrderTableAdapter
    Friend WithEvents tabOverview As TabPage
    Friend WithEvents DsShipmentsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents Label_Result As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents PoOrderDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents UNLOCDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn67 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn69 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn70 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn71 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn72 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn73 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn74 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn75 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn76 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn77 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn78 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn79 As DataGridViewTextBoxColumn
    Friend WithEvents btnDeleteSO As Button
    Friend WithEvents btnAddSO As Button
    Friend WithEvents txtSoNo As TextBox
    Friend WithEvents DsShipment_SOBindingSource As BindingSource
    Friend WithEvents DsShipment_SOTableAdapter As dsDemag_HUBTableAdapters.dsShipment_SOTableAdapter
    Friend WithEvents DsShipment_SODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn82 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn83 As DataGridViewTextBoxColumn
    Friend WithEvents PoShipping_OrderBindingSource As BindingSource
    Friend WithEvents PoShipping_OrderTableAdapter As dsDemag_HUBTableAdapters.poShipping_OrderTableAdapter
    Friend WithEvents PoShipping_OrderDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn80 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn81 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn84 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn85 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn86 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn87 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn88 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn89 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn90 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn91 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn92 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn93 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn94 As DataGridViewTextBoxColumn
End Class
