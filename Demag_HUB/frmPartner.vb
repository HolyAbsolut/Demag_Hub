Public Class frmPartner
    Private Sub DsPartnerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DsPartnerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DsPartnerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsDemag_HUB)

    End Sub

    Private Sub frmPartner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsAddress". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsAddressTableAdapter.Fill(Me.DsDemag_HUB.dsAddress)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsContact". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsContactTableAdapter.Fill(Me.DsDemag_HUB.dsContact)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DsDemag_HUB.dsPartner". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DsPartnerTableAdapter.Fill(Me.DsDemag_HUB.dsPartner)

    End Sub
End Class