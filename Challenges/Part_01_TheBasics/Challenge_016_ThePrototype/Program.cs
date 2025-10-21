/// <summary>
/// Challenge 016 – The Prototype  
/// --------------------------------
/// Prompt:  
///     Mylara, captain of the Guard of Consolas, has approached you with a plan to help track  
///     down The Uncoded One’s airship. One user, representing the pilot, selects a secret  
///     number between 0 and 100. Another user, the hunter, attempts to guess the number.  
///     The program provides feedback on each guess — too high, too low, or correct — until  
///     the correct number is found. Once complete, Mylara believes this "prototype" can be  
///     adapted into a more advanced airship-tracking system.  
///
/// Objectives:  
/// • Build a program that allows a user (the pilot) to enter a number between 0 and 100.  
/// • Validate the input — if it’s out of range, re-prompt until a valid number is entered.  
/// • Clear the screen after a valid number has been chosen.  
/// • Have a second user (the hunter) guess numbers.  
/// • Tell the hunter whether the guess is too high, too low, or correct.  
/// • Continue looping until the correct number is guessed, then end the program.  
///
/// XP: 100  
/// Page: 89  
///
/// Notes:  
/// Created a two-player number guessing game that validates input for both users. The pilot  
/// secretly enters a number within the valid range (0–100), and the console clears before the  
/// hunter begins guessing. The program uses while loops and conditional logic to guide the  
/// hunter with feedback for each guess. Once the hunter correctly identifies  
/// the number, it displays a success message. I went ahead and tried a continuous loop design,
/// it will run until the hunter guesses the correct number and says "n" when prompted if they
/// would like to do it again.
///
/// Reflection:  
/// Practiced nesting loops, validating numeric input, and handling iterative feedback within  
/// a game-style program. Strengthened understanding of control flow and state transitions.  
/// This challenge demonstrated how simple program logic can simulate interactive gameplay. 
/// It strengthened my understanding of continuous loops for user replayability.
/// </summary>


// Aesthetic Configurations
Console.Title = "The Prototype";
Console.ForegroundColor = ConsoleColor.White;


// Sets target # minimum/maximum
int targetMin = 0;
int targetMax = 100;

int targetNumber;
int hunterGuess;

while (true)
{
	Console.WriteLine("\n\t==== The Prototype ====\n");

	Console.ForegroundColor = ConsoleColor.Yellow;
	// Prompts user1 for target number
	Console.Write("\n\nPilot, please enter a whole number between 0 and 100: ");

	// Makes user input white
	Console.ForegroundColor = ConsoleColor.White;

	// Will repeat itself until valid input has been given
	while (!int.TryParse(Console.ReadLine(), out targetNumber) || (targetNumber < targetMin || targetNumber > targetMax))
	{

		// Makes system outpout yellow
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.Write("\nPlease type in a whole number between 0 and 100: ");
		
		// Makes user input white
		Console.ForegroundColor = ConsoleColor.White;
	}

	// Clears the console for actual guesses
	Console.Clear();
	Console.WriteLine("==== The Prototype ====");

	// Prompts user2 for target guess
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.Write("\n\nHunter, guess the number: ");

	// Makes user input white
	Console.ForegroundColor = ConsoleColor.White;

	// Will repeat itself until the hunters guess is correct
	while (!int.TryParse(Console.ReadLine(), out hunterGuess) || hunterGuess != targetNumber)
	{
		if (hunterGuess < targetNumber)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"\n{hunterGuess} is too low.");
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"\n{hunterGuess} is too high.");
		}

		Console.Beep(500, 500);

		// Prompts user2 for next guess
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.Write("\nWhat is your next guess? ");

		// Makes user input white
		Console.ForegroundColor = ConsoleColor.White;
	}

	Console.ForegroundColor = ConsoleColor.Green;
	Console.WriteLine("\nYou guessed the number!");
	Console.Beep(600, 200);
	Console.Beep(800, 600);

	Console.ForegroundColor = ConsoleColor.Yellow;

	// Prompts user for choice to start again
	Console.Write("\nWant to do it again? (y/n): ");
	string answer = Console.ReadLine().ToLower();
	if (answer == "n")
	{
		Console.WriteLine("\nThanks for trying the Prototype!");
		Console.ResetColor();
		break;
	}
	else
	{
		Console.Clear();
	}
}

	

