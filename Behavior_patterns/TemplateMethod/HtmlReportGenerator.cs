using System;

public class HtmlReportGenerator : ReportGenerator
{
    protected override void ExportReport()
    {
        Console.WriteLine("🌐 Exporting to HTML...");
        Console.WriteLine("   • Creating HTML structure");
        Console.WriteLine("   • Adding CSS styles");
        Console.WriteLine("   • Generating HTML file");
    }
    
    protected override void FormatReport()
    {
        Console.WriteLine("🎨 Formatting for HTML layout...");
        Console.WriteLine("   • Creating HTML table structure");
        Console.WriteLine("   • Applying CSS classes");
    }
    
    protected override void GenerateHeader()
    {
        Console.WriteLine("📋 Generating HTML header with navigation...");
    }
}
