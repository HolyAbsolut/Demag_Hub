Public Class frmMaininterface
    Dim dtnEmpty As String = "01.01.0001 00:00:00"


    Private Sub DsShipmentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DsShipmentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DsShipmentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsDemag_HUB)

    End Sub

    Private Sub frmMaininterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        MsgBox("Arbeite")

        Me.DsShipmentsTableAdapter.Update(Me.DsDemag_HUB.dsShipments)
        Me.DsCommentTableAdapter.Update(Me.DsDemag_HUB.dsComment)
        Me.DsPartnerTableAdapter.Update(Me.DsDemag_HUB.dsPartner)
        Me.DsContactTableAdapter.Update(Me.DsDemag_HUB.dsContact)
        Me.DsAddressTableAdapter.Update(Me.DsDemag_HUB.dsAddress)
        MsgBox("Fertig")

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        DsShipmentsBindingSource.AddNew()
        Me.subTabShipments.SelectedTab = tabBooking
    End Sub
End Class
