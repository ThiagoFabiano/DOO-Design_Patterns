public class EconomyShipping : IShippingStrategy
{
    public decimal Calculate(decimal orderValue)
    {
        return orderValue * 0.10m; 
    }
    
    public string GetDescription()
    {
        return "Entrega Econômica (7-10 dias úteis)";
    }
}
