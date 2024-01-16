using Estoque;

Produto x;
int opcao;
x = new Produto();

Console.WriteLine("Digite o Nome, Preço e a Quantidade do produto: ");

x.Nome = Console.ReadLine();
x.Preco = double.Parse(Console.ReadLine());
x.Qntd = int.Parse(Console.ReadLine());
do{
    Console.WriteLine("");
    Console.WriteLine("Aqui está o resultado: ");
    Console.WriteLine("");
    Console.WriteLine(x);
    Console.WriteLine("");
    Console.WriteLine("Digite as seguintes oções: ");
    Console.WriteLine("1 Adicionar produtos.");
    Console.WriteLine("2 Remover produtos");
    Console.WriteLine("0 Para encerrar o programa: ");
    opcao= int.Parse(Console.ReadLine());
    switch(opcao)
    {
        case 1:
            Console.WriteLine("Quantos produtos gostaria de adicionar? ");
            x.Qntd = x.AdicionarP();
            break;
        case 2:
            Console.WriteLine("Quantos Produtos gostaria de remover? ");
            x.Qntd = x.RemoverP();
            break;
        case 0:
            Console.WriteLine("Programa encerrado. :D");
            break;
    }
    

}while(opcao != 0);

Console.ReadKey();