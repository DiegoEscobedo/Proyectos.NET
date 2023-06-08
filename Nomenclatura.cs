using System;
namespace Nomenclatura
{
    class Program
    {
        private readonly string _estaEsMiCadena; // Variables privadas con un (_) al principio
        static void Main(string[] args)
        {
            // Convenciones para escribir código 
            
            // Camel Case | declaración de variables
            var estoEsUnaVariable = "Camel";
            // Snake
            var esto_es_una_variable = "Snake";
            // Pascal Case | tipos, métodos y clases
            var EstoEsUnaVariable = "Pascal";

            int numero1 = 15;
            int numero2 = 10;
            var resultado1 = SumaDosNumeros(numero1, numero2);
            var resultado2 = Suma(numero1, numero2);

            Console.WriteLine("El resultado de sumar " + numero1 + " + " + numero2 + " es " + resultado1);
            Console.WriteLine("El resultado de sumar " + numero1 + " + " + numero2 + " es " + resultado2);
            Console.ReadKey();
        }
        //Buen ejemplo / descriptivo
        public static int SumaDosNumeros(int numeroUno, int numeroDos)
        {
            var resultado = numeroUno + numeroDos;
            return resultado;
        }
        //Incorrecto por cuestión de buena práctica
        public static int Suma(int a, int b)
        {
            var c = a + b;
            return c;
        }
    }
}