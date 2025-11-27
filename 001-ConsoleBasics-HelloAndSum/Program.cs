Console.Title = "Hello and Sum Program";
Console.WriteLine("Hello!\n");

string name;
while (true)
{
	Console.Write("Enter your name: ");
	name = Console.ReadLine();

	if (string.IsNullOrWhiteSpace(name))
	{
		Console.WriteLine("Name cannot be empty!\n");
	}
	else
	{
		break;
	}
}

Console.WriteLine($"\nWelcome {name}!");

int number1;
while (true)
{
	Console.Write("Enter the first number: ");
	if (int.TryParse(Console.ReadLine(), out number1))
		break;
	Console.WriteLine("Invalid input. Please enter a valid integer.\n");
}

int number2;
while (true)
{
	Console.Write("Enter the second number: ");
	if (int.TryParse(Console.ReadLine(), out number2))
		break;
	Console.WriteLine("Invalid input. Please enter a valid integer.\n");
}

int sum = number1 + number2;
Console.WriteLine($"\nThe sum of {number1} and {number2} is {sum}.");

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();