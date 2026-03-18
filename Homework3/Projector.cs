namespace Homework3;

public class Projector : Equipment
{
    public string resolution { get; set; }
    public string displayTechnology { get; set; }

    public Projector(string name, string color, int id, bool available, string brand, string resolution,
        string displayTechnology)
        : base(name, available, color, id, brand)
    {
        this.resolution = resolution;
        this.displayTechnology = displayTechnology;
    }
}