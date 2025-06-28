using System;

public class StateDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Demonstração do Padrão State ===");
        
        var vendingMachine = new VendingMachine();
        
        Console.WriteLine("\n1. Fluxo normal de compra:");
        vendingMachine.InsertCoin();
        vendingMachine.SelectProduct();
        vendingMachine.DispenseProduct();
        
        Console.WriteLine("\n2. Tentando ações inválidas (sem moeda):");
        Console.WriteLine($"Estado atual: {vendingMachine.GetCurrentStateName()}");
        vendingMachine.SelectProduct(); 
        vendingMachine.DispenseProduct(); 
        
        Console.WriteLine("\n3. Inserindo moeda e tentando inserir outra:");
        vendingMachine.InsertCoin();
        vendingMachine.InsertCoin(); 
        
        Console.WriteLine("\n4. Selecionando produto e tentando dispensar sem selecionar:");
        vendingMachine.SelectProduct();
        vendingMachine.InsertCoin(); 
        
        Console.WriteLine("\n5. Finalizando a compra:");
        vendingMachine.DispenseProduct();
        
        Console.WriteLine("\n6. Nova compra completa:");
        vendingMachine.InsertCoin();
        vendingMachine.SelectProduct();
        vendingMachine.DispenseProduct();
        

    }
}
