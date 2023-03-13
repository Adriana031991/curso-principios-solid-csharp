namespace OpenClose;
//using System;

public interface Employee
{
    public string Fullname { get; set; }
    public int HoursWorked { get; set; }

    // public Employee()
	// {
	// }

    public decimal CalculateSalaryMonthly();
}
