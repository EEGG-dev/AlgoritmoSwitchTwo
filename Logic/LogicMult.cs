namespace Logic;

public static class LogicMult
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("--- WELCOME TO SWITCH APP ---");
        Console.WriteLine("*****************************");
        Console.WriteLine();
    }

    public static double GetNumber()
    {
        bool isValidNumber;
        double num;
        do
        {
            Console.WriteLine("Enter a Number: ");
            string numberText = Console.ReadLine();
            isValidNumber = double.TryParse(numberText, out num);
        }while(isValidNumber == false);
        return num;
    }

    public static char GetOperator()
    {
        while(true)
        {
            Console.WriteLine("Enter the sign of the operation to be performed (+, -, *, /): ");
            char sign = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (sign == '+' || sign == '-' || sign == '*' || sign == '/')
                return sign;

            Console.WriteLine("Invalid Operator. Please enter a valid operator (+, -, *, /): ");  
        }
    }

    public static bool AskToContinue()
    {
        Console.Write("Do you keep going (y/n): ");
        char continueLooping = Console.ReadKey().KeyChar;
        Console.WriteLine();
        bool output = (continueLooping == 'y');
        return output;
    }

    public static void GetResult()
    {
        do
        {
            char sign = LogicMult.GetOperator();
            LogicMult.EvaluateSign(sign);
        }while (AskToContinue());
    }

    public static void EvaluateSign(char sign)
    {
        switch (sign)
        {
            case '+':
                Operations.Sum();
                break;
            case '-':
                Operations.Rest();
                break;
            case '*':
                Operations.Mult();
                break;
            case '/':
                Operations.Div();
                break;
            default:
                Console.WriteLine("Invalid arithmetic Operator.");
                break;
        }
    }
}
