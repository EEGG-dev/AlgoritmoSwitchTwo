using Logic;

LogicMult.WelcomeMessage();

LogicMult.GetResult();

/*
LogicMult.WelcomeMessage();

while(true)
{
    char sign = LogicMult.GetOperator();
    if (sign == 'q')
    {
        Console.WriteLine("Exiting the program. Goodbye!");
        break;
    }

    LogicMult.EvaluateSign(sign);

    Console.WriteLine("Press 'q' and Enter to quit or any other key to continue.");
    char quit = Console.ReadKey().KeyChar;
    Console.WriteLine();
    if (quit == 'q')
    {
        Console.WriteLine("Exiting the program. Goodbye!");
        break;
    }
}
*/