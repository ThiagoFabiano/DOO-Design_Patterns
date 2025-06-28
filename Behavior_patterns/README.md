# Padrões Comportamentais (Behavioral Patterns) em C#

Este diretório contém implementações em C# de 11 padrões comportamentais do Design Patterns.
Para executar cada um, acesse sua pasta e execute o arquivo Demo

## 📁 Estrutura do Projeto

```
Behavior_patterns/
├── ChainOfResponsibility/    # Chain of Responsibility
├── Command/                  # Command  
├── Interpreter/              # Interpreter
├── Iterator/                 # Iterator
├── Mediator/                 # Mediator
├── Memento/                  # Memento
├── Observer/                 # Observer
├── State/                    # State
├── Strategy/                 # Strategy
├── TemplateMethod/           # Template Method
└── Visitor/                  # Visitor
```

## 🎯 Padrões Implementados

1. Chain of Responsibility (Cadeia de Responsabilidade)
Descrição: Implemente um sistema de processamento de documentos financeiros. Cada tipo de documento (fatura, recibo, nota fiscal) deve ser tratado por um handler específico, e se nenhum handler puder processá-lo, o sistema deve registrar um erro.

Requisitos:

Crie classes InvoiceHandler, ReceiptHandler e BillHandler que herdam de uma classe base DocumentHandler.
Use o padrão para processar diferentes tipos de documentos.
Entrada esperada:

var handler = new InvoiceHandler();
handler.SetNext(new ReceiptHandler()).SetNext(new BillHandler());

handler.Handle("Invoice");
handler.Handle("Unknown");
Saída esperada:

Processing Invoice...
Cannot process Unknown.

2. Command (Comando)
Descrição: Crie um editor de texto simples que implemente as funcionalidades de desfazer (Undo) e refazer (Redo) para comandos como "Escrever texto" e "Apagar texto".

Requisitos:

Crie uma interface ICommand com os métodos Execute() e Undo().
Implemente comandos como WriteTextCommand e DeleteTextCommand.
Use uma pilha para implementar o histórico de comandos.
Entrada esperada:

var editor = new TextEditor();
var commandManager = new CommandManager();

commandManager.ExecuteCommand(new WriteTextCommand(editor, "Hello, "));
commandManager.ExecuteCommand(new WriteTextCommand(editor, "world!"));

commandManager.Undo();
commandManager.Undo();
commandManager.Redo();
Saída esperada:

Hello, 

3. Interpreter (Interpretador)
Descrição: Implemente um interpretador que avalie expressões matemáticas simples como 5 + 10 - 3.

Requisitos:

Crie uma interface IExpression com o método Interpret().
Implemente classes como NumberExpression, AddExpression e SubtractExpression.
Entrada esperada:

var expression = new AddExpression(
    new NumberExpression(5),
    new SubtractExpression(new NumberExpression(10), new NumberExpression(3))
);

Console.WriteLine(expression.Interpret());
Saída esperada:

12

4. Iterator (Iterador)
Descrição: Crie uma coleção personalizada que suporte iteração. A coleção será uma playlist, e o iterador percorrerá as músicas em ordem ou de maneira aleatória.

Requisitos:

Crie uma classe Playlist que implemente o método GetEnumerator().
Adicione uma funcionalidade para alternar entre iteração ordenada e aleatória.
Entrada esperada:

var playlist = new Playlist();
playlist.Add("Song 1");
playlist.Add("Song 2");
playlist.Add("Song 3");

foreach (var song in playlist) {
    Console.WriteLine(song);
}
Saída esperada (ordem aleatória ou não):

Song 1
Song 2
Song 3

5. Mediator (Mediador)
Descrição: Implemente um sistema de chat onde um mediador gerencie a comunicação entre usuários.

Requisitos:

Crie uma interface IMediator com o método SendMessage().
Crie classes User que se comunicam por meio de um ChatMediator.
Entrada esperada:

var mediator = new ChatMediator();

var user1 = new User("Alice", mediator);
var user2 = new User("Bob", mediator);

user1.SendMessage("Hello, Bob!");
user2.SendMessage("Hi, Alice!");
Saída esperada:

