using Commom.RomanConverters;
using NUnit.Framework;

namespace Tests.RomanConverters
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldConvertSymbolI()
    {
      var symbol = "I";
      var expected = 1;
      ConvertAndAssertAreEqual(symbol, expected);
    }

    [Test]
    public void ShouldConvertSymbolV()
    {
      var symbol = "V";
      var expected = 5;
      ConvertAndAssertAreEqual(symbol, expected);
    }

    private static void ConvertAndAssertAreEqual(string symbol, int expected)
    {
      var result = RomanConverter.Convert(symbol);
      Assert.AreEqual(expected, result);
    }
  }
}