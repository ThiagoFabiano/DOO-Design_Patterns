using System;

public class MementoDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Demonstração do Padrão Memento ===");
        
        var player = new Player();
        var caretaker = new Caretaker();
        
        Console.WriteLine("\n1. Estado inicial do jogador:");
        player.ShowStatus();
        
        Console.WriteLine("\n2. Progredindo no jogo:");
        player.Move(5);
        player.TakeDamage(20);
        
        // Primeiro save
        caretaker.Save(player.SaveState());
        
        Console.WriteLine("\n3. Continuando o jogo:");
        player.Move(10);
        player.LevelUp();
        
        // Segundo save
        caretaker.Save(player.SaveState());
        
        Console.WriteLine("\n4. Mais progressão:");
        player.Move(15);
        player.TakeDamage(50);
        player.TakeDamage(30);
        
        Console.WriteLine("\n5. Situação atual (jogador quase morto):");
        player.ShowStatus();
        
        // Terceiro save (situação ruim)
        caretaker.Save(player.SaveState());
        
        caretaker.ListSaves();
        
        Console.WriteLine("\n6. Restaurando save anterior (melhor situação):");
        caretaker.Restore(player, 1); // Restaura o segundo save
        
        Console.WriteLine("\n7. Testando restore do último save:");
        caretaker.Restore(player); // Último save por padrão
        
        Console.WriteLine("\n8. Voltando para o primeiro save:");
        caretaker.Restore(player, 0);
        
        Console.WriteLine("\n=== Vantagens do Memento Pattern ===");
        Console.WriteLine("✅ Sistema de save/load completo");
        Console.WriteLine("✅ Múltiplos pontos de restore");
        Console.WriteLine("✅ Estado interno protegido");
        Console.WriteLine("✅ Facilita implementar Undo/Redo");
        Console.WriteLine("✅ Usado em editores, jogos, etc.");
    }
}
