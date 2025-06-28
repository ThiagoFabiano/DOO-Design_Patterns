using System;

public class EmailNotifier : IObserver
{
    public void Update(string orderStatus)
    {
        Console.WriteLine($"📧 Email: Your order is now {orderStatus}.");
    }
}
