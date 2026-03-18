namespace Homework3;

public class Laptop : Equipment
{
    public double screenDiagonal { get; set; }
    public string OperatingSystem { get; set; }

    public Laptop(double screenDiagonal, string operatingSystem, string name, bool available, string color, int id,
        string brand)
        : base(name, available, color, id, brand)
    {
        this.screenDiagonal = screenDiagonal;
        this.OperatingSystem = operatingSystem;
    }

}