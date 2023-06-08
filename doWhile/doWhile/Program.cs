using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do
            //{
            //instrucciones
            //} while(true)

            int numero = 0;
            do
            {
                Console.Write(numero);
                numero++;
                if (numero == 9)
                {
                    return;
                }
            } while (numero < 10);
            int numero2 = 0;
            while(numero2<10)
            {
                Console.WriteLine(numero2);
                numero2++;
            }
        }
    }
}
