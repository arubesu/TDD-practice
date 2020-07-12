namespace Common.SalaryCalculators
{
  public interface IBusinessRuleCalculation
  {
    decimal Calculate(Employee employee);
  }
}