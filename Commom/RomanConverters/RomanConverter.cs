using System.Collections.Generic;

namespace Commom.RomanConverters
{
  public static class RomanConverter
  {

    private static Dictionary<string, int> romanDictionary =
    new Dictionary<string, int>{
      {"I", 1},
      {"V", 5}
    };

    public static int Convert(string symbol)
    {
      return romanDictionary[symbol];
    }
  }
}