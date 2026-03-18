namespace Homework3;

public abstract class Equipment
{
    public string name { get; set; }
    public string status { get; set; }
    public string size { get; set; }
    public int levelOfBattery { get; set; }

    public Equipment(string name, string status, string size, int levelOfBattery)
    {
        this.name = name;
        this.status = status;
        this.size = size;
        this.levelOfBattery = levelOfBattery;
    }
    
}