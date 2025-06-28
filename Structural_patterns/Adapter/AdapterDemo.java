public class AdapterDemo {
    public static void main(String[] args) {
        System.out.println("=== Demonstração do Padrão Adapter ===");
        
        SensorA sensorA = new SensorA();
        SensorB sensorB = new SensorB();
        SensorC sensorC = new SensorC();
        
        ITemperatureSensor adapterA = new SensorAAdapter(sensorA);
        ITemperatureSensor adapterB = new SensorBAdapter(sensorB);
        ITemperatureSensor adapterC = new SensorCAdapter(sensorC);
        
        System.out.println("Temperatura do Sensor A: " + adapterA.ReadTemperature() + "°C");
        System.out.println("Temperatura do Sensor B: " + adapterB.ReadTemperature() + "°C");
        System.out.println("Temperatura do Sensor C: " + adapterC.ReadTemperature() + "°C");
        
        ITemperatureSensor[] sensores = {adapterA, adapterB, adapterC};
        
        System.out.println("\nProcessando todos os sensores de forma uniforme:");
        for (int i = 0; i < sensores.length; i++) {
            System.out.println("Sensor " + (i+1) + ": " + sensores[i].ReadTemperature() + "°C");
        }
    }
}
