using System;

namespace ConsoleAppEnum
{
  internal class Program
  {
    private static void Main()
    {
      const Seasons ete = Seasons.Summer;
      const Seasons sunshine = Seasons.Summer| Seasons.Spring;
      const Seasons ski = Seasons.Winter | Seasons.Autumn;
      const Seasons swimming = ete | Seasons.Spring;
      Console.WriteLine($"Ski can be done during {GetStringFromEnum(ski)}");
      Console.WriteLine($"Swimming can be done during {GetStringFromEnum(swimming)}");
      Console.ReadKey();
    }

    private static string GetStringFromEnum(Seasons oneOrMoreSeasons)
    {
      return oneOrMoreSeasons.ToString().Replace(",", " or");
    }

    [Flags]
    public enum Seasons
    {
      None = 0,
      Summer = 1,
      Autumn = 2,
      Winter = 4,
      Spring = 8,
      All = Summer | Autumn | Winter | Spring,
    }
  }
}