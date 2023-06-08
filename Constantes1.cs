using System;

namespace Constantes1
{
    class Program
    {
        public const string NOMBRE = "Diego"; //Buena práctica -> Nombre de constante en mayúscula
        public const int NUMERO_ALUMNOS = 20;

        static void Main(string[] args)
        {
            for (int i = 0; i < 22; i++)
            {
                if( i < NUMERO_ALUMNOS)
                {
                    Console.Write(i);
                }
            }
        }
    }
}