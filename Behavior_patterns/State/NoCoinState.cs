using System;

public class NoCoinState : IState
{
    public void InsertCoin(VendingMachine machine)
    {
        Console.WriteLine("💰 Coin inserted.");
        machine.SetState(machine.GetHasCoinState());
    }
    
    public void SelectProduct(VendingMachine machine)
    {
        Console.WriteLine("❌ Please insert a coin first.");
    }
    
    public void DispenseProduct(VendingMachine machine)
    {
        Console.WriteLine("❌ Please insert a coin first.");
    }
}
