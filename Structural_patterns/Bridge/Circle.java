public class Circle extends Shape {
    public Circle(IColor color) {
        super(color);
    }
    
    @Override
    public void Draw() {
        System.out.println("Desenhando um círculo " + color.ApplyColor());
    }
}
