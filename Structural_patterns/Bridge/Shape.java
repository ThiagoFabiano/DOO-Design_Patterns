public abstract class Shape {
    protected IColor color;
    
    public Shape(IColor color) {
        this.color = color;
    }
    
    public abstract void Draw();
}
