double numOne = 0;
double numTwo = 0;
double result = 0;
bool calAgain = true;

do while (calAgain)
{

    Console.WriteLine("------------");
    Console.WriteLine("Calc Program:");
    Console.WriteLine("------------");

    Console.Write("Enter num1: ");
    numOne = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter num2: ");
    numTwo = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter an operation");
    Console.WriteLine("\t+ : Add");
    Console.WriteLine("\t- : Sub");
    Console.WriteLine("\t* : Multi");
    Console.WriteLine("\t/ : Divide");

    switch (Console.ReadLine())
    {
        case "+":
            result = numOne + numTwo;
            Console.WriteLine($"Your result: {numOne} + {numTwo} = " + result);
            break;

        case "-":
            result = numOne - numTwo;
            Console.WriteLine($"Your result: {numOne} - {numTwo} = " + result);
            break;

        case "/":
            result = numOne / numTwo;
            Console.WriteLine($"Your result: {numOne} / {numTwo} = " + result);
            break;

        case "*":
            result = numOne * numTwo;
            Console.WriteLine($"Your result: {numOne} * {numTwo} = " + result);
            break;
        default:
            Console.WriteLine("that was not a valid option");
            break;
    }
    Console.WriteLine("Do you want to calculate again? Y/N");
    string anotherNumber = Console.ReadLine();
    anotherNumber = anotherNumber.ToUpper();
    if (anotherNumber =="Y")
    {
        calAgain = true;
    }
    else 
    {
        calAgain = false;
        Console.WriteLine("bye!");
    }
}