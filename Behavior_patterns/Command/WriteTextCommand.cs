public class WriteTextCommand : ICommand
{
    private TextEditor editor;
    private string text;
    private string previousContent;
    
    public WriteTextCommand(TextEditor editor, string text)
    {
        this.editor = editor;
        this.text = text;
    }
    
    public void Execute()
    {
        previousContent = editor.GetContent();
        editor.WriteText(text);
    }
    
    public void Undo()
    {
        editor.SetContent(previousContent);
        System.Console.WriteLine($"Texto atual: \"{editor.GetContent()}\"");
    }
}
