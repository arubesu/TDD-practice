using System;

namespace Common.InvoiceCalculators
{
  public class InvoiceGenerator
  {
    public Invoice Generate(Order order)
    {
      return new Invoice(order.Customer, order.TotalValue * 0.94m, DateTime.Now);
    }
  }
}