Console.WriteLine($"Veja a situacao do seu aluno no nosso sistema!");

Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite sua nota ");
float nota = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite seu percentual de frequencia: ");
float frequencia = float.Parse(Console.ReadLine());

if (frequencia<75)
{
    Console.WriteLine($"O aluno {nome} esta reprovado pela frequencia {frequencia}. ");
}
else if( nota >= 7)
{
    Console.WriteLine($"O aluno {nome} esta aprovado.");
}

else if( nota>= 3)
{
    Console.WriteLine($"O aluno esta de recuperacao pela nota {nota}. ");
}
else
{
 Console.WriteLine($"O aluno {nome} esta reprovado pela nota {nota} ");
}