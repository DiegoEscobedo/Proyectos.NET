using System;

namespace doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el dia");
            String texto;
            texto = Console.ReadLine().ToLower();
            if (texto.Equals("lunes") | texto.Equals("martes") | texto.Equals("miercoles") | texto.Equals("Jueves") | texto.Equals("viernes") | texto.Equals("sabado") | texto.Equals("domingo"))
            {
                if(texto.Equals("sabado") | texto.Equals("domingo") | texto.Equals("viernes"))
                {
                    Console.WriteLine("Si es fin de semana");
                }
                else if(texto.Equals("lunes") | texto.Equals("martes") | texto.Equals("miercoles") | texto.Equals("Jueves"))
                {
                    Console.WriteLine("No es fin de semana");
                }
            }
            else
            {
                Console.WriteLine("No es dia");
            }
        }
    }
}
