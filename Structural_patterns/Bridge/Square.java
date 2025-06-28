public class Square extends Shape {
    public Square(IColor color) {
        super(color);
    }
    
    @Override
    public void Draw() {
        System.out.println("Desenhando um quadrado " + color.ApplyColor());
    }
}
