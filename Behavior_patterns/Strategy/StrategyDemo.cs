using System;

public class StrategyDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Demonstração do Padrão Strategy ===");
        
        decimal orderValue = 100;
        
        Console.WriteLine($"\nCalculando frete para pedido de R$ {orderValue:F2}:\n");
        
        Console.WriteLine("1. Entrega Econômica:");
        var calculator = new ShippingCalculator(new EconomyShipping());
        calculator.Calculate(orderValue);
        
        Console.WriteLine("\n" + new string('-', 50));
        Console.WriteLine("2. Entrega Expressa:");
        calculator.SetStrategy(new ExpressShipping());
        calculator.Calculate(orderValue);
        
        Console.WriteLine("\n" + new string('-', 50));
        Console.WriteLine("3. Entrega Local:");
        calculator.SetStrategy(new LocalShipping());
        calculator.Calculate(orderValue);
        
        Console.WriteLine("\n" + new string('=', 50));
        Console.WriteLine("Testando entrega local com pedido menor:");
        
        decimal smallOrder = 30;
        Console.WriteLine($"\nPedido de R$ {smallOrder:F2} com entrega local:");
        calculator.Calculate(smallOrder);
        
        Console.WriteLine("\n" + new string('=', 50));
        Console.WriteLine("Comparando todas as estratégias:");
        
        var strategies = new IShippingStrategy[]
        {
            new EconomyShipping(),
            new ExpressShipping(),
            new LocalShipping()
        };
        
        orderValue = 80;
        Console.WriteLine($"\nComparando fretes para pedido de R$ {orderValue:F2}:");
        
        foreach (var strategy in strategies)
        {
            calculator.SetStrategy(strategy);
            decimal cost = calculator.Calculate(orderValue);
            Console.WriteLine();
        }
        
    }
}
