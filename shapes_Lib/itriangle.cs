using shapes_Lib;
public class itriangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }

    public double CalculatePerimeter()
    {
        return 3 * Base;
    }
}
