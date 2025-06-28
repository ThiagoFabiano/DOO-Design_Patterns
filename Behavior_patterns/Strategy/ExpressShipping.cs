public class ExpressShipping : IShippingStrategy
{
    public decimal Calculate(decimal orderValue)
    {
        return orderValue * 0.25m; 
    }
    
    public string GetDescription()
    {
        return "Entrega Expressa (1-2 dias úteis)";
    }
}
