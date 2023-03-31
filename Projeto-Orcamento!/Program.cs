Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($@"
--------------------------
|  Calcule seu orcamento |
| Com o nosso sistema    |
--------------------------
");
Console.ResetColor();
Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite seu salario: ");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o quanto voce gastou: ");
float gasto = float.Parse(Console.ReadLine());

if (gasto > salario)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Seu orcamento esgotou! ");
    Console.ResetColor();
}



else if(salario >= gasto)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Voce esta no seu orcamento! ");
    Console.ResetColor();
}

