Partial Class dsDemag_HUB
    Partial Public Class rtShipments_ChargesDataTable
        Private Sub dsContainerDataTable_TableNewRow(sender As Object, e As DataTableNewRowEventArgs) Handles Me.TableNewRow
            DirectCast(e.Row, rtShipments_ChargesRow).Created = Date.Now
        End Sub
    End Class

    Partial Public Class dsContainerDataTable
        Private Sub dsContainerDataTable_TableNewRow(sender As Object, e As DataTableNewRowEventArgs) Handles Me.TableNewRow
            DirectCast(e.Row, dsContainerRow).Created = Date.Now
        End Sub
    End Class

    Partial Public Class dsAddressDataTable
        Private Sub dsAddressDataTable_TableNewRow(sender As Object, e As DataTableNewRowEventArgs) Handles Me.TableNewRow
            DirectCast(e.Row, dsAddressRow).Created = Date.Now
        End Sub
    End Class

    Partial Public Class dsRoleDataTable
        Private Sub dsRoleDataTable_TableNewRow(sender As Object, e As DataTableNewRowEventArgs) Handles Me.TableNewRow
            DirectCast(e.Row, dsRoleRow).Created = Date.Now
        End Sub
    End Class

    Partial Public Class dsContactDataTable
        Private Sub dsContactDataTable_TableNewRow(sender As Object, e As DataTableNewRowEventArgs) Handles Me.TableNewRow
            DirectCast(e.Row, dsContactRow).Created = Date.Now
        End Sub
    End Class

    Partial Public Class dsPartnerDataTable
        Private Sub dsPartnerDataTable_TableNewRow(sender As Object, e As DataTableNewRowEventArgs) Handles Me.TableNewRow
            DirectCast(e.Row, dsPartnerRow).Created = Date.Now
        End Sub
    End Class

    Partial Public Class dsShipmentsDataTable
        Private Sub dsShipmentsDataTable_TableNewRow(sender As Object, e As DataTableNewRowEventArgs) Handles Me.TableNewRow
            DirectCast(e.Row, dsShipmentsRow).Created = Date.MinValue
        End Sub


        'Private Sub Protocol(sender As Object, e As DataTableNewRowEventArgs) Handles Me.dsShipmentsRowChanging
        '    'DirectCast(e.Row, dsShipmentsRow).Created = Date.MinValue
        'End Sub


    End Class

    Partial Public Class dsCommentDataTable
        Private Sub DateNow_TableNewRow(sender As Object, e As DataTableNewRowEventArgs) Handles Me.TableNewRow
            DirectCast(e.Row, dsCommentRow).Created = Date.Now
        End Sub
    End Class
End Class
