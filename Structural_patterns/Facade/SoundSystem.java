// Subsistema: Sistema de Som
public class SoundSystem {
    public void on() {
        System.out.println("Sistema de som ligado");
    }
    
    public void setVolume(int volume) {
        System.out.println("Volume do sistema de som ajustado para: " + volume);
    }
    
    public void setSurroundSound() {
        System.out.println("Som surround ativado");
    }
    
    public void off() {
        System.out.println("Sistema de som desligado");
    }
}
