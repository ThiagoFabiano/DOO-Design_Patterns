public class HomeTheaterFacade {
    private DvdPlayer dvdPlayer;
    private Projector projector;
    private SoundSystem soundSystem;
    private Lights lights;
    
    public HomeTheaterFacade(DvdPlayer dvdPlayer, Projector projector, 
                           SoundSystem soundSystem, Lights lights) {
        this.dvdPlayer = dvdPlayer;
        this.projector = projector;
        this.soundSystem = soundSystem;
        this.lights = lights;
    }
    
    public void PlayMovie(String movie) {
        System.out.println("Preparando para assistir " + movie + "...");
        System.out.println("=======================================");
        
        lights.dim(10);
        projector.on();
        projector.setInput("DVD");
        projector.wideScreenMode();
        soundSystem.on();
        soundSystem.setSurroundSound();
        soundSystem.setVolume(25);
        dvdPlayer.on();
        dvdPlayer.play(movie);
        
        System.out.println("=======================================");
        System.out.println("Aproveite o filme!");
    }
    
    public void EndMovie() {
        System.out.println("\nFinalizando sessão de cinema...");
        System.out.println("=======================================");
        
        dvdPlayer.stop();
        dvdPlayer.off();
        soundSystem.off();
        projector.off();
        lights.on();
        
        System.out.println("=======================================");
        System.out.println("Sistema de home theater desligado!");
    }
}
