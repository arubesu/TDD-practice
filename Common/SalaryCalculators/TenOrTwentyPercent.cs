namespace Common.SalaryCalculators
{
  public class TenOrTwentyPercent : BusinessRuleCalculation
  {
    protected override decimal Limit() => 3000m;
    protected override decimal BasePercentage() => 0.9m;
    protected override decimal PercentageAboveLimit() => 0.8m;
  }
}