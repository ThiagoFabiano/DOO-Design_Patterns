public class ProxyImage implements IImage {
    private String filename;
    private RealImage realImage;
    
    public ProxyImage(String filename) {
        this.filename = filename;
        System.out.println("📋 Proxy criado para: " + filename + " (imagem não carregada ainda)");
    }
    
    @Override
    public void Display() {
        // Lazy loading - só carrega a imagem quando necessário
        if (realImage == null) {
            System.out.println("⏳ Primeira exibição - carregando imagem real...");
            realImage = new RealImage(filename);
        } else {
            System.out.println("⚡ Imagem já carregada - exibindo diretamente");
        }
        
        realImage.Display();
    }
}
