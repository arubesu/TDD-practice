using System;

namespace Common.InvoiceCalculators
{
  public interface ISystemDateService
  {
    DateTime GetBusinessDateOrNext();
  }
}