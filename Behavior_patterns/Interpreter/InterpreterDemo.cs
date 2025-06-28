using System;

public class InterpreterDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Demonstração do Padrão Interpreter ===");
        
        Console.WriteLine("\n1. Expressão: 5 + (10 - 3)");
        var expression1 = new AddExpression(
            new NumberExpression(5),
            new SubtractExpression(new NumberExpression(10), new NumberExpression(3))
        );
        Console.WriteLine($"Resultado: {expression1.Interpret()}");
        
        Console.WriteLine("\n2. Expressão: (2 * 3) + (8 - 1)");
        var expression2 = new AddExpression(
            new MultiplyExpression(new NumberExpression(2), new NumberExpression(3)),
            new SubtractExpression(new NumberExpression(8), new NumberExpression(1))
        );
        Console.WriteLine($"Resultado: {expression2.Interpret()}");
        
        Console.WriteLine("\n3. Expressão: 15 - (2 * 4)");
        var expression3 = new SubtractExpression(
            new NumberExpression(15),
            new MultiplyExpression(new NumberExpression(2), new NumberExpression(4))
        );
        Console.WriteLine($"Resultado: {expression3.Interpret()}");
        
        Console.WriteLine("\n4. Expressão complexa: (5 + 3) * (10 - 6)");
        var expression4 = new MultiplyExpression(
            new AddExpression(new NumberExpression(5), new NumberExpression(3)),
            new SubtractExpression(new NumberExpression(10), new NumberExpression(6))
        );
        Console.WriteLine($"Resultado: {expression4.Interpret()}");
        
        Console.WriteLine("\n=== Como funciona o Interpreter ===");
        Console.WriteLine("✅ Cada operação é uma classe separada");
        Console.WriteLine("✅ Expressões são compostas em árvore");
        Console.WriteLine("✅ Método Interpret() calcula o resultado");
        Console.WriteLine("✅ Facilita adicionar novas operações");
    }
}
