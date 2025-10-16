/* This is a program that generates a name for a thing based on user input.
   It prompts the user for the type of thing and a descriptor, then combines these
   with fixed parts to create a descriptive name. Kind of like Madlibs. */
Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); // User input for the type of thing
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); // User input for the descriptor
string c = "Doom"; // A fixed part of the name
string d = "3000"; // A fixed part of the name
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");

//Answer this question:
//  Aside from comments, what else could you do to make this code more understandable?
//      I would personally use space blank lines between the WriteLines and ReadLines to make it more readable.
//      I would also use more descriptive variable names instead of a, b, c, and d. For example, givenNoun, givenAdjective, fixedPart1, and fixedPart2.
//      I would also just combine the fixed variables into one string variable called fixedPart or just type it directly in the final WriteLine.