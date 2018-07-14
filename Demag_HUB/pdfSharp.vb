Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf


Public Structure PDFCoverStructure
    Dim ArchivNo As String
    Dim STTNo As String
    Dim ETA As String
    Dim POL As String
    Dim POD As String
    Dim Vessel As String
    Dim Terminal As String
    Dim dtEK_VK As String
    Dim dtEK_SK As String
    Dim dtEK_SpecialSurcharge As String
    Dim dtVK_VK As String
    Dim dtVK_SK As String
    Dim dtVK_SpecialSurcharge As String
    Dim dtVK_Nachlauf As String
    Dim dt20DC As String
    Dim dt20DCHW As String
    Dim dt40DC As String
    Dim dt40HQ As String
    Dim dtCharge0Description As String
    Dim dtCharge0Value As String
    Dim dtCharge1Description As String
    Dim dtCharge1Value As String
    Dim dtCharge2Description As String
    Dim dtCharge2Value As String
    Dim dtCharge3Description As String
    Dim dtCharge3Value As String
    Dim dtCharge4Description As String
    Dim dtCharge4Value As String
    Dim dtCharge5Description As String
    Dim dtCharge5Value As String
    Dim dtCharge6Description As String
    Dim dtCharge6Value As String
    Dim dtCharge7Description As String
    Dim dtCharge7Value As String
    Dim dtCharge8Description As String
    Dim dtCharge8Value As String
    Dim dtCharge9Description As String
    Dim dtCharge9Value As String
    Dim dtCharge10Description As String
    Dim dtCharge10Value As String
    Dim dtClient As String
    Dim dtContract As String
    Dim dtFullDocs As String
    Dim dtIMDG As String
    Dim dtPMRef As String
    Dim dtWKV As String
    Dim dtBLSent As String
    Dim dtLeerdepot As String
    Dim EmptyDepot As String
    Dim dtIMDGUN As String
    Dim dtIMDGCheck As String
    Dim dtDelivery As String
    Dim dtCUS As String
    Dim dtFISoTRANSIT As String
    Dim dtSTT As String
    Dim dtArchiveNoHBL As String
    Dim dtArchiveNoMBL As String
    Dim chkVomKunden As Boolean
    Dim chkVerzolltSeehafen As Boolean
    Dim chkAtlasFremd As Boolean
    Dim chkVomUnternehmer As Boolean
    Dim chkTruck As Boolean
    Dim chkT1 As Boolean
    Dim chkSchenker As Boolean
    Dim chkRail As Boolean
    Dim chkMBLW As Boolean
    Dim chkMBLO As Boolean
    Dim chkLeer As Boolean
    Dim chkKopiert As Boolean
    Dim chkKompensation As Boolean
    Dim chkHBLW As Boolean
    Dim chkHBLS As Boolean
    Dim chkHBLO As Boolean
    Dim chkFremd As Boolean
    Dim chkFreistellung As Boolean
    Dim chkDispo As Boolean
    Dim chkBarge As Boolean
    Dim chkAtlas2 As Boolean
    Dim chkAtlas1 As Boolean

    Dim chkICM As Boolean
    Dim chkTurnIn As Boolean
    Dim chkPIN As Boolean
    Dim chkAbgerechnet As Boolean

    Dim dtService As String
    Dim dtQuantity As String
    Dim dtWeight As String
    Dim dtVolume As String
    Dim dtChargeable As String

    Dim dtIncoterm As String
    Dim dtSipmentID As String
    Dim dtIncotermLoc As String

    Dim chkSQE As Boolean

    Dim dtCarrier As String
End Structure

