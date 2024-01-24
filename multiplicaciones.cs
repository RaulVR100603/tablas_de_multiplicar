using System;

class Program
{
    static void Main()
    {
        string anotherCalculation = "yes";
        while (anotherCalculation == "yes" || anotherCalculation == "y")
        {
            Console.Write("Ingrese el número para calcular su tabla de multiplicar: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(number + " x " + i + " = " + (number * i));
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }

            Console.Write("¿Desea calcular otra tabla de multiplicar? (yes/no): ");
            anotherCalculation = Console.ReadLine().ToLower();
        }
    }
}
