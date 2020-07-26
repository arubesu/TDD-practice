using System;
using System.Collections.Generic;

namespace Common.BankSlipProcessors
{
  public class BankSlipProcessor
  {
    public void Process(List<BankSlip> bankslips, Invoice invoice)
    {
      foreach (var bankSlip in bankslips)
        invoice.AddPayment(new Payment(bankSlip.Value));
    }
  }
}