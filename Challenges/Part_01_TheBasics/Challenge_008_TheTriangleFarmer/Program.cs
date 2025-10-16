/// <summary>
/// Challenge 008 – The Triangle Farmer
/// --------------------------------
/// Prompt:
///     As you pass through the fields near Arithmetica City, you encounter P-Thag, a triangle farmer, 
///     scratching numbers in the dirt. “What is all of that writing for?” you ask.
///     “I’m just trying to calculate the area of all of my triangles. They sell by their size. 
///     The bigger they are, the more they are worth! But I have many triangles on my farm, and the 
///     math gets tricky, and I sometimes make mistakes. Taking a tiny triangle to town thinking 
///     you’re going to get 100 gold, only to be told it’s only worth three, is not fun! If only I 
///     had a program that could help me….” Suddenly, P-Thag looks at you with fresh eyes. “Wait 
///     just a moment. You have the look of a Programmer about you. Can you help me write a 
///     program that will compute the areas for me, so I can quit worrying about math mistakes 
///     and get back to tending to my triangles? The equation I’m using is this one here,” he 
///     says, pointing to the formula, etched in a stone beside him:
///     
///     Area = (base * height) / 2
/// 
/// Objectives:
/// • Write a program that lets you input the triangle’s base size and height.
/// • Compute the area of a triangle by turning the above equation into code.
/// • Write the result of the computation.
///
/// XP: 100
/// Page 53
/// 
/// Notes:
/// Built a simple geometric calculator to take base and height as inputs, then computed area
/// using standard arithmetic and displayed it. Included a loop to allow multiple calculations.
///
/// Reflection:
/// Practiced user input handling and simple math operations.
/// Could improve by validating numeric input and rounding the result.
/// </summary>

// Intro message
Console.WriteLine("Hello there, this is the triangle calculator 3000!\nPlease enter the base and height of your triangle to calculate its area.\n");

// Variable to control loop for multiple triangles
bool anotherTriangle = true;

// Loop to allow multiple triangle calculations based on userInput at end of loop
while (anotherTriangle)
{
    // Prompts user for base and height of triangle
    Console.Write("Base: ");
    double baseGiven = Convert.ToDouble(Console.ReadLine());
    Console.Write("Height: ");
    double heightGiven = Convert.ToDouble(Console.ReadLine());

    // Calculates area for the triangle
    double area = (baseGiven * heightGiven) / 2;

    // Displays the area and prompts user if they want to calculate another triangle
    Console.WriteLine($"\nThe area of your triangle is: {area}\n\n\nWould you like to calculate another triangle?\n");
    Console.Write("Y/N: ");
    string userInput = Console.ReadLine();

    // Checks user input to continue or exit loop
    if (userInput.ToUpper() == "N")
    {
        anotherTriangle = false;
    }
    else
    {
        Console.Clear(); // Clears console for next calculation
        Console.WriteLine("Alright, here we go again!\n");
    }
}

// Exit message
Console.WriteLine("\nThank you for using the triangle calculator 3000!\n\nGoodbye!\n\n\n");
