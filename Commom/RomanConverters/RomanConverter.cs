using System.Collections.Generic;

namespace Commom.RomanConverters
{
  public static class RomanConverter
  {

    private static Dictionary<char, int> romanDictionary =
      new Dictionary<char, int>
      {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
      };

    public static int Convert(string symbol)
    {
      var accumulator = 0;
      var symbolLength = symbol.Length;

      for (int i = 0; i < symbolLength; i++)
      {

        var currentValue = romanDictionary[symbol[i]];
        var nextIndex = i + 1 > symbolLength - 1 ? i : i + 1;
        var nextValue = romanDictionary[symbol[nextIndex]];
        var multiplier = 1;

        if (nextValue > currentValue)
          multiplier = -1;

        accumulator += currentValue * multiplier;
      }

      return accumulator;
    }
  }
}