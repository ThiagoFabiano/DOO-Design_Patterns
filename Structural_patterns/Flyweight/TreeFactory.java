import java.util.HashMap;
import java.util.Map;

public class TreeFactory {
    private static Map<String, TreeType> treeTypes = new HashMap<>();
    
    public static TreeType getTreeType(String name, String color, String texture) {
        String key = name + "-" + color + "-" + texture;
        
        TreeType treeType = treeTypes.get(key);
        if (treeType == null) {
            System.out.println("Criando novo TreeType: " + key);
            treeType = new TreeType(name, color, texture);
            treeTypes.put(key, treeType);
        } else {
            System.out.println("Reutilizando TreeType existente: " + key);
        }
        
        return treeType;
    }
    
    public static int getCreatedTreeTypesCount() {
        return treeTypes.size();
    }
    
    public static void printTreeTypesInfo() {
        System.out.println("\nTipos de árvore criados:");
        for (String key : treeTypes.keySet()) {
            System.out.println("- " + key);
        }
        System.out.println("Total de tipos únicos: " + treeTypes.size());
    }
}
