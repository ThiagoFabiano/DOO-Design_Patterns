public class DeleteTextCommand : ICommand
{
    private TextEditor editor;
    private int length;
    private string previousContent;
    
    public DeleteTextCommand(TextEditor editor, int length)
    {
        this.editor = editor;
        this.length = length;
    }
    
    public void Execute()
    {
        previousContent = editor.GetContent();
        editor.DeleteText(length);
    }
    
    public void Undo()
    {
        editor.SetContent(previousContent);
        System.Console.WriteLine($"Texto atual: \"{editor.GetContent()}\"");
    }
}
