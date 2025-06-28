public class PlayerMemento
{
    public int Position { get; private set; }
    public int Health { get; private set; }
    public int Level { get; private set; }
    
    public PlayerMemento(int position, int health, int level)
    {
        Position = position;
        Health = health;
        Level = level;
    }
}
