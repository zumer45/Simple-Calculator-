Console.WriteLine("Hello!");

int GetNumberFromUser(string prompt)
{
    Console.Write(prompt);
    string? input = Console.ReadLine();
    return int.Parse(input);
}

int firstNumber = GetNumberFromUser("Input the first Number: ");
int secondNumber = GetNumberFromUser("Input the second Number: ");

Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string choice = Console.ReadLine().ToLower();

int result = 0;
switch (choice)
{
    case "a":
        result = firstNumber + secondNumber;
        break;
    case "s":
        result = firstNumber - secondNumber;
        break;
    case "m":
        result = firstNumber * secondNumber;
        break;
    default:
        Console.WriteLine("Please pick a valid option");
        break;
}

if (choice == "a" || choice == "s" || choice == "m")
{
    Console.WriteLine($"Result: {result}");
}
