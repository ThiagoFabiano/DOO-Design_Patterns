public interface IMediator
{
    void SendMessage(string message, User user);
    void AddUser(User user);
}
