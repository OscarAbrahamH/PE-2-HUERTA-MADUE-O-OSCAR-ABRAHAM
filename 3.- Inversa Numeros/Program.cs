using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace TRES
{
    class Program
    {
        public static int Invertir(int n)
        {
            if (n < 10)
            {
                return n;
            }
            else
            {
                return (n % 10) * 10 + Invertir(n / 10); 
            }
        }
    
        static void Main(string[] args)
        {
            {
                int x = 0;
                try
                {
                    Console.WriteLine("Ingrese numero: ");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Numero: " + Invertir(x));
                }
                catch
                {
                    Console.WriteLine("Ingrese lo que se te pide, vuelve a intentarlo");
                }
                Console.ReadKey();
            }
        }
    }
}
