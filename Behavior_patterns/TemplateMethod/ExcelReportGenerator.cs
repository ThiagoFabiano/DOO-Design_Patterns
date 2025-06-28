using System;
public class ExcelReportGenerator : ReportGenerator
{
    protected override void ExportReport()
    {
        Console.WriteLine("📊 Exporting to Excel...");
        Console.WriteLine("   • Creating Excel workbook");
        Console.WriteLine("   • Adding data to spreadsheet");
        Console.WriteLine("   • Applying Excel formatting");
        Console.WriteLine("   • Saving Excel file");
    }
    
    protected override void FormatReport()
    {
        Console.WriteLine("🎨 Formatting for Excel layout...");
        Console.WriteLine("   • Setting column widths");
        Console.WriteLine("   • Applying cell styles");
    }
    
    protected override void CollectData()
    {
        base.CollectData();
        Console.WriteLine("   • Organizing data for spreadsheet format");
    }
}
