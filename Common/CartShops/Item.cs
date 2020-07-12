namespace Common.CartShops
{

  public class Item
  {
    public Item(string description, int amount, decimal value)
    {
      Description = description;
      Amount = amount;
      Value = value;
    }

    public string Description { get; private set; }
    public int Amount { get; private set; }
    public decimal Value { get; private set; }
    public decimal TotalValue => Value * Amount;
  }
}