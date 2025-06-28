using System.Collections.Generic;
using System;

public class Caretaker
{
    private List<PlayerMemento> savedStates = new List<PlayerMemento>();
    
    public void Save(PlayerMemento memento)
    {
        savedStates.Add(memento);
        Console.WriteLine($"💾 Estado salvo! Total de saves: {savedStates.Count}");
    }
    
    public void Restore(Player player, int saveIndex = -1)
    {
        if (savedStates.Count == 0)
        {
            Console.WriteLine("❌ Nenhum estado salvo encontrado!");
            return;
        }
        

        if (saveIndex == -1)
        {
            saveIndex = savedStates.Count - 1;
        }
        
        if (saveIndex >= 0 && saveIndex < savedStates.Count)
        {
            PlayerMemento memento = savedStates[saveIndex];
            player.RestoreState(memento);
            Console.WriteLine($"📂 Carregado save #{saveIndex + 1}");
        }
        else
        {
            Console.WriteLine("❌ Índice de save inválido!");
        }
    }
    
    public void ListSaves()
    {
        Console.WriteLine($"\n📋 Saves disponíveis ({savedStates.Count}):");
        for (int i = 0; i < savedStates.Count; i++)
        {
            var save = savedStates[i];
            Console.WriteLine($"  Save #{i + 1}: Pos={save.Position}, HP={save.Health}, Lvl={save.Level}");
        }
    }
    
    public int GetSaveCount()
    {
        return savedStates.Count;
    }
}
