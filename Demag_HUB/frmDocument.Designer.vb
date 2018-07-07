<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocument
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDocumentNo = New Demag_HUB.Watermark()
        Me.cmbDocType = New System.Windows.Forms.ComboBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDocumentNo
        '
        Me.txtDocumentNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDocumentNo.Location = New System.Drawing.Point(12, 12)
        Me.txtDocumentNo.Name = "txtDocumentNo"
        Me.txtDocumentNo.Size = New System.Drawing.Size(469, 20)
        Me.txtDocumentNo.TabIndex = 1
        Me.txtDocumentNo.WatermarkColor = System.Drawing.Color.Gray
        Me.txtDocumentNo.WatermarkText = "Document No.:"
        '
        'cmbDocType
        '
        Me.cmbDocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDocType.FormattingEnabled = True
        Me.cmbDocType.Items.AddRange(New Object() {"INV", "PL", "BL", "HBL", "MISC", "SQE_Confirmation", "Booking_Confirmation"})
        Me.cmbDocType.Location = New System.Drawing.Point(487, 11)
        Me.cmbDocType.Name = "cmbDocType"
        Me.cmbDocType.Size = New System.Drawing.Size(73, 21)
        Me.cmbDocType.TabIndex = 2
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOpen.Location = New System.Drawing.Point(12, 45)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 7
        Me.btnOpen.TabStop = False
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Location = New System.Drawing.Point(485, 45)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 6
        Me.btnOk.TabStop = False
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 80)
        Me.Controls.Add(Me.txtDocumentNo)
        Me.Controls.Add(Me.cmbDocType)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnOk)
        Me.Name = "frmDocument"
        Me.Text = "frmDocument"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDocumentNo As Watermark
    Friend WithEvents cmbDocType As ComboBox
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnOk As Button
End Class
