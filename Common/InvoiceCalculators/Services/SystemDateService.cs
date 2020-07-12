using System;

namespace Common.InvoiceCalculators.Services
{
  public class SystemDateService : ISystemDateService
  {
    private readonly int startOfWork = 8;

    public DateTime GetBusinessDateOrNext()
    {
      var today = DateTime.Now;

      if (today.DayOfWeek == DayOfWeek.Saturday)
        return new DateTime(today.Year, today.Month, today.Day, startOfWork, 0, 0).AddDays(2);

      if (today.DayOfWeek == DayOfWeek.Sunday)
        return new DateTime(today.Year, today.Month, today.Day, startOfWork, 0, 0).AddDays(1);

      return today;
    }
  }
}