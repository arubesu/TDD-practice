using System.Collections.Generic;
using System.Linq;
using Common.BankSlipProcessors;
using NUnit.Framework;

namespace Tests.BankSlipProcessors
{
  public class BankSlipProcessorTest
  {

    [Test]
    public void ShouldProcessOneBankSlipPayment()
    {
      var bankSlipProcessor = new BankSlipProcessor();

      var invoice = new Invoice("Aurore", 200m);
      var bankslip = new BankSlip(200m);
      var bankslips = new List<BankSlip> { bankslip };

      bankSlipProcessor.Process(bankslips, invoice);

      Assert.AreEqual(1, invoice.Payments.Count);
      Assert.AreEqual(200m, invoice.Payments.Sum(p => p.Value));
    }

    [Test]
    public void ShouldProcessManyBankSlipPayments()
    {
      var bankSlipProcessor = new BankSlipProcessor();

      var invoice = new Invoice("Aurore", 500m);
      var bankslips = new List<BankSlip>
      {
        new BankSlip(200m),
        new BankSlip(200m),
        new BankSlip(100m)
      };

      bankSlipProcessor.Process(bankslips, invoice);

      Assert.AreEqual(3, invoice.Payments.Count);
      Assert.AreEqual(500, invoice.Payments.Sum(p => p.Value));
    }
  }
}