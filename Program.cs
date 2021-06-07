using System;

namespace TP2_EJ16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BUENASS!");
            Console.Title = "Designar Número par o impar ";
            Console.Write("Ingrese el Número Entero a verificar ");
            var Número = Convert.ToSingle(Console.ReadLine());

            if (Número % 2 == 0)
            
                Console.Write("El Número ingresado es Par ");
            
            else
                Console.Write("El Número ingresado es Impar ");
        }
    }
}
