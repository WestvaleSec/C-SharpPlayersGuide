/// <summary>
/// Challenge 019 – The Laws of Freach  
/// --------------------------------  
/// Prompt:  
///     The town of Freach has banned all loops except the foreach loop after a disastrous for-loop incident.  
///     You have been hired to rewrite their code that computes the minimum and average value of an int array,  
///     replacing all for loops with foreach loops.  
///  
/// Objectives:  
/// • Start with the code that computes an array’s minimum and average values.  
/// • Modify the program to use foreach loops instead of for loops.  
///  
/// XP: 50  
/// Page: 95  
///  
/// Notes:  
/// Replaced all traditional for loops with foreach loops to iterate through the array elements.  
/// Used cumulative sum and comparison logic within foreach to compute the total and track the minimum value.  
/// Output both the minimum and average results at the end of execution.  
///  
/// Reflection:  
/// Practiced transitioning from indexed iteration to direct element iteration using foreach.  
/// Reinforced understanding of collection traversal and accumulation patterns.  
/// Improved comfort with non-index-based iteration and readability enhancements in array processing.  
/// </summary>



/* Original code with for loops

ORIGINAL MINIMUM VALUE CALCULATION
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.
for (int index = 0; index < array.Length; index++)
{
	if (array[index] < currentSmallest)
		currentSmallest = array[index];
}
Console.WriteLine(currentSmallest);

ORIGINAL AVERAGE VALUE CALCULATION
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
for (int index = 0; index < array.Length; index++)
	total += array[index];
float average = (float)total / array.Length;
Console.WriteLine(average);
*/


// Aesthetic Configuration
Console.Title = "The Laws of Freach";
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\t==== The Laws of Freach ====\n");


// NEW CODE WITH FOREACH LOOPS

// Minimum value calculation
int[] minArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.
foreach (int currentNumber in minArray)
{
	if (currentNumber < currentSmallest)
	{
		currentSmallest = currentNumber;
	}
}
Console.WriteLine($"Smallest Number: {currentSmallest, 5}\n");


// Average value calculation
int[] avgArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
foreach (int currentNumber in avgArray)
{
	total += currentNumber;
}
// Calculate average
float average = (float)total / avgArray.Length;
Console.WriteLine($"Average Number: {average, 5: #.##}\n");

Console.ResetColor();