namespace Common.SalaryCalculators
{
  public static class SalaryCalculator
  {
    public static decimal Calculate(Employee employee)
    {
      if (employee.Salary > 3000)
      {
        return employee.Salary * 0.8m;
      }
      else
      {
        return employee.Salary * 0.9m;
      }
    }
  }
}