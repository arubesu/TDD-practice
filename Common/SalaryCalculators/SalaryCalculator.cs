namespace Common.SalaryCalculators
{
  public static class SalaryCalculator
  {
    // Discount rule I: 
    // Developers have a 20% discount if their salary is higher than $ 3000.0.
    // Otherwise, the discount is 10%.

    //DBAs and Testers have 25% discount if their salary is higher than $ 2500.
    //Otherwise, the discount is 15%.

    public static decimal Calculate(Employee employee) =>
       employee.Role.Rule.Calculate(employee);
  }
}