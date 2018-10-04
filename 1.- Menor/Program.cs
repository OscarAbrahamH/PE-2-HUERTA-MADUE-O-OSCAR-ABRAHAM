using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor
{
    class Menor
    {
  
        static void Main(string[] args)
        {
            CMenor figura1 = new CMenor();
            Random NumeroRandom = new Random();
            
            int X;
            Console.Write("Tamaño del Vector: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");
            int[] Vector = new int[X];
            for (int f = 0; f < X; f++)
            {
                Vector[f] = NumeroRandom.Next(0, 100);
                Console.Write(" ");
                Console.Write(Vector[f]);   
            }
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Numero Menor: " + figura1.MenorN(Vector, X - 1, Vector[0]));
            Console.ReadKey();
        }

    }
}
