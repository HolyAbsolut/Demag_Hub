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
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaininterface))
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
        Me.txtPOCount = New System.Windows.Forms.TextBox()
        Me.CarrierTextBox = New System.Windows.Forms.ComboBox()
        Me.bsCarrier = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsigneeTextBox = New System.Windows.Forms.ComboBox()
        Me.bsConsignee = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipperTextBox = New System.Windows.Forms.ComboBox()
        Me.bsShipper = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQECheckBox = New System.Windows.Forms.CheckBox()
        Me.DsShipment_SODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn82 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsSO = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cpyICM = New System.Windows.Forms.ToolStripMenuItem()
        Me.DsShipment_SOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDeleteSO = New System.Windows.Forms.Button()
        Me.btnAddSO = New System.Windows.Forms.Button()
        Me.txtSoNo = New System.Windows.Forms.TextBox()
        Me.DsShipment_OrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Incoterm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Incoterm_Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SQE_Check = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Latest_Arrival = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Buyer_Mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsShipment_OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDeletePO = New System.Windows.Forms.Button()
        Me.btnAddPO = New System.Windows.Forms.Button()
        Me.txtPoNo = New System.Windows.Forms.TextBox()
        Me.btnaddDocument = New System.Windows.Forms.Button()
        Me.DsInvoiceDataGridView = New System.Windows.Forms.DataGridView()
        Me.InvoiceNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LinkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.CreatedDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsDocuments = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmOpenDIR = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.bsUNLOC_Incoterm = New System.Windows.Forms.BindingSource(Me.components)
        Me.Incoterm_LocTextBox = New System.Windows.Forms.ComboBox()
        Me.FullPODTextBox = New System.Windows.Forms.ComboBox()
        Me.bsUNLOC_POD = New System.Windows.Forms.BindingSource(Me.components)
        Me.PODTextBox = New System.Windows.Forms.ComboBox()
        Me.FullPOLTextBox = New System.Windows.Forms.ComboBox()
        Me.bsUNLOC_POL = New System.Windows.Forms.BindingSource(Me.components)
        Me.POLTextBox = New System.Windows.Forms.ComboBox()
        Me.PrincipalTextBox = New System.Windows.Forms.ComboBox()
        Me.bsPrincipal = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.DsInvoiceDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabProtocol = New System.Windows.Forms.TabPage()
        Me.PtShipmentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PtShipmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UNLOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPartnerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PoOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PoShipping_OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCommentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkOpenPDF = New System.Windows.Forms.CheckBox()
        Me.chkPrintPDF = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDB = New System.Windows.Forms.TextBox()
        Me.dirDB = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.tabShipments = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.btnReloadDB = New System.Windows.Forms.Button()
        Me.btnMailSubject = New System.Windows.Forms.Button()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.btnSQE = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Label_Result = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tabPartner = New System.Windows.Forms.TabPage()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DsRoleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsRoleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContactBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnNewPartner = New System.Windows.Forms.Button()
        Me.DsAddressDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsAddressBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsContactDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.PtShipmentsTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.ptShipmentsTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DsRoleTableAdapter = New Demag_HUB.dsDemag_HUBTableAdapters.dsRoleTableAdapter()
        Me.txtSignature = New Demag_HUB.Watermark()
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
        Label5 = New System.Windows.Forms.Label()
        Me.subTabShipments.SuspendLayout()
        Me.tabOverview.SuspendLayout()
        CType(Me.DsShipmentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsShipmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDemag_HUB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBooking.SuspendLayout()
        CType(Me.bsCarrier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsConsignee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsShipper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsShipment_SODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsSO.SuspendLayout()
        CType(Me.DsShipment_SOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsShipment_OrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsShipment_OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsInvoiceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsDocuments.SuspendLayout()
        CType(Me.DsShipmentsdsInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCommentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsShipmentsdsCommentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUNLOC_Incoterm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUNLOC_POD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUNLOC_POL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncotermBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDocuments.SuspendLayout()
        CType(Me.DsInvoiceDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProtocol.SuspendLayout()
        CType(Me.PtShipmentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtShipmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNLOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPartnerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PoOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PoShipping_OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCommentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSettings.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.tabShipments.SuspendLayout()
        Me.tabPartner.SuspendLayout()
        CType(Me.DsRoleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRoleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContactBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAddressDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAddressBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsContactDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Cont40HQLabel.Location = New System.Drawing.Point(596, 242)
        Cont40HQLabel.Name = "Cont40HQLabel"
        Cont40HQLabel.Size = New System.Drawing.Size(35, 13)
        Cont40HQLabel.TabIndex = 48
        Cont40HQLabel.Text = "40HQ"
        '
        'Cont40DCLabel
        '
        Cont40DCLabel.AutoSize = True
        Cont40DCLabel.Location = New System.Drawing.Point(540, 242)
        Cont40DCLabel.Name = "Cont40DCLabel"
        Cont40DCLabel.Size = New System.Drawing.Size(34, 13)
        Cont40DCLabel.TabIndex = 46
        Cont40DCLabel.Text = "40DC"
        '
        'Cont20DCLabel
        '
        Cont20DCLabel.AutoSize = True
        Cont20DCLabel.Location = New System.Drawing.Point(484, 242)
        Cont20DCLabel.Name = "Cont20DCLabel"
        Cont20DCLabel.Size = New System.Drawing.Size(34, 13)
        Cont20DCLabel.TabIndex = 44
        Cont20DCLabel.Text = "20DC"
        '
        'TEULabel
        '
        TEULabel.AutoSize = True
        TEULabel.Location = New System.Drawing.Point(652, 242)
        TEULabel.Name = "TEULabel"
        TEULabel.Size = New System.Drawing.Size(32, 13)
        TEULabel.TabIndex = 42
        TEULabel.Text = "TEU:"
        '
        'WeightLabel
        '
        WeightLabel.AutoSize = True
        WeightLabel.Location = New System.Drawing.Point(371, 242)
        WeightLabel.Name = "WeightLabel"
        WeightLabel.Size = New System.Drawing.Size(44, 13)
        WeightLabel.TabIndex = 40
        WeightLabel.Text = "Weight:"
        '
        'VolumeLabel
        '
        VolumeLabel.AutoSize = True
        VolumeLabel.Location = New System.Drawing.Point(426, 242)
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
        ServiceLabel.Location = New System.Drawing.Point(301, 242)
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
        Label3.Location = New System.Drawing.Point(106, 242)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(47, 13)
        Label3.TabIndex = 93
        Label3.Text = "Add PO:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(668, 27)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(47, 13)
        Label4.TabIndex = 97
        Label4.Text = "Add SO:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(708, 242)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(25, 13)
        Label5.TabIndex = 103
        Label5.Text = "PO:"
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
        Me.subTabShipments.Controls.Add(Me.tabProtocol)
        Me.subTabShipments.Location = New System.Drawing.Point(145, 6)
        Me.subTabShipments.Name = "subTabShipments"
        Me.subTabShipments.SelectedIndex = 0
        Me.subTabShipments.Size = New System.Drawing.Size(1054, 675)
        Me.subTabShipments.TabIndex = 2
        Me.subTabShipments.TabStop = False
        '
        'tabOverview
        '
        Me.tabOverview.Controls.Add(Me.DsShipmentsDataGridView)
        Me.tabOverview.Controls.Add(Me.txtSearch)
        Me.tabOverview.Controls.Add(Me.cmbField)
        Me.tabOverview.Location = New System.Drawing.Point(4, 22)
        Me.tabOverview.Name = "tabOverview"
        Me.tabOverview.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOverview.Size = New System.Drawing.Size(1046, 649)
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
        Me.DsShipmentsDataGridView.Size = New System.Drawing.Size(1034, 611)
        Me.DsShipmentsDataGridView.TabIndex = 12
        Me.DsShipmentsDataGridView.TabStop = False
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
        Me.txtSearch.TabIndex = 1
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
        Me.cmbField.TabIndex = 2
        '
        'tabBooking
        '
        Me.tabBooking.AutoScroll = True
        Me.tabBooking.Controls.Add(Label5)
        Me.tabBooking.Controls.Add(Me.txtPOCount)
        Me.tabBooking.Controls.Add(Me.CarrierTextBox)
        Me.tabBooking.Controls.Add(Me.ConsigneeTextBox)
        Me.tabBooking.Controls.Add(Me.ShipperTextBox)
        Me.tabBooking.Controls.Add(Me.SQECheckBox)
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
        Me.tabBooking.Size = New System.Drawing.Size(1046, 649)
        Me.tabBooking.TabIndex = 1
        Me.tabBooking.Text = "Booking"
        Me.tabBooking.UseVisualStyleBackColor = True
        '
        'txtPOCount
        '
        Me.txtPOCount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "TEU", True))
        Me.txtPOCount.Enabled = False
        Me.txtPOCount.Location = New System.Drawing.Point(711, 258)
        Me.txtPOCount.Name = "txtPOCount"
        Me.txtPOCount.Size = New System.Drawing.Size(50, 20)
        Me.txtPOCount.TabIndex = 102
        '
        'CarrierTextBox
        '
        Me.CarrierTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CarrierTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CarrierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsShipmentsBindingSource, "Carrier", True))
        Me.CarrierTextBox.DataSource = Me.bsCarrier
        Me.CarrierTextBox.DisplayMember = "PartnerName"
        Me.CarrierTextBox.FormattingEnabled = True
        Me.CarrierTextBox.Location = New System.Drawing.Point(109, 211)
        Me.CarrierTextBox.Name = "CarrierTextBox"
        Me.CarrierTextBox.Size = New System.Drawing.Size(257, 21)
        Me.CarrierTextBox.TabIndex = 16
        Me.CarrierTextBox.ValueMember = "Partner_ID"
        '
        'bsCarrier
        '
        Me.bsCarrier.DataMember = "dsPartner"
        Me.bsCarrier.DataSource = Me.DsDemag_HUB
        '
        'ConsigneeTextBox
        '
        Me.ConsigneeTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ConsigneeTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ConsigneeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsShipmentsBindingSource, "Consignee", True))
        Me.ConsigneeTextBox.DataSource = Me.bsConsignee
        Me.ConsigneeTextBox.DisplayMember = "PartnerName"
        Me.ConsigneeTextBox.FormattingEnabled = True
        Me.ConsigneeTextBox.Location = New System.Drawing.Point(381, 74)
        Me.ConsigneeTextBox.Name = "ConsigneeTextBox"
        Me.ConsigneeTextBox.Size = New System.Drawing.Size(281, 21)
        Me.ConsigneeTextBox.TabIndex = 5
        Me.ConsigneeTextBox.ValueMember = "Partner_ID"
        '
        'bsConsignee
        '
        Me.bsConsignee.DataMember = "dsPartner"
        Me.bsConsignee.DataSource = Me.DsDemag_HUB
        '
        'ShipperTextBox
        '
        Me.ShipperTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ShipperTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ShipperTextBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsShipmentsBindingSource, "Shipper", True))
        Me.ShipperTextBox.DataSource = Me.bsShipper
        Me.ShipperTextBox.DisplayMember = "PartnerName"
        Me.ShipperTextBox.FormattingEnabled = True
        Me.ShipperTextBox.Location = New System.Drawing.Point(381, 47)
        Me.ShipperTextBox.Name = "ShipperTextBox"
        Me.ShipperTextBox.Size = New System.Drawing.Size(281, 21)
        Me.ShipperTextBox.TabIndex = 4
        Me.ShipperTextBox.ValueMember = "Partner_ID"
        '
        'bsShipper
        '
        Me.bsShipper.DataMember = "dsPartner"
        Me.bsShipper.DataSource = Me.DsDemag_HUB
        '
        'SQECheckBox
        '
        Me.SQECheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DsShipmentsBindingSource, "SQE", True))
        Me.SQECheckBox.Location = New System.Drawing.Point(22, 256)
        Me.SQECheckBox.Name = "SQECheckBox"
        Me.SQECheckBox.Size = New System.Drawing.Size(56, 24)
        Me.SQECheckBox.TabIndex = 101
        Me.SQECheckBox.TabStop = False
        Me.SQECheckBox.Text = "SQE"
        Me.SQECheckBox.UseVisualStyleBackColor = True
        '
        'DsShipment_SODataGridView
        '
        Me.DsShipment_SODataGridView.AllowUserToAddRows = False
        Me.DsShipment_SODataGridView.AutoGenerateColumns = False
        Me.DsShipment_SODataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DsShipment_SODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsShipment_SODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn82})
        Me.DsShipment_SODataGridView.ContextMenuStrip = Me.cmsSO
        Me.DsShipment_SODataGridView.DataSource = Me.DsShipment_SOBindingSource
        Me.DsShipment_SODataGridView.Location = New System.Drawing.Point(668, 52)
        Me.DsShipment_SODataGridView.Name = "DsShipment_SODataGridView"
        Me.DsShipment_SODataGridView.Size = New System.Drawing.Size(215, 180)
        Me.DsShipment_SODataGridView.TabIndex = 100
        Me.DsShipment_SODataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn82
        '
        Me.DataGridViewTextBoxColumn82.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn82.DataPropertyName = "Shipping_Order"
        Me.DataGridViewTextBoxColumn82.HeaderText = "Shipping_Order"
        Me.DataGridViewTextBoxColumn82.Name = "DataGridViewTextBoxColumn82"
        '
        'cmsSO
        '
        Me.cmsSO.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cpyICM})
        Me.cmsSO.Name = "cmsSO"
        Me.cmsSO.ShowImageMargin = False
        Me.cmsSO.Size = New System.Drawing.Size(103, 26)
        '
        'cpyICM
        '
        Me.cpyICM.Name = "cpyICM"
        Me.cpyICM.Size = New System.Drawing.Size(102, 22)
        Me.cpyICM.Text = "Copy ICM"
        '
        'DsShipment_SOBindingSource
        '
        Me.DsShipment_SOBindingSource.DataMember = "dsShipmentsdsShipment_SO"
        Me.DsShipment_SOBindingSource.DataSource = Me.DsShipmentsBindingSource
        '
        'btnDeleteSO
        '
        Me.btnDeleteSO.Location = New System.Drawing.Point(858, 21)
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
        Me.btnAddSO.Location = New System.Drawing.Point(827, 21)
        Me.btnAddSO.Name = "btnAddSO"
        Me.btnAddSO.Size = New System.Drawing.Size(25, 25)
        Me.btnAddSO.TabIndex = 98
        Me.btnAddSO.TabStop = False
        Me.btnAddSO.Text = "+"
        Me.btnAddSO.UseVisualStyleBackColor = True
        '
        'txtSoNo
        '
        Me.txtSoNo.Location = New System.Drawing.Point(721, 24)
        Me.txtSoNo.Name = "txtSoNo"
        Me.txtSoNo.Size = New System.Drawing.Size(100, 20)
        Me.txtSoNo.TabIndex = 26
        '
        'DsShipment_OrderDataGridView
        '
        Me.DsShipment_OrderDataGridView.AllowUserToAddRows = False
        Me.DsShipment_OrderDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DsShipment_OrderDataGridView.AutoGenerateColumns = False
        Me.DsShipment_OrderDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DsShipment_OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsShipment_OrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.Incoterm, Me.Incoterm_Location, Me.SQE_Check, Me.Latest_Arrival, Me.Buyer_Mail})
        Me.DsShipment_OrderDataGridView.DataSource = Me.DsShipment_OrderBindingSource
        Me.DsShipment_OrderDataGridView.Location = New System.Drawing.Point(9, 290)
        Me.DsShipment_OrderDataGridView.Name = "DsShipment_OrderDataGridView"
        Me.DsShipment_OrderDataGridView.Size = New System.Drawing.Size(1030, 196)
        Me.DsShipment_OrderDataGridView.TabIndex = 95
        Me.DsShipment_OrderDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Purchase_Order"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Purchase_Order"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'Incoterm
        '
        Me.Incoterm.FillWeight = 30.0!
        Me.Incoterm.HeaderText = "Incoterm"
        Me.Incoterm.Name = "Incoterm"
        '
        'Incoterm_Location
        '
        Me.Incoterm_Location.HeaderText = "POL"
        Me.Incoterm_Location.Name = "Incoterm_Location"
        '
        'SQE_Check
        '
        Me.SQE_Check.HeaderText = "SQE Check"
        Me.SQE_Check.Name = "SQE_Check"
        '
        'Latest_Arrival
        '
        Me.Latest_Arrival.HeaderText = "Latest Arrival"
        Me.Latest_Arrival.Name = "Latest_Arrival"
        '
        'Buyer_Mail
        '
        Me.Buyer_Mail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Buyer_Mail.HeaderText = "Buyer Mail"
        Me.Buyer_Mail.Name = "Buyer_Mail"
        '
        'DsShipment_OrderBindingSource
        '
        Me.DsShipment_OrderBindingSource.DataMember = "dsShipmentsdsShipment_Order"
        Me.DsShipment_OrderBindingSource.DataSource = Me.DsShipmentsBindingSource
        '
        'btnDeletePO
        '
        Me.btnDeletePO.Location = New System.Drawing.Point(246, 255)
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
        Me.btnAddPO.Location = New System.Drawing.Point(215, 255)
        Me.btnAddPO.Name = "btnAddPO"
        Me.btnAddPO.Size = New System.Drawing.Size(25, 25)
        Me.btnAddPO.TabIndex = 94
        Me.btnAddPO.TabStop = False
        Me.btnAddPO.Text = "+"
        Me.btnAddPO.UseVisualStyleBackColor = True
        '
        'txtPoNo
        '
        Me.txtPoNo.Location = New System.Drawing.Point(109, 258)
        Me.txtPoNo.Name = "txtPoNo"
        Me.txtPoNo.Size = New System.Drawing.Size(100, 20)
        Me.txtPoNo.TabIndex = 18
        '
        'btnaddDocument
        '
        Me.btnaddDocument.AllowDrop = True
        Me.btnaddDocument.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnaddDocument.Location = New System.Drawing.Point(889, 21)
        Me.btnaddDocument.Name = "btnaddDocument"
        Me.btnaddDocument.Size = New System.Drawing.Size(150, 56)
        Me.btnaddDocument.TabIndex = 90
        Me.btnaddDocument.TabStop = False
        Me.btnaddDocument.Text = "Add Document"
        Me.btnaddDocument.UseVisualStyleBackColor = True
        '
        'DsInvoiceDataGridView
        '
        Me.DsInvoiceDataGridView.AllowUserToAddRows = False
        Me.DsInvoiceDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DsInvoiceDataGridView.AutoGenerateColumns = False
        Me.DsInvoiceDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DsInvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsInvoiceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InvoiceNoDataGridViewTextBoxColumn, Me.LinkDataGridViewTextBoxColumn, Me.CreatedDataGridViewTextBoxColumn1})
        Me.DsInvoiceDataGridView.ContextMenuStrip = Me.cmsDocuments
        Me.DsInvoiceDataGridView.DataSource = Me.DsShipmentsdsInvoiceBindingSource
        Me.DsInvoiceDataGridView.Location = New System.Drawing.Point(889, 83)
        Me.DsInvoiceDataGridView.Name = "DsInvoiceDataGridView"
        Me.DsInvoiceDataGridView.ReadOnly = True
        Me.DsInvoiceDataGridView.Size = New System.Drawing.Size(151, 149)
        Me.DsInvoiceDataGridView.TabIndex = 88
        Me.DsInvoiceDataGridView.TabStop = False
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
        Me.LinkDataGridViewTextBoxColumn.Visible = False
        '
        'CreatedDataGridViewTextBoxColumn1
        '
        Me.CreatedDataGridViewTextBoxColumn1.DataPropertyName = "Created"
        Me.CreatedDataGridViewTextBoxColumn1.HeaderText = "Created"
        Me.CreatedDataGridViewTextBoxColumn1.Name = "CreatedDataGridViewTextBoxColumn1"
        Me.CreatedDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CreatedDataGridViewTextBoxColumn1.Visible = False
        '
        'cmsDocuments
        '
        Me.cmsDocuments.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmCopy, Me.tsmOpen, Me.tsmOpenDIR})
        Me.cmsDocuments.Name = "cmsDocuments"
        Me.cmsDocuments.ShowImageMargin = False
        Me.cmsDocuments.Size = New System.Drawing.Size(129, 70)
        '
        'tsmCopy
        '
        Me.tsmCopy.Enabled = False
        Me.tsmCopy.Name = "tsmCopy"
        Me.tsmCopy.Size = New System.Drawing.Size(128, 22)
        Me.tsmCopy.Text = "Copy"
        '
        'tsmOpen
        '
        Me.tsmOpen.Enabled = False
        Me.tsmOpen.Name = "tsmOpen"
        Me.tsmOpen.Size = New System.Drawing.Size(128, 22)
        Me.tsmOpen.Text = "Open"
        '
        'tsmOpenDIR
        '
        Me.tsmOpenDIR.Name = "tsmOpenDIR"
        Me.tsmOpenDIR.Size = New System.Drawing.Size(128, 22)
        Me.tsmOpenDIR.Text = "Open directory"
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
        Me.DsCommentDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DsCommentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsCommentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TxtCommentDataGridViewTextBoxColumn, Me.PublicDataGridViewCheckBoxColumn, Me.CreatedDataGridViewTextBoxColumn})
        Me.DsCommentDataGridView.DataSource = Me.DsShipmentsdsCommentBindingSource
        Me.DsCommentDataGridView.Location = New System.Drawing.Point(9, 492)
        Me.DsCommentDataGridView.Name = "DsCommentDataGridView"
        Me.DsCommentDataGridView.Size = New System.Drawing.Size(1030, 151)
        Me.DsCommentDataGridView.TabIndex = 89
        Me.DsCommentDataGridView.TabStop = False
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
        Me.dtnETA.TabIndex = 15
        '
        'dtnETD
        '
        Me.dtnETD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "dtnETD", True))
        Me.dtnETD.Location = New System.Drawing.Point(462, 154)
        Me.dtnETD.Name = "dtnETD"
        Me.dtnETD.Size = New System.Drawing.Size(100, 20)
        Me.dtnETD.TabIndex = 14
        '
        'dtnCRD
        '
        Me.dtnCRD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "dtnCRD", True))
        Me.dtnCRD.Location = New System.Drawing.Point(462, 128)
        Me.dtnCRD.Name = "dtnCRD"
        Me.dtnCRD.Size = New System.Drawing.Size(100, 20)
        Me.dtnCRD.TabIndex = 13
        '
        'FullIncoterm_LocTextBox
        '
        Me.FullIncoterm_LocTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FullIncoterm_LocTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FullIncoterm_LocTextBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsShipmentsBindingSource, "Incoterm_Loc", True))
        Me.FullIncoterm_LocTextBox.DataSource = Me.bsUNLOC_Incoterm
        Me.FullIncoterm_LocTextBox.DisplayMember = "Name"
        Me.FullIncoterm_LocTextBox.FormattingEnabled = True
        Me.FullIncoterm_LocTextBox.Location = New System.Drawing.Point(188, 128)
        Me.FullIncoterm_LocTextBox.Name = "FullIncoterm_LocTextBox"
        Me.FullIncoterm_LocTextBox.Size = New System.Drawing.Size(178, 21)
        Me.FullIncoterm_LocTextBox.TabIndex = 8
        Me.FullIncoterm_LocTextBox.TabStop = False
        Me.FullIncoterm_LocTextBox.ValueMember = "UNLOC"
        '
        'bsUNLOC_Incoterm
        '
        Me.bsUNLOC_Incoterm.DataMember = "UNLOC"
        Me.bsUNLOC_Incoterm.DataSource = Me.DsDemag_HUB
        '
        'Incoterm_LocTextBox
        '
        Me.Incoterm_LocTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Incoterm_LocTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Incoterm_LocTextBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsShipmentsBindingSource, "Incoterm_Loc", True))
        Me.Incoterm_LocTextBox.DataSource = Me.bsUNLOC_Incoterm
        Me.Incoterm_LocTextBox.DisplayMember = "UNLOC"
        Me.Incoterm_LocTextBox.FormattingEnabled = True
        Me.Incoterm_LocTextBox.Location = New System.Drawing.Point(109, 128)
        Me.Incoterm_LocTextBox.Name = "Incoterm_LocTextBox"
        Me.Incoterm_LocTextBox.Size = New System.Drawing.Size(68, 21)
        Me.Incoterm_LocTextBox.TabIndex = 7
        Me.Incoterm_LocTextBox.ValueMember = "UNLOC"
        '
        'FullPODTextBox
        '
        Me.FullPODTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FullPODTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FullPODTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.FullPODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsShipmentsBindingSource, "POD", True))
        Me.FullPODTextBox.DataSource = Me.bsUNLOC_POD
        Me.FullPODTextBox.DisplayMember = "Name"
        Me.FullPODTextBox.FormattingEnabled = True
        Me.FullPODTextBox.Location = New System.Drawing.Point(188, 184)
        Me.FullPODTextBox.Name = "FullPODTextBox"
        Me.FullPODTextBox.Size = New System.Drawing.Size(178, 21)
        Me.FullPODTextBox.TabIndex = 12
        Me.FullPODTextBox.TabStop = False
        Me.FullPODTextBox.ValueMember = "UNLOC"
        '
        'bsUNLOC_POD
        '
        Me.bsUNLOC_POD.DataMember = "UNLOC"
        Me.bsUNLOC_POD.DataSource = Me.DsDemag_HUB
        '
        'PODTextBox
        '
        Me.PODTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PODTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PODTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "POD", True))
        Me.PODTextBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsShipmentsBindingSource, "POD", True))
        Me.PODTextBox.DataSource = Me.bsUNLOC_POD
        Me.PODTextBox.DisplayMember = "UNLOC"
        Me.PODTextBox.FormattingEnabled = True
        Me.PODTextBox.Location = New System.Drawing.Point(109, 184)
        Me.PODTextBox.Name = "PODTextBox"
        Me.PODTextBox.Size = New System.Drawing.Size(68, 21)
        Me.PODTextBox.TabIndex = 11
        Me.PODTextBox.ValueMember = "UNLOC"
        '
        'FullPOLTextBox
        '
        Me.FullPOLTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FullPOLTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FullPOLTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.FullPOLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsShipmentsBindingSource, "POL", True))
        Me.FullPOLTextBox.DataSource = Me.bsUNLOC_POL
        Me.FullPOLTextBox.DisplayMember = "Name"
        Me.FullPOLTextBox.FormattingEnabled = True
        Me.FullPOLTextBox.Location = New System.Drawing.Point(188, 155)
        Me.FullPOLTextBox.Name = "FullPOLTextBox"
        Me.FullPOLTextBox.Size = New System.Drawing.Size(178, 21)
        Me.FullPOLTextBox.TabIndex = 10
        Me.FullPOLTextBox.TabStop = False
        Me.FullPOLTextBox.ValueMember = "UNLOC"
        '
        'bsUNLOC_POL
        '
        Me.bsUNLOC_POL.DataMember = "UNLOC"
        Me.bsUNLOC_POL.DataSource = Me.DsDemag_HUB
        '
        'POLTextBox
        '
        Me.POLTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.POLTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.POLTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.POLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "POL", True))
        Me.POLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsShipmentsBindingSource, "POL", True))
        Me.POLTextBox.DataSource = Me.bsUNLOC_POL
        Me.POLTextBox.DisplayMember = "UNLOC"
        Me.POLTextBox.FormattingEnabled = True
        Me.POLTextBox.Location = New System.Drawing.Point(109, 155)
        Me.POLTextBox.Name = "POLTextBox"
        Me.POLTextBox.Size = New System.Drawing.Size(68, 21)
        Me.POLTextBox.TabIndex = 9
        Me.POLTextBox.ValueMember = "UNLOC"
        '
        'PrincipalTextBox
        '
        Me.PrincipalTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PrincipalTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PrincipalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsShipmentsBindingSource, "Principal", True))
        Me.PrincipalTextBox.DataSource = Me.bsPrincipal
        Me.PrincipalTextBox.DisplayMember = "PartnerName"
        Me.PrincipalTextBox.FormattingEnabled = True
        Me.PrincipalTextBox.Location = New System.Drawing.Point(381, 20)
        Me.PrincipalTextBox.Name = "PrincipalTextBox"
        Me.PrincipalTextBox.Size = New System.Drawing.Size(281, 21)
        Me.PrincipalTextBox.TabIndex = 3
        Me.PrincipalTextBox.ValueMember = "Partner_ID"
        '
        'bsPrincipal
        '
        Me.bsPrincipal.DataMember = "dsPartner"
        Me.bsPrincipal.DataSource = Me.DsDemag_HUB
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
        Me.IncotermTextBox.TabIndex = 6
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
        Me.ServiceTextBox.Location = New System.Drawing.Point(304, 258)
        Me.ServiceTextBox.Name = "ServiceTextBox"
        Me.ServiceTextBox.Size = New System.Drawing.Size(65, 21)
        Me.ServiceTextBox.TabIndex = 19
        '
        'Shipment_IDTextBox
        '
        Me.Shipment_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Shipment_ID", True))
        Me.Shipment_IDTextBox.Enabled = False
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
        Me.STT_NoTextBox.TabIndex = 1
        '
        'POL_NoTextBox
        '
        Me.POL_NoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.POL_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "POL_No", True))
        Me.POL_NoTextBox.Location = New System.Drawing.Point(109, 72)
        Me.POL_NoTextBox.Name = "POL_NoTextBox"
        Me.POL_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.POL_NoTextBox.TabIndex = 2
        '
        'VesselTextBox
        '
        Me.VesselTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VesselTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Vessel", True))
        Me.VesselTextBox.Enabled = False
        Me.VesselTextBox.Location = New System.Drawing.Point(462, 98)
        Me.VesselTextBox.Name = "VesselTextBox"
        Me.VesselTextBox.Size = New System.Drawing.Size(200, 20)
        Me.VesselTextBox.TabIndex = 14
        Me.VesselTextBox.TabStop = False
        '
        'Contract_NoTextBox
        '
        Me.Contract_NoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Contract_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Contract_No", True))
        Me.Contract_NoTextBox.Location = New System.Drawing.Point(462, 211)
        Me.Contract_NoTextBox.Name = "Contract_NoTextBox"
        Me.Contract_NoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Contract_NoTextBox.TabIndex = 17
        '
        'VolumeTextBox
        '
        Me.VolumeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Volume", True))
        Me.VolumeTextBox.Location = New System.Drawing.Point(429, 258)
        Me.VolumeTextBox.Name = "VolumeTextBox"
        Me.VolumeTextBox.Size = New System.Drawing.Size(50, 20)
        Me.VolumeTextBox.TabIndex = 21
        '
        'WeightTextBox
        '
        Me.WeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Weight", True))
        Me.WeightTextBox.Location = New System.Drawing.Point(374, 258)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(50, 20)
        Me.WeightTextBox.TabIndex = 20
        '
        'TEUTextBox
        '
        Me.TEUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "TEU", True))
        Me.TEUTextBox.Enabled = False
        Me.TEUTextBox.Location = New System.Drawing.Point(655, 258)
        Me.TEUTextBox.Name = "TEUTextBox"
        Me.TEUTextBox.Size = New System.Drawing.Size(50, 20)
        Me.TEUTextBox.TabIndex = 25
        '
        'Cont20DCTextBox
        '
        Me.Cont20DCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Cont20DC", True))
        Me.Cont20DCTextBox.Location = New System.Drawing.Point(487, 258)
        Me.Cont20DCTextBox.Name = "Cont20DCTextBox"
        Me.Cont20DCTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Cont20DCTextBox.TabIndex = 22
        '
        'Cont40DCTextBox
        '
        Me.Cont40DCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Cont40DC", True))
        Me.Cont40DCTextBox.Location = New System.Drawing.Point(543, 258)
        Me.Cont40DCTextBox.Name = "Cont40DCTextBox"
        Me.Cont40DCTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Cont40DCTextBox.TabIndex = 23
        '
        'Cont40HQTextBox
        '
        Me.Cont40HQTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsShipmentsBindingSource, "Cont40HQ", True))
        Me.Cont40HQTextBox.Location = New System.Drawing.Point(599, 258)
        Me.Cont40HQTextBox.Name = "Cont40HQTextBox"
        Me.Cont40HQTextBox.Size = New System.Drawing.Size(50, 20)
        Me.Cont40HQTextBox.TabIndex = 24
        '
        'tabShipping
        '
        Me.tabShipping.Location = New System.Drawing.Point(4, 22)
        Me.tabShipping.Name = "tabShipping"
        Me.tabShipping.Padding = New System.Windows.Forms.Padding(3)
        Me.tabShipping.Size = New System.Drawing.Size(1046, 649)
        Me.tabShipping.TabIndex = 2
        Me.tabShipping.Text = "Shipping"
        Me.tabShipping.UseVisualStyleBackColor = True
        '
        'tabDispo
        '
        Me.tabDispo.Location = New System.Drawing.Point(4, 22)
        Me.tabDispo.Name = "tabDispo"
        Me.tabDispo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDispo.Size = New System.Drawing.Size(1046, 649)
        Me.tabDispo.TabIndex = 3
        Me.tabDispo.Text = "Dispo"
        Me.tabDispo.UseVisualStyleBackColor = True
        '
        'tabDocuments
        '
        Me.tabDocuments.AutoScroll = True
        Me.tabDocuments.Controls.Add(Me.DsInvoiceDataGridView1)
        Me.tabDocuments.Location = New System.Drawing.Point(4, 22)
        Me.tabDocuments.Name = "tabDocuments"
        Me.tabDocuments.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDocuments.Size = New System.Drawing.Size(1046, 649)
        Me.tabDocuments.TabIndex = 4
        Me.tabDocuments.Text = "Documents"
        Me.tabDocuments.UseVisualStyleBackColor = True
        '
        'DsInvoiceDataGridView1
        '
        Me.DsInvoiceDataGridView1.AllowUserToAddRows = False
        Me.DsInvoiceDataGridView1.AllowUserToDeleteRows = False
        Me.DsInvoiceDataGridView1.AutoGenerateColumns = False
        Me.DsInvoiceDataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DsInvoiceDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsInvoiceDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn58})
        Me.DsInvoiceDataGridView1.ContextMenuStrip = Me.cmsDocuments
        Me.DsInvoiceDataGridView1.DataSource = Me.DsShipmentsdsInvoiceBindingSource
        Me.DsInvoiceDataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DsInvoiceDataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DsInvoiceDataGridView1.Name = "DsInvoiceDataGridView1"
        Me.DsInvoiceDataGridView1.Size = New System.Drawing.Size(1037, 640)
        Me.DsInvoiceDataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Invoice_ID"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Invoice_ID"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Shipment_ID"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Shipment_ID"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Created"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Created"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Invoice_No"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Invoice_No"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "Link"
        Me.DataGridViewTextBoxColumn58.HeaderText = "Link"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'tabProtocol
        '
        Me.tabProtocol.Controls.Add(Me.PtShipmentsDataGridView)
        Me.tabProtocol.Location = New System.Drawing.Point(4, 22)
        Me.tabProtocol.Name = "tabProtocol"
        Me.tabProtocol.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProtocol.Size = New System.Drawing.Size(1046, 649)
        Me.tabProtocol.TabIndex = 6
        Me.tabProtocol.Text = "Protocol"
        Me.tabProtocol.UseVisualStyleBackColor = True
        '
        'PtShipmentsDataGridView
        '
        Me.PtShipmentsDataGridView.AllowUserToAddRows = False
        Me.PtShipmentsDataGridView.AllowUserToDeleteRows = False
        Me.PtShipmentsDataGridView.AutoGenerateColumns = False
        Me.PtShipmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PtShipmentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn63, Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn65, Me.DataGridViewTextBoxColumn66, Me.DataGridViewTextBoxColumn67})
        Me.PtShipmentsDataGridView.DataSource = Me.PtShipmentsBindingSource
        Me.PtShipmentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PtShipmentsDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.PtShipmentsDataGridView.Name = "PtShipmentsDataGridView"
        Me.PtShipmentsDataGridView.ReadOnly = True
        Me.PtShipmentsDataGridView.Size = New System.Drawing.Size(1040, 643)
        Me.PtShipmentsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "Created"
        Me.DataGridViewTextBoxColumn61.HeaderText = "Created"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.ReadOnly = True
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn63.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        Me.DataGridViewTextBoxColumn63.ReadOnly = True
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "Column_Name"
        Me.DataGridViewTextBoxColumn64.HeaderText = "Column_Name"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        Me.DataGridViewTextBoxColumn64.ReadOnly = True
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "oldValue"
        Me.DataGridViewTextBoxColumn65.HeaderText = "oldValue"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        Me.DataGridViewTextBoxColumn65.ReadOnly = True
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "newValue"
        Me.DataGridViewTextBoxColumn66.HeaderText = "newValue"
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        Me.DataGridViewTextBoxColumn66.ReadOnly = True
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "User"
        Me.DataGridViewTextBoxColumn67.HeaderText = "User"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        Me.DataGridViewTextBoxColumn67.ReadOnly = True
        '
        'PtShipmentsBindingSource
        '
        Me.PtShipmentsBindingSource.DataMember = "dsShipmentsptShipments"
        Me.PtShipmentsBindingSource.DataSource = Me.DsShipmentsBindingSource
        '
        'UNLOCBindingSource
        '
        Me.UNLOCBindingSource.DataMember = "UNLOC"
        Me.UNLOCBindingSource.DataSource = Me.DsDemag_HUB
        '
        'DsPartnerBindingSource
        '
        Me.DsPartnerBindingSource.DataMember = "dsPartner"
        Me.DsPartnerBindingSource.DataSource = Me.DsDemag_HUB
        '
        'PoOrderBindingSource
        '
        Me.PoOrderBindingSource.DataMember = "poOrder"
        Me.PoOrderBindingSource.DataSource = Me.DsDemag_HUB
        '
        'PoShipping_OrderBindingSource
        '
        Me.PoShipping_OrderBindingSource.DataMember = "poShipping_Order"
        Me.PoShipping_OrderBindingSource.DataSource = Me.DsDemag_HUB
        '
        'DsCommentBindingSource
        '
        Me.DsCommentBindingSource.DataMember = "dsShipmentsdsComment"
        Me.DsCommentBindingSource.DataSource = Me.DsShipmentsBindingSource
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 454)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Status"
        Me.Label2.Visible = False
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.txtSignature)
        Me.tabSettings.Controls.Add(Me.Label1)
        Me.tabSettings.Controls.Add(Me.chkOpenPDF)
        Me.tabSettings.Controls.Add(Me.chkPrintPDF)
        Me.tabSettings.Controls.Add(Me.Button1)
        Me.tabSettings.Controls.Add(Me.txtDB)
        Me.tabSettings.Controls.Add(Me.dirDB)
        Me.tabSettings.Location = New System.Drawing.Point(4, 4)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSettings.Size = New System.Drawing.Size(1205, 687)
        Me.tabSettings.TabIndex = 0
        Me.tabSettings.Text = "Settings"
        Me.tabSettings.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "http://www.iconarchive.com/show/captiva-icons-by-bokehlicia/web-github-icon.html"
        '
        'chkOpenPDF
        '
        Me.chkOpenPDF.AutoSize = True
        Me.chkOpenPDF.Location = New System.Drawing.Point(7, 82)
        Me.chkOpenPDF.Name = "chkOpenPDF"
        Me.chkOpenPDF.Size = New System.Drawing.Size(76, 17)
        Me.chkOpenPDF.TabIndex = 6
        Me.chkOpenPDF.Text = "Open PDF"
        Me.chkOpenPDF.UseVisualStyleBackColor = True
        '
        'chkPrintPDF
        '
        Me.chkPrintPDF.AutoSize = True
        Me.chkPrintPDF.Enabled = False
        Me.chkPrintPDF.Location = New System.Drawing.Point(7, 59)
        Me.chkPrintPDF.Name = "chkPrintPDF"
        Me.chkPrintPDF.Size = New System.Drawing.Size(71, 17)
        Me.chkPrintPDF.TabIndex = 5
        Me.chkPrintPDF.Text = "Print PDF"
        Me.chkPrintPDF.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(389, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDB
        '
        Me.txtDB.Location = New System.Drawing.Point(7, 33)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(375, 20)
        Me.txtDB.TabIndex = 1
        '
        'dirDB
        '
        Me.dirDB.Location = New System.Drawing.Point(7, 7)
        Me.dirDB.Name = "dirDB"
        Me.dirDB.Size = New System.Drawing.Size(375, 20)
        Me.dirDB.TabIndex = 0
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
        Me.btnSearch.Text = "S&earch"
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
        Me.TabControl3.Size = New System.Drawing.Size(1213, 713)
        Me.TabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl3.TabIndex = 16
        Me.TabControl3.TabStop = False
        '
        'tabShipments
        '
        Me.tabShipments.Controls.Add(Me.Button3)
        Me.tabShipments.Controls.Add(Me.Button2)
        Me.tabShipments.Controls.Add(Me.btnPDF)
        Me.tabShipments.Controls.Add(Me.btnReloadDB)
        Me.tabShipments.Controls.Add(Me.btnMailSubject)
        Me.tabShipments.Controls.Add(Me.btnSchedule)
        Me.tabShipments.Controls.Add(Me.btnSQE)
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
        Me.tabShipments.Size = New System.Drawing.Size(1205, 687)
        Me.tabShipments.TabIndex = 0
        Me.tabShipments.Text = "Shipments"
        Me.tabShipments.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(23, 391)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 88
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(6, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 40)
        Me.Button2.TabIndex = 87
        Me.Button2.TabStop = False
        Me.Button2.Text = "SQE Check"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnPDF
        '
        Me.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPDF.Location = New System.Drawing.Point(6, 282)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(134, 40)
        Me.btnPDF.TabIndex = 86
        Me.btnPDF.TabStop = False
        Me.btnPDF.Text = "Job Dossier"
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'btnReloadDB
        '
        Me.btnReloadDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReloadDB.Location = New System.Drawing.Point(6, 595)
        Me.btnReloadDB.Name = "btnReloadDB"
        Me.btnReloadDB.Size = New System.Drawing.Size(134, 40)
        Me.btnReloadDB.TabIndex = 85
        Me.btnReloadDB.TabStop = False
        Me.btnReloadDB.Text = "&Reload DB"
        Me.btnReloadDB.UseVisualStyleBackColor = True
        '
        'btnMailSubject
        '
        Me.btnMailSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMailSubject.Location = New System.Drawing.Point(5, 236)
        Me.btnMailSubject.Name = "btnMailSubject"
        Me.btnMailSubject.Size = New System.Drawing.Size(134, 40)
        Me.btnMailSubject.TabIndex = 84
        Me.btnMailSubject.TabStop = False
        Me.btnMailSubject.Text = "Email subject"
        Me.btnMailSubject.UseVisualStyleBackColor = True
        '
        'btnSchedule
        '
        Me.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedule.Location = New System.Drawing.Point(5, 190)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(134, 40)
        Me.btnSchedule.TabIndex = 83
        Me.btnSchedule.TabStop = False
        Me.btnSchedule.Text = "Sent schedule"
        Me.btnSchedule.UseVisualStyleBackColor = True
        '
        'btnSQE
        '
        Me.btnSQE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSQE.Location = New System.Drawing.Point(5, 144)
        Me.btnSQE.Name = "btnSQE"
        Me.btnSQE.Size = New System.Drawing.Size(134, 40)
        Me.btnSQE.TabIndex = 82
        Me.btnSQE.TabStop = False
        Me.btnSQE.Text = "SQE"
        Me.btnSQE.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(6, 578)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(133, 11)
        Me.ProgressBar.TabIndex = 81
        '
        'Label_Result
        '
        Me.Label_Result.AutoSize = True
        Me.Label_Result.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Result.Location = New System.Drawing.Point(5, 562)
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
        Me.tabPartner.Controls.Add(Me.ComboBox3)
        Me.tabPartner.Controls.Add(Me.DsRoleDataGridView)
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
        Me.tabPartner.Size = New System.Drawing.Size(1205, 687)
        Me.tabPartner.TabIndex = 1
        Me.tabPartner.Text = "Partner"
        Me.tabPartner.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.DataSource = Me.DsPartnerBindingSource
        Me.ComboBox3.DisplayMember = "PartnerName"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(625, 26)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 17
        Me.ComboBox3.ValueMember = "Partner_ID"
        '
        'DsRoleDataGridView
        '
        Me.DsRoleDataGridView.AutoGenerateColumns = False
        Me.DsRoleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DsRoleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn68})
        Me.DsRoleDataGridView.DataSource = Me.DsRoleBindingSource
        Me.DsRoleDataGridView.Location = New System.Drawing.Point(967, 85)
        Me.DsRoleDataGridView.Name = "DsRoleDataGridView"
        Me.DsRoleDataGridView.Size = New System.Drawing.Size(208, 220)
        Me.DsRoleDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn68.DataPropertyName = "Role"
        Me.DataGridViewTextBoxColumn68.HeaderText = "Role"
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
        Me.DataGridViewTextBoxColumn68.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DsRoleBindingSource
        '
        Me.DsRoleBindingSource.DataMember = "dsContactdsRole"
        Me.DsRoleBindingSource.DataSource = Me.DsContactBindingSource
        '
        'DsContactBindingSource
        '
        Me.DsContactBindingSource.DataMember = "dsPartnerdsContact"
        Me.DsContactBindingSource.DataSource = Me.DsPartnerBindingSource
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
        Me.DsAddressDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.DsAddressDataGridView.DataSource = Me.DsAddressBindingSource
        Me.DsAddressDataGridView.Location = New System.Drawing.Point(9, 321)
        Me.DsAddressDataGridView.Name = "DsAddressDataGridView"
        Me.DsAddressDataGridView.Size = New System.Drawing.Size(907, 138)
        Me.DsAddressDataGridView.TabIndex = 15
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
        Me.DsContactDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DsContactDataGridView.DataSource = Me.DsContactBindingSource
        Me.DsContactDataGridView.Location = New System.Drawing.Point(9, 85)
        Me.DsContactDataGridView.Name = "DsContactDataGridView"
        Me.DsContactDataGridView.Size = New System.Drawing.Size(907, 230)
        Me.DsContactDataGridView.TabIndex = 14
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
        'PtShipmentsTableAdapter
        '
        Me.PtShipmentsTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1021, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'DsRoleTableAdapter
        '
        Me.DsRoleTableAdapter.ClearBeforeFill = True
        '
        'txtSignature
        '
        Me.txtSignature.Location = New System.Drawing.Point(7, 141)
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.Size = New System.Drawing.Size(375, 20)
        Me.txtSignature.TabIndex = 8
        Me.txtSignature.WatermarkColor = System.Drawing.Color.Gray
        Me.txtSignature.WatermarkText = "Signatur"
        '
        'frmMaininterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 797)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.cmbFilter)
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
        CType(Me.bsCarrier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsConsignee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsShipper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsShipment_SODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsSO.ResumeLayout(False)
        CType(Me.DsShipment_SOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsShipment_OrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsShipment_OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsInvoiceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsDocuments.ResumeLayout(False)
        CType(Me.DsShipmentsdsInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCommentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsShipmentsdsCommentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUNLOC_Incoterm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUNLOC_POD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUNLOC_POL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncotermBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDocuments.ResumeLayout(False)
        CType(Me.DsInvoiceDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProtocol.ResumeLayout(False)
        CType(Me.PtShipmentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtShipmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNLOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPartnerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PoOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PoShipping_OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCommentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSettings.ResumeLayout(False)
        Me.tabSettings.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.tabShipments.ResumeLayout(False)
        Me.tabShipments.PerformLayout()
        Me.tabPartner.ResumeLayout(False)
        Me.tabPartner.PerformLayout()
        CType(Me.DsRoleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRoleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContactBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAddressDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAddressBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsContactDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsDemag_HUB As dsDemag_HUB
    Friend WithEvents DsShipmentsBindingSource As BindingSource
    Friend WithEvents DsShipmentsTableAdapter As dsDemag_HUBTableAdapters.dsShipmentsTableAdapter
    Friend WithEvents TableAdapterManager As dsDemag_HUBTableAdapters.TableAdapterManager
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
    Friend WithEvents btnNewPartner As Button
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
    Friend WithEvents btnDeleteSO As Button
    Friend WithEvents btnAddSO As Button
    Friend WithEvents txtSoNo As TextBox
    Friend WithEvents DsShipment_SOBindingSource As BindingSource
    Friend WithEvents DsShipment_SOTableAdapter As dsDemag_HUBTableAdapters.dsShipment_SOTableAdapter
    Friend WithEvents DsShipment_SODataGridView As DataGridView
    Friend WithEvents PoShipping_OrderBindingSource As BindingSource
    Friend WithEvents PoShipping_OrderTableAdapter As dsDemag_HUBTableAdapters.poShipping_OrderTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn82 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents Incoterm As DataGridViewTextBoxColumn
    Friend WithEvents Incoterm_Location As DataGridViewTextBoxColumn
    Friend WithEvents SQE_Check As DataGridViewTextBoxColumn
    Friend WithEvents Latest_Arrival As DataGridViewTextBoxColumn
    Friend WithEvents Buyer_Mail As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LinkDataGridViewTextBoxColumn As DataGridViewLinkColumn
    Friend WithEvents CreatedDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents btnSQE As Button
    Friend WithEvents DsInvoiceDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents tabProtocol As TabPage
    Friend WithEvents PtShipmentsBindingSource As BindingSource
    Friend WithEvents PtShipmentsTableAdapter As dsDemag_HUBTableAdapters.ptShipmentsTableAdapter
    Friend WithEvents btnSchedule As Button
    Friend WithEvents dirDB As TextBox
    Friend WithEvents txtDB As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnReloadDB As Button
    Friend WithEvents btnMailSubject As Button
    Friend WithEvents PtShipmentsDataGridView As DataGridView
    Friend WithEvents cmsDocuments As ContextMenuStrip
    Friend WithEvents tsmCopy As ToolStripMenuItem
    Friend WithEvents tsmOpen As ToolStripMenuItem
    Friend WithEvents tsmOpenDIR As ToolStripMenuItem
    Friend WithEvents btnPDF As Button
    Friend WithEvents chkOpenPDF As CheckBox
    Friend WithEvents chkPrintPDF As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SQECheckBox As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ShipperTextBox As ComboBox
    Friend WithEvents bsShipper As BindingSource
    Friend WithEvents CarrierTextBox As ComboBox
    Friend WithEvents bsCarrier As BindingSource
    Friend WithEvents ConsigneeTextBox As ComboBox
    Friend WithEvents bsConsignee As BindingSource
    Friend WithEvents bsPrincipal As BindingSource
    Friend WithEvents bsUNLOC_Incoterm As BindingSource
    Friend WithEvents bsUNLOC_POD As BindingSource
    Friend WithEvents bsUNLOC_POL As BindingSource
    Friend WithEvents DsRoleBindingSource As BindingSource
    Friend WithEvents DsRoleTableAdapter As dsDemag_HUBTableAdapters.dsRoleTableAdapter
    Friend WithEvents DsRoleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents txtPOCount As TextBox
    Friend WithEvents cmsSO As ContextMenuStrip
    Friend WithEvents cpyICM As ToolStripMenuItem
    Friend WithEvents txtSignature As Watermark
End Class
