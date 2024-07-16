public abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
    public abstract double CalculateVolume();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);

    public override double CalculatePerimeter() => 2 * Math.PI * Radius;

    public override double CalculateVolume() => 0;
}

public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }

    public override double CalculateArea() => 0.5 * Base * Height;

    public override double CalculatePerimeter() => Base + 2 * Height; // Approximation for isosceles triangle

    public override double CalculateVolume() => 0;
}

public class Square : Shape
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    public override double CalculateArea() => Math.Pow(Side, 2);

    public override double CalculatePerimeter() => 4 * Side;

    public override double CalculateVolume() => 0;
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double CalculateArea() => Length * Width;

    public override double CalculatePerimeter() => 2 * (Length + Width);

    public override double CalculateVolume() => 0;
}
