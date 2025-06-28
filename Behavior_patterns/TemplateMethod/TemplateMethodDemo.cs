using System;

public class TemplateMethodDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Demonstração do Padrão Template Method ===");
        
        Console.WriteLine("\n1. Gerando relatório PDF:");
        var pdfReport = new PdfReportGenerator();
        pdfReport.GenerateReport();
        
        Console.WriteLine("2. Gerando relatório Excel:");
        var excelReport = new ExcelReportGenerator();
        excelReport.GenerateReport();
        
        Console.WriteLine("3. Gerando relatório HTML:");
        var htmlReport = new HtmlReportGenerator();
        htmlReport.GenerateReport();
        

    }
}
