import java.util.ArrayList;
import java.util.List;

public class Menu implements IMenuComponent {
    private String name;
    private List<IMenuComponent> menuComponents;
    
    public Menu(String name) {
        this.name = name;
        this.menuComponents = new ArrayList<>();
    }
    
    @Override
    public void Display() {
        System.out.println("\n" + name + ":");
        System.out.println("------------------------");
        
        for (IMenuComponent component : menuComponents) {
            component.Display();
        }
    }
    
    @Override
    public void Add(IMenuComponent component) {
        menuComponents.add(component);
    }
}
