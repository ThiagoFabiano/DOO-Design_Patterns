public class MenuItem implements IMenuComponent {
    private String name;
    private double price;
    
    public MenuItem(String name, double price) {
        this.name = name;
        this.price = price;
    }
    
    @Override
    public void Display() {
        System.out.println("  " + name + " - R$ " + price);
    }
    
    @Override
    public void Add(IMenuComponent component) {
        // Item individual não pode ter filhos
        System.out.println("Não é possível adicionar itens a um MenuItem individual");
    }
}
