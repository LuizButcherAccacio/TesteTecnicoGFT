using System;

namespace questao04
{
    class Program
    {
        static void Main(string[] args)
        {

            int num =-1;
            Random numAleatorio = new Random();
            int valorInteiro = numAleatorio.Next(0,10);

            while(num != valorInteiro){
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Parabens o numero é {0}, vc acertou!", num);
        }
    }
}
