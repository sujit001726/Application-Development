class Program
{
    static void Main()
    {
       
        Console.WriteLine("PI = " + Circle.PI);

        
        // 3. Calculate area and perimeter
        double radius = 5;
        Console.WriteLine("Area = " + Circle.Area(radius));
        Console.WriteLine("Perimeter = " + Circle.Perimeter(radius));
    }
}