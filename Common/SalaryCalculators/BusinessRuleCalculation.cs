namespace Common.SalaryCalculators
{
  public abstract class BusinessRuleCalculation : IBusinessRuleCalculation
  {
    public decimal Calculate(Employee employee)
    {
      var salary = employee.Salary;

      if (salary > Limit())
        return salary * PercentageAboveLimit();

      return salary * BasePercentage();
    }

    protected abstract decimal Limit();
    protected abstract decimal PercentageAboveLimit();
    protected abstract decimal BasePercentage();
  }
}