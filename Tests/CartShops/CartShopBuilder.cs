using Common.CartShops;

namespace Tests.CartShops
{
  public class CartShopBuilder
  {
    public CartShop cartShop;
    public CartShopBuilder()
    {
      cartShop = new CartShop();
    }

    public CartShop Build() => cartShop;

    public CartShopBuilder WithItems(params decimal[] values)
    {
      for (int i = 0; i < values.Length; i++)
        cartShop.AddItem(new Item($"Item{i + 1}", 1, values[i]));

      return this;
    }
  }
}