/// <summary>
/// Challenge 018 – The Replicator of D’To  
/// --------------------------------  
/// Prompt:  
///     While searching through an abandoned storage building filled with strange code artifacts,  
///     you uncover the ancient Replicator of D’To — a mystical device capable of copying data  
///     from one array into another. Unfortunately, the relic’s replication magic has faded and  
///     requires a skilled Programmer to restore it.  
///
/// Objectives:  
/// • Create an integer array of length 5.  
/// • Ask the user for five numbers and store them in the array.  
/// • Create a second array of length 5.  
/// • Use a loop to copy all values from the original array into the new one.  
/// • Display the contents of both arrays to demonstrate that the Replicator now works again.  
///
/// XP: 100  
/// Page: 98 
///
/// Notes:  
/// Designed a dual-array program where user input populates the first array, and iteration-based  
/// logic transfers each value into a second array. Displayed both arrays to confirm identical data.  
/// Leveraged for-loops for explicit index-based control and practiced reinforcing array fundamentals.  
///
/// Reflection:  
/// Practiced array creation, indexing, and value assignment. Reinforced loop traversal and data  
/// replication logic — foundational to understanding memory operations and copying behavior.  
/// The Replicator of D’To was a great hands-on challenge to strengthen confidence in arrays  
/// and iteration flow control.  
/// </summary>

// Aesthetic Configurations
Console.Title = "The Replicator of D'To";
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\t==== The Replicator of D'To ====\n");

// Variable initialization
int arraySizeGiven = 5;
int numberGiven = 0;
int[] originalArray = new int[arraySizeGiven];

Console.ForegroundColor = ConsoleColor.Yellow;

// Asks for X amount of numbers
Console.WriteLine($"Please give me {arraySizeGiven} numbers:");


// Loops actual prompt
for (int i = 0; i < arraySizeGiven; i++)
{
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.Write($"\t{i + 1}: "); // Shows how many numbers have been given
	Console.ForegroundColor = ConsoleColor.DarkYellow;

	// Validates input
	while (!int.TryParse(Console.ReadLine(), out numberGiven))
	{
		Console.Write("Try again: ");
	}

	// Sets current index to the validated number given
	originalArray[i] = numberGiven;
}

// Copies original to new array
int[] newArray = originalArray[0..];

// Prints both arrays
for (int i = 0; i < originalArray.Length; i++)
{
	Console.ForegroundColor = ConsoleColor.DarkYellow;
	Console.WriteLine($"Loop {i + 1}:");
	Console.ForegroundColor = ConsoleColor.DarkRed;
	Console.WriteLine($"\tOriginal Array: {originalArray[i]}");
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine($"\tNew Array: {newArray[i]}\n");
}
Console.ResetColor();