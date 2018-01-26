using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
  class EnumerableExample
  {
    static IEnumerable<string> Suits()
    {
      yield return "clubs";
      yield return "diamonds";
      yield return "hearts";
      yield return "spades";
    }

    static IEnumerable<string> Ranks()
    {
      yield return "two";
      yield return "three";
      yield return "four";
      yield return "five";
      yield return "six";
      yield return "seven";
      yield return "eight";
      yield return "nine";
      yield return "ten";
      yield return "jack";
      yield return "queen";
      yield return "king";
      yield return "ace";
    }
    void printCollections()
    {
      var ranks = Ranks().Where(x => x.Length > 3);
      foreach (var item in ranks)
      {
        Console.WriteLine(item);

      }
    }
  }
}