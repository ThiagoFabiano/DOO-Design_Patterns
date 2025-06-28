using System;

public class ObserverDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Demonstração do Padrão Observer ===");
        
        var order = new Order();
        
        Console.WriteLine("\n1. Criando notificadores:");
        var emailNotifier = new EmailNotifier();
        var smsNotifier = new SmsNotifier();
        var appNotifier = new AppNotifier();
        
        Console.WriteLine("\n2. Registrando observadores:");
        order.Attach(emailNotifier);
        order.Attach(smsNotifier);
        
        Console.WriteLine("\n3. Primeira atualização de status:");
        order.UpdateStatus("Confirmed");
        
        Console.WriteLine("\n4. Adicionando mais um observador:");
        order.Attach(appNotifier);
        
        Console.WriteLine("\n5. Segunda atualização de status:");
        order.UpdateStatus("Shipped");
        
        Console.WriteLine("\n6. Removendo observador de SMS:");
        order.Detach(smsNotifier);
        
        Console.WriteLine("\n7. Terceira atualização de status:");
        order.UpdateStatus("Delivered");
        
        Console.WriteLine("\n8. Status final:");
        Console.WriteLine($"Status atual do pedido: {order.GetStatus()}");
        

    }
}