Module pdfSharp
    ' VB.NET version of 'Hello World'



    Sub Cover(ByVal dirFile As String)
        Dim Line As Integer
        Dim drwLine As Integer
        Dim stdDistance As Byte = 25

        ' Create a new PDF document
        Dim document As PdfDocument = New PdfDocument
        document.Info.Title = "Job Dossier // " & frmMaininterface.PDFCover.ArchivNo
        document.Info.Author = My.User.Name
        document.Info.Keywords = "Job Dossier"

        ' Create an empty page
        Dim page As PdfPage = document.AddPage

        '' Get an XGraphics object for drawing
        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)

        '' Draw crossing lines
        'Dim pen As XPen = New XPen(XColor.FromArgb(0, 0, 0))
        'gfx.DrawLine(pen, New XPoint(0, 0), New XPoint(page.Width.Point, page.Height.Point))
        'gfx.DrawLine(pen, New XPoint(page.Width.Point, 0), New XPoint(0, page.Height.Point))

        '' Draw an ellipse
        'gfx.DrawEllipse(pen, 3 * page.Width.Point / 10, 3 * page.Height.Point / 10, 2 * page.Width.Point / 5, 2 * page.Height.Point / 5)











        ' Create a font
        Dim FormularFont As XFont = New XFont("Arial", 18, XFontStyle.Bold)
        Dim EntryFont As XFont = New XFont("Arial", 18, XFontStyle.Regular)
        Dim CheckBoxFont As XFont = New XFont("Wingdings", 18, XFontStyle.Regular)

        ' Header
        gfx.DrawString("ETA ", FormularFont, XBrushes.DarkGray, New XRect(30, 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("Schiff ", FormularFont, XBrushes.DarkGray, New XRect(30, 50, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("Hafen ", FormularFont, XBrushes.DarkGray, New XRect(300, 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("Terminal ", FormularFont, XBrushes.DarkGray, New XRect(300, 50, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.ETA, EntryFont, XBrushes.Black, New XRect(100, 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.Vessel, EntryFont, XBrushes.Black, New XRect(100, 50, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.POL & " - " & frmMaininterface.PDFCover.POD, EntryFont, XBrushes.Black, New XRect(400, 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        'gfx.DrawString(frmMaininterface.PDFCover.POD, EntryFont, XBrushes.Black, New XRect(400, 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.Terminal, EntryFont, XBrushes.Black, New XRect(400, 50, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        Dim Pen As XPen = New XPen(XColors.Black, 1)
        gfx.DrawRectangle(Pen, 25, 25, page.Width.Point - 60, 50)

        FormularFont = New XFont("Arial", 11, XFontStyle.Bold)
        EntryFont = New XFont("Arial", 11, XFontStyle.Regular)
        CheckBoxFont = New XFont("Wingdings", 11, XFontStyle.Regular)



        'Line 1
        Line = 80
        gfx.DrawString("Verzollt – Seehafen / Grenze", FormularFont, XBrushes.Black, New XRect(40, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("Vom Kunden", FormularFont, XBrushes.Black, New XRect(250, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("ATLAS bei fremder ZollSt.", FormularFont, XBrushes.Black, New XRect(350, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        If frmMaininterface.PDFCover.chkVerzolltSeehafen = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkVomKunden = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(240, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(240, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkAtlasFremd = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(340, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(340, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If

        'Line 2
        Line += stdDistance
        gfx.DrawString("auf T1 / Selbstverzoller", FormularFont, XBrushes.Black, New XRect(40, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("Vom Unternehmer", FormularFont, XBrushes.Black, New XRect(250, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("ATLAS Eingabe:", FormularFont, XBrushes.Black, New XRect(350, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        If frmMaininterface.PDFCover.chkT1 = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkVomUnternehmer = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(240, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(240, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkAtlas1 = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(440, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(440, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkAtlas2 = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(450, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(450, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If

        'Draw Line
        drwLine = Line + 18
        gfx.DrawLine(Pen, 25, drwLine, page.Width.Point - 35, drwLine)

        'Line 3
        Line += stdDistance + 2
        gfx.DrawString("Bemerkungen:", FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("EK-VK US-$", FormularFont, XBrushes.Black, New XRect(110, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtEK_VK, EntryFont, XBrushes.Black, New XRect(175, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("EK-SK US-$", FormularFont, XBrushes.Black, New XRect(280, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtEK_SK, EntryFont, XBrushes.Black, New XRect(350, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Draw Lines
        drwLine = Line + 12
        gfx.DrawLine(Pen, 30, drwLine, 108, drwLine) 'Bemerkungen
        gfx.DrawLine(Pen, 175, drwLine, 270, drwLine) 'EK-VK US-$
        gfx.DrawLine(Pen, 350, drwLine, 445, drwLine) 'EK-SK US-$


        'Line 4
        Line += stdDistance
        gfx.DrawString("Special Surcharge US $", FormularFont, XBrushes.Black, New XRect(110, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtEK_SpecialSurcharge, EntryFont, XBrushes.Black, New XRect(250, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Draw Lines
        drwLine = Line + 12
        gfx.DrawLine(Pen, 250, drwLine, 345, drwLine) 'Special Surcharge US $


        'Line 5
        Line += stdDistance
        gfx.DrawString("Fremd", FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("VK-VK US-$", FormularFont, XBrushes.Black, New XRect(110, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtVK_VK, EntryFont, XBrushes.Black, New XRect(175, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("VK-SK EU-€", FormularFont, XBrushes.Black, New XRect(280, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtVK_SK, EntryFont, XBrushes.Black, New XRect(350, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        If frmMaininterface.PDFCover.chkFremd = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(80, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(80, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If

        'Draw Lines
        drwLine = Line + 12
        gfx.DrawLine(Pen, 175, drwLine, 270, drwLine) 'VK-VK US-$
        gfx.DrawLine(Pen, 350, drwLine, 445, drwLine) 'VK-SK US-$

        'Line 6
        Line += stdDistance
        gfx.DrawString("Special Surcharge EU €", FormularFont, XBrushes.Black, New XRect(110, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtVK_SpecialSurcharge, EntryFont, XBrushes.Black, New XRect(250, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Draw Lines
        drwLine = Line + 12
        gfx.DrawLine(Pen, 250, drwLine, 345, drwLine) 'Special Surcharge US $

        'Line 7
        Line += stdDistance
        gfx.DrawString("Schenker", FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("Nachlauf", FormularFont, XBrushes.Black, New XRect(110, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtVK_Nachlauf, EntryFont, XBrushes.Black, New XRect(200, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        If frmMaininterface.PDFCover.dtService = "FCL" Then
            gfx.DrawString("Leerdepot", FormularFont, XBrushes.Black, New XRect(350, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
            gfx.DrawString(frmMaininterface.PDFCover.dtLeerdepot, EntryFont, XBrushes.Black, New XRect(425, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        End If
        If frmMaininterface.PDFCover.chkSchenker = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(80, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(80, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If

        'Draw Lines
        drwLine = Line + 12
        gfx.DrawLine(Pen, 200, drwLine, 295, drwLine) 'FCL Nachlauf
        If frmMaininterface.PDFCover.dtService = "FCL" Then gfx.DrawLine(Pen, 425, drwLine, 520, drwLine) 'Leerdepot

        'Line 8
        Line += stdDistance
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge0Description, FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge0Value, EntryFont, XBrushes.Black, New XRect(150, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("Reeder:", FormularFont, XBrushes.Black, New XRect(350, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtCarrier, EntryFont, XBrushes.Black, New XRect(425, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Draw Lines
        drwLine = Line + 12
        gfx.DrawLine(Pen, 425, drwLine, 520, drwLine) 'Reeder:.

        'Line 9
        Line += stdDistance
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge1Description, FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge1Value, EntryFont, XBrushes.Black, New XRect(150, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("Kontrakt Nr.:", FormularFont, XBrushes.Black, New XRect(350, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtContract, EntryFont, XBrushes.Black, New XRect(425, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Draw Lines
        drwLine = Line + 12
        gfx.DrawLine(Pen, 425, drwLine, 520, drwLine) 'Kontrakt Nr.:

        'Line 10
        Line += stdDistance
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge2Description, FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge2Value, EntryFont, XBrushes.Black, New XRect(150, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("PM Ref.:", FormularFont, XBrushes.Black, New XRect(350, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtPMRef, EntryFont, XBrushes.Black, New XRect(425, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Draw Lines
        drwLine = Line + 12
        gfx.DrawLine(Pen, 425, drwLine, 520, drwLine) 'PM Ref.:

        'Line 11
        Line += stdDistance
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge3Description, FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge3Value, EntryFont, XBrushes.Black, New XRect(150, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("Kunde:", FormularFont, XBrushes.Black, New XRect(350, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtClient, EntryFont, XBrushes.Black, New XRect(425, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Line 12
        Line += stdDistance
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge4Description, FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge4Value, EntryFont, XBrushes.Black, New XRect(150, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Line 13
        Line += stdDistance
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge5Description, FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge5Value, EntryFont, XBrushes.Black, New XRect(150, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("Incoterm:", FormularFont, XBrushes.Black, New XRect(350, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtIncoterm & " - ", EntryFont, XBrushes.Black, New XRect(425, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtIncotermLoc, EntryFont, XBrushes.Black, New XRect(460, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Line 14
        Line += stdDistance
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge6Description, FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge6Value, EntryFont, XBrushes.Black, New XRect(150, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Line 15
        Line += stdDistance
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge7Description, FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge7Value, EntryFont, XBrushes.Black, New XRect(150, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Line 16
        Line += stdDistance
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge8Description, FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge8Value, EntryFont, XBrushes.Black, New XRect(150, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Line 17
        Line += stdDistance
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge9Description, FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge9Value, EntryFont, XBrushes.Black, New XRect(150, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Line 18
        Line += stdDistance
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge10Description, FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtCharge10Value, EntryFont, XBrushes.Black, New XRect(150, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Line 19
        Line += stdDistance
        If frmMaininterface.PDFCover.dtService = "FCL" Then
            gfx.DrawString(frmMaininterface.PDFCover.dt20DC, EntryFont, XBrushes.Black, New XRect(30, Line, 88, 12), XStringFormats.TopCenter)
            gfx.DrawString("20'", FormularFont, XBrushes.Black, New XRect(110, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
            gfx.DrawString(frmMaininterface.PDFCover.dt20DCHW, EntryFont, XBrushes.Black, New XRect(125, Line, 88, 12), XStringFormats.TopCenter)
            gfx.DrawString("20' schwer", FormularFont, XBrushes.Black, New XRect(210, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
            gfx.DrawString(frmMaininterface.PDFCover.dt40DC, EntryFont, XBrushes.Black, New XRect(270, Line, 88, 12), XStringFormats.TopCenter)
            gfx.DrawString("40'", FormularFont, XBrushes.Black, New XRect(360, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
            gfx.DrawString(frmMaininterface.PDFCover.dt40HQ, EntryFont, XBrushes.Black, New XRect(380, Line, 88, 12), XStringFormats.TopCenter)
            gfx.DrawString("40' HC", FormularFont, XBrushes.Black, New XRect(470, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
            'Draw Lines
            drwLine = Line + 12
            gfx.DrawLine(Pen, 30, drwLine, 108, drwLine) '20DC
            gfx.DrawLine(Pen, 125, drwLine, 208, drwLine) '20DC schwer
            gfx.DrawLine(Pen, 270, drwLine, 358, drwLine) '40DC
            gfx.DrawLine(Pen, 380, drwLine, 468, drwLine) '40HQ
        End If

        If frmMaininterface.PDFCover.dtService = "LCL" Then
            gfx.DrawString(frmMaininterface.PDFCover.dtQuantity, EntryFont, XBrushes.Black, New XRect(30, Line, 88, 12), XStringFormats.TopCenter)
            gfx.DrawString("Kolli", FormularFont, XBrushes.Black, New XRect(110, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
            gfx.DrawString(frmMaininterface.PDFCover.dtWeight, EntryFont, XBrushes.Black, New XRect(145, Line, 88, 12), XStringFormats.TopCenter)
            gfx.DrawString("KG", FormularFont, XBrushes.Black, New XRect(230, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
            gfx.DrawString(frmMaininterface.PDFCover.dtVolume, EntryFont, XBrushes.Black, New XRect(270, Line, 88, 12), XStringFormats.TopCenter)
            gfx.DrawString("CBM", FormularFont, XBrushes.Black, New XRect(360, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
            gfx.DrawString(frmMaininterface.PDFCover.dtChargeable, EntryFont, XBrushes.Black, New XRect(380, Line, 88, 12), XStringFormats.TopCenter)
            gfx.DrawString("Chargeable", FormularFont, XBrushes.Black, New XRect(470, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
            'Draw Lines
            drwLine = Line + 12
            gfx.DrawLine(Pen, 30, drwLine, 108, drwLine) '20DC
            gfx.DrawLine(Pen, 145, drwLine, 228, drwLine) '20DC schwer
            gfx.DrawLine(Pen, 270, drwLine, 358, drwLine) '40DC
            gfx.DrawLine(Pen, 380, drwLine, 468, drwLine) '40HQ
        End If

        'Line 20
        Line += stdDistance
        gfx.DrawString("H/BL: Original", FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("H/BL: Waybill", FormularFont, XBrushes.Black, New XRect(120, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("H/BL: Surrendered", FormularFont, XBrushes.Black, New XRect(200, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("M/BL: Original", FormularFont, XBrushes.Black, New XRect(310, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("M/BL: Waybill", FormularFont, XBrushes.Black, New XRect(400, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        If frmMaininterface.PDFCover.chkHBLO = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(110, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(110, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkHBLW = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(190, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(190, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkHBLS = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(300, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(300, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkMBLO = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(390, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(390, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkMBLW = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(480, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(480, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If

        'Draw Line
        drwLine = Line + 20
        gfx.DrawLine(Pen, 25, drwLine, page.Width.Point - 35, drwLine)


        'Line 21
        Line += stdDistance
        gfx.DrawString("KB/WKV geprüft:", FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtWKV, EntryFont, XBrushes.Black, New XRect(140, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Draw Line
        drwLine = Line + 20
        gfx.DrawLine(Pen, 25, drwLine, page.Width.Point - 35, drwLine)

        'Line 22
        Line += stdDistance
        gfx.DrawString("Dokumente vollzählig:", FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtFullDocs, EntryFont, XBrushes.Black, New XRect(160, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("B/L-Einreichung:", FormularFont, XBrushes.Black, New XRect(350, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtBLSent, EntryFont, XBrushes.Black, New XRect(450, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Draw Line
        drwLine = Line + 20
        gfx.DrawLine(Pen, 25, drwLine, page.Width.Point - 35, drwLine)

        'Line 23
        Line += stdDistance
        gfx.DrawString("Gefahrgut:", FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("IMDG:", FormularFont, XBrushes.Black, New XRect(100, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtIMDG, EntryFont, XBrushes.Black, New XRect(140, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("IMDG geprüft:", FormularFont, XBrushes.Black, New XRect(350, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtIMDGCheck, EntryFont, XBrushes.Black, New XRect(450, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Draw Line
        drwLine = Line + 20
        gfx.DrawLine(Pen, 25, drwLine, page.Width.Point - 35, drwLine)

        'Line 24
        Line += stdDistance
        gfx.DrawString("UN:", FormularFont, XBrushes.Black, New XRect(100, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtIMDGUN, EntryFont, XBrushes.Black, New XRect(140, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Draw Line
        drwLine = Line + 20
        gfx.DrawLine(Pen, 25, drwLine, page.Width.Point - 35, drwLine)

        'Line 25
        Line += stdDistance
        gfx.DrawString("Zustellung:", FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtDelivery, EntryFont, XBrushes.Black, New XRect(140, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("Truck", FormularFont, XBrushes.Black, New XRect(350, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("Rail", FormularFont, XBrushes.Black, New XRect(400, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("Barge", FormularFont, XBrushes.Black, New XRect(450, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        If frmMaininterface.PDFCover.chkTruck = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(340, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(340, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkRail = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(390, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(390, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkBarge = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(440, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(440, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If

        'Draw Line
        drwLine = Line + 20
        gfx.DrawLine(Pen, 25, drwLine, page.Width.Point - 35, drwLine)

        'Line 26
        Line += stdDistance
        gfx.DrawString("Zollabfertigung eingereicht am:", FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtCUS, EntryFont, XBrushes.Black, New XRect(200, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("T1/Fiskal eingereicht am:", FormularFont, XBrushes.Black, New XRect(350, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtFISoTRANSIT, EntryFont, XBrushes.Black, New XRect(490, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Draw Line
        drwLine = Line + 20
        gfx.DrawLine(Pen, 25, drwLine, page.Width.Point - 35, drwLine)

        EntryFont = New XFont("Arial", 17, XFontStyle.Regular) 'Schrift für Archiv & STT erhöhen

        'Line 27
        Line += stdDistance
        gfx.DrawString("Archive No House:", FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtArchiveNoHBL, EntryFont, XBrushes.Black, New XRect(140, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("STT", FormularFont, XBrushes.Black, New XRect(350, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtSTT, EntryFont, XBrushes.Black, New XRect(400, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Draw Line
        drwLine = Line + 20
        gfx.DrawLine(Pen, 25, drwLine, page.Width.Point - 35, drwLine)

        'Line 28
        Line += stdDistance
        gfx.DrawString("Archive No Master:", FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString(frmMaininterface.PDFCover.dtArchiveNoMBL, EntryFont, XBrushes.Black, New XRect(140, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        EntryFont = New XFont("Arial", 11, XFontStyle.Regular)  'Back to the standard

        'Draw Line
        drwLine = Line + 20
        gfx.DrawLine(Pen, 25, drwLine, page.Width.Point - 35, drwLine)

        'Line 29
        Line += stdDistance
        gfx.DrawString("PIN erhalten:", FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("Turn In erhalten:", FormularFont, XBrushes.Black, New XRect(170, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("T1 erhalten:", FormularFont, XBrushes.Black, New XRect(300, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("Rechnung erstellt:", FormularFont, XBrushes.Black, New XRect(420, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        If frmMaininterface.PDFCover.chkPIN = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(20, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(20, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkTurnIn = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(160, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(160, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkT1 = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(290, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(290, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkAbgerechnet = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(410, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(410, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If


        'Line 30
        Line += stdDistance - 10
        gfx.DrawString("Kopiert:", FormularFont, XBrushes.Black, New XRect(30, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("TOPS:", FormularFont, XBrushes.Black, New XRect(170, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("ICM:", FormularFont, XBrushes.Black, New XRect(300, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("SQE:", FormularFont, XBrushes.Black, New XRect(420, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)
        gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(20, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        If frmMaininterface.PDFCover.chkDispo = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(160, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(160, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkICM = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(290, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(290, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If
        If frmMaininterface.PDFCover.chkSQE = True Then
            gfx.DrawString("þ", CheckBoxFont, XBrushes.Black, New XRect(410, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) ' check
        Else
            gfx.DrawString("o", CheckBoxFont, XBrushes.Black, New XRect(410, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft) 'uncheck
        End If


        'Shipment ID
        FormularFont = New XFont("Arial", 18, XFontStyle.Bold) ' Pretty Big
        Line += stdDistance - 10
        gfx.DrawString("#" & frmMaininterface.PDFCover.dtSipmentID, FormularFont, XBrushes.Black, New XRect(50, Line, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        'Datamatrix
        Dim Image As XImage = frmMaininterface.GetDataMatrix(frmMaininterface.PDFCover.dtSipmentID)
        gfx.DrawImage(Image, page.Width.Point - 580, page.Height.Point - 30)



        'Version    
        EntryFont = New XFont("Arial", 9, XFontStyle.Regular)  'Small
        gfx.DrawString("v1.0", EntryFont, XBrushes.Black, New XRect(page.Width.Point - 20, page.Height.Point - 15, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)


        ' Save the document...
        'Dim filename As String = "Abrenzungsblatt.pdf"
        document.Save(dirFile)

        ' ...and start a viewer.
        Process.Start(dirFile)
    End Sub



    ' VB.NET version of 'Hello World'

    Sub Schablone()


        ' Create a new PDF document
        Dim document As PdfDocument = New PdfDocument
        document.Info.Title = "Schablone"

        ' Create an empty page
        Dim page As PdfPage = document.AddPage

        '' Get an XGraphics object for drawing
        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)

        ' Draw crossing lines
        Dim pen As XPen = New XPen(XColor.FromArgb(0, 0, 0))


        ' Create a font
        Dim FormularFont As XFont = New XFont("Arial", 10, XFontStyle.Regular)
        Dim EntryFont As XFont = New XFont("Arial", 10, XFontStyle.Regular)

        Dim xPos As Integer = 0
        Dim yPos As Integer = 0

        'Breite
        Do
            xPos += 50
            gfx.DrawLine(pen, New XPoint(xPos, 0), New XPoint(xPos, page.Height.Point))
            gfx.DrawString(xPos.ToString, FormularFont, XBrushes.DarkGray, New XRect(xPos, 0, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        Loop Until xPos > 5000

        'Höhe
        Do
            yPos += 50
            gfx.DrawLine(pen, New XPoint(0, yPos), New XPoint(page.Width.Point, yPos))
            gfx.DrawString(yPos.ToString, FormularFont, XBrushes.DarkGray, New XRect(0, yPos, page.Width.Point, page.Height.Point), XStringFormats.TopLeft)

        Loop Until yPos > 6000


        ' Save the document...
        Dim filename As String = "Hesdddddd.pdf"
        document.Save(filename)

        ' ...and start a viewer.
        Process.Start(filename)
    End Sub


End Module
