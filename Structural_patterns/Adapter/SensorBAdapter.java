public class SensorBAdapter implements ITemperatureSensor {
    private SensorB sensorB;
    
    public SensorBAdapter(SensorB sensorB) {
        this.sensorB = sensorB;
    }
    
    @Override
    public double ReadTemperature() {
        return sensorB.ObtenerTemperaturaEnCentigrados();
    }
}
