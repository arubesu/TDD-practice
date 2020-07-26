using System.Collections.Generic;
using System.Linq;

namespace Common.BankSlipProcessors
{
  public class Invoice
  {
    private List<Payment> payments = new List<Payment>();

    public string CustomerName { get; }
    public decimal Value { get; }

    public bool TotalPaid => payments.Sum(p => p.Value) >= Value;

    public IReadOnlyCollection<Payment> Payments
    {
      get => payments.AsReadOnly();
    }

    public Invoice(string customerName, decimal value)
    {
      CustomerName = customerName;
      Value = value;
    }

    public void AddPayment(Payment payment) => payments.Add(payment);
  }
}