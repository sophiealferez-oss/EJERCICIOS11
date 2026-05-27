using System;
namespace tarea
{
    class motos
    {
        public string color;
        public int cilindraje, velocidad;
        public void fullThrottle()
        {
            System.Console.WriteLine("Las tres motos prestan un servicio, se pueden adelantar y frenar con ellas. ");
        }

        static void Main(string[] args)
        {
            motos Pulsar = new motos(); //el objeto que creé es pulsar con la palabra clave new
            Pulsar.color= "Verde";
            Pulsar.cilindraje = 200;
            Pulsar. velocidad = 150;

            System.Console.WriteLine($"Las caracteristicas de Pulsar son Color:{Pulsar.color}, cilindraje:{Pulsar.cilindraje}, Velocidad:{Pulsar.velocidad}");

            motos Yamaha = new motos();
            Yamaha.color = "negra";
            Yamaha. cilindraje = 100;
            Yamaha. velocidad= 85;

              System.Console.WriteLine($"Las caracteristicas de Yamaha son Color:{Yamaha.color}, cilindraje:{Yamaha.cilindraje}, Velocidad:{Yamaha.velocidad}");

            motos Suzuki = new motos();
            Suzuki.color= "azul";
            Suzuki.cilindraje = 140;
            Suzuki.velocidad = 80;

            System.Console.WriteLine($"Las caracteristicas de Suzuki son Color:{Suzuki.color}, cilindraje:{Suzuki.cilindraje}, Velocidad:{Suzuki.velocidad}");

            Pulsar.fullThrottle();
            

        }



    }
}