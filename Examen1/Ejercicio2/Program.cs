using System;

public class Program
{
    public static bool esVocal(List<string> vocales, string var)
    {
        return vocales.Contains(var);
    }

    public static bool esConsonante(List<string> consonantes, string var)
    {
        return consonantes.Contains(var);
    }

    public static bool esNumero(string var)
    {
        return Int32.TryParse(var, out int x);
    }

    public static void Main(string[] args)
    {
        List<string> vocales = new List<string>() {"a", "e", "i", "o", "u","A", "E", "I", "O", "U"};
        List<string> consonantes = new List<string>() {"b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z", "ñ", "Ñ" };
        Console.WriteLine("Introduzca una letra o un numero");
        String variableDelUsuario = Console.ReadLine().;

        if (esNumero(variableDelUsuario))
        {
            Console.WriteLine("Es Numero");
        }
        if (esVocal(vocales, variableDelUsuario))
        {
            Console.WriteLine("Es Vocal");
        }
        if (esConsonante(consonantes, variableDelUsuario))
        {
            Console.WriteLine("Es Consonante");
        }
    }
}