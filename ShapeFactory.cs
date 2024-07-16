public class ShapeFactory
{
    public Shape CreateShape(string shapeType)
    {
        switch (shapeType.ToLower())
        {
            case "daire":
                Console.Write("Yarıçapı giriniz: ");
                double radius = double.Parse(Console.ReadLine());
                return new Circle(radius);
            case "üçgen":
                Console.Write("Taban uzunluğunu giriniz: ");
                double baseLength = double.Parse(Console.ReadLine());
                Console.Write("Yüksekliği giriniz: ");
                double height = double.Parse(Console.ReadLine());
                return new Triangle(baseLength, height);
            case "kare":
                Console.Write("Kenar uzunluğunu giriniz: ");
                double side = double.Parse(Console.ReadLine());
                return new Square(side);
            case "dikdörtgen":
                Console.Write("Uzun kenarı giriniz: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Kısa kenarı giriniz: ");
                double width = double.Parse(Console.ReadLine());
                return new Rectangle(length, width);
            default:
                throw new ArgumentException("Geçersiz şekil türü.");
        }
    }
}
