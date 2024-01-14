using CursoC;

Triangulo x, y;

x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Digite os lados do primeiro triângulo: ");
x.A= double.Parse(Console.ReadLine());
x.B= double.Parse(Console.ReadLine());
x.C= double.Parse(Console.ReadLine());

Console.WriteLine("Agora digite os dados do segundo triângulo: ");
y.A= double.Parse(Console.ReadLine());
y.B= double.Parse(Console.ReadLine());
y.C= double.Parse(Console.ReadLine());

double p = (x.A + x.B + x.C)/2;
double areax= Math.Sqrt(p*(p - x.A)* (p - x.B)* (p - x.C));

p = (y.A + y.B + y.C)/2;
double areay = Math.Sqrt(p*(p - y.A)* (p - y.B)* (p - y.C));

Console.WriteLine("A área do primeiro triângulo é igual a: "+ areax.ToString("F4"));
Console.WriteLine("A área do segundo Triângulo é igual a: "+ areay.ToString("F4"));

if(areax > areay)
{
    Console.WriteLine("A área do primeiro triângulo é maior. :)");
}
else if(areax == areay)
{
    Console.WriteLine("Ambos os triângulos tem a mesma área. :)");
}

else{
    Console.WriteLine("A área do segundo Triângulo é maior. :)");
}

Console.ReadKey();