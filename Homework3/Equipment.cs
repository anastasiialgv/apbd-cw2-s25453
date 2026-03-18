namespace Homework3;

public abstract class Equipment
{
    public int id { get; set; }
    public string name { get; set; }
    public bool available { get; set; }
    
    public string color { get; set; }
    public string brand { get; set; }
    

    public Equipment(string name, bool available, string color, int id, string brand)
    {
        this.name = name;
        this.available = available;
        this.color = color;
        this.id = id;
        this.brand = brand;
    }
    
}