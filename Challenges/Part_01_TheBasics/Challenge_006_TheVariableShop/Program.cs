/// <summary>
/// Challenge 006 – The Variable Shop
/// --------------------------------
/// Prompt:
///     You see an old shopkeeper struggling to stack up variables in a window display.
///     “Hoo-wee! All these variable types sure are exciting but setting them all up to show
///     them off to excited new programmers like yourself is a lot of work for these aching
///     bones,” she says. “You wouldn’t mind helping me set up this program with one variable
///     of every type, would you?”
///
/// Objectives:
/// • Build a program with a variable of all fourteen types described in this level.
/// • Assign each of them a value using a literal of the correct type.
/// • Use Console.WriteLine to display the contents of each variable.
///
/// XP: 100
/// Page: 45
///
/// Notes:
/// Created a program that declares and assigns one variable of each C# primitive type.
/// Displayed each variable’s value using Console.WriteLine to confirm correct assignment.
///
/// Reflection:
/// Practiced declaring, assigning, and printing all built-in C# types.
/// This challenge reinforced data-type fundamentals and literal syntax.
/// </summary>

// Intro message
Console.WriteLine("Welcome to the Variable Shop!\nIs there anything specific you're looking for today?");
Console.WriteLine("We have a wide variety of items, from A to Z.\n\nJust let me know which variable you're interested in!\n");

// All Variable declarations with example values
byte numByte = 255;
sbyte numSByte = 127;
short numShort = 32767;
ushort numUShort = 65535;
int numInt = 2147483647;
uint numUInt = 4294967295;
long numLong = 9223372036854775807;
ulong numULong = 18446744073709551615;
float numFloat = 3.40282347E+38F;
double numDouble = 1.7976931348623157E+308;
decimal numDecimal = 79228162514264337593543950335M;
char letterChar = 'Z';
bool isAvailable = true;
string exampleString = "Hello, World!";

// Displaying all variable values to the user
Console.WriteLine("\nHere are some examples of our variables (and their max values):");
Console.WriteLine($"Byte: {numByte}");
Console.WriteLine($"SByte: {numSByte}");
Console.WriteLine($"Short: {numShort}");
Console.WriteLine($"UShort: {numUShort}");
Console.WriteLine($"Int: {numInt}");
Console.WriteLine($"UInt: {numUInt}");
Console.WriteLine($"Long: {numLong}");
Console.WriteLine($"ULong: {numULong}");
Console.WriteLine($"Float: {numFloat}");
Console.WriteLine($"Double: {numDouble}");
Console.WriteLine($"Decimal: {numDecimal}");
Console.WriteLine($"Char: {letterChar}");
Console.WriteLine($"Bool: {isAvailable}");
Console.WriteLine($"String: {exampleString}");
Console.WriteLine("\nFeel free to ask if you have any questions about these variables!");
Console.WriteLine("\n\n\n\n...\n\n\nThank you for visiting the Variable Shop. Have a great day!");

// This program introduces various C# variable types and their maximum values to the user.