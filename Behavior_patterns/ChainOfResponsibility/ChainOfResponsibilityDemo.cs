using System;

public class ChainOfResponsibilityDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Demonstração do Padrão Chain of Responsibility ===");
        
        var handler = new InvoiceHandler();
        handler.SetNext(new ReceiptHandler()).SetNext(new BillHandler());
        
        Console.WriteLine("\n1. Processando documentos conhecidos:");
        handler.Handle("Invoice");
        handler.Handle("Receipt");
        handler.Handle("Bill");
        
        Console.WriteLine("\n2. Tentando processar documento desconhecido:");
        handler.Handle("Unknown");
        
        Console.WriteLine("\n3. Testando mais documentos:");
        handler.Handle("Contract"); 
        

    }
}
