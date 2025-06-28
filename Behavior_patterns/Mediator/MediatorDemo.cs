using System;

public class MediatorDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Demonstração do Padrão Mediator ===");
        
        var mediator = new ChatMediator();
        
        Console.WriteLine("\n1. Usuários entrando no chat:");
        var alice = new User("Alice", mediator);
        var bob = new User("Bob", mediator);
        var charlie = new User("Charlie", mediator);
        
        Console.WriteLine("\n2. Conversação no chat:");
        alice.SendMessage("Olá pessoal!");
        bob.SendMessage("Oi Alice! Como você está?");
        charlie.SendMessage("Olá galera! Que bom ver vocês aqui!");
        alice.SendMessage("Estou bem, obrigada Bob!");
        
        Console.WriteLine("\n3. Mais usuários entrando:");
        var diana = new User("Diana", mediator);
        diana.SendMessage("Oi todo mundo! Acabei de chegar!");
        
        Console.WriteLine("\n4. Mensagem para todos:");
        bob.SendMessage("Que tal marcarmos uma reunião?");
        
        Console.WriteLine("\n=== Como funciona o Mediator ===");
        Console.WriteLine("✅ Usuários não se comunicam diretamente");
        Console.WriteLine("✅ Todas as mensagens passam pelo mediador");
        Console.WriteLine("✅ Mediador distribui mensagens para todos");
        Console.WriteLine("✅ Facilita adicionar novos usuários");
        Console.WriteLine("✅ Centraliza a lógica de comunicação");
        
        Console.WriteLine("\n=== Sem Mediator seria assim ===");
        Console.WriteLine("❌ Cada usuário precisaria conhecer todos os outros");
        Console.WriteLine("❌ Lógica de comunicação espalhada");
        Console.WriteLine("❌ Difícil de manter e estender");
    }
}
