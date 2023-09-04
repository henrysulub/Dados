using System;

namespace dosDados
{
   class Program
    {
        static void Main(string[] args)
        {
            int res;
            int s;
            do
            {
                Random rnd = new Random();
                int dado1 = rnd.Next(1,6);
                int dado2 = rnd.Next(1, 6);
                Console.WriteLine();
                Console.WriteLine("dado 1: "+dado1);
                Console.WriteLine("dado 2: " + dado2);
                res = dado1 + dado2;
                Console.WriteLine();
                Console.WriteLine("El resultado de los dados es: " + res);
                Console.WriteLine();
                Console.WriteLine("Desea volver a tirar? si 1 o No: Ingresa cualquier numero");
                s = Convert.ToInt32(Console.ReadLine());
            } while (s == 1);    


            
        }


    }
























}
