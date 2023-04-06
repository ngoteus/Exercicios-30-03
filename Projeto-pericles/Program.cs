bool idadeCerta = false;

do
{
    Console.WriteLine($"Qual a idade do Pericles: ");
    int idade = int.Parse(Console.ReadLine());

    if ( idade == 53)
    idadeCerta = true;
    
} while(!idadeCerta);