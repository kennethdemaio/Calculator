using System.ComponentModel.Design;

bool run = true;
while (run) {
    Console.WriteLine("---------------------------");
    Console.WriteLine("Welcome to my C# calculator");
    Console.WriteLine("---------------------------");

    Console.WriteLine("Please enter your first input");
    string InputOne = Console.ReadLine();
    Console.WriteLine("Please enter your second input");
    string InputTwo = Console.ReadLine();

    if (!int.TryParse(InputOne, out var InputOneConverted) || !int.TryParse(InputTwo, out var InputTwoConverted))
    {
        Console.WriteLine("Invalid input. Please enter valid numbers.");
        continue; // Restart the loop to get valid input
    }
    else
    {
        Calculate(InputOne, InputTwo);
    }


    static void Calculate(string InputOne, string InputTwo){
        var InputOneConverted = Convert.ToInt32(InputOne);
        var InputTwoConverted = Convert.ToInt32(InputTwo);

        Console.WriteLine("Would you like to multiply (*), power of (**), divide (/), subtract(-), or add(+)?");
        string InputOperator = Console.ReadLine();

        switch (InputOperator) {
            case "+":
                int AddResult = InputOneConverted + InputTwoConverted;
                Console.WriteLine(AddResult);
                break;
            case "-":
                int SubResult = InputOneConverted - InputTwoConverted;
                Console.WriteLine(SubResult);
                break;
            case "*":
                int MultiplyResult = InputOneConverted * InputTwoConverted;
                Console.WriteLine(MultiplyResult);
                break;
            case "/":
                if (InputTwoConverted != 0){
                    int DivideResult = InputOneConverted / InputTwoConverted;
                    Console.WriteLine(DivideResult);
                }
                else{
                    Console.WriteLine("You can not divide by 0!");
                }
                break;
            case "**":
                double PowerResult = Math.Pow(InputOneConverted, InputTwoConverted);
                Console.WriteLine(PowerResult);
                break;
        }
    }
    bool QuestAgain = true;
    while (QuestAgain)
    {
        Console.WriteLine("Would you like to calculate another value? (Y/N)");
        string CalAgain = Console.ReadLine().ToUpper();
        if (CalAgain == "Y")
        {
            run = true;
            QuestAgain = false;
        }
        else if (CalAgain == "N")
        {
            Console.WriteLine("Have a nice day!");
            run = false;
            QuestAgain = false;
        }
        else
        {
            Console.WriteLine("Please input a valid response");
            QuestAgain = true;
        }
    }
}