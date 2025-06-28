public class PushDecorator extends NotificationDecorator {
    public PushDecorator(INotification notification) {
        super(notification);
    }
    
    @Override
    public void Send(String message) {
        super.Send(message);
        sendPushNotification(message);
    }
    
    private void sendPushNotification(String message) {
        System.out.println("🔔 Enviando PUSH NOTIFICATION: " + message);
    }
}
