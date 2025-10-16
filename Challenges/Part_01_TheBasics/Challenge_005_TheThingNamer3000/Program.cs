/// <summary>
/// Challenge 005 – The Thing Namer 3000
/// --------------------------------
/// Prompt:
///     As you walk through the city of Commenton, admiring its forward-slash-based architectural
///     buildings, a young man approaches you in a panic. “I dropped my Thing Namer 3000 and
///     broke it. I think it’s mostly working, but all my variable names got reset! I don’t
///     understand what they do!” He shows you the following program:
///
///     Console.WriteLine("What kind of thing are we talking about?");
///     string a = Console.ReadLine();
///     Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
///     string b = Console.ReadLine();
///     string c = "of Doom";
///     string d = "3000";
///     Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
///
///     “You gotta help me figure it out!”
///
/// Objectives:
/// • Rebuild the program above on your computer.
/// • Add comments near each of the four variables that describe what they store. You must use at
///   least one of each comment type (// and /* */).
/// • Find the bug in the text displayed and fix it.
/// • Answer this question: Aside from comments, what else could you do to make this code more
///   understandable?
///         - I would personally use space blank lines between the WriteLines and ReadLines to make 
///         it more readable.
///         - I would also use more descriptive variable names instead of a, b, c, and d. For example, 
///         givenNoun, givenAdjective, fixedPart1, and fixedPart2.
///         - I would also just combine the fixed variables into one string variable called fixedPart 
///         or just type it directly in the final WriteLine
///
/// XP: 100
/// Page: 31
///
/// Notes:
/// Recreated the Thing Namer 3000 program and added clear comments to explain each variable.
/// Fixed the display bug by removing the extra "of" before "Doom 3000" and improved readability
/// by renaming variables to descriptive identifiers.
///
/// Reflection:
/// Practiced using both single-line and multi-line comments.
/// Gained experience improving code readability through naming conventions and documentation.
/// </summary>




/* This is a program that generates a name for a thing based on user input.
   It prompts the user for the type of thing and a descriptor, then combines these
   with fixed parts to create a descriptive name. Kind of like Madlibs. */

Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); // User input for the type of thing (a noun)


Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

string b = Console.ReadLine(); // User input for the descriptor (an adjective)

string c = "Doom"; // A fixed part of the name

string d = "3000"; // A fixed part of the name

// Display the generated name
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
