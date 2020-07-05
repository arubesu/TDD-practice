using Common.RomanConverters;
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

    [Test]
    public void ShouldConvertSymbolWhenRepeatedThreeTimes()
    {
      var symbol = "XXX";
      var expected = 30;
      ConvertAndAssertAreEqual(symbol, expected);
    }

    [Test]
    public void ShouldConvertSymbolFourLettersLikeXXII()
    {
      var symbol = "XXII";
      var expected = 22;
      ConvertAndAssertAreEqual(symbol, expected);
    }

    [Test]
    public void ShouldConvertSymbolWhenALowerValueSymbolIsFollowedByABiggerValueSymbolLikeIX()
    {
      var symbol = "IX";
      var expected = 9;
      ConvertAndAssertAreEqual(symbol, expected);
    }

    [Test]
    public void ShouldConvertSymbolWhenALowerValueSymbolIsFollowedByABiggerValueSymbolLikeIV()
    {
      var symbol = "IV";
      var expected = 4;
      ConvertAndAssertAreEqual(symbol, expected);
    }

    [Test]
    public void ShouldConvertSymbolsWhenMixedLikeXXIV()
    {
      var symbol = "XXIV";
      var expected = 24;
      ConvertAndAssertAreEqual(symbol, expected);
    }

    [Test]
    public void ShouldConvertSymbolsWhenMixedLikeXIX()
    {
      var symbol = "XIX";
      var expected = 19;
      ConvertAndAssertAreEqual(symbol, expected);
    }

    [Test]
    public void ShouldReturnNegativeWhenSymbolRepeatedMoreThanTimesInARowLikeXXXX()
    {
      var symbol = "XXXX";
      var expected = -1;
      ConvertAndAssertAreEqual(symbol, expected);
    }

    [Test]
    public void ShouldNotReturnNegativeWhenSymbolRepeatedMoreThanTimesButNotInARowLikeXXXIX()
    {
      var symbol = "XXXIX";
      var expected = 39;
      ConvertAndAssertAreEqual(symbol, expected);
    }

    [TestCase("VVV")]
    [TestCase("VV")]
    [TestCase("DD")]
    [TestCase("LL")]
    [TestCase("XLL")]
    [TestCase("XVV")]
    public void ShouldNotReturnNegativeWhenASymbolCannotBeRepeated(string symbol)
    {
      var expected = -1;
      ConvertAndAssertAreEqual(symbol, expected);
    }

    [TestCase("XIII", 13)]
    [TestCase("XIV", 14)]
    [TestCase("XVIII", 18)]
    [TestCase("XXVI", 26)]
    [TestCase("XXXXII", -1)]
    [TestCase("LXI", 61)]
    [TestCase("DXLV", 545)]
    [TestCase("CCXVII", 217)]
    [TestCase("VII", 7)]
    [TestCase("XXXIV", 34)]
    [TestCase("XXXVII", 37)]
    [TestCase("XLIII", 43)]
    [TestCase("XLVIII", 48)]
    [TestCase("LII", 52)]
    [TestCase("CXL", 140)]
    [TestCase("CXLV", 145)]
    public void ShouldConvertAllSymbolsBatchTest(string symbol, int expected)
    {
      ConvertAndAssertAreEqual(symbol, expected);
    }

    private static void ConvertAndAssertAreEqual(string symbol, int expected)
    {
      var result = RomanConverter.Convert(symbol);
      Assert.AreEqual(expected, result);
    }
  }
}