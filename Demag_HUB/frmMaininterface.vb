Imports System.Text
Imports System.IO
Public Class frmMaininterface
    Dim dtnEmpty As String = "01.01.0001 00:00:00"


    Private Sub DsShipmentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DsShipmentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DsShipmentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsDemag_HUB)

    End Sub

    Private Sub frmMaininterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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



    Private Sub dtnConvert(sender As Object, e As EventArgs) Handles dtnCRD.Leave, dtnETD.Leave, dtnETA.Leave
        If sender.Text = "" Then
            DsDemag_HUB.dsShipments.Rows.Find(Shipment_IDTextBox.Text).Item(sender.name) = System.DBNull.Value
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
        'Me.DsShipment_OrderBindingSource.EndEdit()
        MsgBox("Arbeite")

        Me.DsShipmentsTableAdapter.Update(Me.DsDemag_HUB.dsShipments)
        Me.DsCommentTableAdapter.Update(Me.DsDemag_HUB.dsComment)
        Me.DsPartnerTableAdapter.Update(Me.DsDemag_HUB.dsPartner)
        Me.DsContactTableAdapter.Update(Me.DsDemag_HUB.dsContact)
        Me.DsAddressTableAdapter.Update(Me.DsDemag_HUB.dsAddress)
        'Me.DsShipment_OrderTableAdapter.Update(Me.DsDemag_HUB.dsShipment_Order)
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
        newDocRow.Shipment_ID = Shipment_IDTextBox.Text
        newDocRow.Created = Date.Now
        newDocRow.Invoice_No = frmDocument.docNo
        newDocRow.Link = frmDocument.docDirectory
        DsDemag_HUB.dsInvoice.Rows.Add(newDocRow)

        Me.DsInvoiceBindingSource.EndEdit()
        Me.DsInvoiceTableAdapter.Update(Me.DsDemag_HUB.dsInvoice)


    End Sub

    Private Sub Shipment_IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles Shipment_IDTextBox.TextChanged
        If Convert.ToDouble(Shipment_IDTextBox.Text) > 0 Then
            btnaddDocument.Enabled = True
        Else
            btnaddDocument.Enabled = False
        End If
    End Sub




End Class
