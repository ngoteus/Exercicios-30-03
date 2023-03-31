
Console.WriteLine($" Calcule o valor da compra de macas com o nosso sistema! ");


Console.WriteLine($"Digite a quantidade de maca que voce vai comprar: ");
int maca= int.Parse(Console.ReadLine());

float preco = 0.30F;

float duzia = 0.25F;

float totalPreco;

if(maca >= 12 )
{
    totalPreco= maca*duzia;
    Console.WriteLine($"sua compra deu o valor total de {totalPreco}");
}

else  
{
    totalPreco=maca*preco;
    Console.WriteLine($"sua compra deu o valor total de {totalPreco}");
}
