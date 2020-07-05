namespace Common.SalaryCalculators
{
  public static class SalaryCalculator
  {
    // Discount rule I: 
    // Developers have a 20% discount if their salary is higher than $ 3000.0.
    // Otherwise, the discount is 10%.

    public static decimal Calculate(Employee employee)
    {
      if (employee.Salary > 3000)
        return employee.Salary * 0.8m;

      return employee.Salary * 0.9m;
    }
  }
}