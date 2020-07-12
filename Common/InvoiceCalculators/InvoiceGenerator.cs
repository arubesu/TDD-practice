using System;
using System.Collections.Generic;
using System.Linq;
using Common.InvoiceCalculators.Services;

namespace Common.InvoiceCalculators
{
  public class InvoiceGenerator
  {
    private const decimal DiscountFactor = 0.94m;
    private IList<IActionAfterGenerateInvoice> actions;
    private ISystemDateService systemDateService;

    public InvoiceGenerator(IList<IActionAfterGenerateInvoice> actions, ISystemDateService systemDateService)
    {
      this.actions = actions;
      this.systemDateService = systemDateService;
    }

    public InvoiceGenerator(IList<IActionAfterGenerateInvoice> actions) :
      this(actions, new SystemDateService())
    { }

    public Invoice Generate(Order order)
    {
      var invoice = new Invoice(order.Customer, order.TotalValue * DiscountFactor, systemDateService.GetBusinessDateOrNext());

      foreach (var action in actions)
        action.Execute(invoice);

      return invoice;
    }
  }
}