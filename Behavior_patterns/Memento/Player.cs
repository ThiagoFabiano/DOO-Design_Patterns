using System;

public class Player
{
    public int Position { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    
    public Player()
    {
        Position = 0;
        Health = 100;
        Level = 1;
    }
    
    // Salva o estado atual
    public PlayerMemento SaveState()
    {
        Console.WriteLine($"💾 Salvando estado: Pos={Position}, HP={Health}, Lvl={Level}");
        return new PlayerMemento(Position, Health, Level);
    }
    
    // Restaura um estado salvo
    public void RestoreState(PlayerMemento memento)
    {
        Position = memento.Position;
        Health = memento.Health;
        Level = memento.Level;
        Console.WriteLine($"📂 Estado restaurado: Pos={Position}, HP={Health}, Lvl={Level}");
    }
    
    // Simula ações do jogo que mudam o estado
    public void Move(int newPosition)
    {
        Position = newPosition;
        Console.WriteLine($"🚶 Jogador moveu para posição {Position}");
    }
    
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
        Console.WriteLine($"💔 Jogador recebeu {damage} de dano. HP atual: {Health}");
    }
    
    public void LevelUp()
    {
        Level++;
        Health = 100; // Recupera HP ao subir de nível
        Console.WriteLine($"⭐ Subiu para o nível {Level}! HP restaurado para {Health}");
    }
    
    public void ShowStatus()
    {
        Console.WriteLine($"📊 Status atual: Posição={Position}, HP={Health}, Nível={Level}");
    }
}
