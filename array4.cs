using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare an array
      string[] cars;

      // Add values, using new
      cars = new string[] {"Volvo", "BMW", "Ford"};

      // esto causaria un error: cars = {"Volvo", "BMW", "Ford"};

      Console.WriteLine(cars[0]);
    }
  }
}