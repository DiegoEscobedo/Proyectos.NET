using System;

public class Pulsa0
{
    public static void Main(string[] args)
    {
        int num;
        List<int> listadeNumeros = new List<int>();
        do
        {
            Console.WriteLine("Ingrese un numero: ");
            num = (int)long.Parse(Console.ReadLine());
            listadeNumeros.Add(num);
        } while (num != 0);
        Console.WriteLine("Numero mas alto: " + (int)listadeNumeros.Max());
        Console.WriteLine("Numero mas pequeño: " + (int)listadeNumeros.Min());
        Console.WriteLine("Diferencia entre el menor y mayor: " + ((int)listadeNumeros.Max() - (int)listadeNumeros.Min()));
        Console.WriteLine("Numeros introducidos: " + listadeNumeros.Count());
    }
}
