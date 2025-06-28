using System;

public class ElementB : IElement
{
    public string Content { get; set; } = "XML Body Content";
    
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
    
    public void ProcessSpecificB()
    {
        Console.WriteLine("   Processing specific ElementB functionality");
    }
}
