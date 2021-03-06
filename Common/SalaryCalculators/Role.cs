namespace Common.SalaryCalculators
{
  public class Role
  {
    public IBusinessRuleCalculation Rule { get; private set; }

    public static Role Developer { get { return new Role(new TenOrTwentyPercent()); } }
    public static Role DBA { get { return new Role(new FifteenOrTwentyFivePercent()); } }
    public static Role Tester { get { return new Role(new FifteenOrTwentyFivePercent()); } }

    public Role(IBusinessRuleCalculation rule)
    {
      Rule = rule;
    }
  }
}