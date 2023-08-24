namespace Logic;

public static class Operations
{
    public static void Sum()
    {
        double num1 = LogicMult.GetNumber();
        double num2 = LogicMult.GetNumber();
        Console.WriteLine($"Result: {num1 + num2}");
    }

    public static void Rest()
    {
        double num1 = LogicMult.GetNumber();
        double num2 = LogicMult.GetNumber();
        Console.WriteLine($"Result: {num1 - num2}");
    }

    public static void Mult()
    {
        double num1 = LogicMult.GetNumber();
        double num2 = LogicMult.GetNumber();
        Console.WriteLine($"Result: {num1 * num2}");
    }

    public static void Div()
    {
        double num1 = LogicMult.GetNumber();
        double num2;
        do
        {
            num2 = LogicMult.GetNumber();
            if (num2 == 0)
                Console.WriteLine("Division by zero is not allowed. Please enter a non-zero divisor.");
        }while(num2 == 0);
        Console.WriteLine($"Result: {num1 / num2}");
    }
}
