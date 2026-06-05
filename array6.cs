using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine(myNumbers.Max());  // para el numero más grande
      Console.WriteLine(myNumbers.Min());  // para el numero más pequeño
      Console.WriteLine(myNumbers.Sum());  // para la suma de numeros
      
    }
  }
}