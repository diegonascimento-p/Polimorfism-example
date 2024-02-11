using Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        
        Poligon rectangle = new Rectangle(5, 10);
        Poligon triangle = new Triangle(4, 7);

        Console.WriteLine("Rectangle area: " + rectangle.CalculateArea());
        Console.WriteLine("Triangle area: " + triangle.CalculateArea());
    }
}