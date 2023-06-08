using System;

public class Program
{
    public static void Main(string[] args)
    {
        int variable;
        int dolar;
        int euro;
        double cantidad;
        Console.WriteLine("Que tipo de cambio desea dar hoy?... porfavor digite el numero segun la opcion" + "\n" + "1)Dolares a Euros" + "\n" + "2)Euros a Dolares" + "\n" + "0)Salir");
        variable = (int)long.Parse(Console.ReadLine());
        while (variable != 0) {
            if (variable == 1)
            {
                Console.WriteLine("Dame la cantidad de dolares...");
                dolar = (int)long.Parse(Console.ReadLine());
                cantidad = dolar * .94;
                Console.WriteLine("La cantidad en euros es:" + cantidad);
            } else if (variable == 2)
            {
                Console.WriteLine("Dame la cantidad de euros...");
                euro = (int)long.Parse(Console.ReadLine());
                cantidad = euro * 1.07;
                Console.WriteLine("La cantidad en euros es:" + cantidad);
            } else
            {
                Console.WriteLine("La opcion no existe, digita una correcta");
                Console.WriteLine("Que tipo de cambio desea dar hoy?... porfavor digite el numero segun la opcion" + "\n" + "1)Dolares a Euros" + "\n" + "2)Euros a Dolares" + "\n" + "0)Salir");
                variable = (int)long.Parse(Console.ReadLine());
            }
        }
    }
}
