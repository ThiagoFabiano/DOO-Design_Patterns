public class SensorAAdapter implements ITemperatureSensor {
    private SensorA sensorA;
    
    public SensorAAdapter(SensorA sensorA) {
        this.sensorA = sensorA;
    }
    
    @Override
    public double ReadTemperature() {
        return sensorA.GetTemperatureInCelsius();
    }
}
