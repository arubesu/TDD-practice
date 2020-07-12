using System;
using Common.InvoiceCalculators.DAO;

namespace Common.InvoiceCalculators
{
  public class InvoiceGenerator
  {
    public Invoice Generate(Order order)
    {
      var invoice = new Invoice(order.Customer, order.TotalValue * 0.94m, DateTime.Now);

      new InvoiceDAO().Persist(invoice);

      return invoice;
    }
  }
}