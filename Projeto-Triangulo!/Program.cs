Console.ForegroundColor=ConsoleColor.Cyan;
Console.WriteLine($@"
---------------------------------
|Saiba qual triangulo voce esta |
|com o nosso sistema!!          |
---------------------------------
");
Console.ResetColor();
Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Informe a medida do primeiro lado do triangulo: ");
float lado1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a medida do segundo lado do triangulo: ");
float lado2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a medida do terceiro lado do triangulo: ");
float lado3 = float.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3 )
{
    Console.ForegroundColor=ConsoleColor.Yellow;
    Console.WriteLine($"Esse e Triangulo Equilatero {nome}! ");
    Console.ResetColor();
} 

else if ( lado1 == lado2 )
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine($"Esse e triangulo Isoceles {nome}!");
    Console.ResetColor();
}
else if ( lado1 == lado3)
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine($"Esse e triangulo Isoceles {nome}!");
    Console.ResetColor();
}
else if ( lado2== lado3)
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine($"Esse e triangulo Isoceles {nome}!");
    Console.ResetColor();
}
else 
{
    Console.ForegroundColor=ConsoleColor.Blue;
    Console.WriteLine($"Esse e triangulo Escaleno {nome}!");
    Console.ResetColor();
}

