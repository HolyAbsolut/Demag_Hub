Option Strict On





Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element


Module PDF
    Sub Test()

        Dim DEST As String = "C:\Users\HolyAbsolut\Desktop\Tesdt.pdf"
        'Dim File As = New FileIO(DEST)
        MsgBox("OK")
        ''Dim document As New Document(iText.text.PageSize.A4, 10, 10, 42, 35)
        Dim writer As New PdfWriter(DEST)
        Dim pdf As New PdfDocument(writer)
        Dim document As New Document(pdf)

        document.Add(New Paragraph("Hello World"))

        document.Close()
        MsgBox("OK")




        ''https://developers.itextpdf.com/examples/itext-action-second-edition/chapter-10#395-barcodes.java
        ''// step 1
        ''Document document = new Document(new Rectangle(340, 842));
        'Dim document As New Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35)
        ''// step 2
        ''PdfWriter writer = PdfWriter.getInstance(document, new FileOutputStream(filename));
        'Using fs As System.IO.FileStream = New FileStream("C:\Users\HolyAbsolut\Desktop\Test.pdf", FileMode.Create)
        '    Dim writer As PdfWriter = PdfWriter.GetInstance(document, fs)

        '    '// step 3
        '    'document.open();
        '    document.Open()
        '    '// step 4
        '    'PdfContentByte cb = writer.getDirectContent();
        '    Dim cb As PdfContentByte = writer.DirectContent

        '    document.Add(New Paragraph("Barcode Datamatrix"))
        '    'BarcodeDatamatrix DataMatrix = New BarcodeDatamatrix()
        '    Dim DataMatrix As BarcodeDatamatrix = New BarcodeDatamatrix
        '    'DataMatrix.Generate(Text)
        '    DataMatrix.Generate("Test")
        '    Dim img As Image = DataMatrix.CreateImage()
        '    document.Add(img)

        '    ' // step 5
        '    'document.close();

        '    document.Close()

        'End Using

        'Process.Start("C:\Users\HolyAbsolut\Desktop\Test.pdf")
    End Sub

End Module
