using System;

public abstract class ReportGenerator
{
    public void GenerateReport()
    {
        Console.WriteLine("=== Iniciando geração de relatório ===");
        
        GenerateHeader();
        CollectData();
        ProcessData();
        FormatReport();
        ExportReport(); 
        GenerateFooter();
        
        Console.WriteLine("=== Relatório gerado com sucesso ===\n");
    }
    
    protected virtual void GenerateHeader()
    {
        Console.WriteLine("📋 Generating report header...");
    }
    
    protected virtual void CollectData()
    {
        Console.WriteLine("📊 Collecting data from database...");
    }
    
    protected virtual void ProcessData()
    {
        Console.WriteLine("⚙️  Processing collected data...");
    }
    
    protected virtual void FormatReport()
    {
        Console.WriteLine("🎨 Formatting report layout...");
    }
    
    protected virtual void GenerateFooter()
    {
        Console.WriteLine("📄 Generating report footer...");
    }
    
    protected abstract void ExportReport();
}
