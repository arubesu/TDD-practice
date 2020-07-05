using NUnit.Framework;

namespace Tests.SalaryCalculators
{
  public class SalaryCalculatorTest
  {
    [SetUp]
    public void Setup()
    {
    }

    // Developers have a 20% discount if their salary is higher than $ 3000.0.
    // Otherwise, the discount is 10%.

    [Test]
    public void ShouldGive20PercentDiscountInDeveloperSalaryWhenSalaryIs3000()
    {


      Assert.Fail();
    }


    [Test]
    public void ShouldGive10PercentDiscountInDeveloperSalaryWhenSalaryIsLessThan3000()
    {

      Assert.Fail();
    }

  }
}