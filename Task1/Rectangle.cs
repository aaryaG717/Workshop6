public class Rectangle
{
    private double length;
    private double breadth;

    public double Length
    {
        get => length;
        set => length = value;
    }

    public double Breadth
    {
        get => breadth;
        set => breadth = value;
    }

    public double GetArea() => length * breadth;

    public double GetPerimeter() => 2 * (length + breadth);

    public string SeeDetails() => $"Length: {length}, Breadth: {breadth}";
}