Alice to Bob: Hello, Bob!
Bob to Alice: Hi, Alice!

6. Memento (Memento)
Descrição: Implemente um jogo de tabuleiro que permite salvar e restaurar o estado de um jogador.

Requisitos:

Crie uma classe Player com propriedades como Position e Health.
Use o padrão Memento para implementar os métodos SaveState() e RestoreState().
Entrada esperada:

var player = new Player();
player.Position = 5;
player.Health = 100;

var caretaker = new Caretaker();
caretaker.Save(player.SaveState());

player.Position = 10;
caretaker.Restore(player);
Console.WriteLine(player.Position);
Saída esperada:

5

7. Observer (Observador)
Descrição: Crie um sistema de notificações onde diferentes observadores (email, SMS, app) sejam notificados quando um pedido é atualizado.

Requisitos:

Crie uma interface IObserver com o método Update().
Implemente classes como EmailNotifier, SmsNotifier, etc.
Entrada esperada:

var order = new Order();
order.Attach(new EmailNotifier());
order.Attach(new SmsNotifier());

order.UpdateStatus("Shipped");
Saída esperada:

Email: Your order is now Shipped.
SMS: Your order is now Shipped.

8. State (Estado)
Descrição: Implemente uma máquina de venda automática que muda de comportamento dependendo do estado (sem moeda, com moeda, produto entregue).

Requisitos:

Crie uma interface IState com o método Handle().
Implemente classes como NoCoinState, HasCoinState e SoldState.
Entrada esperada:

var vendingMachine = new VendingMachine();

vendingMachine.InsertCoin();
vendingMachine.SelectProduct();
vendingMachine.DispenseProduct();
Saída esperada:

Coin inserted.
Product selected.
Product dispensed.

9. Strategy (Estratégia)
Descrição: Implemente um sistema de cálculo de frete com estratégias como entrega rápida, econômica e local.

Requisitos:

Crie uma interface IShippingStrategy com o método Calculate().
Implemente classes como ExpressShipping, EconomyShipping, etc.
Entrada esperada:

var calculator = new ShippingCalculator(new EconomyShipping());
Console.WriteLine(calculator.Calculate(100));

calculator.SetStrategy(new ExpressShipping());
Console.WriteLine(calculator.Calculate(100));
Saída esperada:

10
25

10. Template Method (Método Template)
Descrição: Implemente um sistema de geração de relatórios que pode ser exportado em diferentes formatos (PDF, Excel).

Requisitos:

Crie uma classe base ReportGenerator com o método GenerateReport().
Substitua métodos específicos em subclasses como PdfReportGenerator e ExcelReportGenerator.
Entrada esperada:

var pdfReport = new PdfReportGenerator();
pdfReport.GenerateReport();

var excelReport = new ExcelReportGenerator();
excelReport.GenerateReport();
Saída esperada:

Generating report header...
Exporting to PDF...

11. Visitor (Visitante)
Descrição: Implemente um analisador de arquivos XML que realiza validações e exportações usando o padrão Visitor.

Requisitos:

Crie uma interface IVisitor com métodos Visit(ElementA) e Visit(ElementB).
Crie classes de elementos que aceitam visitantes.
Entrada esperada:

var visitor = new ValidationVisitor();
var elementA = new ElementA();
elementA.Accept(visitor);
Saída esperada:

Validating ElementA...

## 🚀 Como Executar

### Pré-requisitos
- .NET Framework 4.7.2 ou superior, ou .NET Core 3.1+
- Visual Studio, VS Code, ou terminal com suporte ao C#

### Executando um padrão específico

1. Navegue até o diretório do padrão desejado:
   ```bash
   cd Behavior_patterns/ChainOfResponsibility
   ```

2. Compile e execute:
   ```bash
   csc *.cs && ChainOfResponsibilityDemo.exe
   ```

   Ou usando dotnet (se tiver .NET Core/5+):
   ```bash
   dotnet run --source *.cs --entry ChainOfResponsibilityDemo
   ```

*Implementado para disciplina de Padrões de Projeto - Programação Orientada a Objetos*
