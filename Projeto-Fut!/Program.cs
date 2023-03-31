Console.ForegroundColor=ConsoleColor.Cyan;
Console.WriteLine($@"
-----------------------------------
| Veja o placar do jogo de futebol|
|  Com o nosso sistema!!!         |
-----------------------------------
");
Console.ResetColor();

Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite o nome do primeiro time: ");
string nome1 = Console.ReadLine();

Console.WriteLine($"Digite o nome do segundo time: ");
string nome2 = Console.ReadLine();

Console.WriteLine($"Digite os gols do primeiro time: ");
float gols1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite os gols do segundo time: ");
float gols2 = float.Parse(Console.ReadLine());

if (gols1 > gols2)
{
    Console.ForegroundColor=ConsoleColor.Green;;
    Console.WriteLine($"o {nome1} venceu a partida! ");
    Console.ResetColor();
}
else if (gols2 > gols1)
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine($"o {nome2} venceu a partida! ");
    Console.ResetColor();
}
else if (gols1 == gols2)
{
    Console.ForegroundColor=ConsoleColor.Blue;
    Console.WriteLine($"A partida foi empate! ");
    Console.ResetColor();
}


