using Common.SalaryCalculators;
using NUnit.Framework;

namespace Tests.SalaryCalculators
{
  public class SalaryCalculatorTest
  {
    [SetUp]
    public void Setup()
    {
    }

    // Discount rule I: 
    // Developers have a 20% discount if their salary is higher than $ 3000.0.
    // Otherwise, the discount is 10%.

    [Test]
    public void ShouldGive20PercentDiscountInDeveloperSalaryWhenSalaryIs3000()
    {
      var developer = new Employee(name: "Fleta Balistreri", salary: 5000m, Role.Developer);
      var expected = 4000m;

      var result = SalaryCalculator.Calculate(developer);
      Assert.AreEqual(expected, result);
    }


    [Test]
    public void ShouldGive10PercentDiscountInDeveloperSalaryWhenSalaryIsLessThan3000()
    {
      var developer = new Employee(name: "John Hermiston", salary: 2900m, Role.Developer);
      var expected = 2610m;

      var result = SalaryCalculator.Calculate(developer);
      Assert.AreEqual(expected, result);
    }
  }
}