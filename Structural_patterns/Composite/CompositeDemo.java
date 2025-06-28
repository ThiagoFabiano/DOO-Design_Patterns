public class CompositeDemo {
    public static void main(String[] args) {
        System.out.println("=== Demonstração do Padrão Composite ===");
        
        Menu menuPrincipal = new Menu("MENU DO RESTAURANTE");
        
        Menu menuEntradas = new Menu("ENTRADAS");
        menuEntradas.Add(new MenuItem("Salada Caesar", 15.90));
        menuEntradas.Add(new MenuItem("Bruschetta", 12.50));
        menuEntradas.Add(new MenuItem("Sopa do Dia", 8.90));
        
        Menu menuPratosPrincipais = new Menu("PRATOS PRINCIPAIS");
        menuPratosPrincipais.Add(new MenuItem("Filé à Parmegiana", 35.90));
        menuPratosPrincipais.Add(new MenuItem("Salmão Grelhado", 42.90));
        menuPratosPrincipais.Add(new MenuItem("Risotto de Camarão", 38.50));
        
        Menu menuSobremesas = new Menu("SOBREMESAS");
        menuSobremesas.Add(new MenuItem("Tiramisu", 14.90));
        menuSobremesas.Add(new MenuItem("Petit Gateau", 16.90));
        menuSobremesas.Add(new MenuItem("Sorvete", 8.90));
        
        Menu menuEspecial = new Menu("MENU ESPECIAL DO DIA");
        menuEspecial.Add(new MenuItem("Entrada Especial", 18.90));
        menuEspecial.Add(new MenuItem("Prato Principal Especial", 45.90));
        menuEspecial.Add(new MenuItem("Sobremesa Especial", 12.90));
        
        menuPrincipal.Add(menuEntradas);
        menuPrincipal.Add(menuPratosPrincipais);
        menuPrincipal.Add(menuSobremesas);
        menuPrincipal.Add(menuEspecial);
        
        menuPrincipal.Display();
        
        System.out.println("\n\nExibindo apenas o submenu de entradas:");
        menuEntradas.Display();
    }
}
