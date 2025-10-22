/// <summary>
/// Challenge 019 – Taking a Number
/// --------------------------------
/// Prompt:
///     Many previous tasks have required getting a number from a user. To save time writing this code repeatedly,  
///     you have decided to make a method to do this common task.
/// 
/// Objectives:
/// • Make a method with the signature int AskForNumber(string text).  
///   Display the text parameter in the console window, get a response from the user, convert it to an int, and return it.  
///   Example: int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");
/// 
/// • Make a method with the signature int AskForNumberInRange(string text, int min, int max).  
///   Only return if the entered number is between the min and max values. Otherwise, ask again.
/// 
/// • Place these methods in at least one of your previous programs to improve it.
/// 
/// XP: 100  
/// Page: 106
/// 
/// Notes:
/// Created two reusable methods for validated numeric input:  
///  - `AskForNumber()` displays a message and safely returns a parsed integer.  
///  - `AskForNumberInRange()` extends it with validation to ensure input falls within a specified range.  
/// Integrated one or both into a previous challenge to simplify repeated user input handling.
/// 
/// Reflection:
/// Practiced writing and reusing parameterized methods to reduce redundant code.  
/// Reinforced input validation, range checking, and function structure.  
/// This challenge improved understanding of modular code and method reusability in console applications.
/// </summary>


// Aesthetic Configuration
Console.Title = "Taking a Number";
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\t==== Taking a Number ====\n");

// Example usage of the methods
int anyNum = AskForNumber("Can I please have a number:");
int numWithinRange = AskForNumberInRange("Can I please have a number between 1 an 10:", 1, 10);

Console.ForegroundColor = ConsoleColor.Green;

// Displays the results
Console.WriteLine($"\n\tFirst Input: {anyNum}\n\tSecond Input: {numWithinRange}");



// Asks user for a number
int AskForNumber(string text)
{
	Console.ForegroundColor = ConsoleColor.Yellow;

	// Adds space after given text prompt
	Console.Write($"{text} ");
	while (true)
	{
		Console.ForegroundColor = ConsoleColor.DarkYellow;

		// Checks for valid integer input
		if (int.TryParse(Console.ReadLine(), out int numberGiven))
		{
			return numberGiven;
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("Give me WHOLE NUMBER: ");
		}

	}
}


// Asks user for a number within a specified range
int AskForNumberInRange(string text, int min, int max)
{
	Console.ForegroundColor = ConsoleColor.Yellow;

	// Adds space after given text prompt
	Console.Write($"{text} ");
	while (true)
	{
		Console.ForegroundColor = ConsoleColor.DarkYellow;

		// Checks for valid integer input
		if (int.TryParse(Console.ReadLine(), out int numberGiven))
		{

			// Checks if input is within specified range
			if (numberGiven >= min && numberGiven <= max)
			{
				return numberGiven;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("Give me a whole number WITHIN THE RANGE: ");
			}
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("Give me a WHOLE NUMBER: ");
		}
	}
}

Console.ResetColor();