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

    //DBAs and Testers have 25% discount if their salary is higher than $ 2500.
    //Otherwise, the discount is 15%.

    [Test]
    public void ShouldGive20PercentDiscountIfSalaryIsHigherThanLimit()
    {
      var salary = 5000m;
      var developer = new Employee(name: "Fleta Balistreri", salary, Role.Developer);
      Assert.AreEqual(4000, SalaryCalculator.Calculate(developer));
    }

    [Test]
    public void ShouldGive10PercentDiscountIfSalaryIsLessThanLimit()
    {
      var salary = 3000m;
      var developer = new Employee(name: "Fleta Balistreri", salary, Role.Developer);
      Assert.AreEqual(2700m, SalaryCalculator.Calculate(developer));
    }

    [Test]
    public void ShouldGive25PercentDiscountIfSalaryIsHigherThanLimit()
    {
      var salary = 3000m;
      var dba = new Employee(name: "Fleta Balistreri", salary, Role.DBA);
      var tester = new Employee(name: "Fleta Balistreri", salary, Role.Tester);

      Assert.AreEqual(2250m, SalaryCalculator.Calculate(dba));
      Assert.AreEqual(2250m, SalaryCalculator.Calculate(tester));
    }

    [Test]
    public void ShouldGive15PercentDiscountIfSalaryIsLessThanLimit()
    {
      var salary = 2500m;
      var dba = new Employee(name: "Fleta Balistreri", salary, Role.DBA);
      var tester = new Employee(name: "Fleta Balistreri", salary, Role.Tester);

      Assert.AreEqual(2125m, SalaryCalculator.Calculate(dba));
      Assert.AreEqual(2125m, SalaryCalculator.Calculate(tester));
    }
  }
}