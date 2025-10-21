/// <summary>
/// Challenge 012 – Repairing the Clocktower
/// --------------------------------
/// Prompt:
///     The recent attacks damaged the great Clocktower of Consolas. The citizens of Consolas have repaired
///     most of it, except one piece that requires the steady hand of a Programmer. It is the part that makes
///     the clock tick and tock. Numbers flow into the clock to make it go, and if the number is even, the
///     clock’s pendulum should tick to the left; if the number is odd, the pendulum should tock to the right.
///     Only a programmer can recreate this critical clock element to make it work again.
///
/// Objectives:
/// • Take a number as input from the console.
/// • Display the word “Tick” if the number is even. Display the word “Tock” if the number is odd.
/// • Hint: Remember that you can use the remainder operator to determine if a number is even or odd.
///
/// XP: 100
/// Page: 75
///
/// Notes:
/// Built a simple program that accepts an integer input and uses the remainder operator (%) to determine
/// whether the number is even or odd. Displayed “Tick” for even inputs and “Tock” for odd inputs, simulating
/// the rhythm of the Clocktower’s pendulum. If the input given is not a number, prints error message.
///
/// Reflection:
/// Reinforced understanding of conditional logic and modulus operations in C#. Practiced using if/else
/// statements to produce dynamic output based on input conditions. Quick and effective exercise in
/// decision-making fundamentals. I also decided to go ahead and learn a bit about error handling and
/// made sure the user input a number.
/// </summary>

// Aesthetic configurations
Console.Title = "Clocktower";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=== Repairing the Clocktower ===");

// Prompts user for a number
Console.Write("\nEnter a number: ");

// Checks if user input was a number and if so, gives number to the double "numberGiven"
if (double.TryParse(Console.ReadLine(), out double numberGiven))
{
	// Checks if the number given is even
	bool isEven = numberGiven % 2 == 0;

	// Outputs "Tick" for an even number, and "Tock" for an odd number
	if (isEven)
	{
		Console.WriteLine("\nTick\n");
	}
	else
	{
		Console.WriteLine("\nTock\n");
	}
}
else // Handles misinputs
{
	Console.WriteLine("\nPlease. Just give a whole number next time, bozo...\n");
}