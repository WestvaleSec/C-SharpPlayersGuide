/// <summary>
/// Challenge 020 – The Properties of Arrows  
/// ------------------------------------------
/// Page: 168  
/// XP: 100  
///
/// Prompt:  
/// Vin Fletcher has one last request. His rival, Flynn Vetcher, sells unsafe and overpriced arrows,  
/// but customers like his design because it’s “easier to use.” Vin doesn’t want to sacrifice safety,  
/// but he remembers your mention of *properties* and asks for your help making his own class  
/// cleaner and more intuitive.  
///
/// Objectives:  
/// • Modify the existing `Arrow` class to replace getter and setter methods with **C# properties**.  
/// • Keep all encapsulation (no public fields).  
/// • Ensure the program still works as before — users can create and inspect arrows easily without  
///   sacrificing safety.  
///
/// Key Learning Points:  
/// • Properties are a clean and safe way to expose class data in C# without giving up control.  
/// • You can use auto-properties (for simple fields) or backing fields with logic (for validation).  
/// • Properties provide the ease of field access (`arrow.Length`) while still protecting internal data.  
///
/// Reflection:  
/// This challenge teaches the modern way to handle encapsulation — by using properties to provide  
/// controlled access to internal data. Instead of explicitly writing `GetLength()` and `SetLength()`,  
/// you expose the data safely using `public int Length { get; private set; }`, combining the clarity  
/// of direct access with the safety of private control.  
/// </summary>


Console.Title = "The Properties of Arrows";
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\t==== The Properties of Arrows ====\n");

// --- Arrow Attributes Tuple Initialization ---
(Arrow.ArrowheadType arrowheadType, Arrow.ArrowFletchingType fletchingType, int shaftLength) arrowChoice = (Arrow.ArrowheadType.Unknown, Arrow.ArrowFletchingType.Unknown, 60);

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
			arrowChoice.fletchingType = Arrow.ArrowFletchingType.Plastic;
			isFletchingChoiceMade = true;
			break;
		case "turkey feathers":
			arrowChoice.fletchingType = Arrow.ArrowFletchingType.TurkeyFeathers;
			isFletchingChoiceMade = true;
			break;
		case "goose feathers":
			arrowChoice.fletchingType = Arrow.ArrowFletchingType.GooseFeathers;
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
Console.WriteLine($"The cost of the arrow will be {theArrow.GetCost(): 0.00} gold.");

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
	public  ArrowheadType HeadType { get; init; } = ArrowheadType.Unknown;
	public ArrowFletchingType FletchingType { get; init; } = ArrowFletchingType.Unknown;
	public int ShaftLength { get; init; } = 60;
	public float PricePerCentimeter { get; } = 0.05f;



	public Arrow() : this(ArrowheadType.Unknown, ArrowFletchingType.Unknown, 60)
	{
	}

	public Arrow(ArrowheadType headType, ArrowFletchingType fletchingType, int shaftLength)
	{
		HeadType = headType;
		FletchingType = fletchingType;
		ShaftLength = shaftLength;
	}

	public float GetCost()
	{
		float arrowCost = 0;
		arrowCost += GetHeadTypeCost();
		arrowCost += GetFletchingTypeCost();
		arrowCost += GetShaftLengthCost();
		return arrowCost;
	}

	private float GetHeadTypeCost()
	{
		float steelCost = 10;
		float woodCost = 3;
		float obsidianCost = 5;

		switch (HeadType)
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

	private float GetFletchingTypeCost()
	{
		float plasticCost = 10;
		float turkeyFeathersCost = 5;
		float gooseFeathersCost = 3;

		switch (FletchingType)
		{
			case ArrowFletchingType.Plastic:
				return plasticCost;
			case ArrowFletchingType.TurkeyFeathers:
				return turkeyFeathersCost;
			case ArrowFletchingType.GooseFeathers:
				return gooseFeathersCost;
			default:
				return 0;
		}
	}

	private float GetShaftLengthCost() => ShaftLength * PricePerCentimeter;




	public enum ArrowheadType { Unknown, Steel, Wood, Obsidian }
	public enum ArrowFletchingType { Unknown, Plastic, TurkeyFeathers, GooseFeathers }
}
