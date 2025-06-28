using System;

public class TransformVisitor : IVisitor
{
    public void Visit(ElementA element)
    {
        Console.WriteLine("🔄 Transforming ElementA...");
        Console.WriteLine($"   Original: {element.Content}");
        element.Content = element.Content.ToUpper();
        Console.WriteLine($"   Transformed: {element.Content}");
    }
    
    public void Visit(ElementB element)
    {
        Console.WriteLine("🔄 Transforming ElementB...");
        Console.WriteLine($"   Original: {element.Content}");
        element.Content = $"[PROCESSED] {element.Content}";
        Console.WriteLine($"   Transformed: {element.Content}");
    }
    
    public void Visit(ElementC element)
    {
        Console.WriteLine("🔄 Transforming ElementC...");
        Console.WriteLine($"   Original: {element.Content}");
        element.Content = element.Content.Replace("Data", "Information");
        Console.WriteLine($"   Transformed: {element.Content}");
    }
}
