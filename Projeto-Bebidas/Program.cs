Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($@"

--------------------------------------
|Escolha a sua bebida no nosso menu! |
|Digite '1' para Coca-Cola           |
|Digite '2' para Pina Colada         |
|Digite '3' para um copo Jack Daniels|
|Digite '4' para Sprite              |
--------------------------------------
");

Console.ResetColor();

Console.WriteLine($"Escolha sua bebida");
char bebida = char.Parse(Console.ReadLine());

Console.WriteLine($"Voce deseja acrescentar gelo? responda com sim ou nao.");
string gelo = Console.ReadLine();

string sabor = "bebida nao selecionada!";

switch (bebida)
{
    case '1':
    sabor = "Coca-Cola";
    break;

    case '2':
    sabor = "Pina Colada";
    break;

    case '3':
    sabor = "Jack Daniels";
    break;

    case '4':
    sabor = "Sprite";
    break;

    
    default:
    Console.WriteLine($"Bebida nao selecionada. ");
    break;

    }

switch (gelo)
{
case "sim":
gelo = "com gelo! Boa bebida. ";
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($" Voce selecionou a bebida {sabor} {gelo}");
Console.ResetColor();
break;

case "nao":
gelo = "sem gelo! Boa bebida. ";
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($" Voce selecionou a bebida {sabor} {gelo}");
Console.ResetColor();
break;

default:
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Gelo nao selecionado.");
Console.ResetColor();
break;
}