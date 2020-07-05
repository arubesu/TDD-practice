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

    [Test]
    public void ShouldGive20PercentDiscountWhenSalaryIsHigherThanLimit()
    {
      var developer = new Employee(name: "Fleta Balistreri", salary: 5000m, Role.Developer);
      var expected = 4000m;

      var result = SalaryCalculator.Calculate(developer);
      Assert.AreEqual(expected, result);
    }

    [Test]
    public void ShouldGive10PercentDiscountInDeveloperSalaryWhenSalaryIsLessThanLimit()
    {
      var developer = new Employee(name: "John Hermiston", salary: 2900m, Role.Developer);
      var expected = 2610m;

      var result = SalaryCalculator.Calculate(developer);
      Assert.AreEqual(expected, result);
    }
  }
}