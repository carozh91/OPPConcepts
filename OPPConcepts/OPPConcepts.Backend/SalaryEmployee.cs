
namespace OPPConcepts.Backend;

public class SalaryEmployee : Employee
{

    private decimal _salary;
    public SalaryEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, decimal salary):
        base(id, firstName, lastName, isActive, bornDate, hireDate)
    {
        Salary = salary;
    }

    public decimal Salary 
    {   
        get => _salary; 
        set => _salary = ValidateSalary(value); 
    }

    public override decimal GetValueToPay() => Salary;

    public override string ToString() => base.ToString();

    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 2000000) 
        {
            throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be gratest o equal than 2000000");
        }
        return salary;
    }   


}
