/// <summary>
/// Challenge 014 – Buying Inventory
/// --------------------------------
/// Prompt:
///     It is time to resupply. A nearby outfitter shop has the supplies you need but is so disorganized
///     that they cannot sell things to you. “Can’t sell if I can’t find the price list,” Tortuga, the owner,
///     tells you as he turns over and attempts to go back to sleep in his reclining chair in the corner.
///     Using your programming skills, you can build something that reports the prices of equipment
///     based on the user’s selection.
///
///     The following items are available:
///         1 – Rope
///         2 – Torches
///         3 – Climbing Equipment
///         4 – Clean Water
///         5 – Machete
///         6 – Canoe
///         7 – Food Supplies
///
/// Objectives:
/// • Build a program that displays the numbered menu above.
/// • Ask the user to enter a number corresponding to the item they want to view.
/// • Use a switch statement (or switch expression) to show the item’s cost:
///         Rope – 10 gold
///         Torches – 15 gold
///         Climbing Equipment – 25 gold
///         Clean Water – 1 gold
///         Machete – 20 gold
///         Canoe – 200 gold
///         Food Supplies – 1 gold
///
/// XP: 100
/// Page: 83
///
/// Notes:
/// Created an interactive shop price lookup tool that displays a list of available equipment
/// and prompts the user to choose an item by number. Implemented a switch statement to
/// map each menu selection to its corresponding price and item name. Included validation
/// for invalid selections and formatted the console output for readability.
///
/// Reflection:
/// Practiced the use of switch statements to replace long if/else chains and learned how to
/// clearly present user options in a menu-driven console program. Reinforced input handling
/// and the use of integer-based branching logic for user-driven choices.
/// </summary>


// Aesthetic Configurations
Console.Title = "Ye Olde Shoppe";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("==== Ye Olde Shoppe ====");

// Grumpy store owner
Console.WriteLine("\nWhat do you want? You think just because you organized my store you can buy whatever you want?\nWell... I guess I'll at least let you have a look.\n\nYou probably can't afford anything anyway.");

// Display items for sale
Console.WriteLine("\nThe following items are available:");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\n\t1 - Rope\n\t2 - Torches\n\t3 - Climbing Equipment\n\t4 - Clean Water\n\t5 - Machete\n\t6 - Canoe\n\t7 - Food Supplies");


Console.ForegroundColor = ConsoleColor.Yellow;

// Prompts user for choice
Console.Write("\nSo, what number do you want to see the price of, poor boy? ");

// Initializes choice variable
int choice;

// Makes user input white
Console.ForegroundColor = ConsoleColor.White;

// If anything other than a reasonable whole number is input, output error code
if (int.TryParse(Console.ReadLine(), out choice))
{
	string itemPrices;

	itemPrices = choice switch
	{
		1 => "Rope cost 10 gold.",
		2 => "Torches cost 15 gold.",
		3 => "Climbing Equipment cost 25  gold.",
		4 => "Clean Water cost 1 gold.",
		5 => "Machetes cost 20 gold.",
		6 => "Canoes cost 200 gold.",
		7 => "Food Supplies cost 1 gold",
		_ => "Yup, get out of my store."
	};

	// Makes price output dark yellow
	Console.ForegroundColor = ConsoleColor.DarkYellow;

	// Outputs item price of user choice
	Console.WriteLine("\n" + itemPrices);
	Console.Beep(2000, 100);

}
else
{
	// Insults user for not making an actual choice
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("\nExcuse me, are you stupid?");
	Console.Beep(750, 1500);
}

Console.ResetColor();