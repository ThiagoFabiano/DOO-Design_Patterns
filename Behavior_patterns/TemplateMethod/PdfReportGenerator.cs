using System;

public class PdfReportGenerator : ReportGenerator
{
    protected override void ExportReport()
    {
        Console.WriteLine("📄 Exporting to PDF...");
        Console.WriteLine("   • Creating PDF document");
        Console.WriteLine("   • Adding content to PDF");
        Console.WriteLine("   • Saving PDF file");
    }
    
    protected override void FormatReport()
    {
        Console.WriteLine("🎨 Formatting for PDF layout...");
        Console.WriteLine("   • Setting PDF margins");
        Console.WriteLine("   • Applying PDF fonts");
    }
}
