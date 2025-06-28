using System;

public class User
{
    private IMediator mediator;
    public string Name { get; private set; }
    
    public User(string name, IMediator mediator)
    {
        Name = name;
        this.mediator = mediator;
        mediator.AddUser(this);
    }
    
    public void SendMessage(string message)
    {
        Console.WriteLine($"📤 {Name} enviou: {message}");
        mediator.SendMessage(message, this);
    }
    
    public void Receive(string message, string senderName)
    {
        Console.WriteLine($"📨 {Name} recebeu de {senderName}: {message}");
    }
}
