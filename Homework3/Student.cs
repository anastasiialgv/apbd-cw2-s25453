namespace Homework3;

public class Student : User
{
    public override string Role => "Student";
    public override int MaxRental => 2;
    
    public Student(string name, string surname) : base(name, surname) { }
    
    public override string ToString() => base.ToString() + $" | Role: student, MaxRental: 2";

}