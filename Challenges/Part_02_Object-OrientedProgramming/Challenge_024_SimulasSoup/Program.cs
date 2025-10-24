/// <summary>
/// Challenge 024 – Simula’s Soup
/// --------------------------------
/// Prompt:
///     Simula is impressed with how you reconstructed the box with an enumeration. When the box opened,
///     you saw a glowing emerald gem inside. You don’t know what it is, but it seems important. Also in the box
///     were three vials of powder labeled HOT, SALTY, and SWEET.
///
///     “Finally! I can make soup again!” Simula says. She casually tosses the small glowing gem to you but is
///     wholly focused on the powders. “You stick around and help me make soup with your programming skills,
///     and I’ll tell you what that gem does.”
///
///     She pulls out a cookpot, knocks the clutter off the table with a quick sweep of her arm, and begins
///     cooking. She says, “I’m the best soup maker in town, and you’re in for a treat. I’ve got recipes for soup,
///     stew, and gumbo. I’ve got mushrooms, chicken, carrots, and potatoes for ingredients. And thanks to you
///     getting that box open, I’ve got seasonings again! Spicy, salty, and sweet seasoning. Pick a recipe, an
///     ingredient, and a seasoning, and I’ll make it. Use your programming skills to help us track what we make.”
///
/// Objectives:
/// • Define enumerations for the three variations on food: type (soup, stew, gumbo), main ingredient
///   (mushrooms, chicken, carrots, potatoes), and seasoning (spicy, salty, sweet).
/// • Make a tuple variable to represent a soup composed of the three above enumeration types.
/// • Let the user pick a type, main ingredient, and seasoning from the allowed choices and fill the tuple
///   with the results. Hint: You could give the user a menu to pick from or simply compare the user’s
///   text input against specific strings to determine which enumeration value represents their choice.
/// • When done, display the contents of the soup tuple variable in a format like “Sweet Chicken Gumbo.”
///   Hint: You don’t need to convert the enumeration value back to a string. Simply displaying an
///   enumeration value with Write or WriteLine will display the name of the enumeration value.
///
/// XP: 100
/// Page: 135
///
/// Notes:
/// Created enumerations for food type, main ingredient, and seasoning. Allowed the user to select one of each,
/// stored the selections in a tuple, and displayed the final result in a readable format (e.g., “Spicy Potato Stew”).
/// Focused on reinforcing enumeration handling, tuple creation, and clean user input flow.
///
/// Reflection:
/// Practiced organizing and combining multiple enums into a single structured tuple to represent complex data.
/// This challenge strengthened understanding of enum design, value selection, and simple data aggregation
/// — all key concepts for building modular, readable programs.
/// </summary>

Console.Title = "Simula's Soup";

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\t==== Simula's Soup ====\n");
Console.ForegroundColor = ConsoleColor.Yellow;

bool invalidChoice = true;
Console.Write($"Glad you're here!\nWhat kind of food do you want me to make you? (soup, stew, or gumbo): ");

(FoodType theFoodType, MainIngredient theMainIngredient, Seasoning theSeasoning) simulasSoup = (FoodType.Stew, MainIngredient.Mushrooms, Seasoning.Salty);

while (invalidChoice)
{
	Console.ForegroundColor = ConsoleColor.DarkYellow;
	string foodTypeChoice = Console.ReadLine().ToLower();
	switch (foodTypeChoice)
	{
		case "soup":
			simulasSoup.theFoodType = FoodType.Soup;
			invalidChoice = false;
			break;
		case "stew":
			simulasSoup.theFoodType = FoodType.Stew;
			invalidChoice = false;
			break;
		case "gumbo":
			simulasSoup.theFoodType = FoodType.Gumbo;
			invalidChoice = false;
			break;
		default:
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("That's not a type of food I offered you: ");
			break;
	}
}

invalidChoice = true;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write($"What do you want the main ingredient to be? (mushrooms, chicken, carrots, or potatoes): ");

while (invalidChoice)
{
	Console.ForegroundColor = ConsoleColor.DarkYellow;
	string mainIngredientChoice = Console.ReadLine().ToLower();
	switch (mainIngredientChoice)
	{
		case "mushrooms":
			simulasSoup.theMainIngredient = MainIngredient.Mushrooms;
			invalidChoice = false;
			break;
		case "chicken":
			simulasSoup.theMainIngredient = MainIngredient.Chicken;
			invalidChoice = false;
			break;
		case "carrots":
			simulasSoup.theMainIngredient = MainIngredient.Carrots;
			invalidChoice = false;
			break;
		case "potatoes":
			simulasSoup.theMainIngredient = MainIngredient.Potatoes;
			invalidChoice = false;
			break;
		default:
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("That's not an ingredient I offered you: ");
			break;
	}
}


invalidChoice = true;
Console.ForegroundColor = ConsoleColor.Yellow;

Console.Write($"What kind of seasoning do you want to try on it? (spicy, salty, or sweet): ");
while (invalidChoice)
{
	Console.ForegroundColor = ConsoleColor.DarkYellow;
	string seasoningChoice = Console.ReadLine().ToLower();
	switch (seasoningChoice)
	{
		case "spicy":
			simulasSoup.theSeasoning = Seasoning.Spicy;
			invalidChoice = false;
			break;
		case "salty":
			simulasSoup.theSeasoning = Seasoning.Salty;
			invalidChoice = false;
			break;
		case "sweet":
			simulasSoup.theSeasoning = Seasoning.Sweet;
			invalidChoice = false;
			break;
		default:
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("That's not a seasoning I offered you: ");
			break;
	}
}

Console.ForegroundColor = ConsoleColor.Yellow;
(FoodType theFoodType, MainIngredient theMainIngredient, Seasoning theSeasoning) = simulasSoup;
Console.WriteLine($"\n{theSeasoning} {theMainIngredient} {theFoodType}.\n\n");


Console.ResetColor();

enum FoodType { Soup, Stew, Gumbo }
enum MainIngredient { Mushrooms, Chicken, Carrots, Potatoes }
enum Seasoning { Spicy, Salty, Sweet }