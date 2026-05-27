using System;
namespace condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
         
            System.Console.WriteLine("¿Tiene licencia?");
            string rta = Console.ReadLine();

            System.Console.WriteLine("Ingrese los años de experiencia:");
            int años=int.Parse(Console.ReadLine());
            
            if(rta == "si" && años >= 2)
            {
                System.Console.WriteLine("Puedes aplicar al puesto");
            }
            
            else
            {
                System.Console.WriteLine("No puedes aplicar al puesto");
            }
        }
    }
}

