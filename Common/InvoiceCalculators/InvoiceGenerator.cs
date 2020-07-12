using System;
using System.Collections.Generic;
using System.Linq;

namespace Common.InvoiceCalculators
{
  public class InvoiceGenerator
  {
    private const decimal DiscountFactor = 0.94m;
    private IList<IActionAfterGenerateInvoice> actions;

    public InvoiceGenerator(IList<IActionAfterGenerateInvoice> actions)
    {
      this.actions = actions;
    }

    public Invoice Generate(Order order)
    {
      var invoice = new Invoice(order.Customer, order.TotalValue * DiscountFactor, DateTime.Now);

      foreach (var action in actions)
        action.Execute(invoice);

      return invoice;
    }
  }
}