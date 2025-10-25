/// <summary>
/// Boss Battle – The Locked Door
/// --------------------------------
/// Page: 192
/// XP: 100
///
/// Prompt:
///     The fourth pedestal demands constructing a door class with a locking mechanism that
///     requires a unique numeric code to unlock. The door should support realistic transitions
///     between open, closed, and locked states, and only unlock when the correct numeric passcode
///     is provided.
///
/// Objectives:
/// • Define a Door class that can keep track of whether it is locked, open, or closed.
/// • Allow four valid transitions:
///     - An open door can always be closed.
///     - A closed (but unlocked) door can always be opened.
///     - A closed door can always be locked.
///     - A locked door can be unlocked with the correct passcode.
/// • When created, a Door must have an initial numeric passcode.
/// • Include a method to change the passcode by providing the correct current code and a new one.
/// • In Main, ask the user for a starting passcode, create a new Door instance, and let the user
///   control the door with text commands (open, close, lock, unlock, change passcode).
///
/// Notes:
/// Built a class-based simulation of a locking mechanism with encapsulated state and validation.
/// Reinforced understanding of constructors, condition-based transitions, and encapsulation of
/// internal state and logic.
///
/// Reflection:
/// Practiced applying class design, state management, and secure validation logic using user input.
/// Helped reinforce the importance of limiting direct state access and enforcing transitions through
/// method logic.
/// </summary>


