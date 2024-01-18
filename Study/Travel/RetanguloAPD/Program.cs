using Exercicio;


Retangulo x;
x = new Retangulo();

Console.WriteLine("Digite aqui a largura e altura do Retangulo RESPECTIVAMENTE");
x.Base = double.Parse(Console.ReadLine());
x.Altura = double.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Aqui está o resultado: ");
Console.WriteLine(x);
Console.ReadKey();