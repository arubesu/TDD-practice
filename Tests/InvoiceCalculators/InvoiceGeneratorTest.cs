using Common.InvoiceCalculators;
using Common.InvoiceCalculators.DAO;
using Moq;
using NUnit.Framework;

namespace Tests.InvoiceCalculators
{
  public class InvoiceGeneratorTest
  {
    [Test]
    public void ShouldGenerateInvoiceDiscounting6Percent()
    {
      var generator = new InvoiceGenerator();
      var order = new Order("Gus Herzog", 1000, 1);
      var invoice = generator.Generate(order);
      Assert.AreEqual(1000 * 0.94, invoice.Value);
    }

    [Test]
    public void ShouldPersistInvoice()
    {
      var dao = new Mock<InvoiceDAO>();

    }
  }
}