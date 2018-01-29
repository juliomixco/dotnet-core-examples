using System;

namespace IteratorDemo
{
  class ProportionalPainter : IPainter
  {
    public TimeSpan TimePerSqMeter { get; set; }
    public double DollarPerHour { get; set; }

    public bool IsAvailable => true;

    public double EstimateCompensation(double sqMeters)
    {
      return this.EstimateTimeToPaint(sqMeters).TotalHours * this.DollarPerHour;
    }

    public TimeSpan EstimateTimeToPaint(double sqMeters)
    {
      return TimeSpan.FromHours(this.TimePerSqMeter.TotalHours * sqMeters);
    }
  }
}