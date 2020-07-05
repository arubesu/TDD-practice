using System.Collections.Generic;
using System.Linq;

namespace Commom.RomanConverters
{
  public static class RomanConverter
  {

    const int InvalidInputResult = -1;

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

    private static char[] forbiddenToRepeat = new char[]{
        'V',
        'L',
        'D'
      };

    private static Dictionary<char, int> a =
   new Dictionary<char, int>
   {
        {'V', 5},
        {'L', 50},
        {'D', 500},
   };

    public static int Convert(string symbol)
    {
      if (HasForbiddenRepetition(symbol))
        return InvalidInputResult;

      var accumulator = 0;
      var symbolLength = symbol.Length;
      var lastValue = 0;
      var countRepeatedChar = 0;

      for (int i = 0; i < symbolLength; i++)
      {
        var currentValue = romanDictionary[symbol[i]];
        var nextIndex = i + 1 > symbolLength - 1 ? i : i + 1;
        var nextValue = romanDictionary[symbol[nextIndex]];
        var multiplier = 1;

        if (i == 0 || lastValue == currentValue)
        {
          countRepeatedChar++;
        }
        else
        {
          countRepeatedChar = 1;
        }

        if (countRepeatedChar > 3)
          return InvalidInputResult;

        if (nextValue > currentValue)
          multiplier = -1;

        accumulator += currentValue * multiplier;

        lastValue = currentValue;
      }

      return accumulator;
    }

    private static bool HasForbiddenRepetition(string symbol)
    {
      return symbol
      .GroupBy(letter => letter)
      .Where(group => group.Count() > 1)
      .Select(group => group.Key)
      .Any(letter => forbiddenToRepeat.Contains(letter));
    }
  }

}