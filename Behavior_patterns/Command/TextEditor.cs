using System;

public class TextEditor
{
    private string content = "";
    
    public void WriteText(string text)
    {
        content += text;
        Console.WriteLine($"Texto atual: \"{content}\"");
    }
    
    public void DeleteText(int length)
    {
        if (length > content.Length)
            length = content.Length;
            
        content = content.Substring(0, content.Length - length);
        Console.WriteLine($"Texto atual: \"{content}\"");
    }
    
    public string GetContent()
    {
        return content;
    }
    
    public void SetContent(string newContent)
    {
        content = newContent;
    }
}
