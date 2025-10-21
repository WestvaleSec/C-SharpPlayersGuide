/// <summary>
/// Challenge 013 – Watchtower
/// --------------------------------
/// Prompt:
///     There are watchtowers in the region around Consolas that can alert you when an enemy is spotted.
///     With some help from you, they can tell you which direction the enemy is from the watchtower.
///
/// Objectives:
/// • Ask the user for an x value and a y value. These are the coordinates of the enemy relative to
///   the watchtower’s location (which is at the origin, 0, 0).
/// • Using if statements and relational operators, display a message about what direction the
///   enemy is coming from. For example:
///     "The enemy is to the northwest!"  
///     "The enemy is here!"
///
/// XP: 100
/// Page: 78
///
/// Notes:
/// Created a program that takes two integer inputs representing the enemy’s position relative
/// to the watchtower. Used a series of if/else statements with relational operators to determine
/// which compass direction (north, south, east, west, or combinations thereof) the enemy lies in
/// and displayed an appropriate message. Included a special condition for when both coordinates
/// are zero, meaning the enemy is at the same location as the watchtower.
///
/// Reflection:
/// Practiced conditional branching and comparison operators to handle multiple logical cases.
/// Reinforced understanding of coordinate systems and decision trees in programming.
/// This was a good exercise in structuring readable conditional logic.
/// </summary>

// Aesthetic Configurations
Console.Title = "Watchtower";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=== Challenge 013: Watchtower ===");

// Short explanation and initial prompt
Console.WriteLine("Where is the enemy? Please give us their coordinates!");
Console.Write("X: ");

// Initialization for global variables
double valueX;
double valueY;

// Validate user input or close program
if (double.TryParse(Console.ReadLine(), out valueX))
{
	Console.WriteLine("\nGreat, and what about their Y coordinate?");
}
else
{
	Console.WriteLine("\nC'mon now, use a number next time.");
	return;
}

// Prompt for Y
Console.Write("Y: ");

// Validate user input or close program
if (double.TryParse(Console.ReadLine(), out valueY))
{
	Console.WriteLine("");
}
else
{
	Console.WriteLine("\nC'mon now, use a number next time.");
	return;
}

// Determine direction of the enemy based off coordinates given
bool isXZero = valueX == 0;
bool isEast = valueX > 0;
bool isWest = valueX < 0;

bool isYZero = valueY == 0;
bool isNorth = valueY > 0;
bool isSouth = valueY < 0;


// Simplifies message change for future
string warningMessage = "The enemy is";

// Aesthetic
Console.ForegroundColor = ConsoleColor.Green;

// Outputs where enemy is based on previous booleans
if (isXZero && isYZero)
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine($"{warningMessage} here!");
}
else if (isXZero && !isYZero)
{
	if (isNorth)
	{
		Console.WriteLine($"{warningMessage} to the north!");
	}
	else
	{
		Console.WriteLine($"{warningMessage} to the south!");
	}
}
else if (!isXZero && isYZero)
{
	if (isEast)
	{
		Console.WriteLine($"{warningMessage} to the east!");
	}
	else
	{
		Console.WriteLine($"{warningMessage} to the west!");
	}
}
else
{
	if (isNorth)
	{
		if (isEast)
		{
			Console.WriteLine($"{warningMessage} to the northeast!");
		}
		else
		{
			Console.WriteLine($"{warningMessage} to the northwest!");
		}
	}
	else
	{
		if (isEast)
		{
			Console.WriteLine($"{warningMessage} to the southeast!");
		}
		else
		{
			Console.WriteLine($"{warningMessage} to the southwest!");
		}
	}
}

// Aesthetic
Console.ResetColor();
