using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      while (i < 10) 
      {
        Console.WriteLine(i);
        i++;
        if (i == 4) 
        {
          break; //para interrumpir y continuar con el bucle
        }
      }    
    }
  }
}
