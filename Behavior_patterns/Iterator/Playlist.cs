using System;
using System.Collections;
using System.Collections.Generic;

public class Playlist : IEnumerable<string>
{
    private List<string> songs = new List<string>();
    private bool randomOrder = false;
    
    public void Add(string song)
    {
        songs.Add(song);
        Console.WriteLine($"Música adicionada: {song}");
    }
    
    public void SetRandomOrder(bool random)
    {
        randomOrder = random;
        Console.WriteLine($"Modo aleatório: {(random ? "Ativado" : "Desativado")}");
    }
    
    public IEnumerator<string> GetEnumerator()
    {
        if (randomOrder)
        {
            return new RandomPlaylistIterator(songs);
        }
        else
        {
            return new OrderedPlaylistIterator(songs);
        }
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    public int Count => songs.Count;
}
