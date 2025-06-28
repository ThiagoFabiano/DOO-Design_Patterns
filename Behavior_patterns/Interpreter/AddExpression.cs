public class AddExpression : IExpression
{
    private IExpression left;
    private IExpression right;
    
    public AddExpression(IExpression left, IExpression right)
    {
        this.left = left;
        this.right = right;
    }
    
    public int Interpret()
    {
        return left.Interpret() + right.Interpret();
    }
}
