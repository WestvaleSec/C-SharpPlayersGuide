/// <summary>
/// Challenge 026 – Vin’s Trouble  
/// --------------------------------
/// Prompt:  
///     “Master Programmer!” Vin Fletcher shouts as he races to catch up to you.  
///     “I have a problem. I created an arrow for a young man who took it and changed its  
///     length to be half as long as I had designed. It no longer fit in his bow correctly  
///     and misfired. It sliced his hand pretty bad. He’ll survive, but is there any way  
///     we can make sure somebody doesn’t change an arrow’s length when they walk away  
///     from my shop? I don’t want to be the cause of such self-inflicted pain.”  
///
/// Objectives:  
/// • Modify your `Arrow` class to have **private** instead of public fields.  
/// • Add **getter methods** (or properties) for each of the fields so they can still  
///   be safely accessed without being directly modified.  
///
/// XP: 50  
/// Page: 162  
///
/// Notes:  
/// Updated the `Arrow` class to properly encapsulate its data, hiding the internal  
/// fields for arrowhead, fletching, and length. Added public getter methods to allow  
/// controlled read access while preventing external modification.  
/// Reinforced understanding of encapsulation, access modifiers, and information hiding  
/// as key principles of object-oriented programming.  
///
/// Reflection:  
/// Practiced transforming a basic data container class into a safer, more robust  
/// structure through encapsulation. Learned how private fields protect internal state  
/// while getter methods provide a clean and safe interface for other parts of the program.  
/// This challenge emphasized defensive programming and class design hygiene.  
/// </summary>


Console.Title = "Vin's Trouble";
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\t==== Vin's Trouble ====\n");

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
Console.ForegroundColor = ConsoleColor.Yellow;
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
internal class Arrow
{
	private ArrowheadType _headType;
	private FletchingType _fletchingType;
	private int _shaftLength;
	private float _pricePerCentimeter = 0.05f;

	public Arrow() : this(ArrowheadType.Unknown, FletchingType.Unknown, 60)
	{
	}

	public Arrow(ArrowheadType headType, FletchingType fletchingType, int shaftLength)
	{
		_headType = headType;
		_fletchingType = fletchingType;
		_shaftLength = shaftLength;
	}
	public ArrowheadType GetArrowheadType() => _headType;

	public FletchingType GetFletchingType() => _fletchingType;

	public int GetShaftLength() => _shaftLength;

	public void SetPricePerCentimeter(float newPrice) => _pricePerCentimeter = newPrice;

	public float GetCost()
	{
		float arrowCost = 0;
		arrowCost += GetHeadTypeCost(_headType);
		arrowCost += GetFletchingTypeCost(_fletchingType);
		arrowCost += GetShaftLengthCost();
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

	private float GetShaftLengthCost() => _shaftLength * _pricePerCentimeter;




	public enum ArrowheadType { Unknown, Steel, Wood, Obsidian }
	public enum FletchingType { Unknown, Plastic, TurkeyFeathers, GooseFeathers }
}
