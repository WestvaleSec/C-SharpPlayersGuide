/// <summary>
/// Boss Battle – The Color  
/// ------------------------------------------  
/// Page: 191  
/// XP: 100  
///
/// Prompt:  
/// The second pedestal challenges you to forge a **Color** class that represents colors using  
/// their three primary light channels: red, green, and blue. Each channel can range from 0 (off)  
/// to 255 (fully lit). Using this system, all colors can be described numerically, and a few  
/// standard colors are provided as reference examples.  
///
/// Common Colors:  
/// • White (255, 255, 255)  
/// • Black (0, 0, 0)  
/// • Red (255, 0, 0)  
/// • Orange (255, 165, 0)  
/// • Yellow (255, 255, 0)  
/// • Green (0, 128, 0)  
/// • Blue (0, 0, 255)  
/// • Purple (128, 0, 128)  
///
/// Objectives:  
/// • Define a `Color` class with `Red`, `Green`, and `Blue` properties.  
/// • Add constructors to initialize color values — for example, a default (black) constructor and  
///   a parameterized one that accepts red, green, and blue values.  
/// • Create static properties for each of the eight commonly used colors so they can be accessed  
///   easily (e.g., `Color.Red`, `Color.White`).  
/// • In `Main()`, create one color using a constructor and another using a static property,  
///   then display their RGB channel values.  
///
/// Key Learning Points:  
/// • Reinforces **object instantiation** and **property encapsulation**.  
/// • Introduces the use of **static members** to provide quick access to shared, predefined data.  
/// • Demonstrates how to represent abstract concepts (like color) with simple data structures.  
///
/// Reflection:  
/// This Boss Battle demonstrates the power of encapsulating raw numerical data into a well-defined  
/// object. By giving color values meaningful structure and names, your code becomes cleaner, safer,  
/// and easier to reason about — a core principle of object-oriented design.  
/// </summary>


Color aRandomColor = new Color(143, 200, 45);
Color purple = Color.Purple;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"A Random Color: RGB({aRandomColor.RedValue}, {aRandomColor.GreenValue}, {aRandomColor.BlueValue})");

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Purple: RGB({purple.RedValue}, {purple.GreenValue}, {purple.BlueValue})");

Console.ResetColor();

public class Color
{
	public byte RedValue { get; set; }
	public byte GreenValue { get; set; }
	public byte BlueValue { get; set; }

	public Color() : this(0, 0, 0)
	{
	}
	public Color(byte red, byte green, byte blue)
	{
		RedValue = red;
		GreenValue = green;
		BlueValue = blue;
	}

	public static Color White { get; } = new Color(255, 255, 255);
	public static Color Black { get; } = new Color(0, 0, 0);
	public static Color Red { get; } = new Color(255, 0, 0);
	public static Color Orange { get; } = new Color(255, 165, 0);
	public static Color Yellow { get; } = new Color(255, 255, 0);
	public static Color Green { get; } = new Color(0, 128, 0);
	public static Color Blue { get; } = new Color(0, 0, 255);
	public static Color Purple { get; } = new Color(128, 0, 128);
}