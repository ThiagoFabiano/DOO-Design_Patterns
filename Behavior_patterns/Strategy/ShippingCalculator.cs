using System;

public class ShippingCalculator
{
    private IShippingStrategy strategy;
    
    public ShippingCalculator(IShippingStrategy strategy)
    {
        this.strategy = strategy;
    }
    
    public void SetStrategy(IShippingStrategy newStrategy)
    {
        strategy = newStrategy;
        Console.WriteLine($"🔄 Estratégia alterada para: {strategy.GetDescription()}");
    }
    
    public decimal Calculate(decimal orderValue)
    {
        decimal shippingCost = strategy.Calculate(orderValue);
        Console.WriteLine($"📦 {strategy.GetDescription()}");
        Console.WriteLine($"💰 Valor do pedido: R$ {orderValue:F2}");
        Console.WriteLine($"🚚 Custo do frete: R$ {shippingCost:F2}");
        Console.WriteLine($"💵 Total: R$ {(orderValue + shippingCost):F2}");
        
        return shippingCost;
    }
}
