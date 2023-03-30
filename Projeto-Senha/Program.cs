
Console.ForegroundColor=ConsoleColor.Cyan;
Console.WriteLine($"Logue com sua senha no nosso sistema!");
Console.ResetColor();

Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite a senha: ");
int senha = int.Parse(Console.ReadLine());

int senhaCerta = 1234;

if (senha==senhaCerta)
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine($"ACESSO PERMITIDO");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"ACESSO NEGADO");
    Console.ResetColor();
}