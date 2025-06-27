// See https://aka.ms/new-console-template for more information
using Emp.src.enums;
using Emp.src.models;

Console.WriteLine("Hello, World!");

List<EmployeeModel> employees = new List<EmployeeModel>();

employees.Add(new EmployeeModel(
    "123 Main St",
    new EmployeeSalaryModel { Amount = 50000, Grade = "A" },
    EmployeeType.FTE
));

employees.Add(new EmployeeModel(
    "456 Elm St",
    new EmployeeSalaryModel { Amount = 60000, Grade = "B" },
    EmployeeType.CTE
));

employees.Add(new EmployeeModel(
    "789 Oak St",
    new EmployeeSalaryModel { Amount = 70000, Grade = "C" },
    EmployeeType.FTE
));

employees.Where( slry => slry.Salary.Amount > employees..max)
         .ToList()
         .ForEach(emp => Console.WriteLine($"Employee Address: {emp.Address}, Salary: {emp.Salary.Amount}, Grade: {emp.Salary.Grade}, Type: {emp.TypeOfEmployee}"));