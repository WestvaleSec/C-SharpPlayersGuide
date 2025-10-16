/// <summary>
/// Challenge 007 – The Variable Shop Returns
/// --------------------------------
/// Prompt:
///     “Hey! Programmer!” It’s the shopkeeper from the Variable Shop who hobbles over to you.
///     “Thanks to your help, variables are selling like RAM cakes! But these people just aren’t
///     any good at programming. They keep asking how to modify the values of the variables
///     they’re buying, and… well… frankly, I have no clue. But you’re a programmer, right?
///     Maybe you could show me so I can show my customers?”
///
/// Objectives:
/// • Modify your Variable Shop program to assign a new, different literal value to each of
///   the 14 original variables. Do not declare any additional variables.
/// • Use Console.WriteLine to display the updated contents of each variable.
///
/// XP: 50
/// Page: 45
///
/// Notes:
/// Expanded upon the previous Variable Shop program to allow reassigning all variables.
/// Used Convert methods and user input to turn the task into an interactive type test,
/// providing feedback for each successful reassignment.
///
/// Reflection:
/// Reinforced understanding of variable reassignment and type conversion.
/// Could improve by adding exception handling for invalid input.
/// </summary>

// Intro message
Console.WriteLine("Apparently these peasants don't know how to do basic reassignment of variables.\nCan you input valid changes for each variable type?");

// All Variable declarations with sample values
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

Console.WriteLine("\nI'll give you a type and it's value, and you give me a valid reassignment value.\nIf you give a wrong value, this world will crash.\n\nNo Pressure ;)");

// Reassignment prompts for each variable type
Console.WriteLine($"Byte: {numByte}");
numByte = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Success!");

Console.WriteLine($"SByte: {numSByte}");
numSByte = Convert.ToSByte(Console.ReadLine());
Console.WriteLine("Success!");

Console.WriteLine($"Short: {numShort}");
numShort = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Success!");

Console.WriteLine($"UShort: {numUShort}");
numUShort = Convert.ToUInt16(Console.ReadLine());
Console.WriteLine("Success!");

Console.WriteLine($"Int: {numInt}");
numInt = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Success!");

Console.WriteLine($"UInt: {numUInt}");
numUInt = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Success!");

Console.WriteLine($"Long: {numLong}");
numLong = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Success!");

Console.WriteLine($"ULong: {numULong}");
numULong = Convert.ToUInt64(Console.ReadLine());
Console.WriteLine("Success!");

Console.WriteLine($"Float: {numFloat}");
numFloat = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Success!");

Console.WriteLine($"Double: {numDouble}");
numDouble = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Success!");

Console.WriteLine($"Decimal: {numDecimal}");
numDecimal = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Success!");

Console.WriteLine($"Char: {letterChar}");
letterChar = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Success!");

Console.WriteLine($"Bool: {isAvailable}");
isAvailable = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Success!");

Console.WriteLine($"String: {exampleString}");
exampleString = Console.ReadLine();
Console.WriteLine("Success!");

// Exit message
Console.WriteLine("Congratulations!\n\nYou've successfully reassigned all variable types without crashing the world!");

// This program tests the user's ability to reassign various C# variable types correctly.
