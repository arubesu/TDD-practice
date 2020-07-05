namespace Common.SalaryCalculators
{
  public class Employee
  {
    public string Name { get; private set; }
    public decimal Salary { get; private set; }
    public Role Role { get; private set; }

    public Employee(string name, decimal salary, Role role)
    {
      Name = name;
      Salary = salary;
      Role = role;
    }
  }
}