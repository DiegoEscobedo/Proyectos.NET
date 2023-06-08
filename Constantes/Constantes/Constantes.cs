using System;
namespace Constante
{
    class Program
    {
        public const string NOMBRE = "Diego";
        public const int NUMERO_ALUMNO = 28;
        public static void Main(string[] args)
        {
            for (int i = 0; i < 22; i++)
            {
                if (i < NUMERO_ALUMNO)
                {
                    Console.Write(i + "\n");
                }
            }
        }
    }
}