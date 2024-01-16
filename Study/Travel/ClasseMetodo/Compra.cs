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

    }
}