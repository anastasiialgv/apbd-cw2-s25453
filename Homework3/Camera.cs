namespace Homework3;

public class Camera : Equipment
{
    public string imageFormat { get; set; }
    public string imageResolution  { get; set; }

    public Camera(string imageFormat, string imageResolution, string name, bool available, string color, int id,
        string brand) : base(name, available, color, id, brand)
    {
        this.imageFormat = imageFormat;
        this.imageResolution = imageResolution;
    }
}