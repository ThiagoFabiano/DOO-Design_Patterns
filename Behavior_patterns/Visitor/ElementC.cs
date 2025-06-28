using System;

public class ElementC : IElement
{
    public string Content { get; set; } = "XML Footer Data";
    
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
    
    public void ProcessSpecificC()
    {
        Console.WriteLine("   Processing specific ElementC functionality");
    }
}
