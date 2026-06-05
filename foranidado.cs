using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Outer loop
      for (int i = 1; i <= 2; ++i) 
      {
        Console.WriteLine("Outer: " + i);  // Ejecuta 2 veces
        
        // Inner loop
        for (int j = 1; j <= 3; j++) 
        {
          Console.WriteLine(" Inner: " + j);  // ejecuta 6 veces (2 * 3)
        }
      }    
    }
  }
}