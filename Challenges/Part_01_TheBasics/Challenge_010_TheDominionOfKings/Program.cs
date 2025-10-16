/// <summary>
/// Challenge 010 – The Dominion of Kings
/// --------------------------------
/// Prompt:
///     Three kings, Melik, Casik, and Balik, are sitting around a table, debating who has the greatest
///     kingdom among them. Each king rules an assortment of provinces, duchies, and estates.
///     Collectively, they agree to a point system that helps them judge whose kingdom is greatest:
///     Every estate is worth 1 point, every duchy is worth 3 points, and every province is worth 6 points.
///     They just need a program that will allow them to enter their current holdings and compute a
///     point total.
///
/// Objectives:
/// • Create a program that allows users to enter how many provinces, duchies, and estates they have.
/// • Add up the user’s total score, giving 1 point per estate, 3 per duchy, and 6 per province.
/// • Display the point total to the user.
///
/// XP: 100
/// Page: 57
///
/// Notes:
/// Created a straightforward scoring calculator where the user inputs the number of provinces,
/// duchies, and estates, then receives a total score based on their values (6, 3, and 1 points).
/// Added basic input validation to prevent negative numbers and included humorous responses to
/// reinforce correct input behavior. Finished with a short ranking system to flavor the output
/// and make the program more engaging.
///
/// Reflection:
/// Practiced reading and validating user input while performing simple arithmetic operations.
/// Reinforced understanding of integer math and conditional branching. Gained more comfort with
/// adding small personality elements to functional console programs to make them feel alive.
/// </summary>

Console.WriteLine("As we all know the greatness of a kingdom is determined by its amount of provinces, duchies, and estates.\n\nLet us calculate the points for each of our kingdoms.\n\nIt'll go like this:\n - provinces = 6 points\n - duchies = 3 points\n - estates = 1 point\n");
Console.Write("So, how many provinces do you have? ");
int provinces = Convert.ToInt32(Console.ReadLine());
if (provinces < 0)
{
    Console.WriteLine("You can't have a negative amount of provinces!\nSetting provinces to 0.\n\nYou truly are a peasant.");
    provinces = 0;
}
Console.Write("And how many duchies? ");
int duchies = Convert.ToInt32(Console.ReadLine());
if (duchies < 0)
{
    Console.WriteLine("You can't have a negative amount of duchies!\nSetting duchies to 0.\n\nYou truly are worthless.");
    duchies = 0;
}
Console.Write("Finally, how many estates? ");
int estates = Convert.ToInt32(Console.ReadLine());
if (estates < 0)
{
    Console.WriteLine("You can't have a negative amount of estates!\nSetting estates to 0.\n\nYou truly are a beggar.");
    estates = 0;
}
int score = (provinces * 6) + (duchies * 3) + estates;
Console.WriteLine($"\n\nYour kingdom's score is: {score} points!\n");
if (score >= 50)
{
    Console.WriteLine("You are a legendary king!\n\nYour name will be remembered for generations to come.");
}
else if (score >= 20)
{
    Console.WriteLine("You are a strong king.\n\nI guess you have earned my respect.");
}
else if (score >= 10)
{
    Console.WriteLine("You are a humble king.\n\nDo you need me to train you on how to make a kingdom prosperous");
}
else
{
    Console.WriteLine("You are a mere peasant.\n\nGuards. Throw him out.\n\n\n\n");
}