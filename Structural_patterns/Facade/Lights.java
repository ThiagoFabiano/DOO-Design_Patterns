// Subsistema: Luzes
public class Lights {
    public void dim(int level) {
        System.out.println("Luzes ajustadas para " + level + "% de intensidade");
    }
    
    public void on() {
        System.out.println("Luzes ligadas");
    }
    
    public void off() {
        System.out.println("Luzes desligadas");
    }
}
