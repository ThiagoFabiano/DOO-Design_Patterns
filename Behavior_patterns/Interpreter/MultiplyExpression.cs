public class MultiplyExpression : IExpression
{
    private IExpression left;
    private IExpression right;
    
    public MultiplyExpression(IExpression left, IExpression right)
    {
        this.left = left;
        this.right = right;
    }
    
    public int Interpret()
    {
        return left.Interpret() * right.Interpret();
    }
}
