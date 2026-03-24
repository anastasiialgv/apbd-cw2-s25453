namespace Homework3;

public class Laptop : Equipment
{
    public double ScreenDiagonal { get; set; }
    public string OperatingSystem { get; set; }

    public Laptop(double screenDiagonal, string operatingSystem, string name, bool available, string color,
        string brand)
        : base(name, available, color, brand)
    {
        ScreenDiagonal = screenDiagonal;
        OperatingSystem = operatingSystem;
    }
    public override string ToString() => base.ToString() + $" | Screen Diagonal: {ScreenDiagonal}\", " +
                                         $"Operating System: {OperatingSystem}";    
}