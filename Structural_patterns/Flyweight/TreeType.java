public class TreeType {
    private String name;
    private String color;
    private String texture;
    
    public TreeType(String name, String color, String texture) {
        this.name = name;
        this.color = color;
        this.texture = texture;
    }
    
    public void render(int x, int y) {
        System.out.println("Renderizando " + name + " " + color + 
                         " com textura " + texture + 
                         " na posição (" + x + ", " + y + ")");
    }
    
    public String getName() {
        return name;
    }
}
