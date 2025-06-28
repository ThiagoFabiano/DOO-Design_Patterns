using System;
using System.Collections.Generic;

public class ChatMediator : IMediator
{
    private List<User> users = new List<User>();
    
    public void AddUser(User user)
    {
        users.Add(user);
        Console.WriteLine($"👤 {user.Name} entrou no chat");
    }
    
    public void SendMessage(string message, User sender)
    {
        foreach (User user in users)
        {
            if (user != sender)
            {
                user.Receive(message, sender.Name);
            }
        }
    }
}
