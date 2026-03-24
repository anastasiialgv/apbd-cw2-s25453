namespace Homework3;

public class Camera : Equipment
{
    public string ImageFormat { get; set; }
    public string ImageResolution  { get; set; }

    public Camera(string imageFormat, string imageResolution, string name, bool available, string color,
        string brand) : base(name, available, color, brand)
    {
        ImageFormat = imageFormat;
        ImageResolution = imageResolution;
    }
    
    public override string ToString() => base.ToString() + $" | Image Format: {ImageFormat}, Image Resolution: {ImageResolution}";
}