using System;

using System.Text.RegularExpressions;

/// <summary>
/// Challenge 009 – The Four Sisters and the Duckbear
/// --------------------------------
/// Prompt:
///     Four sisters own a chocolate farm and collect chocolate eggs laid by chocolate chickens
///     every day. But more often than not, the number of eggs is not evenly divisible among the
///     sisters, and everybody knows you cannot split a chocolate egg into pieces without ruining it.
///     The arguments have grown more heated over time. The town is tired of hearing the four sisters
///     complain, and Chandra, the town’s Arbiter, has finally come up with a plan everybody can agree to.
///     All four sisters get an equal number of chocolate eggs every day, and the remainder is fed to their
///     pet duckbear. All that is left is to have some skilled Programmer build a program to tell them how
///     much each sister and the duckbear should get.
///
/// Objectives:
/// • Create a program that lets the user enter the number of chocolate eggs gathered that day.
/// • Using / and %, compute how many eggs each sister should get and how many are left over for the duckbear.
/// • Answer this question: What are three total egg counts where the duckbear gets more than each sister does?
///     (You can use the program you created to help you find the answer.)
///         I actually just wrote it down on a piece of paper:
///             if total eggs = 3, duckbear = 3, each sister = 0
///             if total eggs = 7, duckbear = 3, each sister = 1
///             if total eggs = 11, duckbear = 3, each sister = 2
///
/// XP: 100
/// Page: 56
///
/// Notes:
/// Expanded the challenge far beyond the base requirements by adding multiple layers of user interaction
/// and validation. Implemented custom logic allowing the user to set a minimum number of eggs the duckbear
/// must receive, and built a loop to ensure that condition is always met. Added safeguards against invalid
/// input and several fun narrative-driven responses for edge cases (e.g., starving the duckbear or having
/// no eggs). The program uses integer division and modulus to distribute eggs fairly while handling
/// multiple branching outcomes.
///
/// Reflection:
/// Strengthened understanding of input validation, control flow, and arithmetic operations in C#.
/// Practiced designing logical conditions that adapt to user input dynamically. Also learned how to add
/// personality and storytelling to console applications without breaking functionality. This challenge
/// helped reinforce both technical logic and creative expression in programming.
/// </summary>


// Introduction and prompt for duckbear minimum eggs
Console.WriteLine("I am the chocolate egg distributor for you four sisters and your duckbear.\nI'll decide what each of you get and how many the duckbear gets.\n\n");
Console.Write("But first, what is the minimum amount of eggs you want the duckbear to receive? ");
double duckbearMinimum = Convert.ToInt32(Console.ReadLine());

// Flag to indicate if duckbear gets all eggs
bool duckBearGetsAll = false;

// Punishes user if they try to starve the duckbear
if (duckbearMinimum < 1)
{
    Console.WriteLine("\n\nYou evildoers. Are you trying to starve the poor duckbear?\n\n...\n...\n...\n\nFine, today you receive no eggs, and the duckbear gets them all.\n\nHopefully you learn your lesson from today.\n\n\n\n");
    duckBearGetsAll = true;
    return;
}

// Prompt for total eggs collected
Console.Write("How many chocolate eggs did you all collect today? ");

// Initialize total eggs variable
int totalEggs = -1;

// Flag to validate input
bool validInput = true;

// Loop until valid non-negative input is received
while (totalEggs < 0)
{
    // Validate input to ensure non-negative number of eggs
    if (validInput == false)
    {
        Console.Write("Please enter a valid number of eggs (at least 0): ");
    }

    // Get user input for total eggs
    totalEggs = Convert.ToInt32(Console.ReadLine());

    // Set input flag to false in case of another loop (will occur if input is invalid)
    validInput = false;
}


// Store original total eggs for output later
int totalEggsCollected = totalEggs;

// Validate total eggs input (rounds down to nearest whole number)
int eggsPerSister = totalEggs / 4;

// int remainderEggs = Convert.ToInt32(Math.Round(totalEggs - (eggsPerSister * 4)));
int remainderEggs = totalEggsCollected % 4;

// Ensure the duckbear gets at least the minimum amount of eggs
while (remainderEggs < duckbearMinimum)
{
    eggsPerSister = (totalEggs / 4) - 1; // Decrease eggs per sister by 1 per loop
    remainderEggs = remainderEggs + 4; // Increase remainder eggs by 4 per loop
    totalEggs = totalEggs - 4; // Decrease total eggs by 4 per loop
}

// Calculate final distribution
int eggsToDuckbear = remainderEggs;
int eggsLeftAfterDuckbear = totalEggs - eggsToDuckbear;

// Output results based on conditions
if (totalEggsCollected == 0) // Edge case where total eggs is 0
{
    Console.WriteLine("\nHmm...\n\nThe chocolate chickens must have been lazy today.\n\n...\n...\n...\n\nFine, today I'll give you some eggs. Two eggs to each sister, and one to the duckbear.\n\n");
    return;
}
else if (totalEggs == 5 && duckbearMinimum == 1) // Edge case where total eggs is 5 and duckbear minimum is 1
{
    Console.WriteLine("Just enough. One for each of you sisters and one for the duckbear.");
}
else if (totalEggsCollected < 5) // Edge case where total eggs is less than 5
{
    Console.WriteLine("\nHmm...\n\nThe chocolate chickens must have been lazy today.\n\n...\n...\n...\n\nFine, today you receive no eggs, and the duckbear gets them all.\nHopefully the chickens produce more eggs tomorrow.");
    duckBearGetsAll = true;
}
else if (eggsLeftAfterDuckbear < 4) // Edge case where not enough eggs left for each sister after duckbear minimum is met
{
    Console.WriteLine("You evildoers. Are you trying to starve your poor sisters?\n\n...\n...\n...\n\nFine, today the duckbear will receive the minimum amount of eggs, and you sisters will have to share them all equally.\n\nHopefully you learned your lesson for today.");
}

if (duckBearGetsAll == true) // If duckbear gets all the eggs
{
    Console.WriteLine($"\nSo, if you collected {totalEggsCollected} eggs today, the duckbear gets them all!");
    return;
}
else // Normal case where distribution is successful
{
    Console.WriteLine($"\nSo, if you collected {totalEggsCollected} eggs today, each sister gets {eggsPerSister} eggs, totaling {eggsPerSister * 4}, and the duckbear gets {eggsToDuckbear} eggs.");
}
