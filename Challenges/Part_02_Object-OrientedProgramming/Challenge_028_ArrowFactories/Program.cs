/// <summary>
/// Challenge 028 – Arrow Factories  
/// ------------------------------------------  
/// Page: 173  
/// XP: 100  
///
/// Prompt:  
/// Vin Fletcher’s workshop is expanding! While he still crafts custom arrows for special orders,  
/// most customers now buy one of three popular, predefined models. To save time, you’ll add  
/// **static factory methods** to the `Arrow` class that instantly create these standard variations.  
///
/// Predefined Arrows:  
/// • **Elite Arrow** – Steel head, plastic fletching, 95 cm shaft  
/// • **Beginner Arrow** – Wood head, goose feathers, 75 cm shaft  
/// • **Marksman Arrow** – Steel head, goose feathers, 65 cm shaft  
///
/// Objectives:  
/// • Add three static methods to your `Arrow` class:  
///   - `public static Arrow CreateEliteArrow()`  
///   - `public static Arrow CreateBeginnerArrow()`  
///   - `public static Arrow CreateMarksmanArrow()`  
/// • Each should return a new `Arrow` instance with the appropriate preset configuration.  
/// • Update your main program to allow the user to select either a predefined arrow or create  
///   a custom one using your previous input logic.  
///
/// Key Learning Points:  
/// • Static factory methods encapsulate object creation logic in a clear, reusable way.  
/// • This pattern improves readability (`Arrow.CreateEliteArrow()`) and prevents repeated code.  
/// • This introduces the idea of the **Factory Method pattern**, a core principle in OOP design.  
///
/// Reflection:  
/// This challenge demonstrates a cleaner, more professional way to construct objects — especially  
/// when certain configurations repeat often. It prepares you for advanced OOP topics like factories,  
/// builders, and dependency injection by reinforcing the idea that **object creation can be abstracted**  
/// just like any other logic.  
/// </summary>

Console.Title = "Arrow Factories";
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\t==== Arrow Factories ====\n");

// --- Arrow Attributes Tuple Initialization ---
(Arrow.ArrowheadType arrowheadType, Arrow.ArrowFletchingType fletchingType, int shaftLength) customArrow = (Arrow.ArrowheadType.Unknown, Arrow.ArrowFletchingType.Unknown, 60);

