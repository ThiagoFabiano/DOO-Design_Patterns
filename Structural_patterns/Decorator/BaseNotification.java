public class BaseNotification implements INotification {
    @Override
    public void Send(String message) {
        System.out.println("Notificação base: " + message);
    }
}
