public class ProxyDemo {
    public static void main(String[] args) {
        System.out.println("=== Demonstração do Padrão Proxy ===");
        
        System.out.println("1. Criando proxies de imagens (sem carregar ainda):");
        IImage image1 = new ProxyImage("foto_vacacao_4K.jpg");
        IImage image2 = new ProxyImage("wallpaper_8K.jpg");
        IImage image3 = new ProxyImage("poster_filme_HD.jpg");
        
        System.out.println("\n2. Primeira exibição das imagens (carregamento sob demanda):");
        
        System.out.println("\n--- Exibindo primeira imagem ---");
        image1.Display();
        
        System.out.println("\n--- Exibindo segunda imagem ---");
        image2.Display();
        
        System.out.println("\n3. Segunda exibição das mesmas imagens (já carregadas):");
        
        System.out.println("\n--- Exibindo primeira imagem novamente ---");
        image1.Display();
        
        System.out.println("\n--- Exibindo segunda imagem novamente ---");
        image2.Display();
        
        System.out.println("\n4. Exibindo terceira imagem pela primeira vez:");
        image3.Display();
        
        System.out.println("\n=== Vantagens do Proxy ===");
        System.out.println("✅ Economia de memória: Imagens só são carregadas quando necessário");
        System.out.println("✅ Melhora na performance inicial: Aplicação inicia mais rápido");
        System.out.println("✅ Cache automático: Imagens já carregadas são reutilizadas");
        System.out.println("✅ Controle de acesso: Proxy pode adicionar validações de segurança");
    }
}