Arrow theArrow = Arrow.CreateMarksmanArrow();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("This is what I got in stock:\n\tElite Arrows - steel arrowhead, plastic fletching, and a 95cm shaft\n\tMarksman Arrows - steel arrowhead, goose feather fletching, and a 65cm shaft\n\tBeginner Arrows - wood arrowhead, goose feather fletching, and a 75cm shaft\nOr I can get you a custom made arrow if you'd rather.\n");
Console.Write("Would you like an elite, marksman, beginner, or custom made arrow? (elite, marksman, beginner, custom) ");
string arrowTypeChoice = "";
bool isArrowTypeChoiceMade = false;
while (!isArrowTypeChoiceMade)
{
	Console.ForegroundColor = ConsoleColor.DarkYellow;
	arrowTypeChoice = Console.ReadLine().ToLower();
	switch (arrowTypeChoice)
	{
		case "elite":
			theArrow = Arrow.CreateEliteArrow();
			isArrowTypeChoiceMade = true;
			break;
		case "marksman":
			theArrow = Arrow.CreateMarksmanArrow();
			isArrowTypeChoiceMade = true;
			break;
		case "beginner":
			theArrow = Arrow.CreateBeginnerArrow();
			isArrowTypeChoiceMade = true;
			break;
		case "custom":
			isArrowTypeChoiceMade = true;
			break;
		default:
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("That doesn't exist. Try again: ");
			break;
	}
}
if (arrowTypeChoice == "custom")
{
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
				customArrow.arrowheadType = Arrow.ArrowheadType.Steel;
				isArrowheadChoiceMade = true;
				break;
			case "wood":
				customArrow.arrowheadType = Arrow.ArrowheadType.Wood;
				isArrowheadChoiceMade = true;
				break;
			case "obsidian":
				customArrow.arrowheadType = Arrow.ArrowheadType.Obsidian;
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
				customArrow.fletchingType = Arrow.ArrowFletchingType.Plastic;
				isFletchingChoiceMade = true;
				break;
			case "turkey feathers":
				customArrow.fletchingType = Arrow.ArrowFletchingType.TurkeyFeathers;
				isFletchingChoiceMade = true;
				break;
			case "goose feathers":
				customArrow.fletchingType = Arrow.ArrowFletchingType.GooseFeathers;
				isFletchingChoiceMade = true;
				break;
			default:
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.Write("That doesn't exist. Try again: ");
				break;
		}
	}

	// --- Input: Shaft length ---
	customArrow.shaftLength = AskForNumberInRange("How long would you like the arrow shaft to be? (60 - 100 cm)", 60, 100);

	// --- Create Arrow object and display total cost ---
	Arrow theCustomArrow = new Arrow(customArrow.arrowheadType, customArrow.fletchingType, customArrow.shaftLength);
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.WriteLine($"The cost of the arrow will be {theCustomArrow.GetCost(): 0.00} gold.");
	Console.ResetColor();
}
else
{
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.WriteLine($"The cost of the arrow will be {theArrow.GetCost(): 0.00} gold.");
	Console.ResetColor();
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

// Represents a single arrow with cost calculation logic.
internal class Arrow
{
	public ArrowheadType HeadType { get; init; } = ArrowheadType.Unknown;
	public ArrowFletchingType FletchingType { get; init; } = ArrowFletchingType.Unknown;
	public int ShaftLength { get; init; } = 60;
	public static float PricePerCentimeter { get; } = 0.05f;



	public Arrow() : this(ArrowheadType.Unknown, ArrowFletchingType.Unknown, 60)
	{
	}

	public Arrow(ArrowheadType aHeadType, ArrowFletchingType aFletchingType, int aShaftLength)
	{
		HeadType = aHeadType;
		FletchingType = aFletchingType;
		ShaftLength = aShaftLength;
	}



	public static Arrow CreateEliteArrow()
	{
		ArrowheadType eliteArrowHead = ArrowheadType.Steel;
		ArrowFletchingType eliteFletchingType = ArrowFletchingType.Plastic;
		int eliteShaftLength = 95;
		return new Arrow(eliteArrowHead, eliteFletchingType, eliteShaftLength);
	}

	public static Arrow CreateBeginnerArrow()
	{
		ArrowheadType beginnerArrowHead = ArrowheadType.Wood;
		ArrowFletchingType beginnerFletchingType = ArrowFletchingType.GooseFeathers;
		int beginnerShaftLength = 75;
		return new Arrow(beginnerArrowHead, beginnerFletchingType, beginnerShaftLength);
	}

	public static Arrow CreateMarksmanArrow()
	{
		ArrowheadType marksmanArrowHead = ArrowheadType.Wood;
		ArrowFletchingType marksmanFletchingType = ArrowFletchingType.GooseFeathers;
		int marksmanShaftLength = 65;
		return new Arrow(marksmanArrowHead, marksmanFletchingType, marksmanShaftLength);
	}

	public float GetCost()
	{
		float arrowCost = 0;
		arrowCost += GetHeadTypeCost(HeadType);
		arrowCost += GetFletchingTypeCost(FletchingType);
		arrowCost += GetShaftLengthCost(ShaftLength);
		return arrowCost;
	}

	private static float GetHeadTypeCost(ArrowheadType aHeadType)
	{
		float steelCost = 10;
		float woodCost = 3;
		float obsidianCost = 5;

		switch (aHeadType)
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

	private static float GetFletchingTypeCost(ArrowFletchingType aFletchingType)
	{
		float plasticCost = 10;
		float turkeyFeathersCost = 5;
		float gooseFeathersCost = 3;

		switch (aFletchingType)
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

	private static float GetShaftLengthCost(int aShaftLength) => aShaftLength * PricePerCentimeter;




	public enum ArrowheadType { Unknown, Steel, Wood, Obsidian }
	public enum ArrowFletchingType { Unknown, Plastic, TurkeyFeathers, GooseFeathers }
}