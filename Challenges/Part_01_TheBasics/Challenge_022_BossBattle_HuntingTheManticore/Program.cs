/// <summary>
/// Challenge 022 - Boss Battle – Hunting the Manticore
/// --------------------------------
/// Prompt:
///     Boss Battle Hunting the Manticore 250 XP
///     The Uncoded One’s airship, the Manticore, has begun an all-out attack on the city of Consolas. It must be
///     destroyed, or the city will fall. Only by combining Mylara’s prototype, Skorin’s cannon, and your
///     programming skills will you have a chance to win this fight. You must build a program that allows one
///     user—the pilot of the Manticore—to enter the airship’s range from the city and a second user—the city’s
///     defenses—to attempt to find what distance the airship is at and destroy it before it can lay waste to the
///     town.
///     The first user begins by secretly establishing how far the Manticore is from the city, in the range 0 to 100.
///     The program then allows a second player to repeatedly attempt to destroy the airship by picking the
///     range to target until either the city of Consolas or the Manticore is destroyed. In each attempt, the player
///     is told if they overshot (too far), fell short (not far enough), or hit the Manticore. The damage dealt to the
///     Manticore depends on the turn number. For most turns, 1 point of damage is dealt. But if the turn number
///     is a multiple of 3, a fire blast deals 3 points of damage; a multiple of 5, an electric blast deals 3 points of
///     damage, and if it is a multiple of both 3 and 5, a mighty fire-electric blast deals 10 points of damage. The
///     Manticore is destroyed after taking 10 points of damage.
///     However, if the Manticore survives a turn, it will deal a guaranteed 1 point of damage to the city of
///     Consolas. The city can only take 15 points of damage before being annihilated.
///     Before a round begins, the user should see the current status: the current round number, the city’s health,
///     and the Manticore’s health.
///     A sample run of the program is shown below. The first player gets a chance to place the Manticore:
///     Player 1, how far away from the city do you want to station the Manticore?
///     32
///     At this point, the display is cleared, and the second player gets their chance:
///     Player 2, it is your turn.
///     -----------------------------------------------------------
///     STATUS: Round: 1 City: 15/15 Manticore: 10/10
///     The cannon is expected to deal 1 damage this round.
///     Enter desired cannon range:
///     50
///     That round OVERSHOT the target.
///     -----------------------------------------------------------
///     STATUS: Round: 2 City: 14/15 Manticore: 10/10
///     The cannon is expected to deal 1 damage this round.
///     Enter desired cannon range:
///     25
///     That round FELL SHORT of the target.
///     -----------------------------------------------------------
///     STATUS: Round: 3 City: 13/15 Manticore: 10/10
///     The cannon is expected to deal 3 damage this round.
///     Enter desired cannon range:
///     32
///     That round was a DIRECT HIT!
///     -----------------------------------------------------------
///     STATUS: Round: 4 City: 12/15 Manticore: 7/10
///     The cannon is expected to deal 1 damage this round.
///     Enter desired cannon range:
///     32
///     That round was a DIRECT HIT!
///     -----------------------------------------------------------
///     STATUS: Round: 5 City: 11/15 Manticore: 6/10
///     The cannon is expected to deal 3 damage this round.
///     Enter desired cannon range:
///     32
///     That round was a DIRECT HIT!
///     -----------------------------------------------------------
///     STATUS: Round: 6 City: 10/15 Manticore: 3/10
///     The cannon is expected to deal 3 damage this round.
///     Enter desired cannon range:
///     32
///     That round was a DIRECT HIT!
///     The Manticore has been destroyed! The city of Consolas has been saved!
///     CLEANING UP HEAP MEMORY 125
///
/// Objectives:
///     • Establish the game’s starting state: the Manticore begins with 10 health points and the city with 15.
///       The game starts at round 1.
///     • Ask the first player to choose the Manticore’s distance from the city (0 to 100). Clear the screen
///       afterward.
///     • Run the game in a loop until either the Manticore’s or city’s health reaches 0.
///     • Before the second player’s turn, display the round number, the city’s health, and the Manticore’s
///       health.
///     • Compute how much damage the cannon will deal this round: 10 points if the round number is a
///       multiple of both 3 and 5, 3 if it is a multiple of 3 or 5 (but not both), and 1 otherwise. Display this to
///       the player.
///     • Get a target range from the second player, and resolve its effect. Tell the user if they overshot (too
///       far), fell short, or hit the Manticore. If it was a hit, reduce the Manticore’s health by the expected
///       amount.
///     • If the Manticore is still alive, reduce the city’s health by 1.
///     • Advance to the next round.
///     • When the Manticore or the city’s health reaches 0, end the game and display the outcome.
///     • Use different colors for different types of messages.
///     • Note: This is the largest program you have made so far. Expect it to take some time!
///     • Note: Use methods to focus on solving one problem at a time.
///     • Note: This version requires two players, but in the future, we will modify it to allow the computer
///       to randomly place the Manticore so that it can be a single-player game.
///
/// XP: 250
/// Page: 124
///
/// Notes:
/// Implemented a two-player artillery game that tracks round number, city health, and Manticore health.
/// Calculated cannon damage based on round multiples (3, 5, and both) and applied hits accordingly.
/// Added colored status messages, input validation, and clear phase transitions (placement → battle).
///
/// Reflection:
/// Practiced breaking a larger problem into small methods (status display, damage calculation, input).
/// Reinforced loop control, state management, and conditional logic in a longer program.
/// This felt like a real “boss fight” that tied together prior challenges (ranges, loops, and the magic cannon).
/// </summary>

