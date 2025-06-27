
using Emp.src.enums;

namespace Emp.src.models;
public class EmployeeModel
{
    public int EmployeeId { get; set; }
    //public Address Address { get; set; }
    public string Address { get; set; }
    public EmployeeSalaryModel Salary { get; set; }
    public EmployeeType TypeOfEmployee { get; set; }

    public EmployeeModel(string address,
        EmployeeSalaryModel employeeSalaryModel,
        EmployeeType typeofEmployee)
    {
        this.Address = address;
        Salary = employeeSalaryModel;
        TypeOfEmployee = typeofEmployee;
    }
}
