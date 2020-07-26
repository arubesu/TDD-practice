using Common.BankSlipProcessors;
using NUnit.Framework;
using FluentAssertions;

namespace Tests.BankSlipProcessors
{
  public class InvoiceTest
  {
    public Invoice invoice;

    [SetUp]
    public void Setup()
    {
      invoice = new Invoice("Aurore", 500);
    }

    [Test]
    public void ShouldBePaidIfHasTotalPayment()
    {
      invoice.AddPayment(new Payment(500));
      var actual = invoice.TotalPaid;

      actual.Should().BeTrue();
    }

    [Test]
    public void ShouldNotBePaidIfHasPartialPayment()
    {
      invoice.AddPayment(new Payment(100));
      var actual = invoice.TotalPaid;

      actual.Should().BeFalse();
    }
  }
}