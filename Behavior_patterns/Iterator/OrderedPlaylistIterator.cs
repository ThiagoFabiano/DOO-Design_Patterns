using System.Collections;
using System.Collections.Generic;

public class OrderedPlaylistIterator : IEnumerator<string>
{
    private List<string> songs;
    private int currentIndex = -1;
    
    public OrderedPlaylistIterator(List<string> songs)
    {
        this.songs = new List<string>(songs); // Cópia para segurança
    }
    
    public string Current { get; private set; }
    
    object IEnumerator.Current => Current;
    
    public bool MoveNext()
    {
        currentIndex++;
        if (currentIndex < songs.Count)
        {
            Current = songs[currentIndex];
            return true;
        }
        return false;
    }
    
    public void Reset()
    {
        currentIndex = -1;
    }
    
    public void Dispose()
    {
        
    }
}
