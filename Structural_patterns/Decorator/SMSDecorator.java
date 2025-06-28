public class SMSDecorator extends NotificationDecorator {
    public SMSDecorator(INotification notification) {
        super(notification);
    }
    
    @Override
    public void Send(String message) {
        super.Send(message);
        sendSMS(message);
    }
    
    private void sendSMS(String message) {
        System.out.println("📱 Enviando por SMS: " + message);
    }
}
