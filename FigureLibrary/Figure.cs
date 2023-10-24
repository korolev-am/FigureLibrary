using System.Diagnostics;

namespace FigureLibrary;

abstract public class Figure
{
    protected double? square = null;
    protected double delta = 0.00001;

    public abstract double GetSquare();

    static public bool DoubleComparer(double a, double b, double delta = 0.00001)
    {
        return Math.Abs(a - b) < delta;
    }
}

public class Triangle: Figure
{   
    private double[] sides;

    public Triangle(double a, double b, double c)
    {
        sides = new double[3] {a, b, c};
        bool IsTriangle = CheckIfTriangle();
        Debug.Assert(IsTriangle, "Is not a triangle, check sides length.");
    }

    private bool CheckIfTriangle()
    {
        Array.Sort(sides);
        return sides[0] + sides[1] - sides[2] > 0;
    }

    public bool CheckIfRectangular()
    {
        return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < delta;
    }

    public override double GetSquare()
    {
        if(!square.HasValue)
        {
            double p = (sides[0] + sides[1] + sides[2]) / 2;
            square = Math.Sqrt(p*(p - sides[0])*(p - sides[1])*(p - sides[2]));
        }
        return (double)square;
    }
}

public class Circle : Figure
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
        bool IsCircle = CheckIfCircle();
        Debug.Assert(IsCircle, "Radius should be non-negative.");
    }

    private bool CheckIfCircle()
    {
        return radius >= 0;
    }

    public override double GetSquare()
    {
        if(!square.HasValue)
        {
            square = Math.PI * radius * radius;
        }
        return (double)square;
    }
}
