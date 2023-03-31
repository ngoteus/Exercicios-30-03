Console.WriteLine($"Veja se sua data de aniversario!");


Console.WriteLine($"Diga o dia que voce nasceu: ");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine($"Diga o mes que voce nasceu: ");
int mes = int.Parse(Console.ReadLine());

Console.WriteLine($"Diga o ano que voce nasceu: ");
int ano = int.Parse(Console.ReadLine());

if (dia>31)
{
    Console.WriteLine($"o dia {dia} esta invalido.");

}
else if(mes>12)
{
    Console.WriteLine($"o mes {mes} esta invalido.");
}

else if(ano>2013)
{
    Console.WriteLine($"o ano {ano} esta invalido.");
}
else
{
 Console.WriteLine($"Sua data esta valida! ");
}