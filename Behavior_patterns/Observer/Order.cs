using System;
using System.Collections.Generic;

public class Order
{
    private List<IObserver> observers = new List<IObserver>();
    private string status = "Pending";
    
    public void Attach(IObserver observer)
    {
        observers.Add(observer);
        Console.WriteLine($"👥 Observador adicionado. Total: {observers.Count}");
    }
    
    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
        Console.WriteLine($"👥 Observador removido. Total: {observers.Count}");
    }
    
    public void UpdateStatus(string newStatus)
    {
        Console.WriteLine($"\n📦 Atualizando status do pedido: {status} → {newStatus}");
        status = newStatus;
        NotifyObservers();
    }
    
    private void NotifyObservers()
    {
        Console.WriteLine("📢 Notificando todos os observadores:");
        foreach (IObserver observer in observers)
        {
            observer.Update(status);
        }
    }
    
    public string GetStatus()
    {
        return status;
    }
}
