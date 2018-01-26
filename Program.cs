using System;
using System.Collections.Generic;
using System.Linq;
using IteratorDemo;

namespace test
{
  class Program
  {
    private static IPainter FindCheapestPainter(double sqMeters, IEnumerable<IPainter> painters)
    {
      return painters
      .Where(painter => painter.IsAvailable)
      .WithMinimum(painter => painter.EstimateCompensation(sqMeters: sqMeters));
    }

    static void Main(string[] args)
    {
      string message = "      Hello World!       ";
      Console.WriteLine($"[{message}]");

      string trimmedMessage = message.TrimStart();
      Console.WriteLine($"[{trimmedMessage}]");

      trimmedMessage = message.TrimEnd();
      Console.WriteLine($"[{trimmedMessage}]");

      trimmedMessage = message.Trim();
      Console.WriteLine($"[{trimmedMessage}]");
    }
  }
}
