using System.Security.Cryptography;

namespace Homework3;

public abstract class User
{
    private static int _counter = 0;
    public int Id;
    public string Name { get; set; }
    public string Surname { get; set; }
    public abstract string Role { get; }
    public abstract int MaxRental { get; }

    public User(string name, string surname)
    {
        _counter++;
        Id = _counter;
        Name = name;
        Surname = surname; 
    }
}