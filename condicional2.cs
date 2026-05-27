using System;
namespace condicionales2
{
    class Program
    {
        static void Main(string[] args)
        {
            int time;
            System.Console.WriteLine("ingrese un número:");
            time=int.Parse(Console.ReadLine());

            if(time > 10)
            {
                System.Console.WriteLine("Buenos días");
            }
            else
            {
                System.Console.WriteLine("Buenas noches");
            }
        }
    }
}
