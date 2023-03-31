Console.WriteLine("Descubra as medidas de uma circuferencia: ");

Console.WriteLine("qual o raio da circuferencia?");
float raio = float.Parse(Console.ReadLine());

float diametro;
float comprimento;
float area;


    diametro=raio*2;
    Console.WriteLine($"o diametro e igual a {diametro}");


    comprimento=2*3.14F*raio;
    Console.WriteLine($"o comprimento e igual a {comprimento}");

    area=3.14F*raio*raio;
    Console.WriteLine($"a area e igual a {area}");
