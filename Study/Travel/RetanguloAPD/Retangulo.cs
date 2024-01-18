
namespace Exercicio{

    class Retangulo{

        public double Base;

        public double Altura;


        public double Area()
        {

            double area= Base * Altura;
            return area;

        }


        public double Perimetro()
        {

            double p= (Base * 2) + (Altura * 2);
            return p;

        }   
    
        public double Diagonal()
        {
            double somaCateto =Math.Pow(Base,2) + Math.Pow(Altura, 2);
            double h = Math.Sqrt(somaCateto);
            return h;
        }

        public override string ToString(){

            return "Área do Retângulo: " + Area().ToString("F2") 
            + ". Perímetro igual a: " + Perimetro().ToString("F2")
            + ". Diagonal do triângulo equivalente a: "+Diagonal().ToString("F2"); 


        }


}
}