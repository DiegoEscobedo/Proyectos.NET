using System;

namespace doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el costo");
            int cost = Int32.Parse(Console.ReadLine());
            if (cost > 0)
            {
                Console.WriteLine("Desea pagar con tarjeta o efectivo");
                String texto;
                texto = Console.ReadLine().ToLower();
                if (texto.Equals("tarjeta"))
                {
                    Console.WriteLine("Introduzca el numero de tarjeta");
                    int tarjeta = (int)long.Parse(Console.ReadLine());

                }
                else if (texto.Equals("efectivo"))
                {
                    Console.WriteLine("Introduzca el efectivo efectivo");

                }
            }
            else
            {
                Console.WriteLine("EL COSTO ES INVALIDO");
            }
        }
    }
}