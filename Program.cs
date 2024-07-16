using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lütfen geometrik şekli seçiniz (Daire, Üçgen, Kare, Dikdörtgen):");
        string shapeType = Console.ReadLine();

        ShapeFactory shapeFactory = new ShapeFactory();
        Shape shape;
        try
        {
            shape = shapeFactory.CreateShape(shapeType);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        Console.WriteLine("Hesaplanmak istenen boyutu seçiniz (Alan, Çevre, Hacim):");
        string calculationType = Console.ReadLine();

        Calculator calculator = new Calculator();
        double result;
        try
        {
            result = calculator.Calculate(shape, calculationType);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        Console.WriteLine($"Hesaplanan {calculationType}: {result}");
    }
}
