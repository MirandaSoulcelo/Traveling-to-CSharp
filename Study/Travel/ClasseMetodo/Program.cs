using Estoque;

Produto x;
int opcao;
x = new Produto();

Console.WriteLine("Digite o preço e a quantidade do produto: ");

x.Preco = double.Parse(Console.ReadLine());
x.Qntd = int.Parse(Console.ReadLine());
do{
    double n1 = x.ValorTotal();
    Console.WriteLine("");
    Console.WriteLine("Aqui está o resultado: ");
    Console.WriteLine("");
    Console.WriteLine("Quantidade do produto igual a: "+ x.Qntd);
    Console.WriteLine("Valor do produto igual a: "+x.Preco);
    Console.WriteLine("Valor total da quantidade de produtos igual a: "+n1);
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