public class Calculator
{
    public double Calculate(Shape shape, string calculationType)
    {
        switch (calculationType.ToLower())
        {
            case "alan":
                return shape.CalculateArea();
            case "çevre":
                return shape.CalculatePerimeter();
            case "hacim":
                return shape.CalculateVolume();
            default:
                throw new ArgumentException("Geçersiz hesaplama türü.");
        }
    }
}
