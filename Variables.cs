using System;
namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje = Console.ReadLine();
            int edad = 20;
            edad = 20 + 1;
            Console.WriteLine(edad);
            Console.ReadLine();

            string hola = null;
            int edad2 = default(int); //0
            int? altura = null;
            bool verdadero = default(bool); //false

            edad2 = edad2 + 5;
            if (altura == null)
            {
                Console.WriteLine("Te faltó agregar la altura");

            }
            DateTime? fecha = new DateTime();
            fecha = null;

            //Comprobar el nulo
            int? dia = fecha?.Day;
            Console.WriteLine("Fecha faltante " + dia);
            Console.Write(edad2);
            Console.ReadLine();
        }
    }
}