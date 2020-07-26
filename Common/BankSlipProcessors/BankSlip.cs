namespace Common.BankSlipProcessors
{
  public class BankSlip
  {
    public BankSlip(decimal value)
    {
      Value = value;
    }

    public decimal Value { get; }
  }
}