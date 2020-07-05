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

      foreach (var letter in symbol)
      {
        accumulator += romanDictionary[letter];
      }

      return accumulator;
    }
  }
}