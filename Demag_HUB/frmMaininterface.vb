﻿Option Strict On

Imports System.Text
Imports System.IO
Imports System.ComponentModel

Public Class frmMaininterface
    Dim dtnEmpty As String = "01.01.0001 00:00:00"
    Dim CON As New OleDb.OleDbConnection
    Dim MyConnection As System.Data.OleDb.OleDbConnection
    Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
    Dim ImportDS As System.Data.DataSet
    Public PDFCover As PDFCoverStructure


    'Private Sub DsShipmentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.DsShipmentsBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DsDemag_HUB)

    'End Sub
    Private Sub frmMaininterface_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.sttDBPath = txtDB.Text
        My.Settings.sttOpenPDF = chkOpenPDF.Checked
        My.Settings.sttPrintPDF = chkPrintPDF.Checked
        My.Settings.sttSignature = txtSignature.Text
        Save()
        'custom.Default.Save()

        'MyBase.OnFormClosing(e)
    End Sub


    Private Sub frmMaininterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtDB.Text = My.Settings.sttDBPath
        chkOpenPDF.Checked = My.Settings.sttOpenPDF
        chkPrintPDF.Checked = My.Settings.sttPrintPDF
        txtSignature.Text = My.Settings.sttSignature
        DsDocumentDataGridView.AllowDrop = True
        DsDocumentDataGridView1.AllowDrop = True
        'dirDB.DataBindings.Add("Text", My.Settings, "sttDBPath")

        LoadDB()
        bgwImportICM.RunWorkerAsync(0)
    End Sub

    Sub LoadDB()
        If My.Settings.sttDBPath = "" Then
            dlgFileDialog.Title = "Bitte Datenbank auswählen"
            dlgFileDialog.ShowDialog() 'Fileauswählen
            My.Settings.sttDBPath = dlgFileDialog.FileName
        End If



        CON.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & txtDB.Text
        'CON.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.sttDBPath


        PoShipping_OrderTableAdapter.Connection = CON
        DsShipment_SOTableAdapter.Connection = CON
        PoOrderTableAdapter.Connection = CON
        DsShipment_OrderTableAdapter.Connection = CON
        DsDocumentsTableAdapter.Connection = CON
        DsDocumentsTableAdapter.Connection = CON
        DsCommentTableAdapter.Connection = CON
        UNLOCTableAdapter.Connection = CON
        DsAddressTableAdapter.Connection = CON
        DsContactTableAdapter.Connection = CON
        DsPartnerTableAdapter.Connection = CON
        IncotermTableAdapter.Connection = CON
        DsShipmentsTableAdapter.Connection = CON
        PtShipmentsTableAdapter.Connection = CON
        DsRoleTableAdapter.Connection = CON
        DsContainerTableAdapter.Connection = CON
        RtCharge_CodeTableAdapter.Connection = CON
        RtShipments_ChargesTableAdapter.Connection = CON
        RtRatesTableAdapter.Connection = CON


        'TODO:   Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsShipments". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsShipmentsTableAdapter.Fill(Me.DsDemag_HUB.dsShipments)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.poShipping_Order". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.PoShipping_OrderTableAdapter.Fill(Me.DsDemag_HUB.poShipping_Order)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsShipment_SO". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsShipment_SOTableAdapter.Fill(Me.DsDemag_HUB.dsShipment_SO)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.poOrder". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.PoOrderTableAdapter.Fill(Me.DsDemag_HUB.poOrder)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsShipment_Order". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsShipment_OrderTableAdapter.Fill(Me.DsDemag_HUB.dsShipment_Order)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsDocuments". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsDocumentsTableAdapter.Fill(Me.DsDemag_HUB.dsDocuments)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsComment". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsCommentTableAdapter.Fill(Me.DsDemag_HUB.dsComment)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.UNLOC". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.UNLOCTableAdapter.Fill(Me.DsDemag_HUB.UNLOC)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsAddress". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsAddressTableAdapter.Fill(Me.DsDemag_HUB.dsAddress)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsContact". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsContactTableAdapter.Fill(Me.DsDemag_HUB.dsContact)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsPartner". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsPartnerTableAdapter.Fill(Me.DsDemag_HUB.dsPartner)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.Incoterm". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.IncotermTableAdapter.Fill(Me.DsDemag_HUB.Incoterm)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.ptShipments". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.PtShipmentsTableAdapter.Fill(Me.DsDemag_HUB.ptShipments)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsRole". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsRoleTableAdapter.Fill(Me.DsDemag_HUB.dsRole)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsContainer". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsContainerTableAdapter.Fill(Me.DsDemag_HUB.dsContainer)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.rtCharge_Code". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.RtCharge_CodeTableAdapter.Fill(Me.DsDemag_HUB.rtCharge_Code)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.rtShipments_Charges". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.RtShipments_ChargesTableAdapter.Fill(Me.DsDemag_HUB.rtShipments_Charges)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.rtRates". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.RtRatesTableAdapter.Fill(Me.DsDemag_HUB.rtRates)


        'MsgBox(DsShipmentsTableAdapter.Connection.ConnectionString.ToString)
    End Sub

    Sub selectTab()
        'PeopleBindingSource.Current("Name")

        'Dim rowActual As dsDemag_HUB.dsShipmentsRow = DsDemag_HUB.dsShipments.FindByShipment_ID(Convert.ToInt32(Shipment_IDTextBox.Text))

        Dim rowActual As dsDemag_HUB.dsShipmentsRow = DsDemag_HUB.dsShipments.FindByShipment_ID(Convert.ToInt32(DirectCast(DsShipmentsBindingSource.Current, DataRowView).Item(0).ToString()))

        If rowActual.IsdtnETDNull Then
            Me.subTabShipments.SelectedTab = tabBooking
            Exit Sub
        End If
        If rowActual.IsdtnETANull Then
            Me.subTabShipments.SelectedTab = tabBooking
            Exit Sub
        End If



        If rowActual.dtnETD < Date.Now Then
            Me.subTabShipments.SelectedTab = tabBooking
            'Me.subTabShipments.SelectedTab = tabShipping 'Deaktiviert bis funktioniert
            Exit Sub
        End If

    End Sub

    Private Sub btnNewPartner_Click(sender As Object, e As EventArgs) Handles btnNewPartner.Click
        DsPartnerBindingSource.AddNew()
        PartnerNameTextBox.Focus()
    End Sub

    Private Sub OnlyNumeric(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VolumeTextBox.KeyPress, WeightTextBox.KeyPress, Cont20DCTextBox.KeyPress, Cont40DCTextBox.KeyPress, Cont40HQTextBox.KeyPress, STT_NoTextBox.KeyPress, txtSoNo.KeyPress, STT_NoTextBox1.KeyPress, WeightTextBox1.KeyPress, VolumeTextBox1.KeyPress, QuantityTextBox.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 44
                ' Zahlen, Backspace und Komma zulassen
            Case Else
                ' alle anderen Eingaben unterdrücken
                e.Handled = True
        End Select

    End Sub

    Public Function GetWeekStartDate(ByVal Year As String, ByVal Week As Integer, Optional FirstDayOfWeek As DayOfWeek = DayOfWeek.Monday) As Date
        Dim dt As Date = New Date(Convert.ToInt32(Year), 1, 1)
        If dt.DayOfWeek > 4 Then dt = dt.AddDays(7 - dt.DayOfWeek) Else dt = dt.AddDays(-dt.DayOfWeek)
        dt = dt.AddDays(FirstDayOfWeek)
        Return dt.AddDays(7 * (Week - 1))
    End Function

    Function getDate(ByVal dtnString As String) As Date
        Try
            Select Case dtnString.Length
                Case 0
                    getDate = Nothing
                Case 2
                    getDate = GetWeekStartDate(dtnString, Date.Today.Year)
                Case 6
                    getDate = DateTime.ParseExact(dtnString, "ddMMyy", Globalization.CultureInfo.InvariantCulture)
                Case 8
                    If dtnString.Contains("."c) Then getDate = DateTime.ParseExact(dtnString, "dd.MM.yy", Globalization.CultureInfo.InvariantCulture)
                    If dtnString.Contains("/"c) Then getDate = DateTime.ParseExact(dtnString, "dd/MM/yy", Globalization.CultureInfo.InvariantCulture)
                    If getDate.ToString = dtnEmpty Then
                        getDate = DateTime.ParseExact(dtnString, "ddMMyyyy", Globalization.CultureInfo.InvariantCulture)
                    Else
                        getDate = Nothing
                    End If
                Case 10
                    getDate = DateTime.ParseExact(dtnString, "dd.MM.yyyy", Globalization.CultureInfo.InvariantCulture)
                Case 19
                    getDate = DateTime.ParseExact(dtnString, "dd.MM.yyyy hh:mm:ss", Globalization.CultureInfo.InvariantCulture)
                Case Else
                    getDate = Nothing
                    MsgBox("Format unkown")
            End Select
        Catch ex As Exception
            getDate = Nothing
            MsgBox("Format unkown")
        End Try
    End Function

    Private Sub dtnConvert(ctlButton As Object, e As EventArgs) Handles dtnCRD.Leave, dtnETD.Leave, dtnETA.Leave, dtnATD.Leave, dtnETAShipping.Leave
        Dim sender As Control = CType(ctlButton, Control)
        If sender.Text = "" Then
            'DsDemag_HUB.dsShipments.Rows.Find(Shipment_IDTextBox.Text).Item(sender.Name) = System.DBNull.Value
        Else
            sender.Text = getDate(sender.Text).ToString
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Sub Save()
        'MsgBox("Starte")

        Me.Validate()
        Me.DsShipmentsBindingSource.EndEdit()
        Me.DsCommentBindingSource.EndEdit()
        Me.DsPartnerBindingSource.EndEdit()
        Me.DsContactBindingSource.EndEdit()
        Me.DsAddressBindingSource.EndEdit()
        Me.DsShipment_OrderBindingSource.EndEdit()
        Me.DsShipment_SOBindingSource.EndEdit()
        Me.PtShipmentsBindingSource.EndEdit()
        Me.PoOrderBindingSource.EndEdit()
        Me.PoShipping_OrderBindingSource.EndEdit()
        Me.DsRoleBindingSource.EndEdit()
        Me.DsContainerBindingSource.EndEdit()
        Me.RtShipments_ChargesBindingSource.EndEdit()
        'MsgBox("Arbeite")



        Me.DsPartnerTableAdapter.Update(Me.DsDemag_HUB.dsPartner)
        Me.DsContactTableAdapter.Update(Me.DsDemag_HUB.dsContact)
        Me.DsAddressTableAdapter.Update(Me.DsDemag_HUB.dsAddress)
        Me.PoOrderTableAdapter.Update(Me.DsDemag_HUB.poOrder)
        Me.PoShipping_OrderTableAdapter.Update(Me.DsDemag_HUB.poShipping_Order)
        Me.DsShipment_OrderTableAdapter.Update(Me.DsDemag_HUB.dsShipment_Order)
        Me.DsShipment_SOTableAdapter.Update(Me.DsDemag_HUB.dsShipment_SO)
        Me.DsShipmentsTableAdapter.Update(Me.DsDemag_HUB.dsShipments)
        Me.DsCommentTableAdapter.Update(Me.DsDemag_HUB.dsComment)
        Me.PtShipmentsTableAdapter.Update(Me.DsDemag_HUB.ptShipments)
        Me.DsRoleTableAdapter.Update(Me.DsDemag_HUB.dsRole)
        Me.DsContainerTableAdapter.Update(Me.DsDemag_HUB.dsContainer)
        Me.RtShipments_ChargesTableAdapter.Update(Me.DsDemag_HUB.rtShipments_Charges)
        'MsgBox("Fertig")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        DsShipmentsBindingSource.Filter = "Service = 'FREE'"


        If DsShipmentsBindingSource.Count < 20 Then
            For i As Integer = DsShipmentsBindingSource.Count To 20
                Dim newShipment As dsDemag_HUB.dsShipmentsRow
                newShipment = DsDemag_HUB.dsShipments.NewdsShipmentsRow
                newShipment.Created = Date.MinValue
                newShipment.Service = "FREE"
                newShipment.POL = "ZZZZZ"
                newShipment.POD = "ZZZZZ"
                DsDemag_HUB.dsShipments.Rows.Add(newShipment)
            Next
        End If

        'Dim noValidID As Boolean = True
        'For Each Row As dsDemag_HUB.dsShipmentsRow In DsDemag_HUB.dsShipments
        '    If Row.Shipment_ID > 0 And Row.Service = "FREE" Then noValidID = False
        '    Exit For
        'Next
        'If noValidID = True Then LoadDB()

        'Prüfen ob noch genug 'fertige' PO da sind und auswählen
        DsShipmentsBindingSource.Filter = "Service = 'FREE' AND Shipment_ID > 0"
        DsShipmentsBindingSource.Sort = "Shipment_ID"

        If DsShipmentsBindingSource.Count = 0 Then
            LoadDB()
            DsShipmentsBindingSource.Filter = "Service = 'FREE' AND Shipment_ID > 0"
        End If
        DsShipmentsBindingSource.MoveFirst()



        'DsShipmentsBindingSource.AddNew()
        Me.subTabShipments.SelectedTab = tabBooking
        'DsShipmentsBindingSource.Filter = String.Empty
    End Sub
    'Drag & Dropp https://www.codeproject.com/Articles/7140/Drag-and-Drop-Attached-File-From-Outlook-and-ab
    Private Sub frmMaininterface_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles btnaddDocument.DragDrop, DsDocumentDataGridView.DragDrop, DsDocumentDataGridView1.DragDrop, btnAddBL.DragDrop
        Dim fileNames As String() = Nothing

        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
                fileNames = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
                ' handle each file passed as needed
                ' do what you are going to do with each filename
                For Each fileName As String In fileNames
                    docHandle(fileName)
                Next
            ElseIf e.Data.GetDataPresent("FileGroupDescriptor") Then
                '
                ' the first step here is to get the filename
                ' of the attachment and
                ' build a full-path name so we can store it
                ' in the temporary folder
                '

                ' set up to obtain the FileGroupDescriptor
                ' and extract the file name
                Dim theStream As Stream = DirectCast(e.Data.GetData("FileGroupDescriptor"), Stream)
                Dim fileGroupDescriptor As Byte() = New Byte(511) {}
                theStream.Read(fileGroupDescriptor, 0, 512)
                ' used to build the filename from the FileGroupDescriptor block
                Dim fileName As New StringBuilder
                ' this trick gets the filename of the passed attached file
                Dim i As Integer = 76
                While fileGroupDescriptor(i) <> 0
                    fileName.Append(Convert.ToChar(fileGroupDescriptor(i)))
                    i += 1
                End While
                theStream.Close()
                Dim path__1 As String = Path.GetTempPath()
                ' put the zip file into the temp directory
                Dim theFile As String = path__1 & fileName.ToString()
                ' create the full-path name

                '
                ' Second step:  we have the file name.
                ' Now we need to get the actual raw
                ' data for the attached file and copy it to disk so we work on it.
                '

                ' get the actual raw file into memory
                Dim ms As MemoryStream = DirectCast(e.Data.GetData("FileContents", True), MemoryStream)
                ' allocate enough bytes to hold the raw data
                Dim fileBytes As Byte() = New Byte(CInt(ms.Length - 1)) {}
                ' set starting position at first byte and read in the raw data
                ms.Position = 0
                ms.Read(fileBytes, 0, CInt(ms.Length))
                ' create a file and save the raw zip file to it
                Dim fs As New FileStream(theFile, FileMode.Create)
                fs.Write(fileBytes, 0, CInt(fileBytes.Length))
                fs.Close()
                ' close the file
                Dim tempFile As New FileInfo(theFile)
                ' always good to make sure we actually created the file
                If tempFile.Exists = True Then
                    ' for now, just delete what we created
                    docHandle(theFile)
                    tempFile.Delete()
                Else
                    Trace.WriteLine("File was not created!")
                End If

            End If

        Catch ex As Exception

            ' don't use MessageBox here - Outlook or Explorer is waiting !
            Trace.WriteLine("Error in DragDrop function: " + ex.Message)
        End Try

    End Sub

    Private Sub btnImport_DragEnter(sender As Object, e As DragEventArgs) Handles btnaddDocument.DragEnter, DsDocumentDataGridView.DragEnter, DsDocumentDataGridView1.DragEnter, btnAddBL.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Or e.Data.GetDataPresent("FileGroupDescriptor") Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Sub docHandle(ByVal File As String)
        frmDocument.dirFile = File
        frmDocument.ShowDialog()
        Dim rowActual As dsDemag_HUB.dsShipmentsRow = DsDemag_HUB.dsShipments.FindByShipment_ID(Convert.ToInt32(Shipment_IDTextBox.Text))
        If frmDocument.docType = "HBL" Then
            If rowActual.IsHBL_NoNull Then rowActual.HBL_No = frmDocument.docNo
        End If

        If frmDocument.docType = "BL" Then
            If rowActual.IsMBL_NoNull Then rowActual.MBL_No = frmDocument.docNo
        End If


        'Datenbank ergänzen
        Dim newDocRow As dsDemag_HUB.dsDocumentsRow
        newDocRow = DsDemag_HUB.dsDocuments.NewdsDocumentsRow
        newDocRow.Shipment_ID = Convert.ToInt32(Shipment_IDTextBox.Text)
        newDocRow.Created = Date.Now
        newDocRow.Document_No = frmDocument.docNo
        newDocRow.Link = frmDocument.docDirectory
        newDocRow.Document_Type = frmDocument.docType
        DsDemag_HUB.dsDocuments.Rows.Add(newDocRow)

        Me.dsDocumentsBindingSource.EndEdit()
        Me.DsDocumentsTableAdapter.Update(Me.DsDemag_HUB.dsDocuments)


    End Sub

    Private Sub Shipment_IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles Shipment_IDTextBox.TextChanged
        If Convert.ToDouble(Shipment_IDTextBox.Text) > 0 Then
            btnaddDocument.Enabled = True
            btnAddPO.Enabled = True
            txtPoNo.Enabled = True
            DsCommentDataGridView.Enabled = True
        Else
            btnaddDocument.Enabled = False
            btnAddPO.Enabled = False
            txtPoNo.Enabled = False
            DsCommentDataGridView.Enabled = False
        End If

        'Prüfen ob gecancelt
        Dim curRow As dsDemag_HUB.dsShipmentsRow
        curRow = DsDemag_HUB.dsShipments.FindByShipment_ID(Convert.ToInt32(Shipment_IDTextBox.Text))
        shpCancel(curRow.Cancelled)

        'Püfen ob surrendered
        If curRow.IsdtnSurenderedNull Then
            chkSurrenderedShipping.Checked = False
        Else
            chkSurrenderedShipping.Checked = True
        End If

    End Sub


    Private Sub btnAddPO_Click(sender As Object, e As EventArgs) Handles btnAddPO.Click
        'Prüfen ob PO leer ist
        If txtPoNo.Text = "" Then
            txtPoNo.BackColor = Color.LightGoldenrodYellow
            Exit Sub
        End If

        'Prüfen ob PO bereits in der Sendung ist
        For Each row As DataGridViewRow In DsShipment_OrderDataGridView.Rows
            If txtPoNo.Text = row.Cells(0).Value.ToString Then
                txtPoNo.BackColor = Color.LightGoldenrodYellow
                Exit Sub
            End If
        Next

        'Prüfen ob PO exisitiert und ggf. einfügen
        PoOrderBindingSource.Filter = "Purchase_Order = '" & txtPoNo.Text & "'"
        If PoOrderBindingSource.Count = 0 Then
            Dim newPORow As dsDemag_HUB.poOrderRow
            newPORow = DsDemag_HUB.poOrder.NewpoOrderRow
            newPORow.Purchase_Order = txtPoNo.Text
            newPORow.Created = Date.Now
            'newPORow.Supplier = Convert.ToDateTime("01.01.2000")
            newPORow.Service = ServiceTextBox.Text
            newPORow.Incoterm = IncotermTextBox.Text
            newPORow.Incoterm_Location = Incoterm_LocTextBox.Text
            DsDemag_HUB.poOrder.Rows.Add(newPORow)
            txtPoNo.BackColor = Color.YellowGreen
        Else
            txtPoNo.BackColor = Color.White
        End If


        'PO mit Shipment verknüpfen
        Dim newShipmentPO As dsDemag_HUB.dsShipment_OrderRow
        newShipmentPO = DsDemag_HUB.dsShipment_Order.NewdsShipment_OrderRow
        newShipmentPO.Shipment_ID = Convert.ToInt32(Shipment_IDTextBox.Text)
        newShipmentPO.Purchase_Order = txtPoNo.Text
        newShipmentPO.Created = Date.Now
        DsDemag_HUB.dsShipment_Order.Rows.Add(newShipmentPO)


        txtPoNo.Clear()
        txtPoNo.Focus()
        'sqeCheck(Convert.ToInt32(Shipment_IDTextBox.Text))

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            DsShipmentsBindingSource.RemoveFilter()
            Exit Sub
        End If

        Dim intSearch As Integer
        If Integer.TryParse(txtSearch.Text, intSearch) = False Then
            intSearch = 0
        End If

        Dim doubleSearch As Double
        If Double.TryParse(txtSearch.Text, doubleSearch) = False Then
            doubleSearch = 0
        End If

        Select Case cmbField.Text
            Case Is = "ShipmentID"
                If intSearch <> 0 Then DsShipmentsBindingSource.Filter = "Shipment_ID = '" & intSearch & "'"
            Case Is = "STT No.:"
                DsShipmentsBindingSource.Filter = "STT_No = '" & txtSearch.Text & "'"
            Case Is = "Archive No.:"
                DsShipmentsBindingSource.Filter = "Archive_No = '" & txtSearch.Text & "'"
            Case Is = "HBL No.:"
                DsShipmentsBindingSource.Filter = "HBL_No = '" & txtSearch.Text & "'"
            Case Is = "MBL No.:"
                DsShipmentsBindingSource.Filter = "MBL_No = '" & txtSearch.Text & "'"
            Case Is = "POL No.:"
                DsShipmentsBindingSource.Filter = "POL_No = '" & txtSearch.Text & "'"
            Case Is = "PO No.:"
                DsShipmentsBindingSource.Filter = searchPO(txtSearch.Text)
            Case Is = "SO No.:"
                If doubleSearch <> 0 Then DsShipmentsBindingSource.Filter = searchSO(txtSearch.Text)
            Case Is = "Inv No.:"
                DsShipmentsBindingSource.Filter = searchINV(txtSearch.Text)
            Case Else
                If intSearch <> 0 Then
                    DsShipmentsBindingSource.Filter = "Shipment_ID = '" & txtSearch.Text & "' OR " &
                                                   "STT_No = '" & txtSearch.Text & "' OR " &
                                                   "Archive_No = '" & txtSearch.Text & "' OR " &
                                                   "HBL_No = '" & txtSearch.Text & "' OR " &
                                                   "MBL_No = '" & txtSearch.Text & "' OR " &
                                                   "POL_No = '" & txtSearch.Text & "' OR " &
                                                   searchPO(txtSearch.Text) & " OR " &
                                                   searchSO(txtSearch.Text) & " OR " &
                                                   searchINV(txtSearch.Text)
                    Exit Select
                End If

                If doubleSearch <> 0 Then
                    DsShipmentsBindingSource.Filter = "STT_No = '" & txtSearch.Text & "' OR " &
                                                   "Archive_No = '" & txtSearch.Text & "' OR " &
                                                   "HBL_No = '" & txtSearch.Text & "' OR " &
                                                   "MBL_No = '" & txtSearch.Text & "' OR " &
                                                   "POL_No = '" & txtSearch.Text & "' OR " &
                                                   searchPO(txtSearch.Text) & " OR " &
                                                   searchSO(txtSearch.Text) & " OR " &
                                                   searchINV(txtSearch.Text)
                    Exit Select
                End If

                DsShipmentsBindingSource.Filter = "STT_No = '" & txtSearch.Text & "' OR " &
                                                    "Archive_No = '" & txtSearch.Text & "' OR " &
                                                    "HBL_No = '" & txtSearch.Text & "' OR " &
                                                    "MBL_No = '" & txtSearch.Text & "' OR " &
                                                    "POL_No = '" & txtSearch.Text & "' OR " &
                                                    searchPO(txtSearch.Text) & " OR " &
                                                    searchINV(txtSearch.Text)
        End Select




        'Später einmal je Status
        If DsShipmentsBindingSource.Count = 1 Then
            selectTab()
        End If
    End Sub

    Function searchPO(ByVal PoNo As String) As String
        Dim strFilter As String = ""
        DsDemag_HUB.dsShipment_Order.DefaultView.RowFilter = "Purchase_Order = '" & PoNo & "'"
        For Each Row As DataRowView In DsDemag_HUB.dsShipment_Order.DefaultView
            If strFilter = "" Then
                strFilter += "Shipment_ID = '" & Row.Item("Shipment_ID").ToString & "'"
            Else
                strFilter += " OR Shipment_ID = '" & Row.Item("Shipment_ID").ToString & "'"
            End If
        Next
        DsDemag_HUB.dsShipment_Order.DefaultView.RowFilter = String.Empty
        If strFilter = "" Then strFilter = "Shipment_ID = '0'"
        Return strFilter
    End Function

    Function searchSO(ByVal SoNo As String) As String
        Dim strFilter As String = ""
        DsDemag_HUB.dsShipment_SO.DefaultView.RowFilter = "Shipping_Order = '" & SoNo & "'"
        For Each Row As DataRowView In DsDemag_HUB.dsShipment_SO.DefaultView
            If strFilter = "" Then
                strFilter += "Shipment_ID = '" & Row.Item("Shipment_ID").ToString & "'"
            Else
                strFilter += " OR Shipment_ID = '" & Row.Item("Shipment_ID").ToString & "'"
            End If
        Next
        DsDemag_HUB.dsShipment_Order.DefaultView.RowFilter = String.Empty
        If strFilter = "" Then strFilter = "Shipment_ID = '0'"
        Return strFilter
    End Function

    Function searchINV(ByVal INVNo As String) As String
        Dim strFilter As String = ""
        DsDemag_HUB.dsDocuments.DefaultView.RowFilter = "Document_No = '" & INVNo & "'"
        For Each Row As DataRowView In DsDemag_HUB.dsDocuments.DefaultView
            If strFilter = "" Then
                strFilter += "Shipment_ID = '" & Row.Item("Shipment_ID").ToString & "'"
            Else
                strFilter += " OR Shipment_ID = '" & Row.Item("Shipment_ID").ToString & "'"
            End If
        Next
        DsDemag_HUB.dsShipment_Order.DefaultView.RowFilter = String.Empty
        If strFilter = "" Then strFilter = "Shipment_ID = '0'"
        Return strFilter
    End Function


    Private Sub DsShipmentsDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DsShipmentsDataGridView.CellDoubleClick
        selectTab()
    End Sub

    Private Sub txtPoNo_Enter(sender As Object, e As EventArgs) Handles txtPoNo.Enter
        Me.AcceptButton = btnAddPO
    End Sub

    Private Sub txtPoNo_Leave(sender As Object, e As EventArgs) Handles txtPoNo.Leave
        Me.AcceptButton = btnSave
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter, cmbField.Enter
        Me.AcceptButton = btnSearch
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave, cmbField.Leave
        Me.AcceptButton = btnSave
    End Sub

    Function searchPartner(ByVal searchString As String, ByVal searchColum As String, Optional ByVal PartnerName As String = "NewPartner") As Integer
        DsPartnerBindingSource.Filter = searchColum & " = '" & searchString & "'"
        Select Case DsPartnerBindingSource.Count
            Case = 1
                Dim ptRow As DataRow = DsDemag_HUB.dsPartner.Rows(DsDemag_HUB.dsPartner.Rows.IndexOf(DirectCast(DsPartnerBindingSource.Current, DataRowView).Row))
                If ptRow.Item("Partner_ID").ToString = "" Then
                    MsgBox(searchString)
                    Return 4
                Else
                    Return Convert.ToInt32(ptRow.Item("Partner_ID").ToString)
                End If

            Case = 0
                Dim newParter As dsDemag_HUB.dsPartnerRow
                newParter = DsDemag_HUB.dsPartner.NewdsPartnerRow
                newParter.Created = Now
                newParter.PartnerName = PartnerName
                newParter.Item(searchColum) = searchString
                DsDemag_HUB.dsPartner.Rows.Add(newParter)

                Return newParter.Partner_ID
            Case Else
                'Hier müsste noch ein multiple choice hin
                Return 4
        End Select

    End Function

    Function searchUNLOC(ByVal searchString As String, ByVal searchColumn As String) As String
        UNLOCBindingSource.Filter = searchColumn & " = '" & searchString & "'"
        If UNLOCBindingSource.Count = 1 Then
            Dim unRow As DataRow = DsDemag_HUB.UNLOC.Rows(DsDemag_HUB.UNLOC.Rows.IndexOf(DirectCast(UNLOCBindingSource.Current, DataRowView).Row))
            Return unRow.Item("UNLOC").ToString
        Else
            Return "ZZZZZ"
        End If

    End Function


    'Backgroundworker
    'https://www.vb-paradise.de/index.php/Thread/61500-Multithreading-mit-BackgroundWorker/#codeLine_4_82b19c
    Dim WithEvents bgwImportICM As New System.ComponentModel.BackgroundWorker With {.WorkerReportsProgress = True, .WorkerSupportsCancellation = True}

    'Hier die Arbeit eingeben
    Private Sub BGW_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwImportICM.DoWork
        'Prüfen ob Datei vorhanden
        Dim directoryPath As String = Path.GetDirectoryName(My.Settings.sttDBPath)
        Dim dir As New IO.DirectoryInfo(directoryPath & "\ICM Export")
        If dir.Exists = False Then
            System.IO.Directory.CreateDirectory(dir.ToString)
        End If 'Directory erstellen falls Nötig

        Dim Folder As New IO.DirectoryInfo(dir.ToString & "\")
        Dim FileList As IO.FileInfo() = Folder.GetFiles()
        Dim File As IO.FileInfo

        If Folder.GetFiles().Count <> 0 Then
            For Each File In FileList 'Jede Datei abarbeiten
                'Bezeichnungen
                Dim xlsFile As String = File.FullName.ToString
                Dim xlsTable As String = "BM_New_PO"

                'Prüfen ob Datei vorhanden
                If My.Computer.FileSystem.FileExists(xlsFile) = False Then
                    MsgBox("Keine Datei gefunden")
                    Exit Sub
                End If
                'Prüfen ob Datei eine Excel Datei ist
                Dim blExtension As Boolean = False
                If Path.GetExtension(xlsFile) = ".xls" Then blExtension = True
                If Path.GetExtension(xlsFile) = ".XLS" Then blExtension = True
                If Path.GetExtension(xlsFile) = ".xlsx" Then blExtension = True
                If Path.GetExtension(xlsFile) = ".XLSX" Then blExtension = True
                If blExtension = False Then
                    MsgBox("Keine Excel Datei")
                    Exit Sub
                End If

                'ICM xls in DS einspielen
                Try
                    MyConnection = New System.Data.OleDb.OleDbConnection _
                    ("provider=Microsoft.ACE.OLEDB.12.0;" &
                    " Data Source='" & xlsFile & "'; " &
                    "Extended Properties=Excel 12.0;")
                    MyCommand = New System.Data.OleDb.OleDbDataAdapter _
                    ("select * from [" & xlsTable & "$]", MyConnection)
                    MyCommand.TableMappings.Add("Table", "ICMImport")
                    ImportDS = New System.Data.DataSet
                    MyCommand.Fill(ImportDS)
                    'DataGridView1.DataSource = DtSet.Tables(0)
                    MyConnection.Close()
                Catch ex As Exception
                    MsgBox("Kritischer Fehler" & ex.ToString)
                    Exit Sub
                End Try

                Dim countRecord As Integer = 0
                'ProgressBar.Maximum = ImportDS.Tables("ICMImport").Rows.Count
                bgwImportICM.ReportProgress(Convert.ToInt32(countRecord / ImportDS.Tables("ICMImport").Rows.Count) * 100)

                'Import Zeile für Zeile bearbeiten
                For Each Row As DataRow In ImportDS.Tables("ICMImport").Rows
                    Dim PO As String 'PO Bestimmen
                    If Row("Purchase Order").ToString().Length = 21 Then
                        Dim lsPO As String() = Row("Purchase Order").ToString().Split(New Char() {"_"c})
                        'MsgBox(lsPO(0))
                        PO = lsPO(0)
                        PO = PO.Substring(1, PO.Length - 1) ' Um die Null wegzubekomen
                    Else
                        PO = Row("Purchase Order").ToString()
                    End If

                    'Prüfen ob Record bereits vorhanden
                    PoOrderBindingSource.Filter = "Purchase_Order = '" & PO & "'"
                    If PoOrderBindingSource.Count = 0 Then 'Neu anlegen
                        Dim newPO As dsDemag_HUB.poOrderRow
                        newPO = DsDemag_HUB.poOrder.NewpoOrderRow
                        newPO.Purchase_Order = PO
                        newPO.Alias_Purchase_Order = Row("Purchase Order").ToString()
                        newPO.Created = Date.Now
                        newPO.Supplier = searchPartner(Row("Supplier Code").ToString(), "ICM_ID", Row("Supplier").ToString())
                        Select Case Row("Planned Mode").ToString()
                            Case "Ocean"
                                newPO.Service = "SEA"
                            Case "Air"
                                newPO.Service = "AIR"
                            Case Else
                                newPO.Service = "ZZZ"
                        End Select
                        Select Case Row("Shipping Terms").ToString()
                            Case Is = "Carriage Paid To"
                                newPO.Incoterm = "CPT"
                            Case Is = "Carriage and Insurance Paid To"
                                newPO.Incoterm = "CIP"
                            Case Is = "Cost And Freight (CAF)"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Cost and Freight (CFR)"
                                newPO.Incoterm = "CFR"
                            Case Is = "Cost, Insurance, And Freight"
                                newPO.Incoterm = "CIF"
                            Case Is = "DOCK SIDE DUTY PAID FRT COLLECT"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "DOCK SIDE DUTY PAID FRT PREPAID"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Delivered Duty Paid"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Delivered Ex Quay"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Delivered Ex Ship"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Delivered at Frontier"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Delivered at Place"
                                newPO.Incoterm = "DAP"
                            Case Is = "Delivered at Terminal"
                                newPO.Incoterm = "DAT"
                            Case Is = "Delivered, Duty Unpaid"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Delivery Duty Paid"
                                newPO.Incoterm = "DDP"
                            Case Is = "Domesically Supplied"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Ex Quay"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Ex Ship"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Ex Works"
                                newPO.Incoterm = "EXW"
                            Case Is = "Free Alongside Ship"
                                newPO.Incoterm = "FAS"
                            Case Is = "Free Carrier"
                                newPO.Incoterm = "FCA"
                            Case Is = "Free on Board"
                                newPO.Incoterm = "FOB"
                            Case Is = "Free on Rail"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Free on Truck"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Freight Carriage Paid To"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Freight Carriage and Insurance Paid To"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Landed Duty Paid"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Mutually Defined"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Non-privileged Foreign"
                                newPO.Incoterm = "ZZZ"
                            Case Is = "Privileged Foreign"
                                newPO.Incoterm = "ZZZ"
                            Case Else
                                newPO.Incoterm = "ZZZ"

                        End Select  'Incoterm
                        newPO.Incoterm_Location = searchUNLOC(Row("Planned POL").ToString(), "ICM")
                        If Row("Latest On-Board Date").ToString() <> "" Then newPO.Latest_On_Board = Convert.ToDateTime(Row("Latest On-Board Date").ToString())
                        If Row("Expected Arrival Date").ToString() <> "" Then newPO.Latest_Arrival = Convert.ToDateTime(Row("Expected Arrival Date").ToString())
                        'newPO.Forwarding_Agent = ""
                        If Row("Acceptance Status").ToString() = "Order Accepted" Then
                            newPO.Acceptance_Status = True
                        Else
                            newPO.Acceptance_Status = False
                        End If
                        If Row("SQE Check Approval").ToString() <> "" Then newPO.SQE_Check = Convert.ToDateTime(Row("SQE Check Approval").ToString())
                        newPO.Division = Row("Division").ToString()
                        newPO.Buyer_Mail = Row("Buyer E-Mail Address").ToString().Replace("demagcranes.com", "konecranes.com")
                        DsDemag_HUB.poOrder.Rows.Add(newPO)

                    Else 'Update
                        Dim editPO As dsDemag_HUB.poOrderRow
                        editPO = DsDemag_HUB.poOrder.FindByPurchase_Order(PO)
                        'If IsDBNull(editPO.Supplier) Then 'Nötig weil die manuel hinzugefügten keine Supplier haben

                        'Dim kpfile As System.IO.StreamWriter
                        'kpfile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\HolyAbsolut\Desktop\Log.txt", True)
                        'kpfile.WriteLine(PO & "_" & "XLS_" & searchPartner(Row("Supplier Code").ToString(), "ICM_ID", Row("Supplier").ToString()))
                        'kpfile.Close()

                        If editPO.IsSupplierNull Then
                            editPO.Supplier = searchPartner(Row("Supplier Code").ToString(), "ICM_ID", Row("Supplier").ToString())
                        Else
                            If editPO.Supplier <> searchPartner(Row("Supplier Code").ToString(), "ICM_ID", Row("Supplier").ToString()) Then
                                editPO.Supplier = searchPartner(Row("Supplier Code").ToString(), "ICM_ID", Row("Supplier").ToString())
                            End If
                        End If

                        Select Case Row("Planned Mode").ToString()
                            Case "Ocean"
                                If editPO.Service <> "SEA" Then editPO.Service = "SEA"
                            Case "Air"
                                If editPO.Service <> "AIR" Then editPO.Service = "Ocean"
                            Case Else
                                If editPO.Service <> "ZZZ" Then editPO.Service = "ZZZ"
                        End Select
                        Select Case Row("Shipping Terms").ToString()
                            Case Is = "Carriage Paid To"
                                If editPO.Incoterm <> "CPT" Then editPO.Incoterm = "CPT"
                            Case Is = "Carriage and Insurance Paid To"
                                If editPO.Incoterm <> "CIP" Then editPO.Incoterm = "CIP"
                            Case Is = "Cost And Freight (CAF)"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Cost and Freight (CFR)"
                                If editPO.Incoterm <> "CFR" Then editPO.Incoterm = "CFR"
                            Case Is = "Cost, Insurance, And Freight"
                                If editPO.Incoterm <> "CIF" Then editPO.Incoterm = "CIF"
                            Case Is = "DOCK SIDE DUTY PAID FRT COLLECT"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "DOCK SIDE DUTY PAID FRT PREPAID"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Delivered Duty Paid"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Delivered Ex Quay"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Delivered Ex Ship"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Delivered at Frontier"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Delivered at Place"
                                If editPO.Incoterm <> "DAP" Then editPO.Incoterm = "DAP"
                            Case Is = "Delivered at Terminal"
                                If editPO.Incoterm <> "DAT" Then editPO.Incoterm = "DAT"
                            Case Is = "Delivered, Duty Unpaid"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Delivery Duty Paid"
                                If editPO.Incoterm <> "DDP" Then editPO.Incoterm = "DDP"
                            Case Is = "Domesically Supplied"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Ex Quay"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Ex Ship"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Ex Works"
                                If editPO.Incoterm <> "EXW" Then editPO.Incoterm = "EXW"
                            Case Is = "Free Alongside Ship"
                                If editPO.Incoterm <> "FAS" Then editPO.Incoterm = "FAS"
                            Case Is = "Free Carrier"
                                If editPO.Incoterm <> "FCA" Then editPO.Incoterm = "FCA"
                            Case Is = "Free on Board"
                                If editPO.Incoterm <> "FOB" Then editPO.Incoterm = "FOB"
                            Case Is = "Free on Rail"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Free on Truck"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Freight Carriage Paid To"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Freight Carriage and Insurance Paid To"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Landed Duty Paid"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Mutually Defined"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Non-privileged Foreign"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Is = "Privileged Foreign"
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                            Case Else
                                If editPO.Incoterm <> "ZZZ" Then editPO.Incoterm = "ZZZ"
                        End Select
                        If editPO.Incoterm_Location <> searchUNLOC(Row("Planned POL").ToString(), "ICM") Then editPO.Incoterm_Location = searchUNLOC(Row("Planned POL").ToString(), "ICM")
                        If Row("Latest On-Board Date").ToString() <> "" Then
                            If editPO.IsLatest_On_BoardNull Then
                                editPO.Latest_On_Board = Convert.ToDateTime(Row("Latest On-Board Date").ToString())
                            Else
                                If editPO.Latest_On_Board <> Convert.ToDateTime(Row("Latest On-Board Date").ToString()) Then editPO.Latest_On_Board = Convert.ToDateTime(Row("Latest On-Board Date").ToString())
                            End If
                        End If
                        If Row("Expected Arrival Date").ToString() <> "" Then
                            If editPO.IsLatest_ArrivalNull Then
                                editPO.Latest_Arrival = Convert.ToDateTime(Row("Expected Arrival Date").ToString())
                            Else
                                If editPO.Latest_Arrival <> Convert.ToDateTime(Row("Expected Arrival Date").ToString()) Then editPO.Latest_Arrival = Convert.ToDateTime(Row("Expected Arrival Date").ToString())
                            End If
                        End If
                        'newPO.Forwarding_Agent = ""
                        If Row("Acceptance Status").ToString() = "Order Accepted" Then
                            If editPO.Acceptance_Status <> True Then editPO.Acceptance_Status = True
                        Else
                            If editPO.Acceptance_Status <> False Then editPO.Acceptance_Status = False
                        End If

                        Try
                            If Row("SQE Check Approval").ToString() <> "" Then
                                'MsgBox(Row("SQE Check Approval").ToString())
                                If editPO.IsSQE_CheckNull Then
                                    editPO.SQE_Check = Convert.ToDateTime(Row("SQE Check Approval").ToString())
                                Else
                                    If editPO.SQE_Check.ToString <> Row("SQE Check Approval").ToString() Then
                                        editPO.SQE_Check = Convert.ToDateTime(Row("SQE Check Approval").ToString())
                                    End If
                                End If

                            End If
                        Catch ex As Exception
                            MsgBox(editPO.Purchase_Order)
                            MsgBox(ex)
                        End Try

                        If editPO.IsDivisionNull Then
                            editPO.Division = Row("Division").ToString()
                        Else
                            If editPO.Division <> Row("Division").ToString() Then editPO.Division = Row("Division").ToString()
                        End If
                        If editPO.IsBuyer_MailNull Then
                            editPO.Buyer_Mail = Row("Buyer E-Mail Address").ToString().Replace("demagcranes.com", "konecranes.com")
                        Else
                            If editPO.Buyer_Mail <> Row("Buyer E-Mail Address").ToString() Then editPO.Buyer_Mail = Row("Buyer E-Mail Address").ToString().Replace("demagcranes.com", "konecranes.com")
                        End If
                    End If
                    countRecord += 1
                    bgwImportICM.ReportProgress(Convert.ToInt32(countRecord / ImportDS.Tables("ICMImport").Rows.Count * 100))

                Next

                Me.DsPartnerBindingSource.EndEdit()
                Me.DsPartnerTableAdapter.Update(Me.DsDemag_HUB.dsPartner)
                Me.Validate()
                Me.PoOrderBindingSource.EndEdit()
                Me.PoOrderTableAdapter.Update(Me.DsDemag_HUB.poOrder)
                My.Computer.FileSystem.DeleteFile(xlsFile)
            Next
        End If


        'Prüfen ob jetzt bei irgendwem ein SQE ausgelöst werden kann
        DsDemag_HUB.dsShipments.DefaultView.RowFilter = "SQE = 'False'"
        For Each Row As DataRowView In DsDemag_HUB.dsShipments.DefaultView
            sqeCheck(Convert.ToInt32(Row.Item("Shipment_ID").ToString))
        Next
        DsDemag_HUB.dsShipments.DefaultView.RowFilter = String.Empty

    End Sub

    Private Sub BGW_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwImportICM.ProgressChanged
        ProgressBar.Value = e.ProgressPercentage
    End Sub

    Private Sub BGW_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwImportICM.RunWorkerCompleted
        Label_Result.Text = "Update successful"
    End Sub

    Private Sub btnAddSO_Click(sender As Object, e As EventArgs) Handles btnAddSO.Click
        'Prüfen ob SO leer ist
        If txtSoNo.Text = "" Then
            txtSoNo.BackColor = Color.LightGoldenrodYellow
            Exit Sub
        End If

        'Prüfen ob SO bereits in der Sendung ist
        For Each row As DataGridViewRow In DsShipment_SODataGridView.Rows
            If txtSoNo.Text = row.Cells(0).Value.ToString Then
                txtSoNo.BackColor = Color.LightGoldenrodYellow
                Exit Sub
            End If
        Next






        'Prüfen ob PO bereits in der Sendung ist
        'For Each row As DataGridViewRow In Me.dvPoNo.Rows
        '    If txtPoNo.Text = row.Cells(1).Value.ToString Then
        '        txtPoNo.BackColor = Color.LightGoldenrodYellow
        '        Exit Sub
        '    End If
        'Next

        'Prüfen ob SO exisitiert und ggf. einfügen
        PoShipping_OrderBindingSource.Filter = "Shipping_Order = '" & txtSoNo.Text & "'"
        If PoShipping_OrderBindingSource.Count = 0 Then
            Dim newSoRow As dsDemag_HUB.poShipping_OrderRow
            newSoRow = DsDemag_HUB.poShipping_Order.NewpoShipping_OrderRow
            newSoRow.Shipping_Order = Convert.ToDouble(txtSoNo.Text)
            newSoRow.Created = Date.Now
            DsDemag_HUB.poShipping_Order.Rows.Add(newSoRow)
            txtSoNo.BackColor = Color.YellowGreen
        Else
            txtSoNo.BackColor = Color.White
        End If


        'PO mit Shipment verknüpfen
        Dim newShipmentSO As dsDemag_HUB.dsShipment_SORow
        newShipmentSO = DsDemag_HUB.dsShipment_SO.NewdsShipment_SORow
        newShipmentSO.Shipment_ID = Convert.ToInt32(Shipment_IDTextBox.Text)
        newShipmentSO.Shipping_Order = Convert.ToDouble(txtSoNo.Text)
        newShipmentSO.Created = Date.Now
        DsDemag_HUB.dsShipment_SO.Rows.Add(newShipmentSO)


        txtSoNo.Clear()
        txtSoNo.Focus()


    End Sub

    Private Sub txtSoNo_Enter(sender As Object, e As EventArgs) Handles txtSoNo.Enter
        Me.AcceptButton = btnAddSO
    End Sub

    Private Sub txtSoNo_Leave(sender As Object, e As EventArgs) Handles txtSoNo.Leave
        Me.AcceptButton = btnSave
    End Sub

    'Ergänzt die Daten sobald sich was ändert. Verbraucht möglichweiser viele Ressourcen
    Private Sub dvPoNo_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DsShipment_OrderDataGridView.DataBindingComplete
        'Ergänzt die Daten sobald sich was ändert. Verbraucht möglichweiser viele Ressourcen
        dvPoNoAddData()
    End Sub
    Sub dvPoNoAddData()
        For Each row As DataGridViewRow In DsShipment_OrderDataGridView.Rows
            'MsgBox(row.Cells(2).Value.ToString)
            PoOrderBindingSource.Filter = "Purchase_Order = '" & row.Cells(0).Value.ToString & "'"

            If PoOrderBindingSource.Count = 1 Then
                'Dim LatestETD As Date = HellwegDataSet.dsPurchaseOrder.FindByPONo(row.Cells(1).Value.ToString).LatestETD
                If DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).IsIncotermNull <> True Then row.Cells(1).Value = DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).Incoterm
                If DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).IsIncoterm_LocationNull <> True Then row.Cells(2).Value = DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).Incoterm_Location
                If DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).IsSQE_CheckNull <> True Then row.Cells(3).Value = DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).SQE_Check
                If DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).IsLatest_ArrivalNull <> True Then row.Cells(4).Value = DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).Latest_Arrival
                If DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).IsBuyer_MailNull <> True Then row.Cells(5).Value = DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).Buyer_Mail
            End If
        Next
        txtPOCount.Text = DsShipment_OrderDataGridView.Rows.Count.ToString
    End Sub

    Private Sub ServiceTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ServiceTextBox.SelectedIndexChanged
        Select Case ServiceTextBox.Text
            Case = "FCL"
                VolumeTextBox.Enabled = True
                WeightTextBox.Enabled = True
                Cont20DCTextBox.Enabled = True
                Cont40DCTextBox.Enabled = True
                Cont40HQTextBox.Enabled = True
                CarrierTextBox.Enabled = True
                Contract_NoTextBox.Enabled = True
                Container_SizeTextBox.Enabled = True
            Case = "LCL"
                VolumeTextBox.Enabled = True
                WeightTextBox.Enabled = True
                Cont20DCTextBox.Enabled = False
                Cont40DCTextBox.Enabled = False
                Cont40HQTextBox.Enabled = False
                CarrierTextBox.Enabled = False
                Contract_NoTextBox.Enabled = False
                Container_SizeTextBox.Enabled = False
            Case = "AIR"
                VolumeTextBox.Enabled = True
                WeightTextBox.Enabled = True
                Cont20DCTextBox.Enabled = False
                Cont40DCTextBox.Enabled = False
                Cont40HQTextBox.Enabled = False
                CarrierTextBox.Enabled = False
                Contract_NoTextBox.Enabled = False
            Case = "RAIL"
                VolumeTextBox.Enabled = True
                WeightTextBox.Enabled = True
                Cont20DCTextBox.Enabled = True
                Cont40DCTextBox.Enabled = True
                Cont40HQTextBox.Enabled = True
                CarrierTextBox.Enabled = False
                Contract_NoTextBox.Enabled = False
            Case Else
                VolumeTextBox.Enabled = True
                WeightTextBox.Enabled = True
                Cont20DCTextBox.Enabled = True
                Cont40DCTextBox.Enabled = True
                Cont40HQTextBox.Enabled = True
                CarrierTextBox.Enabled = True
                Contract_NoTextBox.Enabled = True
        End Select

    End Sub

    Private Sub calcTEU(sender As Object, e As EventArgs) Handles Cont20DCTextBox.TextChanged, Cont40DCTextBox.TextChanged, Cont40HQTextBox.TextChanged
        Dim cont20DC As Integer = 0
        Dim cont40DC As Integer = 0
        Dim cont40HQ As Integer = 0
        If Cont20DCTextBox.Text <> "" Then cont20DC = Convert.ToInt32(Cont20DCTextBox.Text)
        If Cont40DCTextBox.Text <> "" Then cont40DC = Convert.ToInt32(Cont40DCTextBox.Text)
        If Cont40HQTextBox.Text <> "" Then cont40HQ = Convert.ToInt32(Cont40HQTextBox.Text)

        TEUTextBox.Text = Convert.ToString((cont40DC + cont40HQ) * 2 + cont20DC)
    End Sub



    Private Sub SQE_Click(sender As Object, e As EventArgs) Handles btnSQE.Click
        Dim Subject As String
        Dim Body As String
        Dim File As String = ""
        Dim rowActual As dsDemag_HUB.dsShipmentsRow = DsDemag_HUB.dsShipments.FindByShipment_ID(Convert.ToInt32(Shipment_IDTextBox.Text))

        Subject = "DEMAG: Missing SQE Approval - "
        Subject = Subject & "ID: " & Shipment_IDTextBox.Text
        If STT_NoTextBox.Text <> "" Then Subject = Subject & " // STT No.: " & STT_NoTextBox.Text
        If DsShipment_SODataGridView.Rows.Count <> 0 Then
            Subject = Subject & " // SO No.:"
            For Each Row As DataGridViewRow In Me.DsShipment_SODataGridView.Rows
                Subject = Subject & " " & Row.Cells(0).Value.ToString
            Next
        End If

        If DsDocumentDataGridView.Rows.Count <> 0 Then
            Subject = Subject & " // INV No.:"
            For Each Row As DataGridViewRow In Me.DsDocumentDataGridView.Rows
                Subject = Subject & " " & Row.Cells(0).Value.ToString
            Next
        End If

        If DsShipment_OrderDataGridView.Rows.Count <> 0 Then
            Subject = Subject & " // PO No.:"
            For Each Row As DataGridViewRow In Me.DsShipment_OrderDataGridView.Rows
                Subject = Subject & " " & Row.Cells(0).Value.ToString
            Next
        End If

        'Dim Signature As HtmlDocument




        Body = "Dear Sir or Madam,<br>please check if for above mentioned shipment the SQE approval was given. <br><br> Many thanks"

        If DsDocumentDataGridView.Rows.Count = 1 Then
            'MsgBox(DsInvoiceDataGridView1.Rows(0).Cells(4).Value.ToString)
            File = DsDocumentDataGridView1.Rows(0).Cells(4).Value.ToString
        End If


        SendMailOutlook.SendMailHTTP(GetMailContact(rowActual.Shipper, "SQE"), Subject, Body, File)

        'Protokoll anlegen
        Dim newPtRow As dsDemag_HUB.ptShipmentsRow
        newPtRow = DsDemag_HUB.ptShipments.NewptShipmentsRow
        newPtRow.ShipmentID = Convert.ToInt32(Shipment_IDTextBox.Text)
        newPtRow.Created = Date.Now
        newPtRow.Description = "SQE"
        newPtRow.Description = "SQE Check aproval was requested"
        newPtRow.User = Environment.UserName
        DsDemag_HUB.ptShipments.Rows.Add(newPtRow)
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        If dtnETD.Text = "" Or
        dtnETA.Text = "" Or
        IncotermTextBox.Text = "" Or
        Incoterm_LocTextBox.Text = "" Then
            MsgBox("Es fehlen noch Daten: ETD,ETA,Incoterm, Incoterm Location")
            Exit Sub
        End If


        Dim Subject As String
        Dim Body As String
        Dim File As String = ""
        Dim toMail As String = ""

        Subject = "DEMAG: Shipment schedule - "
        Subject = Subject & "ID: " & Shipment_IDTextBox.Text
        If STT_NoTextBox.Text <> "" Then Subject = Subject & " // STT No.: " & STT_NoTextBox.Text
        If DsShipment_SODataGridView.Rows.Count <> 0 Then
            Subject = Subject & " // SO No.:"
            For Each Row As DataGridViewRow In Me.DsShipment_SODataGridView.Rows
                Subject = Subject & " " & Row.Cells(0).Value.ToString
            Next
        End If

        If DsDocumentDataGridView.Rows.Count <> 0 Then
            Subject = Subject & " // INV No.:"
            For Each Row As DataGridViewRow In Me.DsDocumentDataGridView.Rows
                Subject = Subject & " " & Row.Cells(0).Value.ToString
            Next
        End If

        If DsShipment_OrderDataGridView.Rows.Count <> 0 Then
            Subject = Subject & " // PO No.:"
            For Each Row As DataGridViewRow In Me.DsShipment_OrderDataGridView.Rows
                Subject = Subject & " " & Row.Cells(0).Value.ToString
            Next
        End If


        'Mailadressen auslesen
        Dim arrMail As New List(Of String) 'Doppelte prüfen
        If DsShipment_OrderDataGridView.Rows.Count <> 0 Then
            For Each Row As DataGridViewRow In Me.DsShipment_OrderDataGridView.Rows
                If IsNothing(Row.Cells(5).Value) = False Then
                    If arrMail.Contains(Row.Cells(5).Value.ToString.Replace("demagcranes.com", "konecranes.com")) = False Then arrMail.Add(Row.Cells(5).Value.ToString.Replace("demagcranes.com", "konecranes.com"))
                End If
            Next
        End If

        For Each strgMail As String In arrMail
            toMail += strgMail & ";"
        Next



        Body = "Dear Sir or Madam,<br>above mentioned shipment is planned as follow.<br>" &
                "<br>ETD " & POLTextBox.Text & ": " & dtnETD.Text &
                "<br>ETA " & PODTextBox.Text & ": " & dtnETA.Text &
                "<br>Incoterm: " & IncotermTextBox.Text & " - " & Incoterm_LocTextBox.Text &
                "<br><br>Please let us know if any additional Info is necessary."

        If DsDocumentDataGridView.Rows.Count = 1 Then
            File = DsDocumentDataGridView1.Rows(0).Cells(4).Value.ToString
        End If


        SendMailOutlook.SendMailHTTP(toMail, Subject, Body, File)

        'Protokoll anlegen
        Dim newPtRow As dsDemag_HUB.ptShipmentsRow
        newPtRow = DsDemag_HUB.ptShipments.NewptShipmentsRow
        newPtRow.ShipmentID = Convert.ToInt32(Shipment_IDTextBox.Text)
        newPtRow.Created = Date.Now
        newPtRow.Description = "Schedule"
        newPtRow.Description = "Schedule was announced"
        newPtRow.User = Environment.UserName
        DsDemag_HUB.ptShipments.Rows.Add(newPtRow)
    End Sub

    Private Sub tabOverview_Enter(sender As Object, e As EventArgs) Handles tabOverview.Enter
        txtSearch.Focus()
    End Sub

    Private Sub DsDocumentsDataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DsDocumentDataGridView1.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then 'Dokument öffnen
            Dim selectedRow = DsDocumentDataGridView1.Rows(e.RowIndex)
            Process.Start(selectedRow.Cells(3).Value.ToString)
        End If
    End Sub

    Private Sub btnReloadDB_Click(sender As Object, e As EventArgs) Handles btnReloadDB.Click
        LoadDB()
    End Sub

    Private Sub btnMailSubject_Click(sender As Object, e As EventArgs) Handles btnMailSubject.Click
        Dim Subject As String


        Subject = "DEMAG: "
        Subject = Subject & "ID: " & Shipment_IDTextBox.Text
        If STT_NoTextBox.Text <> "" Then Subject = Subject & " // STT No.: " & STT_NoTextBox.Text
        If DsShipment_SODataGridView.Rows.Count <> 0 Then
            Subject = Subject & " // SO No.:"
            For Each Row As DataGridViewRow In Me.DsShipment_SODataGridView.Rows
                Subject = Subject & " " & Row.Cells(0).Value.ToString
            Next
        End If

        If DsDocumentDataGridView.Rows.Count <> 0 Then
            Subject = Subject & " // INV No.:"
            For Each Row As DataGridViewRow In Me.DsDocumentDataGridView.Rows
                Subject = Subject & " " & Row.Cells(0).Value.ToString
            Next
        End If

        If DsShipment_OrderDataGridView.Rows.Count <> 0 Then
            Subject = Subject & " // PO No.:"
            For Each Row As DataGridViewRow In Me.DsShipment_OrderDataGridView.Rows
                Subject = Subject & " " & Row.Cells(0).Value.ToString
            Next
        End If

        My.Computer.Clipboard.SetText(Subject)

    End Sub

    Private Sub CharacterCasingComboBox(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IncotermTextBox.KeyPress, Incoterm_LocTextBox.KeyPress, POLTextBox.KeyPress, PODTextBox.KeyPress, ServiceTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub

    Private Sub tsmOpenDIR_Click(sender As Object, e As EventArgs) Handles tsmOpenDIR.Click
        Dim directoryPath As String = Path.GetDirectoryName(My.Settings.sttDBPath)
        Dim dir As New IO.DirectoryInfo(directoryPath & "\Documents\" & Shipment_IDTextBox.Text & "\")
        If System.IO.Directory.Exists(dir.ToString) Then Process.Start(Path.GetDirectoryName(dir.ToString))
    End Sub

    Private Sub tsmOpen_Click(sender As Object, e As EventArgs) Handles tsmOpen.Click
        'If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then 'Dokument öffnen
        '    Dim selectedRow = DsInvoiceDataGridView1.Rows(e.RowIndex)
        '    Process.Start(selectedRow.Cells(4).Value.ToString)
        'End If
    End Sub

    Function GetDataMatrix(ByVal Content As String) As Bitmap
        Dim encoder As DataMatrix.net.DmtxImageEncoder = New DataMatrix.net.DmtxImageEncoder
        Dim options As DataMatrix.net.DmtxImageEncoderOptions = New DataMatrix.net.DmtxImageEncoderOptions
        options.ModuleSize = 2
        options.MarginSize = 5
        options.BackColor = Color.White
        options.ForeColor = Color.Black
        options.Scheme = DataMatrix.net.DmtxScheme.DmtxSchemeAsciiGS1
        Dim encodedBitmap As Bitmap = encoder.EncodeImage(Content, options)
        Return encodedBitmap
    End Function

    Function GetPartnerDetails(ByVal PartnerID As Integer, ByVal Field As String) As String
        Dim parRow As dsDemag_HUB.dsPartnerRow = DsDemag_HUB.dsPartner.FindByPartner_ID(PartnerID)
        Select Case Field
            Case "Created"
                Return parRow.Created.ToString
            Case "Tango_ID"
                Return parRow.Tango_ID
            Case "ICM_ID"
                Return parRow.ICM_ID
            Case "PartnerName"
                Return parRow.PartnerName
            Case "EORI"
                Return parRow.EORI
            Case "WKV"
                Return parRow.WKV.ToString
            Case "TrackingLink"
                Return parRow.TrackingLink
            Case Else
                Return ""
        End Select
    End Function

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        Dim curRow As dsDemag_HUB.dsShipmentsRow
        MsgBox(Shipment_IDTextBox.Text)
        curRow = DsDemag_HUB.dsShipments.FindByShipment_ID(Convert.ToInt32(Shipment_IDTextBox.Text))

        PDFCover.dtSipmentID = curRow.Shipment_ID.ToString

        If curRow.IsArchive_NoNull Then
            PDFCover.ArchivNo = ""
        Else
            PDFCover.ArchivNo = curRow.Archive_No
        End If
        If curRow.IsArchive_NoNull Then
            PDFCover.dtArchiveNoHBL = ""
        Else
            PDFCover.dtArchiveNoHBL = curRow.Archive_No
        End If
        If curRow.IsSTT_NoNull Then
            PDFCover.STTNo = ""
        Else
            PDFCover.STTNo = curRow.STT_No
        End If
        If curRow.IsdtnETANull Then
            PDFCover.ETA = ""
        Else
            PDFCover.ETA = curRow.dtnETA.ToString("dd.MM.yyyy")
        End If
        If curRow.IsPOLNull Then
            PDFCover.POL = ""
        Else
            PDFCover.POL = curRow.POL
        End If
        If curRow.IsPODNull Then
            PDFCover.POD = ""
        Else
            PDFCover.POD = curRow.POD
        End If
        If curRow.IsVesselNull Then
            PDFCover.Vessel = ""
        Else
            PDFCover.Vessel = curRow.Vessel
        End If
        If curRow.IsTerminalNull Then
            PDFCover.Terminal = ""
        Else
            PDFCover.Terminal = curRow.Terminal.ToString
        End If
        If curRow.IsCont20DCNull Then
            PDFCover.dt20DC = ""
        Else
            PDFCover.dt20DC = curRow.Cont20DC.ToString
        End If
        If curRow.IsCont40DCNull Then
            PDFCover.dt40DC = ""
        Else
            PDFCover.dt40DC = curRow.Cont40DC.ToString
        End If
        If curRow.IsCont40HQNull Then
            PDFCover.dt40HQ = ""
        Else
            PDFCover.dt40HQ = curRow.Cont40HQ.ToString
        End If
        If curRow.IsContract_NoNull Then
            PDFCover.dtContract = ""
        Else
            PDFCover.dtContract = curRow.Contract_No
        End If
        If curRow.IsSTT_NoNull Then
            PDFCover.dtSTT = ""
        Else
            PDFCover.dtSTT = curRow.STT_No
        End If
        If curRow.IsServiceNull Then
            PDFCover.dtService = ""
        Else
            PDFCover.dtService = curRow.Service
        End If
        If curRow.IsWeightNull Then
            PDFCover.dtWeight = ""
        Else
            PDFCover.dtWeight = curRow.Weight.ToString
        End If
        If curRow.IsVolumeNull Then
            PDFCover.dtVolume = ""
        Else
            PDFCover.dtVolume = curRow.Volume.ToString
        End If
        If curRow.IsVolumeNull Or curRow.IsWeightNull Then
            PDFCover.dtVolume = ""
        Else
            If curRow.Volume > curRow.Weight / 1000 Then
                PDFCover.dtChargeable = curRow.Volume.ToString
            Else
                PDFCover.dtChargeable = (curRow.Weight / 1000).ToString
            End If
            PDFCover.dtVolume = curRow.Volume.ToString
        End If
        If curRow.IsPrincipalNull Then
            PDFCover.dtClient = ""
        Else
            PDFCover.dtClient = GetPartnerDetails(curRow.Principal, "PartnerName")
        End If
        If curRow.IsCarrierNull Then
            PDFCover.dtCarrier = ""
        Else
            PDFCover.dtCarrier = GetPartnerDetails(curRow.Carrier, "PartnerName")
        End If



        If curRow.IsIncotermNull Then
            PDFCover.dtIncoterm = ""
        Else
            PDFCover.dtIncoterm = curRow.Incoterm
        End If
        If curRow.IsIncoterm_LocNull Then
            PDFCover.dtIncotermLoc = ""
        Else
            PDFCover.dtIncotermLoc = curRow.Incoterm_Loc
        End If



        Select Case curRow.Service
            Case = "LCL"
                PDFCover.dtCharge0Description = "T1"
                PDFCover.dtCharge0Value = "€ 35,-"
                PDFCover.dtCharge1Description = "LCL Service-Charges"
                If curRow.Weight / 1000 * 85 > curRow.Volume * 25 Then
                    If curRow.Weight / 1000 * 85 > 85 Then
                        PDFCover.dtCharge1Value = "€ 85,- per To"
                    Else
                        PDFCover.dtCharge1Value = "€ 85,- Minimum"
                    End If
                Else
                    If curRow.Volume * 25 > 85 Then
                        PDFCover.dtCharge1Value = "€ 25,- per cbm"
                    Else
                        PDFCover.dtCharge1Value = "€ 85,- Minimum"
                    End If
                End If
                PDFCover.dtCharge2Description = "Lizenzgebühren POT"
                PDFCover.dtCharge2Value = "€ 17,-"
                PDFCover.dtCharge3Description = "EBS"
                PDFCover.dtCharge3Value = "$ 3,50 w/m"
                PDFCover.dtCharge4Description = ""
                PDFCover.dtCharge4Value = ""
                PDFCover.dtCharge5Description = ""
                PDFCover.dtCharge5Value = ""
            Case = "FCL"
                PDFCover.dtCharge0Description = "T1"
                PDFCover.dtCharge0Value = "€ 35,-"
                PDFCover.dtCharge1Description = "THC"
                PDFCover.dtCharge1Value = "€ 210,-"
                PDFCover.dtCharge2Description = "ISPS"
                PDFCover.dtCharge2Value = "€ 18,50"
                PDFCover.dtCharge3Description = "Release fee"
                PDFCover.dtCharge3Value = "€ 35,"
                PDFCover.dtCharge4Description = "Lizenzgebühren POT"
                PDFCover.dtCharge4Value = "€ 21,75"
                PDFCover.dtCharge5Description = "EBS"
                PDFCover.dtCharge5Value = "$ 62,50"
        End Select
        PDFCover.dtCharge6Description = ""
        PDFCover.dtCharge6Value = ""
        PDFCover.dtCharge7Description = ""
        PDFCover.dtCharge7Value = ""
        PDFCover.dtCharge8Description = ""
        PDFCover.dtCharge8Value = ""
        PDFCover.dtCharge9Description = ""
        PDFCover.dtCharge9Value = ""
        PDFCover.dtCharge10Description = ""
        PDFCover.dtCharge10Value = ""


        PDFCover.dtQuantity = ""
        PDFCover.dtEK_VK = ""
        PDFCover.dtEK_SK = ""
        PDFCover.dtEK_SpecialSurcharge = ""
        PDFCover.dtVK_VK = ""
        PDFCover.dtVK_SK = ""
        PDFCover.dtVK_SpecialSurcharge = ""
        PDFCover.dtVK_Nachlauf = ""
        PDFCover.dt20DCHW = ""
        'PDFCover.dtCharge0Description = ""
        'PDFCover.dtCharge0Value = ""
        'PDFCover.dtCharge1Description = ""
        'PDFCover.dtCharge1Value = ""
        'PDFCover.dtCharge2Description = ""
        'PDFCover.dtCharge2Value = ""
        'PDFCover.dtCharge3Description = ""
        'PDFCover.dtCharge3Value = ""
        'PDFCover.dtCharge4Description = ""
        'PDFCover.dtCharge4Value = ""
        'PDFCover.dtCharge5Description = ""
        'PDFCover.dtCharge5Value = ""
        'PDFCover.dtCharge6Description = ""
        'PDFCover.dtCharge6Value = ""
        'PDFCover.dtCharge7Description = ""
        'PDFCover.dtCharge7Value = ""
        'PDFCover.dtCharge8Description = ""
        'PDFCover.dtCharge8Value = ""
        'PDFCover.dtCharge9Description = ""
        'PDFCover.dtCharge9Value = ""
        'PDFCover.dtCharge10Description = ""
        'PDFCover.dtCharge10Value = ""

        PDFCover.dtFullDocs = ""
        PDFCover.dtIMDG = ""
        PDFCover.dtPMRef = ""
        PDFCover.dtWKV = ""
        PDFCover.dtBLSent = ""
        PDFCover.dtLeerdepot = "Neuss"
        PDFCover.EmptyDepot = ""
        PDFCover.dtIMDGUN = ""
        PDFCover.dtIMDGCheck = ""
        PDFCover.dtDelivery = ""
        PDFCover.dtCUS = ""
        PDFCover.dtFISoTRANSIT = ""
        PDFCover.dtArchiveNoMBL = ""
        PDFCover.chkVomKunden = False
        PDFCover.chkVerzolltSeehafen = False
        PDFCover.chkAtlasFremd = False
        PDFCover.chkVomUnternehmer = False
        PDFCover.chkTruck = False
        PDFCover.chkT1 = True
        PDFCover.chkSchenker = True
        PDFCover.chkRail = True
        PDFCover.chkMBLW = False
        PDFCover.chkMBLO = False
        PDFCover.chkLeer = False
        PDFCover.chkKopiert = False
        PDFCover.chkKompensation = True
        PDFCover.chkHBLW = False
        PDFCover.chkHBLS = False
        PDFCover.chkHBLO = False
        PDFCover.chkFremd = False
        PDFCover.chkFreistellung = False
        PDFCover.chkDispo = False
        PDFCover.chkBarge = False
        PDFCover.chkAtlas2 = False
        PDFCover.chkAtlas1 = False

        PDFCover.chkICM = False
        PDFCover.chkTurnIn = False
        PDFCover.chkPIN = False
        PDFCover.chkAbgerechnet = False
        PDFCover.chkSQE = False

        Dim directoryPath As String = Path.GetDirectoryName(My.Settings.sttDBPath)
        Dim dir As New IO.DirectoryInfo(directoryPath & "\Documents\" & Shipment_IDTextBox.Text & "\")
        If dir.Exists = False Then
            System.IO.Directory.CreateDirectory(dir.ToString)
        End If

        Dim dirCover As String = dir.ToString & "JobDossier_" & Date.Now.ToString("yyyyMMdd-hhmmss") & ".pdf"
        'Create Job Dossier
        Cover(dirCover)

        'Create Invoice
        Dim newDocRow As dsDemag_HUB.dsDocumentsRow
        newDocRow = DsDemag_HUB.dsDocuments.NewdsDocumentsRow
        newDocRow.Shipment_ID = Convert.ToInt32(Shipment_IDTextBox.Text)
        newDocRow.Created = Date.Now
        newDocRow.Document_No = "Job Dossier"
        newDocRow.Link = dirCover
        newDocRow.Document_Type = "Job_Dossier"
        DsDemag_HUB.dsDocuments.Rows.Add(newDocRow)

        Me.DsDocumentsBindingSource.EndEdit()
        Me.DsDocumentsTableAdapter.Update(Me.DsDemag_HUB.dsDocuments)


        If chkOpenPDF.Checked = True Then Process.Start(dirCover)

        'https://blog.scottlogic.com/2012/10/05/pdf-generation-and-printing-in-net-2.html
        'If chkPrintPDF.Checked = True Then
        '    RunGS("-sDEVICE=mswinpr2", "-dNOPAUSE", "-dBATCH", "-sOutputFile=%printer%" & My.Settings.setPrinter, dirCover)
        '    ' If chkPrintDouble.Checked = True Then RunGS("-sDEVICE=mswinpr2", "-dNOPAUSE", "-dBATCH", "-sOutputFile=%printer%" & My.Settings.setPrinter, pdfFile)
        '    'chkPrintFile.Checked = False
        'End If




    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim curRow As dsDemag_HUB.dsShipmentsRow

        curRow = DsDemag_HUB.dsShipments.FindByShipment_ID(Convert.ToInt32(Shipment_IDTextBox.Text))
        'Protokoll anlegen
        Dim newPtRow As dsDemag_HUB.ptShipmentsRow
        newPtRow = DsDemag_HUB.ptShipments.NewptShipmentsRow
        newPtRow.ShipmentID = curRow.Shipment_ID
        newPtRow.Created = Date.Now
        newPtRow.Description = "Cancel"
        newPtRow.User = Environment.UserName

        If curRow.Cancelled = True Then
            curRow.Cancelled = False
            newPtRow.Description = "Shipment was enabled"
            newPtRow.oldValue = True.ToString
            newPtRow.newValue = False.ToString
            newPtRow.Column_Name = "Cancelled"
        Else
            curRow.Cancelled = True
            newPtRow.Description = "Shipment was cancelled"
            newPtRow.oldValue = False.ToString
            newPtRow.newValue = True.ToString
            newPtRow.Column_Name = "Cancelled"
        End If
        DsDemag_HUB.ptShipments.Rows.Add(newPtRow)
        shpCancel(curRow.Cancelled)
    End Sub

    Sub shpCancel(ByVal chkState As Boolean)
        If chkState = True Then
            tabBooking.Enabled = False
            tabBooking.BackColor = Color.IndianRed
            tabShipping.BackColor = Color.IndianRed
        Else
            tabBooking.Enabled = True
            tabBooking.BackColor = Color.White
            tabBooking.BackColor = Color.White
        End If
    End Sub

    Private Sub DsDocumentDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DsDocumentDataGridView.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then 'Dokument öffnen
            Dim selectedRow = DsDocumentDataGridView1.Rows(e.RowIndex)
            Process.Start(selectedRow.Cells(3).Value.ToString)
        End If
    End Sub

    Sub sqeCheck(ByVal idShipment As Integer)
        Dim ShipRow As dsDemag_HUB.dsShipmentsRow = DsDemag_HUB.dsShipments.FindByShipment_ID(idShipment)

        'Prüfen ob bereits confirmed
        If ShipRow.SQE = True Then Exit Sub
        Dim sqeStatus As Boolean = True
        Dim txtPO As String = ""


        'DataRowView

        DsDemag_HUB.dsShipment_Order.DefaultView.RowFilter = "Shipment_ID = '" & idShipment & "'"
        For Each Row As DataRowView In DsDemag_HUB.dsShipment_Order.DefaultView
            Dim poRow As dsDemag_HUB.poOrderRow = DsDemag_HUB.poOrder.FindByPurchase_Order(Row.Item("Purchase_Order").ToString)
            If poRow.IsSQE_CheckNull Then sqeStatus = False
            txtPO += poRow.Purchase_Order & " "
        Next
        If DsDemag_HUB.dsShipment_Order.DefaultView.Count = 0 Then sqeStatus = False

        If sqeStatus = True Then
            ShipRow.SQE = True
            'Protokoll anlegen
            Dim newPtRow As dsDemag_HUB.ptShipmentsRow
            newPtRow = DsDemag_HUB.ptShipments.NewptShipmentsRow
            newPtRow.ShipmentID = ShipRow.Shipment_ID
            newPtRow.Created = Date.Now
            newPtRow.Description = "SQE Aprroved"
            newPtRow.Column_Name = "SQE"
            newPtRow.oldValue = "False"
            newPtRow.newValue = "True"
            newPtRow.User = Environment.UserName
            DsDemag_HUB.ptShipments.Rows.Add(newPtRow)
            'Mail
            Dim Body As String
            Dim Subject As String = "DEMAG: SQE confirmed // ID: " & ShipRow.Shipment_ID.ToString

            Body = "Dear Sir or Madam,<br>above mentioned shipment is confirmed by the cnee.<br>" &
                    "<br>Shipment ID.: " & ShipRow.Shipment_ID.ToString
            Body += "<br>PO No.: <i> " & txtPO & "</i>"
            If ShipRow.IsSTT_NoNull = False Then
                Body += "<br>STT No.: " & ShipRow.STT_No.ToString
                Subject += " // STT No.: " & ShipRow.STT_No.ToString
            End If
            If ShipRow.IsPOL_NoNull = False Then
                Body += "<br>POL No.: " & ShipRow.POL_No.ToString
                Subject += " // POL No.: " & ShipRow.POL_No.ToString
            End If
            If ShipRow.IsServiceNull = False Then Body += "<br>Service " & ShipRow.Service.ToString
            If ShipRow.IsPOLNull = False Then Body += "<br>POL " & ShipRow.POL.ToString
            If ShipRow.IsPODNull = False Then Body += "<br>POD " & ShipRow.POD.ToString
            If ShipRow.IsIncotermNull = False And ShipRow.IsIncoterm_LocNull = False Then Body += "<br>Incoterm: " & ShipRow.Incoterm.ToString & " - " & ShipRow.Incoterm_Loc.ToString
            If ShipRow.IsShipperNull = False Then
                Body += "<br>Shipper: <b>" & GetPartnerDetails(ShipRow.Shipper, "PartnerName") & "</b>"
                Subject += " // " & GetPartnerDetails(ShipRow.Shipper, "PartnerName")
            End If
            Subject += " // PO No.: " & txtPO
            Body += "<br><br>Please advise next available schedule or let us know if any additional Info is necessary"

            SendMailHTTP("Maximilian.Braun@dbschenker.com", Subject, Body, "", "", "", True)
        End If

            DsDemag_HUB.dsShipment_Order.DefaultView.RowFilter = String.Empty
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqeCheck(Convert.ToInt32(Shipment_IDTextBox.Text))
    End Sub

    Function GetMailContact(ByVal idPartner As Integer, ByVal Role As String) As String
        GetMailContact = ""
        DsDemag_HUB.dsContact.DefaultView.RowFilter = "Partner_ID = '" & idPartner & "'"
        For Each Contact As DataRowView In DsDemag_HUB.dsContact.DefaultView
            Dim rowContact As dsDemag_HUB.dsContactRow = DsDemag_HUB.dsContact.FindByContact_ID(Convert.ToInt32(Contact.Item("Contact_ID").ToString))
            DsDemag_HUB.dsRole.DefaultView.RowFilter = "Contact_ID = '" & rowContact.Contact_ID & "' AND ROLE ='" & Role & "'"
            If DsDemag_HUB.dsRole.DefaultView.Count <> 0 Then GetMailContact += rowContact.eMail & ";"
        Next
        Return GetMailContact
    End Function


    Private Sub PrincipalTextBox_Leave(ctlButton As Object, e As EventArgs) Handles PrincipalTextBox.Leave, ShipperTextBox.Leave, ConsigneeTextBox.Leave, CarrierTextBox.Leave, TerminalTextBox.Leave
        Dim rowActual As dsDemag_HUB.dsShipmentsRow = DsDemag_HUB.dsShipments.FindByShipment_ID(Convert.ToInt32(DirectCast(DsShipmentsBindingSource.Current, DataRowView).Item(0).ToString()))


        'Dim rowActual As dsDemag_HUB.dsShipmentsRow = DsDemag_HUB.dsShipments.FindByShipment_ID(Convert.ToInt32(Shipment_IDTextBox.Text))
        Dim sender As Control = CType(ctlButton, Control)

        If sender.Text = "" Then
            Select Case sender.Name
                Case "PrincipalTextBox"
                    rowActual.Principal = 4
                Case "ShipperTextBox"
                    rowActual.Shipper = 4
                Case "ConsigneeTextBox"
                    rowActual.Consignee = 4
                Case "CarrierTextBox"
                    rowActual.Carrier = 4
                Case "CarrierTextBox1"
                    rowActual.Carrier = 4
                Case "TerminalTextBox"
                    rowActual.Terminal = 4
            End Select

            If rowActual.IsIncotermNull Then Exit Sub
            Select Case rowActual.Incoterm
                Case "FOB"
                    If ConsigneeTextBox.Text = "" And PrincipalTextBox.Text <> "" Then ConsigneeTextBox.Text = PrincipalTextBox.Text
                    If PrincipalTextBox.Text = "" And ConsigneeTextBox.Text <> "" Then PrincipalTextBox.Text = ConsigneeTextBox.Text
                    'If rowActual.IsConsigneeNull And rowActual.IsPrincipalNull = False Then rowActual.Consignee = rowActual.Principal
                    'If rowActual.IsPrincipalNull And rowActual.IsConsigneeNull = False Then rowActual.Principal = rowActual.Consignee
                Case "EXW"
                    If ConsigneeTextBox.Text = "" And PrincipalTextBox.Text <> "" Then ConsigneeTextBox.Text = PrincipalTextBox.Text
                    If PrincipalTextBox.Text = "" And ConsigneeTextBox.Text <> "" Then PrincipalTextBox.Text = ConsigneeTextBox.Text
                    'If rowActual.IsConsigneeNull And rowActual.IsPrincipalNull = False Then rowActual.Consignee = rowActual.Principal
                    'If rowActual.IsPrincipalNull And rowActual.IsConsigneeNull = False Then rowActual.Principal = rowActual.Consignee
                Case "CFR"
                    If ShipperTextBox.Text = "" And PrincipalTextBox.Text <> "" Then ShipperTextBox.Text = PrincipalTextBox.Text
                    If PrincipalTextBox.Text = "" And ShipperTextBox.Text <> "" Then PrincipalTextBox.Text = ShipperTextBox.Text
                    'If rowActual.IsConsigneeNull And rowActual.IsShipperNull = False Then rowActual.Consignee = rowActual.Shipper
                    'If rowActual.IsShipperNull And rowActual.IsConsigneeNull = False Then rowActual.Shipper = rowActual.Consignee
            End Select

        End If

    End Sub



    Private Sub SQECheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SQECheckBox.CheckedChanged
        If SQECheckBox.Checked = True Then
            SQECheckBox.ForeColor = Color.DarkSeaGreen
            btnSchedule.Enabled = True
            btnSQE.Enabled = False
        Else
            SQECheckBox.ForeColor = Color.Firebrick
            btnSchedule.Enabled = False
            btnSQE.Enabled = True
        End If
    End Sub

    Private Sub tabBooking_Enter(sender As Object, e As EventArgs) Handles tabBooking.Enter
        If SQECheckBox.Checked = True Then
            SQECheckBox.ForeColor = Color.DarkSeaGreen
            btnSchedule.Enabled = True
            btnSQE.Enabled = False
        Else
            SQECheckBox.ForeColor = Color.Firebrick
            btnSchedule.Enabled = False
            btnSQE.Enabled = True
        End If
    End Sub


    Private Sub cpyICM_Click(sender As Object, e As EventArgs) Handles cpyICM.Click
        Dim strClipboard As String = ""
        For Each Row As DataGridViewRow In DsShipment_SODataGridView.Rows
            strClipboard += Row.Cells(0).Value.ToString & ";"
        Next
        My.Computer.Clipboard.SetText(strClipboard)
        If strClipboard.Length > 100 Then MsgBox("Warning: ICM will not handle all...")
    End Sub


    Private Sub Incoterm_LocTextBox_Leave(ctlButton As Object, e As EventArgs) Handles Incoterm_LocTextBox.Leave, POLTextBox.Leave, PODTextBox.Leave
        Dim rowActual As dsDemag_HUB.dsShipmentsRow = DsDemag_HUB.dsShipments.FindByShipment_ID(Convert.ToInt32(Shipment_IDTextBox.Text))
        Dim sender As Control = CType(ctlButton, Control)

        If sender.Text = "" Then
            Select Case sender.Name
                Case "Incoterm_LocTextBox"
                    rowActual.Incoterm_Loc = "ZZZZZ"
                Case "POLTextBox"
                    rowActual.POL = "ZZZZZ"
                Case "PODTextBox"
                    rowActual.POD = "ZZZZZ"

            End Select

        End If





    End Sub

    Private Sub chkSurrenderedShipping_CheckedChanged(sender As Object, e As EventArgs) Handles chkSurrenderedShipping.Click

        Dim rowActual As dsDemag_HUB.dsShipmentsRow = DsDemag_HUB.dsShipments.FindByShipment_ID(Convert.ToInt32(Shipment_IDTextBox.Text))

        If chkSurrenderedShipping.Checked = True And rowActual.IsdtnSurenderedNull Then
            rowActual.dtnSurendered = Date.Now
        End If

        If chkSurrenderedShipping.Checked = False And rowActual.IsdtnSurenderedNull = False Then
            'rowActual.dtnSurendered = Date.
            DsDemag_HUB.dsShipments.Rows.Find(Shipment_IDTextBox.Text).Item("dtnSurendered") = System.DBNull.Value
        End If

    End Sub

    Private Sub grpBL(sender As Object, e As EventArgs) Handles STT_NoTextBox1.TextChanged, HBL_NoTextBox.TextChanged, MBL_NoTextBox.TextChanged
        If STT_NoTextBox1.Text <> "" And HBL_NoTextBox.Text <> "" And MBL_NoTextBox.Text <> "" Then
            grpTrack.Enabled = True
        Else
            grpTrack.Enabled = False
        End If

    End Sub

    Private Sub CarrierTextBox1_TextChanged(sender As Object, e As EventArgs)
        If CarrierTextBox1.Text = "" Then
            btnTrackShipping.Enabled = False
        Else
            btnTrackShipping.Enabled = True
        End If
    End Sub

    Private Sub btnTrackShipping_Click(sender As Object, e As EventArgs) Handles btnTrackShipping.Click
        Dim curRow As dsDemag_HUB.dsShipmentsRow = DsDemag_HUB.dsShipments.FindByShipment_ID(Convert.ToInt32(Shipment_IDTextBox.Text))
        Process.Start(GetPartnerDetails(curRow.Carrier, "TrackingLink").Replace("%BLNO%", curRow.MBL_No))
    End Sub

    Private Sub grpTrack_TextChanged(sender As Object, e As EventArgs) Handles CarrierTextBox1.TextChanged, Contract_NoTextBox1.TextChanged, TerminalTextBox.TextChanged, VesselTextBox1.TextChanged, dtnATD.TextChanged, dtnETAShipping.TextChanged
        If CarrierTextBox1.Text <> "" And Contract_NoTextBox1.Text <> "" And TerminalTextBox.Text <> "" And VesselTextBox1.Text <> "" And dtnATD.Text <> "" And dtnETAShipping.Text <> "" Then
            grpContainer.Enabled = True
        Else
            grpContainer.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAddContainer.Click
        DsContainerBindingSource.AddNew()
        If ServiceTextBox.Text = "LCL" Then Container_SizeTextBox.Text = "LCL"
        Container_NoTextBox.Focus()
        'Protokoll anlegen
        'Dim newPtRow As dsDemag_HUB.dsContainerRow
        'newPtRow = DsDemag_HUB.dsContainer.NewdsContainerRow
        'newPtRow.Shipment_ID = 10 'Convert.ToInt32(Shipment_IDTextBox.Text)
        'newPtRow.Container_No = "addTest"
        'newPtRow.Created = Date.Now
        'newPtRow.Container_Size = "LCL"
        'DsDemag_HUB.dsContainer.Rows.Add(newPtRow)



    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnAddRate.Click
        RtShipments_ChargesBindingSource.AddNew()
        cmbChargeCode.Focus()
    End Sub

    Private Sub MultiplierTextBox_SelectedIndexChanged(sender As Object, e As EventArgs)





    End Sub


    Private Sub MultiplierTextBox_TextChanged(sender As Object, e As EventArgs) Handles MultiplierTextBox.Leave
        Select Case MultiplierTextBox.Text
            Case "CONT"
                _20DCTextBox.Enabled = True
                _40DCTextBox.Enabled = True
                _40HQTextBox.Enabled = True
                MinimumTextBox.Enabled = False
                ChargesTextBox.Enabled = False
            Case "TEU"
                _20DCTextBox.Enabled = True
                _40DCTextBox.Enabled = True
                _40HQTextBox.Enabled = True
                MinimumTextBox.Enabled = False
                ChargesTextBox.Enabled = False
            Case "WM"
                _20DCTextBox.Enabled = False
                _40DCTextBox.Enabled = False
                _40HQTextBox.Enabled = False
                MinimumTextBox.Enabled = True
                ChargesTextBox.Enabled = True
            Case "KG"
                _20DCTextBox.Enabled = False
                _40DCTextBox.Enabled = False
                _40HQTextBox.Enabled = False
                MinimumTextBox.Enabled = True
                ChargesTextBox.Enabled = True
            Case "CBM"
                _20DCTextBox.Enabled = False
                _40DCTextBox.Enabled = False
                _40HQTextBox.Enabled = False
                MinimumTextBox.Enabled = True
                ChargesTextBox.Enabled = True
            Case "BL"
                _20DCTextBox.Enabled = False
                _40DCTextBox.Enabled = False
                _40HQTextBox.Enabled = False
                MinimumTextBox.Enabled = False
                ChargesTextBox.Enabled = True
            Case Else
                _20DCTextBox.Enabled = True
                _40DCTextBox.Enabled = True
                _40HQTextBox.Enabled = True
                MinimumTextBox.Enabled = True
                ChargesTextBox.Enabled = True
                MsgBox("Multiplier unknow")
        End Select

    End Sub



    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click

        'MsgBox(getIncome(10, "EUR"))
        getRates(10)

    End Sub

    Function getIncome(ByVal ShipmentID As Integer, ByVal Currency As String) As Double
        getIncome = 0
        Dim Weight As Double = 0
        Dim CBM As Double = 0
        Dim c20DC As Double = 0
        Dim c20DCHeavy As Double = 0
        Dim c40DC As Double = 0
        Dim c40HQ As Double = 0
        Dim TEU As Double = 0

        'Heavy weight

        DsDemag_HUB.dsContainer.DefaultView.RowFilter = "Shipment_ID = '" & ShipmentID & "'"
        For Each Row As DataRowView In DsDemag_HUB.dsContainer.DefaultView
            Select Case Row.Item("Container_Size").ToString
                Case "20DC"
                    c20DC += 1
                    TEU += 1
                Case "40DC"
                    c40DC += 1
                    TEU += 2
                Case "40HQ"
                    c40HQ += 1
                    TEU += 2
            End Select
            If Row.Item("Weight").ToString <> "" Then Weight += Convert.ToDouble(Row.Item("Weight").ToString)
            If Row.Item("Volume").ToString <> "" Then CBM += Convert.ToDouble(Row.Item("Volume").ToString)
        Next
        DsDemag_HUB.dsContainer.DefaultView.RowFilter = String.Empty



        For Each Row As DataGridViewRow In RtShipments_ChargesDataGridView.Rows
            Dim exCurrency As Double = 1
            Dim rowCurrency As String = Row.Cells(7).Value.ToString
            Dim row20DC As Double = 0
            Dim row40DC As Double = 0
            Dim row40HQ As Double = 0
            Dim rowMin As Double = 0
            Dim rowCharges As Double = 0


            If Row.Cells(1).Value.ToString <> "" Then row20DC = Convert.ToDouble(Row.Cells(1).Value.ToString)
            If Row.Cells(2).Value.ToString <> "" Then row40DC = Convert.ToDouble(Row.Cells(2).Value.ToString)
            If Row.Cells(3).Value.ToString <> "" Then row40HQ = Convert.ToDouble(Row.Cells(3).Value.ToString)

            If Row.Cells(4).Value.ToString <> "" Then rowMin = Convert.ToDouble(Row.Cells(4).Value.ToString)
            If Row.Cells(5).Value.ToString <> "" Then rowCharges = Convert.ToDouble(Row.Cells(5).Value.ToString)

            'Fals die Währung nicht der Anforderung entsprichen abrufen. Sonst gilt standard als 1
            If Row.Cells(7).Value.ToString <> Currency Then getCurrency(1, Row.Cells(7).Value.ToString, Currency)

            Select Case Row.Cells(6).Value.ToString
                Case "CONT"
                    getIncome += row20DC * c20DC * exCurrency
                    getIncome += row40DC * c40DC * exCurrency
                    getIncome += row40HQ * c40HQ * exCurrency
                Case "TEU"
                    getIncome += rowCharges * TEU * exCurrency
                Case "WM"
                    Dim calcWM As Double = 0
                    If calcWM < rowCharges * Weight Then calcWM = rowCharges * Weight
                    If calcWM < rowCharges * CBM Then calcWM = rowCharges * CBM
                    If calcWM < rowMin Then calcWM = rowMin
                    getIncome += calcWM * exCurrency
                Case "KG"
                    Dim calcWeight As Double = 0
                    calcWeight = rowCharges * Weight
                    If calcWeight < rowMin Then calcWeight = rowMin
                    getIncome += calcWeight * exCurrency
                Case "CBM"
                    Dim calcCBM As Double = 0
                    calcCBM = rowCharges * CBM
                    If calcCBM < rowMin Then calcCBM = rowMin
                    getIncome += calcCBM * exCurrency
                Case "BL"
                    getIncome += rowCharges * exCurrency
                Case Else
                    getIncome += 0
            End Select


        Next





    End Function


    Public Function getCurrency(ByVal amount As Decimal, ByVal fromCurrency As String, ByVal toCurrency As String) As Decimal
        'https://stackoverflow.com/questions/3139879/how-do-i-get-currency-exchange-rates-via-an-api-such-as-google-finance
        'European Central Bank Feed

        getCurrency = 1


    End Function


    Sub getRates(ByVal ShipmentID As Integer)
        Dim curRow As dsDemag_HUB.dsShipmentsRow = DsDemag_HUB.dsShipments.FindByShipment_ID(ShipmentID)
        Dim stdFilter As String = "Size = '"
        Dim dtlFilter As String = ""
        Dim dtnValid As Date

        If curRow.IsServiceNull = False Then
            Select Case curRow.Service
                Case "LCL"
                    stdFilter += "LCL'"
                Case "FCL"
                    stdFilter += "FCL'"
            End Select
        End If

        If curRow.IsdtnATDNull Then
            dtnValid = Today
        Else
            dtnValid = curRow.dtnATD
        End If

        stdFilter += " AND Valid_From <= #" & dtnValid.ToString("yyyy/MM/dd").Replace(".", "/") & "# AND  Valid_Till >=#" & dtnValid.ToString("yyyy/MM/dd").Replace(".", "/") & "#"

        Select Case curRow.Incoterm
            Case "EXW"
                'Generelle Kosten
                dtlFilter += " AND From = ''"
                dtlFilter += " AND To = ''"
                DsDemag_HUB.rtRates.DefaultView.RowFilter = stdFilter & dtlFilter
                For Each Row As DataRowView In DsDemag_HUB.rtRates.DefaultView
                    addShipmenCharge(Convert.ToInt32(Row.Item("ID").ToString), ShipmentID) 'Kosten hinterlegen
                Next

                'Vorlauf
                dtlFilter += " AND From = '" & curRow.Incoterm_Loc & "'"
                dtlFilter += " AND To = '" & curRow.POL & "'"
                DsDemag_HUB.rtRates.DefaultView.RowFilter = stdFilter & dtlFilter
                For Each Row As DataRowView In DsDemag_HUB.rtRates.DefaultView
                    addShipmenCharge(Convert.ToInt32(Row.Item("ID").ToString), ShipmentID) 'Kosten hinterlegen
                Next

                'POL Kosten
                dtlFilter += " AND From = '" & curRow.POL & "'"
                DsDemag_HUB.rtRates.DefaultView.RowFilter = stdFilter & dtlFilter
                For Each Row As DataRowView In DsDemag_HUB.rtRates.DefaultView
                    addShipmenCharge(Convert.ToInt32(Row.Item("ID").ToString), ShipmentID) 'Kosten hinterlegen
                Next
                'Seefracht
                dtlFilter += " AND From = '" & curRow.POL & "'"
                dtlFilter += " AND To = '" & curRow.POD & "'"
                dtlFilter += " AND Charge_Code = 'OFRT'"
                DsDemag_HUB.rtRates.DefaultView.RowFilter = stdFilter & dtlFilter
                For Each Row As DataRowView In DsDemag_HUB.rtRates.DefaultView
                    addShipmenCharge(Convert.ToInt32(Row.Item("ID").ToString), ShipmentID) 'Kosten hinterlegen
                Next
                'POD Kosten
                dtlFilter += " AND From = '" & curRow.POL & "'"
                dtlFilter += " AND To = ''"
                DsDemag_HUB.rtRates.DefaultView.RowFilter = stdFilter & dtlFilter
                For Each Row As DataRowView In DsDemag_HUB.rtRates.DefaultView
                    addShipmenCharge(Convert.ToInt32(Row.Item("ID").ToString), ShipmentID) 'Kosten hinterlegen
                Next

                'Nachlauf
                dtlFilter += " AND From = '" & curRow.POD & "'"
                dtlFilter += " AND To = 'DEHAG'"
                dtlFilter += " AND Charge_Code = 'ODLV'"
                DsDemag_HUB.rtRates.DefaultView.RowFilter = stdFilter & dtlFilter
                For Each Row As DataRowView In DsDemag_HUB.rtRates.DefaultView
                    addShipmenCharge(Convert.ToInt32(Row.Item("ID").ToString), ShipmentID) 'Kosten hinterlegen
                Next


            Case "FOB"
                'Generelle Kosten
                dtlFilter += " AND From = ''"
                dtlFilter += " AND To = ''"
                DsDemag_HUB.rtRates.DefaultView.RowFilter = stdFilter & dtlFilter
                For Each Row As DataRowView In DsDemag_HUB.rtRates.DefaultView
                    addShipmenCharge(Convert.ToInt32(Row.Item("ID").ToString), ShipmentID) 'Kosten hinterlegen
                Next

                'POL Kosten
                dtlFilter += " AND From = '" & curRow.POL & "'"
                DsDemag_HUB.rtRates.DefaultView.RowFilter = stdFilter & dtlFilter
                For Each Row As DataRowView In DsDemag_HUB.rtRates.DefaultView
                    addShipmenCharge(Convert.ToInt32(Row.Item("ID").ToString), ShipmentID) 'Kosten hinterlegen
                Next
                'Seefracht
                dtlFilter += " AND From = '" & curRow.POL & "'"
                dtlFilter += " AND To = '" & curRow.POD & "'"
                dtlFilter += " AND Charge_Code = 'OFRT'"
                DsDemag_HUB.rtRates.DefaultView.RowFilter = stdFilter & dtlFilter
                For Each Row As DataRowView In DsDemag_HUB.rtRates.DefaultView
                    addShipmenCharge(Convert.ToInt32(Row.Item("ID").ToString), ShipmentID) 'Kosten hinterlegen
                Next
                'POD Kosten
                dtlFilter += " AND From = '" & curRow.POL & "'"
                dtlFilter += " AND To = ''"
                DsDemag_HUB.rtRates.DefaultView.RowFilter = stdFilter & dtlFilter
                For Each Row As DataRowView In DsDemag_HUB.rtRates.DefaultView
                    addShipmenCharge(Convert.ToInt32(Row.Item("ID").ToString), ShipmentID) 'Kosten hinterlegen
                Next
                'Nachlauf
                dtlFilter += " AND From = '" & curRow.POD & "'"
                dtlFilter += " AND To = 'DEHAG'"
                dtlFilter += " AND Charge_Code = 'ODLV'"
                DsDemag_HUB.rtRates.DefaultView.RowFilter = stdFilter & dtlFilter
                For Each Row As DataRowView In DsDemag_HUB.rtRates.DefaultView
                    addShipmenCharge(Convert.ToInt32(Row.Item("ID").ToString), ShipmentID) 'Kosten hinterlegen
                Next
            Case "CFR"
                'Generelle Kosten
                dtlFilter += " AND From = ''"
                dtlFilter += " AND To = ''"
                DsDemag_HUB.rtRates.DefaultView.RowFilter = stdFilter & dtlFilter
                For Each Row As DataRowView In DsDemag_HUB.rtRates.DefaultView
                    addShipmenCharge(Convert.ToInt32(Row.Item("ID").ToString), ShipmentID) 'Kosten hinterlegen
                Next
                'POD Kosten
                dtlFilter += " AND From = '" & curRow.POL & "'"
                dtlFilter += " AND To = ''"
                DsDemag_HUB.rtRates.DefaultView.RowFilter = stdFilter & dtlFilter
                For Each Row As DataRowView In DsDemag_HUB.rtRates.DefaultView
                    addShipmenCharge(Convert.ToInt32(Row.Item("ID").ToString), ShipmentID) 'Kosten hinterlegen
                Next
                'Nachlauf
                dtlFilter += " AND From = '" & curRow.POD & "'"
                dtlFilter += " AND To = 'DEHAG'"
                dtlFilter += " AND Charge_Code = 'ODLV'"
                DsDemag_HUB.rtRates.DefaultView.RowFilter = stdFilter & dtlFilter
                For Each Row As DataRowView In DsDemag_HUB.rtRates.DefaultView
                    addShipmenCharge(Convert.ToInt32(Row.Item("ID").ToString), ShipmentID) 'Kosten hinterlegen
                Next
            Case Else
                MsgBox("Incoterm ist noch nicht hinterlegt.")
        End Select








        DsDemag_HUB.rtRates.DefaultView.RowFilter = String.Empty
    End Sub


    Sub addShipmenCharge(ByVal idRates As Integer, ByVal ShipmentID As Integer)
        Dim curRow As dsDemag_HUB.rtRatesRow = DsDemag_HUB.rtRates.FindByID(idRates)


        Dim newRtRow As dsDemag_HUB.rtShipments_ChargesRow
        newRtRow = DsDemag_HUB.rtShipments_Charges.NewrtShipments_ChargesRow
        newRtRow.ShipmentID = ShipmentID
        newRtRow.Created = Date.Now
        If curRow.IsCharge_CodeNull = False Then newRtRow.Charge_Code = curRow.Charge_Code
        If curRow.Is_20DCNull = False Then newRtRow._20DC = curRow._20DC
        If curRow.Is_40DCNull = False Then newRtRow._40DC = curRow._40DC
        If curRow.Is_40HQNull = False Then newRtRow._40HQ = curRow._40HQ
        If curRow.IsMinimumNull = False Then newRtRow.Minimum = curRow.Minimum
        If curRow.IsChargesNull = False Then newRtRow.Charges = curRow.Charges
        If curRow.IsMultiplierNull = False Then newRtRow.Multiplier = curRow.Multiplier
        If curRow.IsCurrencyNull = False Then newRtRow.Currency = curRow.Currency
        If curRow.IsCommentNull = False Then newRtRow.Comment = curRow.Comment


        DsDemag_HUB.rtShipments_Charges.Rows.Add(newRtRow)


    End Sub


    'Private Sub BindingSource_BindingComplete(sender As Object, e As BindingCompleteEventArgs) Handles DsShipmentsBindingSource.BindingComplete
    '    If e.Binding.Control.Name = "IncotermTextBox" Then
    '        If Shipment_IDTextBox.Text = "" Then Exit Sub
    '        Dim rowActual As dsDemag_HUB.dsShipmentsRow = DsDemag_HUB.dsShipments.FindByShipment_ID(Convert.ToInt32(Shipment_IDTextBox.Text))
    '        If rowActual.IsIncotermNull Then Exit Sub
    '        Select Case rowActual.Incoterm
    '            Case "FOB"
    '                If rowActual.IsConsigneeNull And rowActual.IsPrincipalNull = False Then rowActual.Consignee = rowActual.Principal
    '                If rowActual.IsPrincipalNull And rowActual.IsConsigneeNull = False Then rowActual.Principal = rowActual.Consignee
    '            Case "EXW"
    '                If rowActual.IsConsigneeNull And rowActual.IsPrincipalNull = False Then rowActual.Consignee = rowActual.Principal
    '                If rowActual.IsPrincipalNull And rowActual.IsConsigneeNull = False Then rowActual.Principal = rowActual.Consignee
    '            Case "CFR"
    '                If rowActual.IsConsigneeNull And rowActual.IsShipperNull = False Then rowActual.Consignee = rowActual.Shipper
    '                If rowActual.IsShipperNull And rowActual.IsConsigneeNull = False Then rowActual.Shipper = rowActual.Consignee
    '        End Select
    '    End If

    'End Sub



End Class
