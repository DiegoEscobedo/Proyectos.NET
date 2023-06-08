using System;

namespace doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame el numero del 1 - 7");
            int num = Int32.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Ese no existe :/");
                    break;
            }
        }
    }
}