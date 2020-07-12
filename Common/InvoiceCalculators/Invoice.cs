using System;

namespace Common.InvoiceCalculators
{
  public class Invoice
  {
    private string Customer { get; }
    private double Value { get; }
    private DateTime Date { get; }

    public Invoice(string customer, double value, DateTime date)
    {
      Customer = customer;
      Value = value;
      Date = date;
    }
  }
}