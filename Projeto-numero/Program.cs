Console.WriteLine("Saiba qual numero e maior.");


Console.WriteLine($"Digite o primeiro numero: ");
float numero1= float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero: ");
float numero2= float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o terceiro numero: ");
float numero3= float.Parse(Console.ReadLine());

if(numero1>numero2 || numero1>numero3)
{
    Console.WriteLine($"o numero {numero1} e o maior. ");
}
else if (numero2>numero1 || numero2>numero3)
{
    Console.WriteLine($"o numero {numero2} e o maior. ");
}
else if(numero3>numero1 || numero3>numero2)
{
    Console.WriteLine($"o numero {numero3} e o maior. ");
}
 if(numero1<numero2 || numero1<numero3)
{
    Console.WriteLine($"o numero {numero1} e o menor. ");
}
else if (numero2<numero1 || numero2<numero3)
{
    Console.WriteLine($"o numero {numero2} e o menor. ");
}
else if(numero3<numero1 || numero3<numero2)
{
    Console.WriteLine($"o numero {numero3} e o menor. ");
}