/// <summary>
/// Boss Battle – The Point  
/// ------------------------------------------  
/// Page: 191  
/// XP: 75  
///
/// Prompt:  
/// The first pedestal challenges you to forge a **Point** class capable of representing positions  
/// in a two-dimensional plane. Each point tracks its distance from the origin using X and Y coordinates.  
/// This class serves as a fundamental building block for later geometry-based programming challenges.  
///
/// Objectives:  
/// • Define a new `Point` class with `X` and `Y` properties.  
/// • Add a constructor that accepts specific x- and y-coordinates.  
/// • Add a parameterless constructor that initializes the point to the origin (0, 0).  
/// • In `Main()`, create and display a few sample points — e.g., (2, 3) and (-4, 0) — formatted as `(x, y)`.  
/// • Reflect on whether the X and Y properties should be **immutable**, and justify your design choice.  
/// 
/// I decided to make it immutable using init; because if you are going to "point" at something, it shouldn't be easily changed.
///
/// Key Learning Points:  
/// • This reinforces **constructors** — methods that define how objects are created.  
/// • The exercise encourages thinking about **immutability** (read-only properties) and data safety.  
/// • It establishes how small, reusable data objects can form the foundation of larger systems.  
///
/// Reflection:  
/// In this Boss Battle, you learn to define your first geometric class, balancing simplicity with  
/// clarity. Making `X` and `Y` **immutable** (`get; init;`) ensures that once a point is created,  
/// its coordinates cannot be changed — a common and safe practice for mathematical or spatial data.  
/// </summary>

Point exampleOne = new Point(2, 3);
Point exampleTwo = new Point(-4, 0);

Console.WriteLine($"Example One: ({exampleOne.XCoordinate}, {exampleOne.YCoordinate})");
Console.WriteLine($"Example Two: ({exampleTwo.XCoordinate}, {exampleTwo.YCoordinate})");

public class Point
{
	public float XCoordinate { get; private init; }
	public float YCoordinate { get; private init; }

	public Point() : this(0, 0)
	{
	}
	public Point(float xCoordinate, float yCoordinate)
	{
		XCoordinate = xCoordinate;
		YCoordinate = yCoordinate;
	}
}