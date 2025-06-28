public class NumberExpression : IExpression
{
    private int number;
    
    public NumberExpression(int number)
    {
        this.number = number;
    }
    
    public int Interpret()
    {
        return number;
    }
}
