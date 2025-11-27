while (true)
{
	Console.WriteLine("=== MAIN MENU ===");
	Console.WriteLine("1. Sum");
	Console.WriteLine("2. Difference");
	Console.WriteLine("3. Exit");
	Console.WriteLine();
	Console.Write("Select an option (1-3): ");

	if (int.TryParse(Console.ReadLine(), out int choice))
	{
		switch (choice)
		{
			case 1:
				Console.WriteLine("You selected Sum.");

				int sumNumber1, sumNumber2;

				while (true)
				{
					Console.Write("Enter the first number: ");
					if (int.TryParse(Console.ReadLine(), out sumNumber1))
					{
						break;
					}
					else
					{
						Console.WriteLine("Invalid input. Please enter a valid integer.");
					}
				}

				while (true)
				{
					Console.Write("Enter the second number: ");
					if (int.TryParse(Console.ReadLine(), out sumNumber2))
					{
						break;
					}
					else
					{
						Console.WriteLine("Invalid input. Please enter a valid integer.");
					}
				}

				var sum = sumNumber1 + sumNumber2;
				Console.WriteLine($"The sum of {sumNumber1} and {sumNumber2} is {sum}.");
				break;
			case 2:
				Console.WriteLine("You selected Difference.");

				int diffNumber1, diffNumber2;

				while (true)
				{
					Console.Write("Enter the first number: ");
					if (int.TryParse(Console.ReadLine(), out diffNumber1))
					{
						break;
					}
					else
					{
						Console.WriteLine("Invalid input. Please enter a valid integer.");
					}
				}

				while (true)
				{
					Console.Write("Enter the second number: ");
					if (int.TryParse(Console.ReadLine(), out diffNumber2))
					{
						break;
					}
					else
					{
						Console.WriteLine("Invalid input. Please enter a valid integer.");
					}
				}

				var difference = diffNumber1 - diffNumber2;
				Console.WriteLine($"The difference between {diffNumber1} and {diffNumber2} is {difference}.");
				break;
			case 3:
				Console.WriteLine("Exiting the program. Goodbye!");
				return;
			default:
				Console.WriteLine("Invalid option. Please select a number between 1 and 3.");
				break;
		}
	}
	else
	{
		Console.WriteLine("Invalid input. Please enter a valid number.");
	}
}
