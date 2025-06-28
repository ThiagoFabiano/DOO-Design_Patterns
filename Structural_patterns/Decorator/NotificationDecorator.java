public abstract class NotificationDecorator implements INotification {
    protected INotification notification;
    
    public NotificationDecorator(INotification notification) {
        this.notification = notification;
    }
    
    @Override
    public void Send(String message) {
        notification.Send(message);
    }
}
