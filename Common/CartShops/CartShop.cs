using System;
using System.Collections.Generic;

namespace Common.CartShops
{
  public class CartShop
  {
    public IList<Item> Items { get; private set; }

    public CartShop()
    {
      Items = new List<Item>();
    }

    public void AddItem(Item item) => Items.Add(item);

    public decimal GetHigherValue()
    {
      if (Items.Count == 0)
        return 0;

      if (Items.Count == 1)
        return Items[0].Value;

      var higher = 0m;

      foreach (var item in Items)
      {
        if (item.Value > higher)
          higher = item.Value;
      }

      return higher;
    }
  }
}