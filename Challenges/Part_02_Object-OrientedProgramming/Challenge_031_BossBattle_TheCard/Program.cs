
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

/// <summary>
/// Boss Battle – The Card
/// --------------------------------
/// Page: 192
/// XP: 100
///
/// Challenge Summary:
/// The digital Realms of C# contain a deck of cards that differ from traditional playing cards.
/// Each card has both a color (red, green, blue, yellow) and a rank (1–10, $, %, ^, &).
///
/// Objectives:
/// • Define enumerations for the card’s color and rank.
/// • Define a Card class with a color and rank property.
/// • Add methods or properties that determine whether the card is a number card or a symbol card.
/// • In Main(), generate the entire deck (every color with every rank) and display them in a readable format,
///   e.g., “The Red Ampersand” or “The Blue Seven.”
///
/// Reflection Question:
/// Why do we use an enumeration for color here but a class in the previous challenge?
/// → Because card colors represent a **fixed, limited set of distinct options**, making an enum ideal,
///   while color in the previous challenge had **varying RGB values** requiring data storage,
///   making a class the appropriate abstraction.
/// </summary>


Card.InstantiateAllCards();

Console.ResetColor();

public class Card
{
	private Color CardColor { get; }
	private Rank CardRank { get; }

	public Card() : this(Color.Red, Rank.One)
	{
	}
	public Card(Color color, Rank rank)
	{
		CardColor = color;
		CardRank = rank;
	}

	public static void InstantiateAllCards()
	{
		foreach (Rank rank in Enum.GetValues(typeof(Rank)))
		{

			foreach (Color color in Enum.GetValues(typeof(Color)))
			{
				Card newCard = InstantiateCard(color, rank);
				ChangeTextColorBasedOnCard(newCard.CardColor);
				Console.WriteLine($"The {newCard.CardColor} {newCard.CardRank}.   This is a face card: {IsFaceCard(newCard.CardRank)}");
			}
		}
	}

	private static void ChangeTextColorBasedOnCard(Color aColor)
	{
		switch (aColor)
		{
			case Color.Blue:
				Console.ForegroundColor = ConsoleColor.Blue;
				break;
			case Color.Red:
				Console.ForegroundColor = ConsoleColor.Red;
				break;
			case Color.Yellow:
				Console.ForegroundColor = ConsoleColor.Yellow;
				break;
			case Color.Green:
				Console.ForegroundColor = ConsoleColor.Green;
				break;
		}
	}
	private static Card InstantiateCard(Color aCardColor, Rank aCardRank) => new Card(aCardColor, aCardRank);

	private static bool IsFaceCard(Rank aRank) => aRank == Rank.Dollar || aRank == Rank.Percent || aRank == Rank.Carrot || aRank == Rank.Ampersand;

	public enum Color { Red, Green, Blue, Yellow }
	public enum Rank
	{
		One = 1,
		Two,
		Three,
		Four,
		Five,
		Six,
		Seven,
		Eight,
		Nine,
		Ten,
		Dollar, // $
		Percent, // %
		Carrot, // ^
		Ampersand // &
	}
}