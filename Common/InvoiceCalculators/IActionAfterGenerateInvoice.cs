namespace Common.InvoiceCalculators
{
  public interface IActionAfterGenerateInvoice
  {
    void Execute(Invoice invoice);
  }
}