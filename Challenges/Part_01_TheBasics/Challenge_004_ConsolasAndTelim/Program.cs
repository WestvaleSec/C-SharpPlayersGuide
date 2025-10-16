/// <summary>
/// Challenge 004 – Consolas and Telim
/// --------------------------------
/// Prompt:
///     These lands have not seen Programming in a long time due to the blight of the Uncoded One.
///     Even old programs are now crumbling to bits. Your skills with Programming are only fledgling
///     now, but you can still make a difference in these people’s lives. Maybe someday soon, your
///     skills will have grown strong enough to take on the Uncoded One directly. But for now, you
///     decide to do what you can to help.
///
///     In the nearby city of Consolas, food is running short. Telim has a magic oven that can produce
///     bread from thin air. He is willing to share, but Telim is an Excelian, and Excelians love
///     paperwork; they demand it for all transactions—no exceptions. Telim will share his bread with
///     the city if you can build a program that lets him enter the names of those receiving it.
///
///     A sample run of this program looks like this:
///         Bread is ready.
///         Who is the bread for?
///         RB
///         Noted: RB got bread.
///
/// Objectives:
/// • Make a program that runs as shown above, including taking a name from the user.
///
/// XP: 50
/// Page: 26-27
///
/// Notes:
/// Created a simple console program that prompts the user for a name and prints confirmation
/// that the specified person received bread. Used Console.WriteLine and Console.ReadLine for
/// input/output to match the example exactly.
///
/// Reflection:
/// Practiced reading user input and displaying formatted output. Reinforced understanding of
/// basic console interaction and string concatenation.
/// </summary>

// Display the initial prompt
Console.WriteLine("Bread is ready.\nWho is the bread for?");

// Read user input for the name
string name = Console.ReadLine();

// Display the confirmation message
Console.WriteLine("Noted: " + name + " got bread.\n");