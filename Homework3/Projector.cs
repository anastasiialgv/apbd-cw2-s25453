namespace Homework3;

public class Projector : Equipment
{
    public string Resolution { get; set; }
    public string DisplayTechnology { get; set; }

    public Projector(string name, string color, bool available, string brand, string resolution,
        string displayTechnology)
        : base(name, available, color, brand)
    {
        Resolution = resolution;
        DisplayTechnology = displayTechnology;
    }
    
    public override string ToString() => base.ToString() + $" | Resolution: {Resolution}, Display Technology: {DisplayTechnology}";
}