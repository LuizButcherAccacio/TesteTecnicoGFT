using System;

namespace questao02
{
    class Program
    {
        static void Main(string[] args)
        {
            double ma=0;
            int m10 = 0;
            int m50 = 0;
            Console.WriteLine("Por Favor digite 10 números inteiros em uma mesma linha");
            string[] dados = Console.ReadLine().Split();

            Array.Sort(dados);

            int[] arrayInt = Array.ConvertAll(dados, x => int.Parse(x));

            ma = (double.Parse(dados[0]) +double.Parse(dados[1]) +double.Parse(dados[2]) +double.Parse(dados[3]) +double.Parse(dados[4]) +double.Parse(dados[5]) +double.Parse(dados[6]) +double.Parse(dados[7]) +double.Parse(dados[8]) +double.Parse(dados[9]))/100;

            foreach(int li in arrayInt){
              if(li >10){
                m10++;               
              }              
            }
            foreach(int li in arrayInt){
              if(li >50){
                m50++;               
              }              
            }

            Console.WriteLine(dados[9]);
            Console.WriteLine(dados[0]);
            Console.WriteLine(ma);
            Console.WriteLine(m10);
            Console.WriteLine(m50);

        }
    }
}
