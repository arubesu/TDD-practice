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
      var result = RomanConverter.Convert(symbol);
      Assert.AreEqual(expected, result);
    }
  }
}