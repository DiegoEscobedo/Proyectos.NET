using System;

namespace doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el primer numero");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero");
            int num2 = Int32.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("El mayor es" + num1);
            }
            else if (num1 < num2)
            {
                Console.WriteLine("El mayor es" + num2);
            }
        }
    }
}
