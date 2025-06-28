using System;

public class ExportVisitor : IVisitor
{
    public void Visit(ElementA element)
    {
        Console.WriteLine("📤 Exporting ElementA...");
        Console.WriteLine($"   Exporting: {element.Content}");
        Console.WriteLine("   📄 ElementA exported to file");
    }
    
    public void Visit(ElementB element)
    {
        Console.WriteLine("📤 Exporting ElementB...");
        Console.WriteLine($"   Exporting: {element.Content}");
        Console.WriteLine("   📄 ElementB exported to file");
    }
    
    public void Visit(ElementC element)
    {
        Console.WriteLine("📤 Exporting ElementC...");
        Console.WriteLine($"   Exporting: {element.Content}");
        Console.WriteLine("   📄 ElementC exported to file");
    }
}
