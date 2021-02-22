using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n;
                Console.WriteLine("Ingresa el valor");
                n = int.Parse(Console.ReadLine());
                
                Console.WriteLine("El resultado es: " + Fib(n));
                Console.ReadLine();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
           
        }

        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

    }
}
