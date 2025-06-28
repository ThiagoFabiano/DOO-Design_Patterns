import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class FlyweightDemo {
    public static void main(String[] args) {
        System.out.println("=== Demonstração do Padrão Flyweight ===");
        
        List<Tree> forest = new ArrayList<>();
        Random random = new Random();
        
        System.out.println("Criando floresta com 20 árvores...\n");
        
        String[] treeNames = {"Carvalho", "Pinheiro", "Eucalipto"};
        String[] colors = {"Verde", "Verde-escuro"};
        String[] textures = {"Lisa", "Rugosa"};
        
        for (int i = 0; i < 20; i++) {
            int x = random.nextInt(100);
            int y = random.nextInt(100);
            
            String name = treeNames[random.nextInt(treeNames.length)];
            String color = colors[random.nextInt(colors.length)];
            String texture = textures[random.nextInt(textures.length)];
            
            TreeType treeType = TreeFactory.getTreeType(name, color, texture);
            
            Tree tree = new Tree(x, y, treeType);
            forest.add(tree);
        }
        
        System.out.println("\n=== Informações da Floresta ===");
        TreeFactory.printTreeTypesInfo();
        
        System.out.println("\nTotal de árvores na floresta: " + forest.size());
        System.out.println("Tipos únicos de árvore: " + TreeFactory.getCreatedTreeTypesCount());
        
        System.out.println("\n=== Renderizando algumas árvores ===");
        for (int i = 0; i < 5; i++) {
            forest.get(i).render();
        }
        
        System.out.println("\n=== Análise de Memória ===");
        System.out.println("Sem Flyweight: Cada árvore teria sua própria cópia de TreeType");
        System.out.println("Isso resultaria em " + forest.size() + " objetos TreeType");
        System.out.println("Com Flyweight: Apenas " + TreeFactory.getCreatedTreeTypesCount() + 
                         " objetos TreeType são criados e reutilizados!");
        System.out.println("Economia de memória: " + 
                         (forest.size() - TreeFactory.getCreatedTreeTypesCount()) + " objetos!");
    }
}
