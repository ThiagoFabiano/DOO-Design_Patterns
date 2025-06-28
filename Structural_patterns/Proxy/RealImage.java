public class RealImage implements IImage {
    private String filename;
    
    public RealImage(String filename) {
        this.filename = filename;
        loadImageFromDisk();
    }
    
    private void loadImageFromDisk() {
        System.out.println("🔄 Carregando imagem de alta resolução: " + filename);
        // Simula o tempo de carregamento de uma imagem pesada
        try {
            Thread.sleep(2000); // Simula 2 segundos de carregamento
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        System.out.println("✅ Imagem " + filename + " carregada com sucesso!");
    }
    
    @Override
    public void Display() {
        System.out.println("🖼️  Exibindo imagem: " + filename);
    }
}
