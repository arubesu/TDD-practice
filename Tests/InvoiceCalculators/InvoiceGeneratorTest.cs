using Common.InvoiceCalculators;
using Common.InvoiceCalculators.DAO;
using Common.InvoiceCalculators.Services;
using Moq;
using NUnit.Framework;

namespace Tests.InvoiceCalculators
{
  public class InvoiceGeneratorTest
  {
    private Mock<InvoiceDAO> invoiceDaoMock;
    private Mock<SAPService> sapServiceMock;
    private InvoiceGenerator invoiceGenerator;
    private Order order;
    private Invoice invoice;

    [SetUp]
    public void Setup()
    {
      invoiceDaoMock = new Mock<InvoiceDAO>();
      sapServiceMock = new Mock<SAPService>();
      invoiceGenerator = new InvoiceGenerator(invoiceDaoMock.Object, sapServiceMock.Object);
      order = new Order("Gus Herzog", 1000, 1);
      invoice = invoiceGenerator.Generate(order);
    }

    [Test]
    public void ShouldGenerateInvoiceDiscounting6Percent()
    {
      Assert.AreEqual(1000 * 0.94, invoice.Value);
    }

    [Test]
    public void ShouldPersistInvoice()
    {
      invoiceDaoMock.Verify(x => x.Persist(invoice), Times.Once);
    }

    [Test]
    public void ShouldSendInvoiceToSAP()
    {
      sapServiceMock.Verify(x => x.Send(invoice), Times.Once);
    }
  }
}