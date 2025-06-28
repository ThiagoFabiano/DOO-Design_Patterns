using System;

public class AppNotifier : IObserver
{
    public void Update(string orderStatus)
    {
        Console.WriteLine($"📱 App: Your order is now {orderStatus}.");
    }
}