Console.Title = "Hunting the Manticore";

// Main loop
while (true)
{
	// --- Configuration Constants (unchanging) ---
	const int cityMaxHealth = 15;
	const int cityDamagePerRoundIfManticoreMissed = 1;

	const int manticoreMaxHealth = 10;
	const int manticoreMinRange = 0;
	const int manticoreMaxRange = 100;

	const int normalCannonDamage = 1;
	const int fireCannonDamage = 3;
	const int electricCannonDamage = 3;
	const int fireAndElectricCannonDamage = 10;


	// --- Game State Variables (change every loop/game) ---
	int cityCurrentHealth = 15;

	int manticoreCurrentHealth = 10;
	int manticoreDistance = -1;

	int currentCannonDamage = 1;

	int theCurrentRound = 1;



	// --- System / Logic Flags ---
	bool isManticoreDestroyed = false;
	bool isCityDestroyed = false;


	MakeTextThisColor("white");
	Console.WriteLine("\n\t==== Hunting the Manticore ====\n\n");

	manticoreDistance = AskForNumberInRange("Player 1, how far away from the city do you want to station the Manticore: ", manticoreMinRange, manticoreMaxRange);

	// Clears the console after user1 has set the distance of the Manticore
	Console.Clear();

	MakeTextThisColor("white");
	Console.WriteLine("\n\t==== Hunting the Manticore ====\n\n");

	// Actual game loop
	while (true)
	{
		if (theCurrentRound == 1)
		{
			MakeTextThisColor("yellow");
			Console.WriteLine("Player 2, it is your turn.");
		}
		PrintDividerLine();

		PrintRoundStatus(theCurrentRound, cityCurrentHealth, cityMaxHealth, manticoreCurrentHealth, manticoreMaxHealth);

		currentCannonDamage = PrintExpectedCannonDamage(theCurrentRound, normalCannonDamage, fireCannonDamage, electricCannonDamage, fireAndElectricCannonDamage);

		int manticoreGuessDistance = AskForNumberInRange("Enter desired cannon range: ", manticoreMinRange, manticoreMaxRange);
		
		if (!GetShotResult(manticoreDistance, manticoreGuessDistance))
		{
			cityCurrentHealth = DamageCity(cityCurrentHealth, cityDamagePerRoundIfManticoreMissed);
			if (cityCurrentHealth <= 0)
			{
				isCityDestroyed = true;
			}
		}
		else
		{
			manticoreCurrentHealth = DamageManticore(manticoreCurrentHealth, currentCannonDamage);
			if (manticoreCurrentHealth <= 0)
			{
				isManticoreDestroyed = true;
			}
		}

		// Check if game is over
		if (isManticoreDestroyed)
		{
			MakeTextThisColor("green");
			Console.WriteLine("\nThe Manticore has been destroyed! The city of Consolas has been saved!");
			break;
		}
		else if (isCityDestroyed)
		{
			MakeTextThisColor("darkRed");
			Console.WriteLine("\nThe city of Consolas has been destroyed! The Manticore has won!");
			break;
		}


		theCurrentRound++;
	}

	// Continues to new game if user inputs "y"
	if (!AskToContinue())
	{
		Console.ResetColor();
		break;
	}

	Console.Clear();
}

// ------------------------------------- Methods ---------------------------------------------------------

