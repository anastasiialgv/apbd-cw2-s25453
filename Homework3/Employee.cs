namespace Homework3;

public class Employee : User
{
    public override string Role => "Employee";
    public override int MaxRental => 5;
    
    public Employee(string name, string surname) : base(name, surname) { }
    
    public override string ToString() => base.ToString() + $" | Role: employee, MaxRental: 5";

}