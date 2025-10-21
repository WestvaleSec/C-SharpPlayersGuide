/// <summary>
/// Challenge 017 – The Magic Cannon  
/// --------------------------------  
/// Prompt:  
///     Skorin, a member of Consolas’s wall guard, has constructed a magic cannon powered  
///     by two gems: one Fire gem and one Electric gem. Every third turn of the crank, the  
///     Fire gem activates, releasing a fiery blast. Every fifth turn, the Electric gem  
///     activates, discharging an electric blast. When both align on the same turn, the  
///     cannon unleashes a powerful combined blast.  
///     Your task is to help the crew predict what type of blast will occur before turning the crank.  
///
/// Objectives:  
/// • Loop through the values between 1 and 100 (inclusive).  
/// • Use the modulus operator (%) to determine when each gem activates.  
/// • Display the correct type of blast for each turn:  
///     – “Fire” for multiples of 3  
///     – “Electric” for multiples of 5  
///     – “Electric and Fire” for multiples of both  
///     – “Normal” otherwise  
/// • Change the output color based on the blast type:  
///     – Red for Fire  
///     – Yellow for Electric  
///     – Blue for Electric and Fire  
///     – Gray (default) for Normal  
///
/// XP: 100  
/// Page: 94  
///
/// Notes:  
/// Built a simple predictive simulator that iterates from 1 to 100 and classifies each  
/// crank turn according to Fire, Electric, or combined activation conditions.  
/// Implemented color-coded console output to enhance readability and simulate visual feedback.  
/// The program cleanly handles overlapping activation cycles using compound conditional logic.  
///
/// Reflection:  
/// Practiced modular arithmetic and multi-conditional branching to manage recurring events.  
/// Reinforced loop iteration logic and improved console presentation techniques.  
/// This challenge was a satisfying demonstration of how control flow and pattern recognition  
/// can create clear, engaging program output with minimal complexity.  
/// </summary>

//Aesthetic Configuration
Console.Title = "The Magic Cannon";
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\t==== The Magic Cannon ====\n");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n\nSkorin’s Magic Cannon calibration sequence initiated...\n\n");

// Prompt user for any input to activate cannon prediction
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("*Press any key when you're ready for this awesomeness*\n");
Console.ReadKey(true);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\tFIRE");


// Loops 100 times
for (int i = 1; i <= 100; i++)
{

	// Checks what crank the gun is on
	bool isFire = i % 3 == 0;
	bool isElectric = i % 5 == 0;
	string cannonState;

	// Checks to see if any special gem is being used
	if (isFire || isElectric)
	{
		// Checks if both gems are being used
		if (isFire && isElectric)
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			cannonState = "Fire & Electric";
		}
		else if (isFire) // Checks if just the fire gem is being used
		{
			Console.ForegroundColor = ConsoleColor.Red;
			cannonState = "Fire";
		}
		else // Knows that just the electric gem is being used
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			cannonState = "Electric";
		}
	}
	else // Knows that it is a normal shot
	{
		Console.ForegroundColor = ConsoleColor.White;
		cannonState = "Normal";
	}

	// Outputs what crank we're on and what state the cannon is shooting in
	Console.Write($"\n{i, 3}: {cannonState}");
}

// Aesthetic Configuration
Console.WriteLine("\n\n");
Console.ResetColor();