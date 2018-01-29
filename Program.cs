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

    private static IPainter FindFastestPainter(double sqMeters, IEnumerable<IPainter> painters)
    {
      return painters
      .Where(painter => painter.IsAvailable)
      .WithMinimum(painter => painter.EstimateTimeToPaint(sqMeters));
    }

    private static IPainter WorkTogether(double sqMeters, IEnumerable<IPainter> painters)
    {
      TimeSpan time = TimeSpan.FromHours(
        1 / painters
       .Where(painter => painter.IsAvailable)
       .Select(painter => 1 / painter.EstimateTimeToPaint(sqMeters).TotalHours)
       .Sum()
       );

      double cost = painters
     .Where(painter => painter.IsAvailable)
     .Select(painter => painter.EstimateCompensation(sqMeters) /
            painter.EstimateTimeToPaint(sqMeters).TotalHours
            * time.TotalHours)
      .Sum();
      return new ProportionalPainter()
      {
        TimePerSqMeter = TimeSpan.FromHours(time.TotalHours / sqMeters),
        DollarPerHour = cost / time.TotalHours
      };
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
