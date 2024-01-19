
using Pagamento;

Funcionario x;
x = new Funcionario();


x.Nome = Console.ReadLine();
x.SalarioB= double.Parse(Console.ReadLine());
x.Imposto = double.Parse(Console.ReadLine());

double salario = x.SalarioL();
double aumento = double.Parse(Console.ReadLine());
 x.Aumento(aumento);

 Console.WriteLine(salario);
 Console.WriteLine(x);
 Console.ReadKey();


