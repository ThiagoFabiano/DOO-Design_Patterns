using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class RandomPlaylistIterator : IEnumerator<string>
{
    private List<string> shuffledSongs;
    private int currentIndex = -1;
    
    public RandomPlaylistIterator(List<string> songs)
    {
        shuffledSongs = new List<string>(songs);
        Shuffle();
    }
    
    public string Current { get; private set; }
    
    object IEnumerator.Current => Current;
    
    private void Shuffle()
    {
        Random random = new Random();
        for (int i = shuffledSongs.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            string temp = shuffledSongs[i];
            shuffledSongs[i] = shuffledSongs[j];
            shuffledSongs[j] = temp;
        }
    }
    
    public bool MoveNext()
    {
        currentIndex++;
        if (currentIndex < shuffledSongs.Count)
        {
            Current = shuffledSongs[currentIndex];
            return true;
        }
        return false;
    }
    
    public void Reset()
    {
        currentIndex = -1;
        Shuffle(); 
    }
    
    public void Dispose()
    {
        
    }
}
