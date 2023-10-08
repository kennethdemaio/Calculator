Console.WriteLine("---------------------------");
Console.WriteLine("Welcome to my C# calculator");
Console.WriteLine("---------------------------");

Console.WriteLine("Input 1");
string InputOne = Console.ReadLine();
Console.WriteLine("Input 2");
string InputTwo = Console.ReadLine();

var InputOneConverted = Convert.ToInt32(InputOne);
var InputTwoConverted = Convert.ToInt32(InputTwo);

Console.WriteLine("Would you like to multiply (*), divide (/), subtract(-), or add(+)?");
string InputOperator = Console.ReadLine();

switch (InputOperator){
    case "+":
        int AddResult = InputOneConverted + InputTwoConverted;
        Console.WriteLine(AddResult);
        break;
    case "-":
        int SubResult = InputOneConverted - InputTwoConverted;
        Console.WriteLine(SubResult);
        break;
    case "*":
        int MultiplyResult = InputOneConverted + InputTwoConverted;
        Console.WriteLine(MultiplyResult);
        break;
    case "/":
        int DivideResult = InputOneConverted + InputTwoConverted;
        Console.WriteLine(DivideResult);
        break;
}

