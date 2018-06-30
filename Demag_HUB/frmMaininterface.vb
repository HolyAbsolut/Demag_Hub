Option Strict On

Imports System.Text
Imports System.IO
Imports System.ComponentModel

Public Class frmMaininterface
    Dim dtnEmpty As String = "01.01.0001 00:00:00"
    Dim CON As New OleDb.OleDbConnection
    Dim MyConnection As System.Data.OleDb.OleDbConnection
    Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
    Dim ImportDS As System.Data.DataSet


    'Private Sub DsShipmentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.DsShipmentsBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DsDemag_HUB)

    'End Sub
    Private Sub frmMaininterface_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.sttDBPath = txtDB.Text
        Save()
        'custom.Default.Save()

        'MyBase.OnFormClosing(e)
    End Sub


    Private Sub frmMaininterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDB.Text = My.Settings.sttDBPath
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
        DsInvoiceTableAdapter.Connection = CON
        DsInvoiceTableAdapter.Connection = CON
        DsCommentTableAdapter.Connection = CON
        UNLOCTableAdapter.Connection = CON
        DsAddressTableAdapter.Connection = CON
        DsContactTableAdapter.Connection = CON
        DsPartnerTableAdapter.Connection = CON
        IncotermTableAdapter.Connection = CON
        DsShipmentsTableAdapter.Connection = CON
        PtShipmentsTableAdapter.Connection = CON



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
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsInvoice". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsInvoiceTableAdapter.Fill(Me.DsDemag_HUB.dsInvoice)
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
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.ptShipments". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.PtShipmentsTableAdapter.Fill(Me.DsDemag_HUB.ptShipments)


        'MsgBox(DsShipmentsTableAdapter.Connection.ConnectionString.ToString)
    End Sub


    Private Sub btnNewPartner_Click(sender As Object, e As EventArgs) Handles btnNewPartner.Click
        DsPartnerBindingSource.AddNew()
        PartnerNameTextBox.Focus()
    End Sub

    Private Sub OnlyNumeric(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VolumeTextBox.KeyPress, WeightTextBox.KeyPress, Cont20DCTextBox.KeyPress, Cont40DCTextBox.KeyPress, Cont40HQTextBox.KeyPress, STT_NoTextBox.KeyPress, txtSoNo.KeyPress
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








        'MsgBox("Fertig")
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
            btnAddPO.Enabled = True
            txtPoNo.Enabled = True
            DsCommentDataGridView.Enabled = True
        Else
            btnaddDocument.Enabled = False
            btnAddPO.Enabled = False
            txtPoNo.Enabled = False
            DsCommentDataGridView.Enabled = False
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
                searchPO(txtSearch.Text)
            Case Is = "SO No.:"
                searchSO(txtSearch.Text)
            Case Is = "Inv No.:"
                searchINV(txtSearch.Text)
            Case Else
                MsgBox("Filter unbekannt:" & cmbField.Text)
        End Select
    End Sub

    Sub searchPO(ByVal PoNo As String)
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

    Sub searchSO(ByVal SoNo As String)
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
        DsShipmentsBindingSource.Filter = strFilter
    End Sub

    Sub searchINV(ByVal INVNo As String)
        Dim strFilter As String = ""
        DsDemag_HUB.dsInvoice.DefaultView.RowFilter = "Invoice_No = '" & INVNo & "'"
        For Each Row As DataRowView In DsDemag_HUB.dsInvoice.DefaultView
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
                        newPO.Buyer_Mail = Row("Buyer E-Mail Address").ToString()
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
                            editPO.Buyer_Mail = Row("Buyer E-Mail Address").ToString()
                        Else
                            If editPO.Buyer_Mail <> Row("Buyer E-Mail Address").ToString() Then editPO.Buyer_Mail = Row("Buyer E-Mail Address").ToString()
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

    End Sub

    Private Sub BGW_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwImportICM.ProgressChanged
        ProgressBar.Value = e.ProgressPercentage
    End Sub

    Private Sub BGW_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwImportICM.RunWorkerCompleted
        Label_Result.Text = "Update successful"
    End Sub

    Private Sub btnAddSO_Click(sender As Object, e As EventArgs) Handles btnAddSO.Click
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
                If DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).IsSQE_CheckNull Then
                Else
                    'MsgBox(DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(2).Value.ToString).SQE_Check)
                    row.Cells(1).Value = DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).Incoterm
                    row.Cells(2).Value = DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).Incoterm_Location
                    row.Cells(3).Value = DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).SQE_Check
                    row.Cells(4).Value = DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).Latest_Arrival
                    row.Cells(5).Value = DsDemag_HUB.poOrder.FindByPurchase_Order(row.Cells(0).Value.ToString).Buyer_Mail.ToString


                End If

                'row.Cells(3).Value = getCalendarWeek(LatestETD)
                'row.Cells(4).Value = HellwegDataSet.dsPurchaseOrder.FindByPONo(row.Cells(1).Value.ToString).POL
            End If
        Next
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
            Case = "LCL"
                VolumeTextBox.Enabled = True
                WeightTextBox.Enabled = True
                Cont20DCTextBox.Enabled = False
                Cont40DCTextBox.Enabled = False
                Cont40HQTextBox.Enabled = False
                CarrierTextBox.Enabled = False
                Contract_NoTextBox.Enabled = False
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

    Private Sub WeightTextBox_TextChanged(sender As Object, e As EventArgs) Handles WeightTextBox.TextChanged
        If WeightTextBox.Text = "" Then Exit Sub
        Select Case Convert.ToDouble(WeightTextBox.Text)
            Case > 25000
                WeightTextBox.BackColor = Color.Crimson
            Case > 18000
                WeightTextBox.BackColor = Color.Gold
            Case < 18000
                WeightTextBox.BackColor = Color.White
            Case Else
        End Select
    End Sub

    Private Sub SQE_Click(sender As Object, e As EventArgs) Handles SQE.Click
        Dim Subject As String
        Dim Body As String
        Dim File As String = ""

        Subject = "DEMAG: Missing SQE Approval - "
        Subject = Subject & "ID: " & Shipment_IDTextBox.Text
        If STT_NoTextBox.Text <> "" Then Subject = Subject & " // STT No.: " & STT_NoTextBox.Text
        If DsShipment_SODataGridView.Rows.Count <> 0 Then
            Subject = Subject & " // SO No.:"
            For Each Row As DataGridViewRow In Me.DsShipment_SODataGridView.Rows
                Subject = Subject & " " & Row.Cells(0).Value.ToString
            Next
        End If

        If DsInvoiceDataGridView.Rows.Count <> 0 Then
            Subject = Subject & " // INV No.:"
            For Each Row As DataGridViewRow In Me.DsInvoiceDataGridView.Rows
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

        If DsInvoiceDataGridView.Rows.Count = 1 Then
            'MsgBox(DsInvoiceDataGridView1.Rows(0).Cells(4).Value.ToString)
            File = DsInvoiceDataGridView1.Rows(0).Cells(4).Value.ToString
        End If


        SendMailOutlook.SendMailHTTP("", Subject, Body, File)

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

        If DsInvoiceDataGridView.Rows.Count <> 0 Then
            Subject = Subject & " // INV No.:"
            For Each Row As DataGridViewRow In Me.DsInvoiceDataGridView.Rows
                Subject = Subject & " " & Row.Cells(0).Value.ToString
            Next
        End If

        If DsShipment_OrderDataGridView.Rows.Count <> 0 Then
            Subject = Subject & " // PO No.:"
            For Each Row As DataGridViewRow In Me.DsShipment_OrderDataGridView.Rows
                Subject = Subject & " " & Row.Cells(0).Value.ToString
            Next
        End If

        If DsShipment_OrderDataGridView.Rows.Count <> 0 Then
            For Each Row As DataGridViewRow In Me.DsShipment_OrderDataGridView.Rows
                toMail = toMail & ";" & Row.Cells(5).Value.ToString
            Next
        End If

        Body = "Dear Sir or Madam,<br>above mentioned shipment is planned as follow.<br>" &
                "<br>ETD " & POLTextBox.Text & ": " & dtnETD.Text &
                "<br>ETA " & PODTextBox.Text & ": " & dtnETD.Text &
                "<br>Incoterm: " & IncotermTextBox.Text & " - " & Incoterm_LocTextBox.Text &
                "<br><br>Please let us know if any additional Info is necessary."

        If DsInvoiceDataGridView.Rows.Count = 1 Then
            File = DsInvoiceDataGridView1.Rows(0).Cells(4).Value.ToString
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

    Private Sub DsInvoiceDataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DsInvoiceDataGridView1.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then 'Dokument öffnen
            Dim selectedRow = DsInvoiceDataGridView1.Rows(e.RowIndex)
            Process.Start(selectedRow.Cells(4).Value.ToString)
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

        If DsInvoiceDataGridView.Rows.Count <> 0 Then
            Subject = Subject & " // INV No.:"
            For Each Row As DataGridViewRow In Me.DsInvoiceDataGridView.Rows
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
End Class
