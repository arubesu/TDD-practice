namespace Common.SalaryCalculators
{
  public class FifteenOrTwentyFivePercent : BusinessRuleCalculation
  {
    protected override decimal Limit() => 2500m;
    protected override decimal BasePercentage() => 0.85m;
    protected override decimal PercentageAboveLimit() => 0.75m;
  }
}