Public Class frmMaininterface
    Private Sub DsShipmentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DsShipmentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DsShipmentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsDemag_HUB)

    End Sub

    Private Sub frmMaininterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsShipments". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsShipmentsTableAdapter.Fill(Me.DsDemag_HUB.dsShipments)

    End Sub
End Class
