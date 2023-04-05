Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite seu salario: ");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($@"Digite 'S' se voce for solteiro
Digite 'C' se voce for casado
Digite 'V' se voce for viuvo
Digite 'D' se voce for divorcidado ");
char estado = char.Parse(Console.ReadLine());

while (nome.Length == 0)
{
    Console.WriteLine($"Voce errou o nome!");
    nome = Console.ReadLine();
}
while (idade <0 && idade >100)
{
    Console.WriteLine($"Sua idade esta fora dos requeridos");
    idade =  int.Parse(Console.ReadLine());
}
while (salario <0)
{
    Console.WriteLine($"Seu salario precisa ser maior que 0! ");
    salario = float.Parse(Console.ReadLine());
}
while (estado != 'S' &&  estado !='C' && estado !='V' && estado !='D' )
{
    Console.WriteLine($"Seu estado civil esta incorreto! ");
    estado = char.Parse(Console.ReadLine());
}

Console.WriteLine($"Dados inseridos com sucesso! ");

