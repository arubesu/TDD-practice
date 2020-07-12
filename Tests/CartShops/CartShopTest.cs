using NUnit.Framework;
using Common.CartShops;

namespace Tests.CartShops
{
  public class CartShopTest
  {
    private CartShopBuilder cartShopBuilder;

    [SetUp]
    public void Setup()
    {
      cartShopBuilder = new CartShopBuilder();
    }

    [Test]
    public void WhenSearchsForHigherValueShouldReturnZeroIfCartIsEmpty()
    {
      var result = cartShopBuilder
        .Build()
        .GetHigherValue();

      var expected = 0;

      Assert.AreEqual(expected, result);
    }

    [Test]
    public void WhenSearchsForHigherValueShouldReturnItemValueIfCartHas1Item()
    {
      var result = cartShopBuilder
        .WithItems(100)
        .Build()
        .GetHigherValue();

      var expected = 100;

      Assert.AreEqual(expected, result);
    }

    [Test]
    public void WhenSearchsForHigherValueShouldReturnHigherValue()
    {
      var result = cartShopBuilder
        .WithItems(100, 200, 1, 1, 2, 5, 1000, 5000, 200, 500, 895, 10)
        .Build()
        .GetHigherValue();

      var expected = 5000;

      Assert.AreEqual(expected, result);
    }
  }
}