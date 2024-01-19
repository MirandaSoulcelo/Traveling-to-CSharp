using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Pagamento{

    class Funcionario{

        public string Nome;

        public double SalarioB;

        public double Imposto;



        public double SalarioL(){
            double s = SalarioB - Imposto;

            return s;
        }

        public void Aumento(double porcentagem){
            SalarioB = SalarioB + (SalarioB * porcentagem/100);


        }


        public override string ToString(){

            return "Resultado: " + SalarioL();
        }



    }
}