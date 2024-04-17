using shapes_Lib;

public class isquare : IShape
{
    public double SideLength { get; set; }

    public double CalculateArea()
    {
        return SideLength * SideLength;
    }

    public double CalculatePerimeter()
    {
        return 4 * SideLength;
    }
}
