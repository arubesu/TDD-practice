using System.Collections.Generic;
using Common.InvoiceCalculators;
using Moq;
using NUnit.Framework;

namespace Tests.InvoiceCalculators
{
  public class InvoiceGeneratorTest
  {
    private InvoiceGenerator invoiceGenerator;
    private Order order;
    private Invoice invoice;

    [Test]
    public void ShouldGenerateInvoiceDiscounting6Percent()
    {
      var action = new Mock<IActionAfterGenerateInvoice>();
      var actions = new List<IActionAfterGenerateInvoice>();

      invoiceGenerator = new InvoiceGenerator(actions);
      order = new Order("Gus Herzog", 1000, 1);
      invoice = invoiceGenerator.Generate(order);
      Assert.AreEqual(1000 * 0.94, invoice.Value);
    }

    [Test]
    public void ShouldExecuteActionsAfterGenerateInvoice()
    {
      var action1 = new Mock<IActionAfterGenerateInvoice>();
      var action2 = new Mock<IActionAfterGenerateInvoice>();
      var action3 = new Mock<IActionAfterGenerateInvoice>();

      var actions = new List<IActionAfterGenerateInvoice>
      {
        action1.Object, action2.Object, action3.Object
      };

      invoiceGenerator = new InvoiceGenerator(actions);
      order = new Order("Gus Herzog", 1000, 1);
      invoice = invoiceGenerator.Generate(order);

      action1.Verify(x => x.Execute(invoice), Times.Once);
      action2.Verify(x => x.Execute(invoice), Times.Once);
      action3.Verify(x => x.Execute(invoice), Times.Once);
    }
  }
}