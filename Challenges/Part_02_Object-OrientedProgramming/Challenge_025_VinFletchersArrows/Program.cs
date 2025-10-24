
using System.Runtime.InteropServices.Marshalling;

/// <summary>
/// Challenge 018 – Vin Fletcher’s Arrows  
/// --------------------------------
/// Prompt:  
///     Vin Fletcher is a skilled arrow maker. He asks for your help building a new class to represent  
///     arrows and determine how much he should sell them for. “A tiny fragment of my soul goes into  
///     each arrow; I care not for the money; I just need to be able to recoup my costs and get food  
///     on the table,” he says.  
///
///     Each arrow has three parts: the arrowhead (steel, wood, or obsidian), the shaft (a length  
///     between 60 and 100 cm long), and the fletching (plastic, turkey feathers, or goose feathers).  
///
///     His costs are as follows:  
///         • Arrowheads: steel = 10 gold, wood = 3 gold, obsidian = 5 gold  
///         • Fletching: plastic = 10 gold, turkey feathers = 5 gold, goose feathers = 3 gold  
///         • Shaft: 0.05 gold per centimeter  
///
/// Objectives:  
/// • Define a new Arrow class with fields for arrowhead type, fletching type, and length.  
///   (Hint: arrowhead types and fletching types might be good enumerations.)  
/// • Allow a user to pick the arrowhead, fletching type, and length, and then create a new Arrow instance.  
/// • Add a GetCost method that returns its cost as a float based on the numbers above,  
///   and use this to display the arrow’s total cost.  
///
/// XP: 100  
/// Page: 153  
///
/// Notes:  
/// Built an `Arrow` class to encapsulate arrowhead type, fletching type, and shaft length, using enums  
/// for clean categorization of materials. Implemented cost logic in a `GetCost()` method to calculate  
/// total based on material and shaft length. Created user input flow for selecting each component and  
/// outputting the final gold cost.  
///
/// Reflection:  
/// Practiced designing a simple object-oriented class with encapsulated state and behavior.  
/// Reinforced use of enumerations for distinct material categories and learned how to combine  
/// class methods and user interaction to calculate and display object-specific data.  
/// This challenge marked a strong introduction to class design and instance creation in C#.  
/// </summary>

Console.Title = "Vin Fletcher's Arrows";
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\t==== Vin Fletcher's Arrows ====\n");

// --- Arrow Attributes Tuple Initialization ---
(Arrow.ArrowheadType arrowheadType, Arrow.FletchingType fletchingType, int shaftLength) arrowChoice = (Arrow.ArrowheadType.Unknown, Arrow.FletchingType.Unknown, 60);

// --- Input: Arrowhead type ---
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("What kind of arrowhead would you like? (steel, wood, obsidian) ");
bool isArrowheadChoiceMade = false;
while (!isArrowheadChoiceMade)
{
	Console.ForegroundColor = ConsoleColor.DarkYellow;
	string arrowheadChoice = Console.ReadLine().ToLower();
	switch (arrowheadChoice)
	{
		case "steel":
			arrowChoice.arrowheadType = Arrow.ArrowheadType.Steel;
			isArrowheadChoiceMade = true;
			break;
		case "wood":
			arrowChoice.arrowheadType = Arrow.ArrowheadType.Wood;
			isArrowheadChoiceMade = true;
			break;
		case "obsidian":
			arrowChoice.arrowheadType = Arrow.ArrowheadType.Obsidian;
			isArrowheadChoiceMade = true;
			break;
		default:
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("That doesn't exist. Try again: ");
			break;
	}
}

// --- Input: Fletching type ---
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("What kind fletching would you like? (plastic, turkey feathers, goose feathers) ");
bool isFletchingChoiceMade = false;
while (!isFletchingChoiceMade)
{
	Console.ForegroundColor = ConsoleColor.DarkYellow;
	string arrowFletchingChoice = Console.ReadLine().ToLower();
	switch (arrowFletchingChoice)
	{
		case "plastic":
			arrowChoice.fletchingType = Arrow.FletchingType.Plastic;
			isFletchingChoiceMade = true;
			break;
		case "turkey feathers":
			arrowChoice.fletchingType = Arrow.FletchingType.TurkeyFeathers;
			isFletchingChoiceMade = true;
			break;
		case "goose feathers":
			arrowChoice.fletchingType = Arrow.FletchingType.GooseFeathers;
			isFletchingChoiceMade = true;
			break;
		default:
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("That doesn't exist. Try again: ");
			break;
	}
}

// --- Input: Shaft length ---
arrowChoice.shaftLength = AskForNumberInRange("How long would you like the arrow shaft to be? (60 - 100 cm)", 60, 100);

// --- Create Arrow object and display total cost ---
Arrow theArrow = new Arrow(arrowChoice.arrowheadType, arrowChoice.fletchingType, arrowChoice.shaftLength);
Console.WriteLine($"The cost of the arrow will be {theArrow.GetCost()} gold.");

Console.ResetColor();

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

// Represents a single arrow with cost calculation logic.
class Arrow
{
	public ArrowheadType _headType;
	public FletchingType _fletchingType;
	public int _shaftLength;
	public float _pricePerCentimeter = 0.05f;

	public Arrow() : this(ArrowheadType.Unknown, FletchingType.Unknown, 60)
	{
	}

	public Arrow(ArrowheadType headType, FletchingType fletchingType, int shaftLength)
	{
		_headType = headType;
		_fletchingType = fletchingType;
		_shaftLength = shaftLength;
	}

	public float GetCost()
	{
		float arrowCost = 0;
		arrowCost += GetHeadTypeCost(_headType);
		arrowCost += GetFletchingTypeCost(_fletchingType);
		arrowCost += GetShaftLengthCost(_shaftLength);
		return arrowCost;
	}
	
	private float GetHeadTypeCost(ArrowheadType headType)
	{
		float steelCost = 10;
		float woodCost = 3;
		float obsidianCost = 5;

		switch (headType)
		{
			case ArrowheadType.Steel:
				return steelCost;
			case ArrowheadType.Wood:
				return woodCost;
			case ArrowheadType.Obsidian:
				return obsidianCost;
			default:
				return 0;
		}
	}

	private float GetFletchingTypeCost(FletchingType fletchingType)
	{
		float plasticCost = 10;
		float turkeyFeathersCost = 5;
		float gooseFeathersCost = 3;

		switch (fletchingType)
		{
			case FletchingType.Plastic:
				return plasticCost;
			case FletchingType.TurkeyFeathers:
				return turkeyFeathersCost;
			case FletchingType.GooseFeathers:
				return gooseFeathersCost;
			default:
				return 0;
		}
	}

	private float GetShaftLengthCost(int shaftLength)
	{
		return (float)shaftLength * _pricePerCentimeter;
	}



	public enum ArrowheadType { Unknown, Steel, Wood, Obsidian }
	public enum FletchingType { Unknown, Plastic, TurkeyFeathers, GooseFeathers }
}

