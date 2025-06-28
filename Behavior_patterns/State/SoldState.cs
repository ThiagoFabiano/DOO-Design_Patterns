using System;

public class SoldState : IState
{
    public void InsertCoin(VendingMachine machine)
    {
        Console.WriteLine("❌ Please wait, dispensing product.");
    }
    
    public void SelectProduct(VendingMachine machine)
    {
        Console.WriteLine("❌ Product already selected.");
    }
    
    public void DispenseProduct(VendingMachine machine)
    {
        Console.WriteLine("📦 Product dispensed.");
        machine.SetState(machine.GetNoCoinState());
    }
}
