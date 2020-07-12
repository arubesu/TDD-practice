namespace Common.SalaryCalculators
{
  public class Role
  {
    public IBusinessRuleCalculation Rule { get; private set; }

    public Role Developer { get { return new Role(new TenOrTwentyPercent()); } }
    public Role DBA { get { return new Role(new FifteenOrTwentyFivePercent()); } }
    public Role Tester { get { return new Role(new FifteenOrTwentyFivePercent()); } }

    public Role(IBusinessRuleCalculation rule)
    {
      Rule = rule;
    }
  }
}