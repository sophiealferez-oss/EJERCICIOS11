using System;
namespace switch1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;

            System.Console.WriteLine("ingrese un número:");
            dia=int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                if (dia == 1)
                System.Console.WriteLine("Lunes");
                break;

                case 2:
                if (dia == 2)
                System.Console.WriteLine("Martes");
                break;

                case 3:
                if (dia == 3)
                System.Console.WriteLine("Miércoles");
                break;


                case 4:
                if (dia == 4)
                System.Console.WriteLine("Jueves");
                break;

              default:
                System.Console.WriteLine("Fin de semana");
                break;


            }

           
        }
    }
}
