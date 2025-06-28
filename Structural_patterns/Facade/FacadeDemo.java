// Demonstração do padrão Facade
public class FacadeDemo {
    public static void main(String[] args) {
        System.out.println("=== Demonstração do Padrão Facade ===");
        
        // Criando todos os subsistemas
        DvdPlayer dvdPlayer = new DvdPlayer();
        Projector projector = new Projector();
        SoundSystem soundSystem = new SoundSystem();
        Lights lights = new Lights();
        
        // Criando o facade
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(
            dvdPlayer, projector, soundSystem, lights
        );
        
        // Usando o facade para controlar todo o sistema facilmente
        homeTheater.PlayMovie("Vingadores: Ultimato");
        
        // Simulando o fim do filme
        try {
            Thread.sleep(2000); // Simula tempo do filme
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        
        homeTheater.EndMovie();
        
        System.out.println("\n\nSem o Facade seria assim:");
        System.out.println("Usuário teria que controlar cada equipamento individualmente:");
        System.out.println("- lights.dim(10)");
        System.out.println("- projector.on()");
        System.out.println("- projector.setInput(\"DVD\")");
        System.out.println("- projector.wideScreenMode()");
        System.out.println("- soundSystem.on()");
        System.out.println("- soundSystem.setSurroundSound()");
        System.out.println("- soundSystem.setVolume(25)");
        System.out.println("- dvdPlayer.on()");
        System.out.println("- dvdPlayer.play(movie)");
        System.out.println("E depois fazer tudo ao contrário para desligar!");
    }
}
