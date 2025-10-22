/// <summary>
/// Challenge 020 – Countdown  
/// --------------------------------  
/// Prompt:  
///     The Council of Freach has summoned you to prove your mastery over recursion.  
///     You must rewrite a loop-based countdown using a recursive method instead.  
///     The countdown should start from 10 and end at 1, displaying each number on a new line.  
///  
/// Objectives:  
/// • Write code that counts down from 10 to 1 using a recursive method.  
/// • Remember to include a base case that stops the recursion.  
/// • Each recursive call must move closer to the base case.  
///  
/// XP: 100  
/// Page: 107  
///  
/// Notes:  
/// Implemented a simple recursive method `CountDown(int number)` that prints each number  
/// and calls itself with a decremented value until reaching 1. Added clear output formatting  
/// and visual separation for readability.  
///  
/// Reflection:  
/// Practiced core recursion principles including base cases, stack unwinding, and termination.  
/// Strengthened understanding of how recursive calls can replace iterative loops when structured correctly.  
/// This challenge was a concise and elegant demonstration of recursion fundamentals.  
/// </summary>


// Aesthetic Configuration
Console.Title = "Countdown";
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\t==== Countdown ====\n");

Console.ForegroundColor = ConsoleColor.Yellow;
countdownFrom(10);

// Basic recursion method to count down from any number to 1
void countdownFrom(int aNumber)
{
	Console.WriteLine(aNumber);
	if (aNumber == 1)
	{
		return;
	}
	else
	{
		countdownFrom(aNumber - 1);
	}
}

Console.ResetColor();