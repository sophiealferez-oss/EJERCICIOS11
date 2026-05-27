using System;
namespace condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingrese un número: ");
            int num=int.Parse(Console.ReadLine());

            if(num > 10)
            {
                System.Console.WriteLine("número es mayor a 10");
            }
            else
            {
                System.Console.WriteLine("numero no es mayor a 10");
            }
        
        }
    }
}
