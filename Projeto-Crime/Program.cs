Console.WriteLine($"Crime");

Console.WriteLine($"Telefonou para a vítima?");
string pergunta1 = Console.ReadLine();

Console.WriteLine($"Esteve no local do crime?");
string pergunta2 = Console.ReadLine();

Console.WriteLine($"Mora perto da vítima?");
string pergunta3 = Console.ReadLine();

Console.WriteLine($"Devia para a vítima?");
string pergunta4 = Console.ReadLine();

Console.WriteLine($"Já trabalhou com a vítima?");
string pergunta5 = Console.ReadLine();


int pontosDeCrime= 0;

if( pontosDeCrime == 2)
{
    Console.WriteLine($"A Pessoa e suspeita.");
}

else if ( pontosDeCrime >=3)
{
    Console.WriteLine($"A Pessoa e cumplice.");
}

else if ( pontosDeCrime ==5)
{
    Console.WriteLine($"A pessoa e culpada.");
}
else
{
    Console.WriteLine($"a Pessoa e inocente");
}