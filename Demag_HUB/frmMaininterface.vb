Option Strict On

Imports System.Text
Imports System.IO
Public Class frmMaininterface
    Dim dtnEmpty As String = "01.01.0001 00:00:00"
    Dim CON As New OleDb.OleDbConnection
    Dim MyConnection As System.Data.OleDb.OleDbConnection
    Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
    Dim ImportDS As System.Data.DataSet


    Private Sub DsShipmentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DsShipmentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsDemag_HUB)

    End Sub

    Private Sub frmMaininterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.poOrder". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.PoOrderTableAdapter.Fill(Me.DsDemag_HUB.poOrder)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsShipment_Order". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsShipment_OrderTableAdapter.Fill(Me.DsDemag_HUB.dsShipment_Order)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsInvoice". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsInvoiceTableAdapter.Fill(Me.DsDemag_HUB.dsInvoice)

        If My.Settings.sttDBPath = "" Then
            dlgFileDialog.Title = "Bitte Datenbank auswählen"
            dlgFileDialog.ShowDialog() 'Fileauswählen
            My.Settings.sttDBPath = dlgFileDialog.FileName
        End If


        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsInvoice". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsInvoiceTableAdapter.Fill(Me.DsDemag_HUB.dsInvoice)
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
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsShipments". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsShipmentsTableAdapter.Fill(Me.DsDemag_HUB.dsShipments)

    End Sub




    Private Sub btnNewPartner_Click(sender As Object, e As EventArgs) Handles btnNewPartner.Click
        DsPartnerBindingSource.AddNew()
        PartnerNameTextBox.Focus()
    End Sub

    Private Sub OnlyNumeric(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VolumeTextBox.KeyPress, WeightTextBox.KeyPress, Cont20DCTextBox.KeyPress, Cont40DCTextBox.KeyPress, Cont40HQTextBox.KeyPress, STT_NoTextBox.KeyPress
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



    Private Sub dtnConvert(ctlButton As Object, e As EventArgs) Handles dtnCRD.Leave, dtnETD.Leave, dtnETA.Leave
        Dim sender As Control = CType(ctlButton, Control)
        If sender.Text = "" Then
            DsDemag_HUB.dsShipments.Rows.Find(Shipment_IDTextBox.Text).Item(sender.Name) = System.DBNull.Value
        Else
            sender.Text = getDate(sender.Text).ToString
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        MsgBox("Starte")

        Me.Validate()
        Me.DsShipmentsBindingSource.EndEdit()
        Me.DsCommentBindingSource.EndEdit()
        Me.DsPartnerBindingSource.EndEdit()
        Me.DsContactBindingSource.EndEdit()
        Me.DsAddressBindingSource.EndEdit()
        Me.DsShipment_OrderBindingSource.EndEdit()
        MsgBox("Arbeite")

        Me.DsShipmentsTableAdapter.Update(Me.DsDemag_HUB.dsShipments)
        Me.DsCommentTableAdapter.Update(Me.DsDemag_HUB.dsComment)
        Me.DsPartnerTableAdapter.Update(Me.DsDemag_HUB.dsPartner)
        Me.DsContactTableAdapter.Update(Me.DsDemag_HUB.dsContact)
        Me.DsAddressTableAdapter.Update(Me.DsDemag_HUB.dsAddress)
        Me.DsShipment_OrderTableAdapter.Update(Me.DsDemag_HUB.dsShipment_Order)
        MsgBox("Fertig")

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        DsShipmentsBindingSource.AddNew()
        Me.subTabShipments.SelectedTab = tabBooking
    End Sub
    'Drag & Dropp https://www.codeproject.com/Articles/7140/Drag-and-Drop-Attached-File-From-Outlook-and-ab
    Private Sub frmMaininterface_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles btnaddDocument.DragDrop
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

    Private Sub btnImport_DragEnter(sender As Object, e As DragEventArgs) Handles btnaddDocument.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Or e.Data.GetDataPresent("FileGroupDescriptor") Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Sub docHandle(ByVal File As String)
        frmDocument.dirFile = File
        frmDocument.ShowDialog()

        'Datenbank ergänzen
        Dim newDocRow As dsDemag_HUB.dsInvoiceRow
        newDocRow = DsDemag_HUB.dsInvoice.NewdsInvoiceRow
        newDocRow.Shipment_ID = Convert.ToInt32(Shipment_IDTextBox.Text)
        newDocRow.Created = Date.Now
        newDocRow.Invoice_No = frmDocument.docNo
        newDocRow.Link = frmDocument.docDirectory
        DsDemag_HUB.dsInvoice.Rows.Add(newDocRow)

        Me.dsInvoiceBindingSource.EndEdit()
        Me.DsInvoiceTableAdapter.Update(Me.DsDemag_HUB.dsInvoice)


    End Sub

    Private Sub Shipment_IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles Shipment_IDTextBox.TextChanged
        If Convert.ToDouble(Shipment_IDTextBox.Text) > 0 Then
            btnaddDocument.Enabled = True
        Else
            btnaddDocument.Enabled = False
        End If
    End Sub


    Private Sub btnAddPO_Click(sender As Object, e As EventArgs) Handles btnAddPO.Click
        'Prüfen ob PO bereits in der Sendung ist
        'For Each row As DataGridViewRow In Me.dvPoNo.Rows
        '    If txtPoNo.Text = row.Cells(1).Value.ToString Then
        '        txtPoNo.BackColor = Color.LightGoldenrodYellow
        '        Exit Sub
        '    End If
        'Next

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
            Me.PoOrderBindingSource.EndEdit()
            Me.PoOrderTableAdapter.Update(Me.DsDemag_HUB.poOrder)
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


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Select Case cmbField.Text
            Case Is = "ShipmentID"
                DsShipmentsBindingSource.Filter = "Shipment_ID = '" & txtSearch.Text & "'"
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
                HaesslichesEntlein(txtSearch.Text)
            Case Else
                MsgBox("Filter unbekannt:" & cmbField.Text)
        End Select
    End Sub

    Sub HaesslichesEntlein(ByVal PoNo As String)
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
        DsShipmentsBindingSource.Filter = strFilter
    End Sub

    Private Sub DsShipmentsDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DsShipmentsDataGridView.CellDoubleClick
        Me.subTabShipments.SelectedTab = tabBooking
    End Sub

    Private Sub txtPoNo_Enter(sender As Object, e As EventArgs) Handles txtPoNo.Enter
        Me.AcceptButton = btnAddPO
    End Sub

    Private Sub txtPoNo_Leave(sender As Object, e As EventArgs) Handles txtPoNo.Leave
        Me.AcceptButton = btnSave
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        Me.AcceptButton = btnSearch
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        Me.AcceptButton = btnSave
    End Sub
























    Dim WithEvents bgwImportICM As New System.ComponentModel.BackgroundWorker With {.WorkerReportsProgress = True, .WorkerSupportsCancellation = True}

    'C:\Users\HolyAbsolut\Desktop\view_orders.xlsx

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'searchPartner("DEHAGDPIMSw001", "Tango_ID", "Tester")

        ImportICM("C:\Users\HolyAbsolut\Desktop\view_orders.xlsx", "BM_New_PO")


        'If Not bgwImportICM.IsBusy Then
        '    Button1.Enabled = False
        '    Label_Result.Text = "Bitte warten..."
        '    ProgressBar.Maximum = 50
        '    ProgressBar.Value = 0
        '    bgwImportICM.RunWorkerAsync(50)


        'End If

    End Sub

    'Backgroundworker
    'https://www.vb-paradise.de/index.php/Thread/61500-Multithreading-mit-BackgroundWorker/#codeLine_4_82b19c

    Function searchPartner(ByVal searchString As String, ByVal searchColum As String, Optional ByVal PartnerName As String = "NewPartner") As Integer
        DsPartnerBindingSource.Filter = searchColum & " = '" & searchString & "'"
        Select Case DsPartnerBindingSource.Count
            Case = 1
                Dim ptRow As DataRow = DsDemag_HUB.dsPartner.Rows(DsDemag_HUB.dsPartner.Rows.IndexOf(DirectCast(DsPartnerBindingSource.Current, DataRowView).Row))
                Return Convert.ToInt32(ptRow.Item("Partner_ID"))
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




    Sub ImportICM(ByVal xlsFile As String, ByVal xlsTable As String)
        'Prüfen ob Datei vorhanden
        If My.Computer.FileSystem.FileExists(xlsFile) = False Then
            MsgBox("Keine Datei gefungen")
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
        ProgressBar.Maximum = ImportDS.Tables("ICMImport").Rows.Count
        ProgressBar.Value = countRecord


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
            If PoOrderBindingSource.Count = 0 Then
                Dim newPO As dsDemag_HUB.poOrderRow
                newPO = DsDemag_HUB.poOrder.NewpoOrderRow
                newPO.Purchase_Order = PO
                newPO.Alias_Purchase_Order = Row("Purchase Order").ToString()
                newPO.Created = Date.Now
                newPO.Supplier = searchPartner(Row("Supplier Code").ToString(), "ICM_ID", Row("Supplier").ToString())
                If Row("Planned Mode").ToString() = "Ocean" Then newPO.Service = "SEA"
                If Row("Planned Mode").ToString() = "Air" Then newPO.Service = "AIR"
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
                If Row("Acceptance Status").ToString() = "Order Accepted" Then newPO.Acceptance_Status = True
                If Row("SQE Check Approval").ToString() <> "" Then newPO.SQE_Check = Convert.ToDateTime(Row("SQE Check Approval").ToString())
                newPO.Division = Row("Division").ToString()
                newPO.Buyer_Mail = Row("Buyer E-Mail Address").ToString()
                DsDemag_HUB.poOrder.Rows.Add(newPO)

            Else
                'Update Funktion

            End If
            countRecord += 1
            ProgressBar.Value = countRecord








        Next

        Me.DsPartnerBindingSource.EndEdit()
        Me.DsPartnerTableAdapter.Update(Me.DsDemag_HUB.dsPartner)
        Me.Validate()
        Me.PoOrderBindingSource.EndEdit()
        Me.PoOrderTableAdapter.Update(Me.DsDemag_HUB.poOrder)
        MsgBox("Update successful")

    End Sub




    'Hier die Arbeit eingeben
    Private Sub BGW_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwImportICM.DoWork
        'Prüfen ob Datei vorhanden











        For i As Integer = 0 To CInt(e.Argument) - 1
            System.Threading.Thread.Sleep(10)
            bgwImportICM.ReportProgress(i)
        Next
    End Sub

    Private Sub BGW_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwImportICM.ProgressChanged
        ProgressBar.Value = e.ProgressPercentage + 1
    End Sub

    Private Sub BGW_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwImportICM.RunWorkerCompleted
        Label_Result.Text = "Vorgang abgeschlossen"
        Button1.Enabled = True
    End Sub





End Class
