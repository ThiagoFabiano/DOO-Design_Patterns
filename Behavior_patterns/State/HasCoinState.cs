using System;

public class HasCoinState : IState
{
    public void InsertCoin(VendingMachine machine)
    {
        Console.WriteLine("💰 Coin already inserted.");
    }
    
    public void SelectProduct(VendingMachine machine)
    {
        Console.WriteLine("🛒 Product selected.");
        machine.SetState(machine.GetSoldState());
    }
    
    public void DispenseProduct(VendingMachine machine)
    {
        Console.WriteLine("❌ Please select a product first.");
    }
}
