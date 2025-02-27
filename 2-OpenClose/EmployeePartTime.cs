namespace OpenClose;

    public class EmployeePartTime : Employee
{
    public string Fullname { get; set; }
    public int HoursWorked { get; set; }

    public EmployeePartTime(string fullname, int hoursWorked)
    {
        Fullname = fullname;
        HoursWorked = hoursWorked;
    }

    // public override decimal CalculateSalaryMonthly()
    // {
    //     decimal hourValue = 20000M;
    //     decimal salary = hourValue * HoursWorked;
    //     if (HoursWorked > 160)
    //     {
    //         decimal effortCompensation = 5000M;
    //         int extraDays = HoursWorked - 160;
    //         salary += effortCompensation * extraDays;
    //     }
    //     return salary;
    // }
    public decimal CalculateSalaryMonthly()
    {
        decimal hourValue = 20000M;
        decimal salary = hourValue * HoursWorked;
        if (HoursWorked > 160)
        {
            decimal effortCompensation = 5000M;
            int extraDays = HoursWorked - 160;
            salary += effortCompensation * extraDays;
        }
        return salary;
    }


}
