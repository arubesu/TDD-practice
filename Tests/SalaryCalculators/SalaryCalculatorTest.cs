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

    [TestCase(5000, Role.Developer, 4000)]
    [TestCase(5000, Role.DBA, 3750)]
    [TestCase(5000, Role.Tester, 3750)]
    public void ShouldGiveDiscountByRoleWhenSalaryIsHigherThanLimit(decimal salary, Role role, decimal expected)
    {
      var employee = new Employee(name: "Fleta Balistreri", salary, role);

      var result = SalaryCalculator.Calculate(employee);
      Assert.AreEqual(expected, result);
    }

    [TestCase(3000, Role.Developer, 2700)]
    [TestCase(3000, Role.DBA, 2550)]
    [TestCase(3000, Role.Tester, 2550)]
    public void ShouldGiveDiscountInSalaryWhenSalaryIsLessThanLimit(decimal salary, Role role, decimal expected)
    {
      var employee = new Employee(name: "John Hermiston", salary, role);

      var result = SalaryCalculator.Calculate(employee);
      Assert.AreEqual(expected, result);
    }
  }
}