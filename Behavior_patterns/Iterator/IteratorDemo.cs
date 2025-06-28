using System;

public class IteratorDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Demonstração do Padrão Iterator ===");
        
        var playlist = new Playlist();
        
        Console.WriteLine("\n1. Adicionando músicas à playlist:");
        playlist.Add("Song 1 - Rock Anthem");
        playlist.Add("Song 2 - Jazz Ballad");
        playlist.Add("Song 3 - Pop Hit");
        playlist.Add("Song 4 - Classical Piece");
        playlist.Add("Song 5 - Electronic Beat");
        
        Console.WriteLine("\n2. Reproduzindo em ordem normal:");
        playlist.SetRandomOrder(false);
        foreach (var song in playlist)
        {
            Console.WriteLine($"🎵 Tocando: {song}");
        }
        
        Console.WriteLine("\n3. Reproduzindo em ordem aleatória:");
        playlist.SetRandomOrder(true);
        foreach (var song in playlist)
        {
            Console.WriteLine($"🔀 Tocando: {song}");
        }
        
        Console.WriteLine("\n4. Segunda reprodução aleatória (ordem diferente):");
        foreach (var song in playlist)
        {
            Console.WriteLine($"🔀 Tocando: {song}");
        }
        
        Console.WriteLine("\n5. Voltando para ordem normal:");
        playlist.SetRandomOrder(false);
        foreach (var song in playlist)
        {
            Console.WriteLine($"🎵 Tocando: {song}");
        }
        
        Console.WriteLine($"\nTotal de músicas na playlist: {playlist.Count}");
        

    }
}