// Print Methods
void PrintDividerLine()
{
	MakeTextThisColor("yellow");
	Console.WriteLine("-----------------------------------------------------------");
}
void PrintRoundStatus(int aCurrentRound, int cityCurrentHealth, int cityMaxHealth, int manticoreCurrentHealth, int manticoreMaxHealth)
{
	MakeTextThisColor("yellow");
	Console.WriteLine($"STATUS:  Round: {aCurrentRound}  City: {cityCurrentHealth}/{cityMaxHealth}  Manticore: {manticoreCurrentHealth}/{manticoreMaxHealth}");
}
int PrintExpectedCannonDamage(int aCurrentRound, int normalDamage, int fireDamage, int electricDamage, int fireAndElectricDamage)
{
	int expectedCannonDamageThisRound = GetCannonDamage(aCurrentRound, normalDamage, fireDamage, electricDamage, fireAndElectricDamage);
	MakeTextThisColor("yellow");
	Console.WriteLine($"The cannon is expected to deal {expectedCannonDamageThisRound} damage this round.");
	return expectedCannonDamageThisRound;
}

// Damage Methods
static int DamageCity(int cityHealth, int damageToCity)
{
	int newCityHealth = cityHealth - damageToCity;
	return newCityHealth;
} // Takes health away from city
static int DamageManticore(int manticoreHealth, int damageToManticore)
{
	int newManticoreHealth = manticoreHealth - damageToManticore;
	return newManticoreHealth;
} // Takes health away from Manticore

// Get Methods
static int GetCannonDamage(int aCurrentRound, int normalDamage, int fireDamage, int electricDamage, int fireAndElectricDamage)
{
	bool isFireShot = (aCurrentRound % 3 == 0);
	bool isElectricShot = (aCurrentRound % 5 == 0);
	if (isFireShot || isElectricShot)
	{
		if (isFireShot && isElectricShot)
		{
			return fireAndElectricDamage;
		}
		else
		{
			if (isFireShot)
			{
				return fireDamage;
			}
			else
			{
				return electricDamage;
			}
		}
	}
	else
	{
		return normalDamage;
	}
} // Determines cannon damage based on current round
bool GetShotResult(int actualDistance, int guessDistance)
{
	if (guessDistance == actualDistance)
	{
		MakeTextThisColor("green");
		Console.WriteLine("That round was a DIRECT HIT!");
		return true;
	}
	else
	{
		if (guessDistance < actualDistance)
		{
			MakeTextThisColor("darkRed");
			Console.WriteLine("That round FELL SHORT of the target.");
		}
		else
		{
			MakeTextThisColor("darkRed");
			Console.WriteLine("That round OVERSHOT the target.");
		}
		return false;
	}
} // Determines if user guess was under, over, or a hit

// Help Methods
void MakeTextThisColor(string colorChoice)
{
	// Ensures colorChoice is a valid ConsoleColor name
	if (Enum.TryParse<ConsoleColor>(colorChoice, true, out var color))
	{
		Console.ForegroundColor = color;
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.White; // fallback color
		Console.WriteLine($"Invalid color '{colorChoice}', defaulting to White."); // for debugging
	}
} // Takes a color input and makes the Console text that color
int AskForNumberInRange(string promptForNumberWithinRange, int rangeMinimum, int rangeMaximum)
{
	MakeTextThisColor("yellow");

	// Adds space after given text prompt
	Console.Write($"{promptForNumberWithinRange} ");
	while (true)
	{
		MakeTextThisColor("darkYellow");

		// Checks for valid integer input
		if (int.TryParse(Console.ReadLine(), out int userInput))
		{

			// Checks if input is within specified range
			if (userInput >= rangeMinimum && userInput <= rangeMaximum)
			{
				return userInput;
			}
			else
			{
				MakeTextThisColor("red");
				Console.Write($"Give me a number WITHIN {rangeMinimum} and {rangeMaximum}: ");
			}
		}
		else
		{
			MakeTextThisColor("red");
			Console.Write("Give me a WHOLE NUMBER: ");
		}
	}
} // Asks user for a number within a specified range
bool AskToContinue()
{
	MakeTextThisColor("white");
	Console.Write("\nPlay again? (y/n): ");
	while (true)
	{
		MakeTextThisColor("gray");
		string userInput = Console.ReadLine();
		if (userInput.ToLower() == "y" || userInput.ToLower() == "n")
		{
			if (userInput.ToLower() == "y")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		else
		{
			MakeTextThisColor("red");
			Console.Write("That's not an answer. Try again: ");
		}
	}
} // Asks user if they want to play again
Console.ResetColor();