using System;
namespace condicionalesoperadores
{
    class Program
    {
        static void Main(string[] args)
        {


            System.Console.WriteLine("Ingrese el primer día");
            string rta1 = Console.ReadLine();

            System.Console.WriteLine("Ingrese el segundo día");
            string rta2 = Console.ReadLine();
            
            if(rta1 == "sabado" || rta2 == "domingo") //la idea es que el usuario ingrese alguno
            // // de los dos, si ingresa sabado o domingo si o si le debe imprimir que es fin de semana

            {
                System.Console.WriteLine("Es fin de semana");
            }
            
            else
            {
                System.Console.WriteLine("Son días de la semana");
            }
        }
    }
}


