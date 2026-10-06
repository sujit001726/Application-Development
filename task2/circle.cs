// 1. Create the Circle class
public class Circle
{
    // 2. Declare a constant PI with the value 3.14
    public const double PI = 3.14;

    // 3. Method to calculate area
    public static double Area(double radius)
    {
        return PI * radius * radius;
    }

    // 4. Method to calculate perimeter
    public static double Perimeter(double radius)
    {
        return 2 * PI * radius;
    }
}