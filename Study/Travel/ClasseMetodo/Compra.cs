using System.Globalization;

namespace Estoque{
    class Produto{

        public string Nome;
        public double Preco;
        public int Qntd;
  
 

        public int AdicionarP(){
            int num = int.Parse(Console.ReadLine());
            Qntd += num;
            return Qntd;
        }


        public int RemoverP()
        {
            int num = int.Parse(Console.ReadLine());
            Qntd -= num;
            return Qntd;
        }

         public double ValorTotal()
        {
            
            return Preco * Qntd;
        }
        public override string ToString(){

            return "Nome do produto: "+ Nome
            + ". Preço:  $" + Preco.ToString("F2") 
            + ". Quantidade comprada: " + Qntd + "unidades"
            + ". Valor Total da compra: " + ValorTotal().ToString("F2");
        }
    }
}