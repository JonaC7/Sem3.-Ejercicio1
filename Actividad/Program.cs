using System;

namespace Actividad
{
    class Program
    {
        static void Main(string[] args)

        {
         
            Console.WriteLine("Ingrese el numero de operación que desea realisar: 1. Suma, 2. Resta, 3. Multiplicación, 4. División, o escriba el numero 0 si no desea continuar");
            int option = int.Parse(Console.ReadLine());
            int num1, num2;
            

            while (option >= 1 && option <= 4)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Introduzca el primer número");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca el segundo número");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma es: " + Suma(num1, num2));
                        Console.WriteLine("Si desea continuar ingrese el numero de operación que desea realisar: 1. Suma, 2. Resta, 3. Multiplicación, 4. División, o escriba el numero 0 si no desea continuar");
                        option = int.Parse(Console.ReadLine());

                        break;
                    case 2:
                        Console.WriteLine("Introduzca el primer número");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca el segundo número");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La resta es: " + Resta(num1, num2));
                        Console.WriteLine("Si desea continuar ingrese el numero de operación que desea realisar: 1. Suma, 2. Resta, 3. Multiplicación, 4. División, o escriba el numero 0 si no desea continuar");
                        option = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Introduzca el primer número");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca el segundo número");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La multiplicación es: " + Multi(num1, num2));
                        Console.WriteLine("Si desea continuar ingrese el numero de operación que desea realisar: 1. Suma, 2. Resta, 3. Multiplicación, 4. División, o escriba el numero 0 si no desea continuar");
                        option = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Introduzca el primer número");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca el segundo número");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("La divición es: " + Div(num1, num2));
                        Console.WriteLine("Si desea continuar ingrese el numero de operación que desea realisar: 1. Suma, 2. Resta, 3. Multiplicación, 4. División, o escriba el numero 0 si no desea continuar");
                        option = int.Parse(Console.ReadLine());
                        break;
                }

            }
            
        }

        static int Suma(int num1, int num2)

        {
            return (num1 + num2);
        }
        static int Resta(int num1, int num2)
        {
            return (num1 - num2);
        }
        static int Multi(int num1, int num2)
        {
            return (num1 * num2);
        }
        static double Div(int num1, int num2)
        {

            double numd1 = Convert.ToDouble(num1);
            double numd2 = Convert.ToDouble(num2);

            return numd1 / numd2;
        }
    }
}