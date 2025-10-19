/// <summary>
/// Challenge 011 – The Defense of Consolas
/// --------------------------------
/// Prompt:
///     The Uncoded One has begun an assault on the city of Consolas; the situation is dire.
///     From a moving airship called the Manticore, massive fireballs capable of destroying city blocks
///     are being catapulted into the city. The city is arranged in blocks, numbered like a chessboard.
///
///     The city’s only defense is a movable magical barrier, operated by a squad of four that can
///     protect a single city block by positioning themselves in the four adjacent blocks around the
///     target. For example, to defend (Row 6, Column 5), the crew deploys to:
///         (6, 4)
///         (5, 5)
///         (6, 6)
///         (7, 5)
///
/// Objectives:
/// • Ask the user for the target row and column.
/// • Compute the neighboring rows and columns where to deploy the squad.
/// • Display the deployment instructions in a different color.
/// • Change the window title to “Defense of Consolas”.
/// • Play a sound with Console.Beep when the results have been displayed.
///
/// XP: 200
/// Page: 68
///
/// Notes:
/// Built an interactive defense deployment calculator that takes target coordinates and outputs
/// the four surrounding block positions for deployment. Customized console appearance with
/// colored text, changed the window title to “Defense of Consolas”, and triggered a confirmation
/// sound once calculations completed. Ensured the output formatting clearly displayed each
/// coordinate for readability.
///
/// Reflection:
/// Practiced using arithmetic operations and console customization (color, title, and sound).
/// Reinforced understanding of coordinate-based logic and basic user interaction design.
/// This challenge was a fun step toward making functional console tools feel dynamic and responsive.
/// </summary>

// Set console title
Console.Title = "Defense of Consolas";

// Introduction narrative
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("The city of Consolas is under attack from the Uncoded One!\n\nWe need to deploy our magical barrier to protect a city block from incoming fireballs.\n\nTo do this, we need to position our squad in the four adjacent blocks around the target.\n");

// Prompt for target row
Console.Write("\nWhat row do you think the target will land on (1-10): ");
int targetRow = (Convert.ToInt32(Console.ReadLine()));

// Validate user input and apply narrative logic
int timesDied = 0;
int timePassed = 0;
int timeLimit = 5;
bool playerDied = false;

// Validate user input and apply narrative logic
while (targetRow < 1 || targetRow > 10)
{
    // People talking to the player are dark yellow
    Console.ForegroundColor = ConsoleColor.DarkYellow;

    // When player dies
    if (playerDied)
    {
        timePassed = 0;
        timesDied++;
        playerDied = false;
    }

    // Different messages based on how long the player has taken
    if ((targetRow < 1 || targetRow > 10) && timePassed == 0)
    {
        Console.WriteLine("\n\tThat's not a valid row! You're wasting precious time!");
    }
    else if (timePassed == 1)
    {
        Console.WriteLine("\n\tYou have to pick a row between 1 and 10! Hurry up!");
    }
    else if (timePassed == 2)
    {
        Console.WriteLine("\n\tQuit being dumb! We're on the clock! Pick a row between 1 and 10!");
    }
    else if (timePassed == 3)
    {
        Console.WriteLine("\n\tAre you trying to get us all killed? Pick a row between 1 and 10!");
    }
    else if (timePassed == 4)
    {
        Console.WriteLine("\n\tOh we're screwed. Why'd we get stuck with this guy.");
    }
    else if (timePassed >= timeLimit && timesDied < 2) // Player dies on fifth failure two times
    {
        // Narrative for player death
        Console.WriteLine("\n\tThat's it! I've had enough of your incompetence!\n\tThe Uncoded One is going to destroy the city of Consolas because of yo-");

        // Marking death with dark red text
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\n\n\n\tFor just a moment, you feel crushing weight directly on your back.\n\tYou should have been paying more attention.");

        // Change text color back to gray for prompt
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\n\n\n\t\tPress enter to continue.");

        // Wait for player to read and press enter
        Console.ReadKey(true);

        // Clear console for dramatic effect and next narrative
        Console.Clear();

        // Mark player as dead
        playerDied = true;

        // More narrative for dying to the Uncoded One
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"\n\tYou awaken to find yourself facing the Uncoded One himself.\n\n\tHe looks at you with a mix of amusement and disdain.\n\n\t\"You thought you could defend the city of Consolas? Pathetic.\"\n\n\tWith a wave of his hand, he sends you flying into the air, and everything goes black.\n\n\n\n\t*You awaken with a sharp pain in your side as you try to stand up. You look around and see Consolas in it's untouched state.\n\n\tSomeone must have given you another chance (This is your {timesDied + 1} chance). Don't waste it.");

        // Change prompt to continue gray
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\n\n\n\t\tPress enter to continue.");
        Console.ReadKey(true);

        // Clear console for next attempt
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\n\tWhat are you doing? Get up!\n");
    }
    else if (timePassed >= timeLimit && timesDied == 2) // Final death narrative (third death)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nYou have failed the city of Consolas too many times. The Uncoded One has destroyed it.\n\n\n\tGame Over.");
        return; // End program
    }

    // Reset text color to yellow for prompt
    Console.ForegroundColor = ConsoleColor.Yellow;


    // Reprompt for target row
    if (targetRow < 1 || targetRow > 10)
    {
        Console.Write("\n\nWhat row!? (1-10) ");
        targetRow = Convert.ToInt32(Console.ReadLine());

        // Beep to indicate input received
        Console.Beep(500, 100);

        // Increment time passed after each invalid input
        timePassed++;
    }


}

