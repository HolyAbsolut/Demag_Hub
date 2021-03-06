﻿Option Strict On
Imports System.IO

Public Class frmDocument
    Public dirFile As String
    Public docNo As String
    Public docType As String
    Public docDirectory As String
    Dim docSaveNo As String


    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Process.Start(dirFile)
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Prüfen ob Felder leer sind
        If txtDocumentNo.Text = "" Then Exit Sub
        If cmbDocType.Text = "" Then Exit Sub

        'Daten für frmMaininterface verfügbarmachen
        docNo = txtDocumentNo.Text
        docType = cmbDocType.Text
        docSaveNo = txtDocumentNo.Text.Replace("/", String.Empty) 'zum speichern ohne 
        docSaveNo = docSaveNo.Replace("\", String.Empty) 'zum speichern ohne sonderzeichen
        docNo = txtDocumentNo.Text
        Try
            'Datei verschieben
            Dim directoryPath As String = Path.GetDirectoryName(My.Settings.sttDBPath)
            Dim dir As New IO.DirectoryInfo(directoryPath & "\Documents\" & frmMaininterface.Shipment_IDTextBox.Text & "\")
            If dir.Exists = False Then
                System.IO.Directory.CreateDirectory(dir.ToString)
            End If
            docDirectory = dir.ToString & docType & "_" & docSaveNo & Path.GetExtension(dirFile)

            File.Move(dirFile, docDirectory)
            ' See if the original file exists now.
            If File.Exists(dirFile) Then
                MsgBox("The original file still exists, which is unexpected.")
            Else
                Me.Close()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDocumentNo.Text = ""
        txtDocumentNo.Focus()
    End Sub

    Private Sub cmbDocType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDocType.SelectedIndexChanged
        Select Case cmbDocType.Text
            Case "BL"
                If txtDocumentNo.Text = "" Then txtDocumentNo.Text = frmMaininterface.MBL_NoTextBox.Text
            Case "HBL"
                If txtDocumentNo.Text = "" Then txtDocumentNo.Text = frmMaininterface.HBL_NoTextBox.Text
        End Select
    End Sub
End Class