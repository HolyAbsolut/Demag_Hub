Option Strict On




Imports iText
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.IO.Font
Imports iText.Kernel.Font


Module iText
    Sub Test()

        Dim DEST As String = "C:\Users\HolyAbsolut\Desktop\Tesdt.pdf"
        Dim writer As New PdfWriter(DEST)
        Dim pdf As New PdfDocument(writer)
        Dim pdfSize As Global.iText.Kernel.Geom.PageSize = Global.iText.Kernel.Geom.PageSize.A4
        Dim page As PdfPage = pdf.AddNewPage(pdfSize)
        Dim Canvas As Global.iText.Kernel.Pdf.Canvas.PdfCanvas = New Global.iText.Kernel.Pdf.Canvas.PdfCanvas(page)
        'Dim Canvas As iText.Layout.Canvas = New iText.Kernel.Pdf.Canvas.PdfCanvas(page)

        'Dim document As New Document(pdf)
        'Dim newFont As PdfFont
        'newFont = PdfFontFactory.CreateFont(Constants.StandardFonts.TIMES_ITALIC)
        'document.Add(New Paragraph("Hello World"))
        'document.Add(New Paragraph("Hello World").SetFont(newFont))
        'document.Close()


        Canvas.MoveTo(-(pdfSize.GetWidth() / 2 - 15), 0).LineTo(pdfSize.GetWidth() / 2 - 5, 0).Stroke()
        Canvas.SetLineJoinStyle(Global.iText.Kernel.Pdf.Canvas.PdfCanvasConstants.LineJoinStyle.ROUND).MoveTo(pdfSize.GetWidth() / 2 - 25, -10) _
        .LineTo(pdfSize.GetWidth() / 2 - 15, 0) _
        .LineTo(pdfSize.GetWidth() / 2 - 25, 10).Stroke() _
        .SetLineJoinStyle(Global.iText.Kernel.Pdf.Canvas.PdfCanvasConstants.LineJoinStyle.MITER)



        Canvas.Stroke()

        pdf.Close()




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
