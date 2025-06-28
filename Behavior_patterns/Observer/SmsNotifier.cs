using System;

public class SmsNotifier : IObserver
{
    public void Update(string orderStatus)
    {
        Console.WriteLine($"📱 SMS: Your order is now {orderStatus}.");
    }
}
