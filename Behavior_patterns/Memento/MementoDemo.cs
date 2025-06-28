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
        

        caretaker.Save(player.SaveState());
        
        Console.WriteLine("\n3. Continuando o jogo:");
        player.Move(10);
        player.LevelUp();
        
        caretaker.Save(player.SaveState());
        
        Console.WriteLine("\n4. Mais progressão:");
        player.Move(15);
        player.TakeDamage(50);
        player.TakeDamage(30);
        
        Console.WriteLine("\n5. Situação atual (jogador quase morto):");
        player.ShowStatus();
        
        caretaker.Save(player.SaveState());
        
        caretaker.ListSaves();
        
        Console.WriteLine("\n6. Restaurando save anterior (melhor situação):");
        caretaker.Restore(player, 1); 
        
        Console.WriteLine("\n7. Testando restore do último save:");
        caretaker.Restore(player); 
        
        Console.WriteLine("\n8. Voltando para o primeiro save:");
        caretaker.Restore(player, 0);
        

    }
}