// Prompt for target column
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("\nWhat column do you think the target will land on (1-10): ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

// Validate user input and apply narrative logic
while (targetColumn < 1 || targetColumn > 10)
{
    // People talking to the player are dark yellow
    Console.ForegroundColor = ConsoleColor.DarkYellow;

    // Different messages based on how long the player has taken
    if (timePassed == 1)
    {
        Console.WriteLine("\n\tCommander! You’ve got to focus! The coordinates range from 1 to 10!");
    }
    else if (timePassed == 2)
    {
        Console.WriteLine("\n\tThe Manticore’s adjusting its aim — stop guessing and *think!* Pick a column between 1 and 10!");
    }
    else if (timePassed == 3)
    {
        Console.WriteLine("\n\tThe city's burning while you hesitate! Give me a valid column, soldier!");
    }
    else if (timePassed == 4)
    {
        Console.WriteLine("\n\tThe console flickers red. The ground shakes.\n\n\tA fireball slams into the western wall.\n\n\tThis is your last chance!");
    }
    else if (timePassed >= timeLimit && timesDied < 2) // Player dies on fifth failure two times
    {
        // Narrative for player death
        Console.Clear();

        // Marking death with dark red text
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\n\tYou hear the sirens wailing... then nothing.\n\n\tA deep scratchy voice echoes through the static of your comms:\n\tIt makes your skin crawl\n\n\t\"So, this is humanity's defender?\"\n\n\tThe Uncoded One laugh screeches as Consolas burns in the distance.");

        // Change text color back to gray for prompt
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\n\n\n\t\tPress enter to continue.");

        // Make player dead
        playerDied = true;

        // Wait for player to read and press enter
        Console.ReadKey(true);

        // Clear console for dramatic effect and next narrative
        Console.Clear();

        // More narrative for waking up
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\tYou awaken and no longer smell the smoke and buring flesh.\n\n\tSomehow, time has rewound... the same question echoes in your headset...\n\n\tThis is your {timesDied + 1} chance to defend the city. Don’t waste it.");

        // Change prompt to continue gray
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Press enter to continue.");
        Console.ReadKey(true);

        // Clear console for next attempt
        Console.Clear();

        // Change text color back to yellow for prompt
        Console.ForegroundColor = ConsoleColor.Yellow;

        // Increment death count
        timesDied++;

        Console.WriteLine("\n\tWhat are you doing sleeping at a time like this!? Focus!\n\n");
    }
    else if (timePassed >= timeLimit && timesDied == 2) // Final death narrative (third death)
    {
        // Clear console for dramatic effect
        Console.Clear();

        // Marking death with dark red text
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nYou have failed the city of Consolas too many times.\nThe Uncoded One has destroyed it.\n\n\nGame Over.\n\n\n\n\n\n\n");
        return; // End program
    }
    Console.ForegroundColor = ConsoleColor.Yellow;


    // Reprompt for target column if player is still alive and it is not the first time through loop (including after death)
    if ((targetColumn < 1 || targetColumn > 10) && timePassed >= 1 && playerDied == false)
    {
        Console.Write("\n\nWhat column!? (1-10) ");
        targetColumn = Convert.ToInt32(Console.ReadLine());
        Console.Beep(500, 100);
        timePassed++;
    }
    else if ((targetColumn < 1 || targetColumn > 10) && (timesDied == 0 || timePassed == 0)) // Very first time through loop
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n\tThis guy doesn't know his numbers...");
        timePassed++;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\n\nWhat column!? (1-10) ");
        targetColumn = Convert.ToInt32(Console.ReadLine());
    }

    // First prompt for target column if player died
    if (playerDied)
    {
        timePassed = 0;
        playerDied = false;
        Console.WriteLine($"Target Row: {targetRow}");
        Console.Write("\nWhat column!? (1-10) ");
        targetColumn = Convert.ToInt32(Console.ReadLine());
    }


}

// Calculate deployment coordinates
int northRow = targetRow + 1;
int eastColumn = targetColumn + 1;
int southRow = targetRow - 1;
int westColumn = targetColumn - 1;

// Format deployment coordinates
string northMan = ($"({northRow}, {targetColumn})");
string eastMan = ($"({targetRow}, {eastColumn})");
string southMan = ($"({southRow}, {targetColumn})");
string westMan = ($"({targetRow}, {westColumn})");

// Display deployment instructions in green
Console.ForegroundColor = ConsoleColor.Green;

// Play confirmation sound
Console.Beep(1500, 150);
Console.Beep(2000, 600);

// Output deployment coordinates
Console.WriteLine($"\n\nTo defend the target at ({targetRow}, {targetColumn}), deploy the squad to:\n\t{northMan}\n\t{eastMan}\n\t{southMan}\n\t{westMan}\n");

// Confirmation message
Console.WriteLine("Deployment coordinates calculated successfully!");

// Reset console color for exit script
Console.ResetColor();
