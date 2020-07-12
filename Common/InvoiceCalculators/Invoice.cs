using System;

namespace Common.InvoiceCalculators
{
  public class Invoice
  {
    public string Customer { get; private set; }
    public decimal Value { get; private set; }
    public DateTime Date { get; private set; }

    public Invoice(string customer, decimal value, DateTime date)
    {
      Customer = customer;
      Value = value;
      Date = date;
    }
  }
}