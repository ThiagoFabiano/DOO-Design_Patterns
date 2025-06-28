public class SensorCAdapter implements ITemperatureSensor {
    private SensorC sensorC;
    
    public SensorCAdapter(SensorC sensorC) {
        this.sensorC = sensorC;
    }
    
    @Override
    public double ReadTemperature() {
        return sensorC.FetchTempC();
    }
}
