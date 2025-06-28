public class DecoratorDemo {
    public static void main(String[] args) {
        System.out.println("=== Demonstração do Padrão Decorator ===");
        
        String message = "Você tem uma nova mensagem!";
        
        System.out.println("1. Notificação apenas base:");
        INotification basicNotification = new BaseNotification();
        basicNotification.Send(message);
        
        System.out.println("\n2. Notificação com Email:");
        INotification emailNotification = new EmailDecorator(new BaseNotification());
        emailNotification.Send(message);
        
        System.out.println("\n3. Notificação com Email + SMS:");
        INotification emailSmsNotification = new SMSDecorator(
            new EmailDecorator(new BaseNotification())
        );
        emailSmsNotification.Send(message);
        
        System.out.println("\n4. Notificação com Email + SMS + Push:");
        INotification allNotifications = new PushDecorator(
            new SMSDecorator(
                new EmailDecorator(new BaseNotification())
            )
        );
        allNotifications.Send(message);
        
        System.out.println("\n5. Notificação apenas Push + SMS:");
        INotification pushSmsNotification = new SMSDecorator(
            new PushDecorator(new BaseNotification())
        );
        pushSmsNotification.Send(message);
    }
}
