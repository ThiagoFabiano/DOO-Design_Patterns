using System;
using System.Collections.Generic;
public class VisitorDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Demonstração do Padrão Visitor ===");
        
        var elements = new List<IElement>
        {
            new ElementA(),
            new ElementB(), 
            new ElementC()
        };
        
        Console.WriteLine("\n1. Validação dos elementos:");
        var validationVisitor = new ValidationVisitor();
        foreach (var element in elements)
        {
            element.Accept(validationVisitor);
            Console.WriteLine();
        }
        
        Console.WriteLine("2. Transformação dos elementos:");
        var transformVisitor = new TransformVisitor();
        foreach (var element in elements)
        {
            element.Accept(transformVisitor);
            Console.WriteLine();
        }
        
        Console.WriteLine("3. Exportação dos elementos (após transformação):");
        var exportVisitor = new ExportVisitor();
        foreach (var element in elements)
        {
            element.Accept(exportVisitor);
            Console.WriteLine();
        }
        
        Console.WriteLine("4. Nova validação (com dados transformados):");
        var secondValidation = new ValidationVisitor();
        foreach (var element in elements)
        {
            element.Accept(secondValidation);
            Console.WriteLine();
        }
        
        Console.WriteLine("=== Vantagens do Visitor Pattern ===");
        Console.WriteLine("✅ Adiciona operações sem modificar elementos");
        Console.WriteLine("✅ Centraliza operações relacionadas em uma classe");
        Console.WriteLine("✅ Facilita adicionar novos visitantes");
        Console.WriteLine("✅ Separa algoritmo da estrutura de dados");
        Console.WriteLine("✅ Usado em compiladores, analisadores, transformações");
        
        Console.WriteLine("\n=== Como funciona ===");
        Console.WriteLine("🔹 Elemento chama visitor.Visit(this)");
        Console.WriteLine("🔹 Visitor executa operação específica do tipo");
        Console.WriteLine("🔹 Double dispatch: método correto é escolhido");
        Console.WriteLine("🔹 Diferentes visitors = diferentes operações");
    }
}
