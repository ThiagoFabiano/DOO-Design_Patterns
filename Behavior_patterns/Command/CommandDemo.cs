using System;

public class CommandDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Demonstração do Padrão Command ===");
        
        var editor = new TextEditor();
        var commandManager = new CommandManager();
        
        Console.WriteLine("\n1. Executando comandos:");
        commandManager.ExecuteCommand(new WriteTextCommand(editor, "Hello, "));
        commandManager.ExecuteCommand(new WriteTextCommand(editor, "world!"));
        commandManager.ExecuteCommand(new WriteTextCommand(editor, " How are you?"));
        
        Console.WriteLine("\n2. Desfazendo comandos:");
        commandManager.Undo();
        commandManager.Undo();
        
        Console.WriteLine("\n3. Refazendo um comando:");
        commandManager.Redo();
        
        Console.WriteLine("\n4. Testando comando de deletar:");
        commandManager.ExecuteCommand(new DeleteTextCommand(editor, 5));
        
        Console.WriteLine("\n5. Desfazendo delete:");
        commandManager.Undo();
        
        Console.WriteLine("\n6. Tentando desfazer além do limite:");
        commandManager.Undo();
        commandManager.Undo();
        commandManager.Undo();
        commandManager.Undo(); 
        
        Console.WriteLine("\n=== Vantagens do Command Pattern ===");
        Console.WriteLine("✅ Histórico completo de operações");
        Console.WriteLine("✅ Undo/Redo ilimitado");
        Console.WriteLine("✅ Comandos podem ser salvos, enviados por rede, etc.");
        Console.WriteLine("✅ Facilita implementação de macros");
    }
}
