public interface IShippingStrategy
{
    decimal Calculate(decimal orderValue);
    string GetDescription();
}
