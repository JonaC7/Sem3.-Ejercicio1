using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Ingrese un un numero entero (Con 0 finaliza);:");
                num = int.Parse(Console.ReadLine());


                if (num >= 100)
                {
                    Console.WriteLine("tiene 3 digitos");
                }
                if (num >= 10)
                {
                    Console.WriteLine("tiene 2 digitos");
                }
                else
                {
                    Console.WriteLine("tiene 1 digitos");
                }
 
            } while (num != 0);
        }
    }
}
