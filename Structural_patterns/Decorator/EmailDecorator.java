public class EmailDecorator extends NotificationDecorator {
    public EmailDecorator(INotification notification) {
        super(notification);
    }
    
    @Override
    public void Send(String message) {
        super.Send(message);
        sendEmail(message);
    }
    
    private void sendEmail(String message) {
        System.out.println("📧 Enviando por EMAIL: " + message);
    }
}
