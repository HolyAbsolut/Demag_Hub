Partial Class dsDemag_HUB
    Partial Public Class dsShipmentsDataTable
        Private Sub DeineTabelleDataTable_TableNewRow(sender As Object, e As DataTableNewRowEventArgs) Handles Me.TableNewRow
            DirectCast(e.Row, dsShipmentsRow).Created = Date.Now
        End Sub
    End Class
End Class
