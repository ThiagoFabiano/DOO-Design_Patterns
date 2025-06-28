using System;

public class ElementA : IElement
{
    public string Content { get; set; } = "XML Header Data";
    
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
    
    public void ProcessSpecificA()
    {
        Console.WriteLine("   Processing specific ElementA functionality");
    }
}
