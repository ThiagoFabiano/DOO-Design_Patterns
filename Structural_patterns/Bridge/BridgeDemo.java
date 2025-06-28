public class BridgeDemo {
    public static void main(String[] args) {
        System.out.println("=== Demonstração do Padrão Bridge ===");
        
        IColor red = new RedColor();
        IColor blue = new BlueColor();
        
        Shape redCircle = new Circle(red);
        Shape blueCircle = new Circle(blue);
        Shape redSquare = new Square(red);
        Shape blueSquare = new Square(blue);
        
        // Desenhando as formas
        redCircle.Draw();
        blueCircle.Draw();
        redSquare.Draw();
        blueSquare.Draw();
        
        System.out.println("\nDemonstrando flexibilidade - mudando cores:");
        
        Shape[] shapes = {
            new Circle(red),
            new Circle(blue),
            new Square(red),
            new Square(blue)
        };
        
        for (Shape shape : shapes) {
            shape.Draw();
        }
    }
}
