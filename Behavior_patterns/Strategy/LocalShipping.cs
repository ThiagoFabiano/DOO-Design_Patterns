public class LocalShipping : IShippingStrategy
{
    public decimal Calculate(decimal orderValue)
    {
        return orderValue > 50 ? 0 : 5;
    }
    
    public string GetDescription()
    {
        return "Entrega Local (mesmo dia)";
    }
}
