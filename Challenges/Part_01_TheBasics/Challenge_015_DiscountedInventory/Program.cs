/// <summary>
/// Challenge 015 – Discounted Inventory
/// --------------------------------
/// Prompt:
///     After sorting through Tortuga’s outfitter shop and making it viable again, Tortuga realizes
///     you’ve put him back in business. To repay the favor, he’s offering you a 50% discount on any
///     item you buy from him. You must update your shop program to reflect this new discount system.
///
/// Objectives:
/// • Modify your previous inventory program to also ask for the user’s name.
/// • If the name entered matches your own, divide the item’s cost by 2 before displaying it.
///
/// XP: 50
/// Page: 85
///
/// Notes:
/// Extended the “Buying Inventory” challenge by introducing personalized discounts based on user input.
/// Implemented a case-insensitive string comparison to check if the buyer’s name matches the player’s,
/// then halved the item’s cost accordingly. Maintained the original menu but changed the structure
///  of the switch (added another as well) for scalability.
///
/// Reflection:
/// Practiced string comparison and conditional logic alongside prior switch expression knowledge.
/// Reinforced understanding of input handling, arithmetic operations, and flow control in console-based
/// applications.
/// Added more dynamic player interaction to simulate personalized shop behavior.
/// </summary>

// Aesthetic Configurations
Console.Title = "Ye Olde Shoppe";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("==== Ye Olde Shoppe ====");

// Grumpy store owner
Console.WriteLine("\nWelcome to Ye Olde Shoppe! We have nothing you're looking for and everything you're not!");

// If user's name is Zane, recognize them as the Hero
string heroName = "zane";
bool isHero = false;
Console.Write("\nWhat's your name: ");
Console.ForegroundColor = ConsoleColor.White;
string nameGiven = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Yellow;

if (nameGiven != null)
{
	if (nameGiven.ToLower() == heroName)
	{
		Console.WriteLine("\nAh! Our hero is back!\nSorry I gave you such a hard time last go around.\nI was still shaken up by the Consolas attack. I hope you'll forgive me.\n");

		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("I got special prices just for you!");
		Console.ForegroundColor = ConsoleColor.Yellow;

		// Plays little celebration tune
		Console.Beep(600, 200);
		Console.Beep(500, 200);
		Console.Beep(800, 800);
		isHero = true;
	}
	else if (nameGiven == "")
	{
		Console.WriteLine("\nSomeone's not talkative today, eh?");
	}
	else
	{
		Console.WriteLine($"\nNice to meet you, {nameGiven}! My name is Thaldrin Copperthumb the Sleep-Deprived Merchant King.");
	}
}

// Display items for sale
Console.WriteLine("\nWell, the following items are available:");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\n\t1 - Rope\n\t2 - Torches\n\t3 - Climbing Equipment\n\t4 - Clean Water\n\t5 - Machete\n\t6 - Canoe\n\t7 - Food Supplies");


Console.ForegroundColor = ConsoleColor.Yellow;



// Prompts user for choice
Console.Write("\nSo, what number do you want to see the price of: ");

// Initializes variables
int choice;


double ropePrice = 10;
double torchPrice = 15;
double climbEquipPrice = 25;
double waterPrice = 1;
double machetePrice = 20;
double canoePrice = 200;
double foodPrice = 1;

// Makes user input white
Console.ForegroundColor = ConsoleColor.White;

// If anything other than a reasonable whole number is input, output error code
if (int.TryParse(Console.ReadLine(), out choice))
{
	// Assigns item price by choice given by user
	double itemPrice;
	itemPrice = choice switch
	{
		1 => ropePrice,
		2 => torchPrice,
		3 => climbEquipPrice,
		4 => waterPrice,
		5 => machetePrice,
		6 => canoePrice,
		7 => foodPrice,
		_ => 1000000000
	};
	
	// Assigns item name by choice given by user
	string item;
	item = choice switch
	{
		1 => "Rope",
		2 => "Torches",
		3 => "Climbing Equipment",
		4 => "Water",
		5 => "Machetes",
		6 => "Canoes",
		7 => "Food",
		_ => "Wasting my time"
	};


	

	// If user is the Hero, cut prices in half
	if (isHero)
	{
		itemPrice /= 2;
	}


	// Stores message in variable for readability
	string priceMessage = $"\n{item} cost {itemPrice:#.#} gold.\n";

	// Makes price output dark yellow
	Console.ForegroundColor = ConsoleColor.DarkYellow;

	// Prints price
	Console.WriteLine(priceMessage);
	Console.Beep(2000, 100);

}
else
{
	// Insults user for not making an actual choice
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("\nExcuse me, are you stupid?\n");
	Console.Beep(750, 1500);
}

Console.ResetColor();