using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPConcepts.Backend;

public abstract class Employee
{
    protected Employee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        IsActive = isActive;
        BornDate = bornDate;
        HireDate = hireDate;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public bool IsActive { get; set; }

    public Date BornDate { get; set; }

    public Date HireDate { get; set; }


    public override string ToString()
    {
        return $"{Id}\t{FirstName} {LastName}\n\t" +
               $"Value To Pay: {GetValueToPay()}";
    }

    public abstract decimal GetValueToPay();


}
