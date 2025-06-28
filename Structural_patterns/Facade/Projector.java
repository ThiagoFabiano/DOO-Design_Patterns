// Subsistema: Projetor
public class Projector {
    public void on() {
        System.out.println("Projetor ligado");
    }
    
    public void setInput(String input) {
        System.out.println("Projetor entrada configurada para: " + input);
    }
    
    public void wideScreenMode() {
        System.out.println("Projetor configurado para modo widescreen");
    }
    
    public void off() {
        System.out.println("Projetor desligado");
    }
}
