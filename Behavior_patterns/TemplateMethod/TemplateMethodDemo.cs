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
        
        Console.WriteLine("=== Análise do Template Method ===");
        Console.WriteLine("\n🔧 Estrutura do algoritmo (sempre a mesma):");
        Console.WriteLine("   1. Generate Header");
        Console.WriteLine("   2. Collect Data");
        Console.WriteLine("   3. Process Data");
        Console.WriteLine("   4. Format Report");
        Console.WriteLine("   5. Export Report (varia por formato)");
        Console.WriteLine("   6. Generate Footer");
        
        Console.WriteLine("\n✅ Vantagens do Template Method:");
        Console.WriteLine("   • Define esqueleto do algoritmo na classe base");
        Console.WriteLine("   • Subclasses implementam apenas partes específicas");
        Console.WriteLine("   • Elimina duplicação de código");
        Console.WriteLine("   • Garante que algoritmo seja seguido");
        Console.WriteLine("   • Facilita manutenção e extensão");
        
        Console.WriteLine("\n🎯 Métodos do Template Method:");
        Console.WriteLine("   • Template Method: GenerateReport() - não deve ser sobrescrito");
        Console.WriteLine("   • Métodos concretos: têm implementação padrão");
        Console.WriteLine("   • Métodos abstratos: devem ser implementados");
        Console.WriteLine("   • Hook methods: podem ser sobrescritos opcionalmente");
    }
}
