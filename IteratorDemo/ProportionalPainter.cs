using System;

namespace IteratorDemo
{
  class ProportionalPainter : IPainter
  {
    public TimeSpan TimePerSqMeter { get; set; }
    public double DollarPerHour { get; set; }
    bool IPainter.IsAvailable => throw new NotImplementedException();




    TimeSpan EstimateTimeToPaint(double sqMeters) => 
      TimeSpan.FromHours(this.TimePerSqMeter.TotalHours * sqMeters);
    double IPainter.EstimateCompensation(double sqMeters) =>
      this.EstimateTimeToPaint(sqMeters).TotalHours * this.DollarPerHour;
  }
}