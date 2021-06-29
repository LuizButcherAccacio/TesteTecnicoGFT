using System;

namespace questao03
{
    class Program
    {
        static void Main(string[] args)
        {
            double icms = 0;
            double ipi = 0;
            double cofins = 0;
            double vfinal = 0;
            
            Console.WriteLine("Digite um Valor");
            double valor = double.Parse(Console.ReadLine());

            icms = valor * 0.3;

            if(valor>25000){
                ipi = valor/10;
            }else{
                ipi = valor/20;
            }

            if(valor>17000){
                cofins = 0.08 *valor;
            }
            else{
                cofins = 0;
                }

            vfinal = valor - icms - ipi - cofins;

            

            Console.WriteLine("ICMS: {0:0.0}",icms);
            Console.WriteLine("IPI: {0:0.0}",ipi);
            Console.WriteLine("COFINS: {0:0.0}",cofins);
            Console.WriteLine("Valor Final: {0:0.0}",vfinal);


        }
    }
}
