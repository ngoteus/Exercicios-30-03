Console.WriteLine($@"
'+' para somar
'-' para subtrair
'*' para multiplicar
'/' para dividir
");

Console.WriteLine($"Digite sua operacao");
char operacao = char.Parse(Console.ReadLine());

Console.WriteLine($"Digite o numero 1");
float numero1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o numero 2");
float numero2 = float.Parse(Console.ReadLine());

float resultado = 0;

switch (operacao)
{
    case '+' :
    resultado = (numero1+numero2);
    Console.WriteLine($"o Resultado da sua soma foi {resultado}");
    break;

    case '-' :
    resultado = (numero1-numero2);
    Console.WriteLine($"O Resultado da sua subtracao foi {resultado}");
    break;

    case '*':
    resultado = (numero1*numero2);
    Console.WriteLine($"O Resultado da sua multiplicacao foi {resultado}");
    break;

    case '/':
    resultado = (numero1/numero2);
    Console.WriteLine($"O Resultado da sua divisao foi {resultado}");
    break;

    default:
        Console.WriteLine($"Erro na operacao");
    break;
}