using System;

public class ValidationVisitor : IVisitor
{
    public void Visit(ElementA element)
    {
        Console.WriteLine("🔍 Validating ElementA...");
        Console.WriteLine($"   Content: {element.Content}");
        Console.WriteLine("   ✅ ElementA validation passed");
        element.ProcessSpecificA();
    }
    
    public void Visit(ElementB element)
    {
        Console.WriteLine("🔍 Validating ElementB...");
        Console.WriteLine($"   Content: {element.Content}");
        Console.WriteLine("   ✅ ElementB validation passed");
        element.ProcessSpecificB();
    }
    
    public void Visit(ElementC element)
    {
        Console.WriteLine("🔍 Validating ElementC...");
        Console.WriteLine($"   Content: {element.Content}");
        Console.WriteLine("   ✅ ElementC validation passed");
        element.ProcessSpecificC();
    }
}
