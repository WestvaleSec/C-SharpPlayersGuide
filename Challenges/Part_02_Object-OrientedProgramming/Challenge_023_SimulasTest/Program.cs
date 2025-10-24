using System.Net.NetworkInformation;


/// <summary>
/// Challenge 023 – Simula’s Test
/// --------------------------------
/// Prompt:
///     As you move through the village of Enumerant, you notice a short, cloaked figure following you.
///     Not being one to enjoy a mysterious figure tailing you, you seize a moment to confront the figure. 
///     “Don’t be alarmed!” she says. “I am Simula. They are saying you’re a Programmer. Is this true?” 
///     You answer in the affirmative, and Simula’s eyes widen. “If you are truly a Programmer, you will be 
///     able to help me. Follow me.” She leads you to a backstreet and into a dimly lit hovel. She hands you 
///     a small, locked chest. “We haven’t seen any Programmers in these lands in a long time. And especially 
///     not ones that can craft types. If you are a True Programmer, you will want what is in that chest. And 
///     if you are a True Programmer, I will gladly give it to you to aid you in your quest.” The chest is a 
///     small box you can hold in your hand. The lid can be open, closed (but unlocked), or locked. You’d normally 
///     be able to go between these states, opening, closing, locking, and unlocking the box, but the box is broken. 
///     You need to create a program with an enumeration to recreate this locking mechanism.
///		
///		Nothing happens if you attempt an impossible action in the current state, like opening a locked box.
///		The program below shows what using this might look like:
///			The chest is locked. What do you want to do? unlock
///			The chest is unlocked. What do you want to do? open 
///			The chest is open. What do you want to do? close
///			The chest is unlocked. What do you want to do
///
/// Objectives:
/// • Define an enumeration for the chest’s state (Locked, Unlocked, Closed, Open).
/// • Create a variable to store and track the current state.
/// • Allow the user to input commands (lock, unlock, open, close).
/// • Validate state transitions (e.g., you can’t open a locked chest).
/// • Continue looping, allowing the user to interact with the chest indefinitely.
///
/// XP: 100
/// Page: 135
///
/// Notes:
///     Implemented a state machine using an enum and loop-based command
///     system to represent valid transitions between Locked, Closed, and
///     Open chest states. Prevented invalid actions with simple conditional
///     checks and printed current state updates after each command.
///
/// Reflection:
///     Practiced using enumerations to represent discrete program states and
///     reinforce logical flow through state validation. This challenge was a
///     strong introduction to enums and state-based design.
/// </summary>

Console.Title = "Simula's Test";
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n\t==== Simula's Test ====\n");


ChestState currentChestState = ChestState.Locked;



while (true)
{
	string loweredCurrentChestState = $"{currentChestState}".ToLower();
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.Write($"The chest is {loweredCurrentChestState}. What do you want to do? ");
	
	Console.ForegroundColor = ConsoleColor.DarkYellow;
	string userInput = Console.ReadLine().ToLower();

	switch (currentChestState) 
	{
		case ChestState.Locked:
			if (userInput == "unlock")
				currentChestState = ChestState.Closed;
			break;

		case ChestState.Closed:
			if (userInput == "lock")
				currentChestState = ChestState.Locked;
			else if (userInput == "open")
				currentChestState = ChestState.Open;
			break;

		case ChestState.Open:
			if (userInput == "close")
				currentChestState = ChestState.Closed;
			break;
	}

}


enum ChestState
{
	Locked,
	Closed,
	Open
}