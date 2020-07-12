using System;
using Common.InvoiceCalculators.DAO;
using Common.InvoiceCalculators.Services;

namespace Common.InvoiceCalculators
{
  public class InvoiceGenerator
  {
    private InvoiceDAO invoiceDAO;
    private SAPService sapService;

    public InvoiceGenerator(InvoiceDAO invoiceDAO, SAPService sapService)
    {
      this.invoiceDAO = invoiceDAO;
      this.sapService = sapService;
    }

    public Invoice Generate(Order order)
    {
      var invoice = new Invoice(order.Customer, order.TotalValue * 0.94m, DateTime.Now);

      invoiceDAO.Persist(invoice);
      sapService.Send(invoice);

      return invoice;
    }
  }
}