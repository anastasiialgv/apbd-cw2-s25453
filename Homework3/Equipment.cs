namespace Homework3;

public abstract class Equipment
{
    private static int _counter = 0;
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Available { get; set; }
    
    public string Color { get; set; }
    public string Brand { get; set; }
    

    public Equipment(string name, bool available, string color, string brand)
    {
        _counter++;
        Id = _counter;
        Name = name;
        Available = available;
        Color = color;
        Brand = brand;
    }

    public override string ToString()
    {
        return $"[{Id}] {Name} (Available: {(Available ? "Да" : "Нет")}) {Color} {Brand}\n";
    }
}