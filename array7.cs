using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
      numbers[0, 0] = 5;//modificación de elementos en una matriz
      Console.WriteLine(numbers[0, 0]);
    }
  }
}