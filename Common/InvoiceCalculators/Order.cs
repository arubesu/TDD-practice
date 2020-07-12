namespace Common.InvoiceCalculators
{
  public class Order
  {
    public string Customer { get; private set; }
    public decimal TotalValue { get; private set; }
    public int AmountItems { get; private set; }

    public Order(string customer, decimal totalValue, int amountItems)
    {
      Customer = customer;
      TotalValue = totalValue;
      AmountItems = amountItems;
    }
  }
}