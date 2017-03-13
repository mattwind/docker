using System;
using System.Threading;

class Counter
{
  static void Main()
  {
    for (int i = 1; i <= 10; i++)
    {
      Console.WriteLine(i);
      Thread.Sleep(500);
    }
  }
}
