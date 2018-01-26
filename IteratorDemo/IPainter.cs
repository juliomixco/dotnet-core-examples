using System;

namespace IteratorDemo
{
  interface IPainter
  {
    bool IsAvailable { get; }
    TimeSpan EstimateTimeToPaint(double sqMeters);
    double EstimateCompensation(double sqMeters);
  }
}