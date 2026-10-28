namespace csharp_homework10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- ACTION ---");
        Action showTime = ShowTime;
        Action showDate = ShowDate;
        Action showWeek = ShowWeek;
        showTime();
        showDate();
        showWeek();
        
        Action showTriangleAreaAction = ShowTriangleAreaAction;
        Action showRectangleAreaAction = ShowRectangleAreaAction;
        showTriangleAreaAction();
        showRectangleAreaAction();
        Console.WriteLine(" ");
        
        Console.WriteLine("--- FUNC ---");
        Func<double, double, double> showTriangleAreaFunc = ShowTriangleAreaFunc;
        Console.WriteLine($"The area of the triangle: {showTriangleAreaFunc(3, 5)}");
        Func<double, double, double> showRectangleAreaFunc = ShowRectangleAreaFunc;
        Console.WriteLine($"The area of the rectangle: {showRectangleAreaFunc(3, 5)}");
    }

    static void ShowTime()
    {
        Console.WriteLine($"Current time: {DateTime.Now.ToLongTimeString()}");
    }

    static void ShowDate()
    {
        Console.WriteLine($"Current Date: {DateTime.Now.ToLongDateString()}");
    }
    static void ShowWeek()
    {
        Console.WriteLine($"Current Week: {DateTime.Now.DayOfWeek}");
    }

    static void ShowTriangleAreaAction()
    {
        Console.WriteLine(" ");
        Console.Write("Enter the base: ");
        double baseValue = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the height: ");
        double heightValue = Convert.ToDouble(Console.ReadLine());
        
        double area = (baseValue * heightValue) / 2;
        Console.WriteLine($"The area of the triangle: {area}");
    }
    
    static void ShowRectangleAreaAction()
    {
        Console.WriteLine(" ");
        Console.Write("Enter the length: ");
        double lengthValue = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the width: ");
        double widthValue = Convert.ToDouble(Console.ReadLine());
        
        double area = lengthValue * widthValue;
        Console.WriteLine($"The area of the rectangle: {area}");
    }

    static double ShowTriangleAreaFunc(double baseValue, double heightValue)
    {
        if (baseValue <= 0)
            throw new ArgumentException("[EXCEPTION] Base cannot be <= 0");
        if (heightValue <= 0)
            throw new ArgumentException("[EXCEPTION] Height cannot be <= 0");
        
        return (baseValue * heightValue) / 2;
    }
    static double ShowRectangleAreaFunc(double lengthValue, double widthValue)
    {
        if (lengthValue <= 0)
            throw new ArgumentException("[EXCEPTION] Length cannot be <= 0");
        if (widthValue <= 0)
            throw new ArgumentException("[EXCEPTION] Width cannot be <= 0");
        
        return lengthValue * widthValue;
    }
}