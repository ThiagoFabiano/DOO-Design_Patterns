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
        vendingMachine.SelectProduct(); // Erro: sem moeda
        vendingMachine.DispenseProduct(); // Erro: sem moeda
        
        Console.WriteLine("\n3. Inserindo moeda e tentando inserir outra:");
        vendingMachine.InsertCoin();
        vendingMachine.InsertCoin(); // Erro: já tem moeda
        
        Console.WriteLine("\n4. Selecionando produto e tentando dispensar sem selecionar:");
        vendingMachine.SelectProduct();
        vendingMachine.InsertCoin(); // Erro: já em processo de venda
        
        Console.WriteLine("\n5. Finalizando a compra:");
        vendingMachine.DispenseProduct();
        
        Console.WriteLine("\n6. Nova compra completa:");
        vendingMachine.InsertCoin();
        vendingMachine.SelectProduct();
        vendingMachine.DispenseProduct();
        
        Console.WriteLine("\n=== Vantagens do State Pattern ===");
        Console.WriteLine("✅ Elimina condicionais complexas (if/switch)");
        Console.WriteLine("✅ Comportamento muda conforme estado interno");
        Console.WriteLine("✅ Facilita adicionar novos estados");
        Console.WriteLine("✅ Estados bem definidos e encapsulados");
        Console.WriteLine("✅ Usado em máquinas de estado, jogos, workflows");
        
        Console.WriteLine("\n=== Estados da máquina ===");
        Console.WriteLine("🔴 NoCoinState: Aguardando moeda");
        Console.WriteLine("🟡 HasCoinState: Moeda inserida, aguardando seleção");
        Console.WriteLine("🟢 SoldState: Produto vendido, dispensando");
    }
}
