namespace Common.BankSlipProcessors
{
  public class Payment
  {

    public Payment(decimal value)
    {
      this.Value = value;

    }
    public decimal Value { get; set; }
  }
}