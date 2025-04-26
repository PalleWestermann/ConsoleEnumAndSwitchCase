using System;
using System.Drawing;

namespace CardDeckApp
{
    // Enum representing all 52 cards in a deck
    enum Card
    {
        // Spades
        AceOfSpades, TwoOfSpades, ThreeOfSpades, FourOfSpades, FiveOfSpades, SixOfSpades, SevenOfSpades, EightOfSpades, NineOfSpades, TenOfSpades, JackOfSpades, QueenOfSpades, KingOfSpades,
        // Hearts
        AceOfHearts, TwoOfHearts, ThreeOfHearts, FourOfHearts, FiveOfHearts, SixOfHearts, SevenOfHearts, EightOfHearts, NineOfHearts, TenOfHearts, JackOfHearts, QueenOfHearts, KingOfHearts,
        // Diamonds
        AceOfDiamonds, TwoOfDiamonds, ThreeOfDiamonds, FourOfDiamonds, FiveOfDiamonds, SixOfDiamonds, SevenOfDiamonds, EightOfDiamonds, NineOfDiamonds, TenOfDiamonds, JackOfDiamonds, QueenOfDiamonds, KingOfDiamonds,
        // Clubs
        AceOfClubs, TwoOfClubs, ThreeOfClubs, FourOfClubs, FiveOfClubs, SixOfClubs, SevenOfClubs, EightOfClubs, NineOfClubs, TenOfClubs, JackOfClubs, QueenOfClubs, KingOfClubs, Joker
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Available Colors:");

            int counter = 1;
            foreach (Card card in Enum.GetValues(typeof(Card)))
            {
                if (counter % 5 == 0) Console.WriteLine($"{(int)card} - {card} \t");
                else
                    Console.Write($"{(int)card} - {card} \t");
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("Choose a Number representing a card to check (e.g., 0  for AceOfSpades):");
            Console.WriteLine("****************************************************");
            string input = Console.ReadLine();


            if (Enum.TryParse(input, out Card chosenCard))
            {
                CheckCard(chosenCard);
            }
            else
            {
                Console.WriteLine("Invalid card name. Please ensure correct format (e.g., QueenOfHearts).");
            }
        }

        static void CheckCard(Card card)
        {
            switch (card)
            {
                case Card.AceOfSpades:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.TwoOfSpades:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.ThreeOfSpades:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.FourOfSpades:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.FiveOfSpades:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.SixOfSpades:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.SevenOfSpades:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.EightOfSpades:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.NineOfSpades:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.TenOfSpades:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.JackOfSpades:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.QueenOfSpades:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.KingOfSpades:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.AceOfHearts:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.TwoOfHearts:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.ThreeOfHearts:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.FourOfHearts:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.FiveOfHearts:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.SixOfHearts:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.SevenOfHearts:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.EightOfHearts:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.NineOfHearts:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.TenOfHearts:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.JackOfHearts:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.QueenOfHearts:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.KingOfHearts:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.AceOfDiamonds:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.TwoOfDiamonds:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.ThreeOfDiamonds:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.FourOfDiamonds:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.FiveOfDiamonds:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.SixOfDiamonds:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.SevenOfDiamonds:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.EightOfDiamonds:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.NineOfDiamonds:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.TenOfDiamonds:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.JackOfDiamonds:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.QueenOfDiamonds:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.KingOfDiamonds:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.AceOfClubs:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.TwoOfClubs:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.ThreeOfClubs:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.FourOfClubs:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.FiveOfClubs:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.SixOfClubs:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.SevenOfClubs:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.EightOfClubs:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.NineOfClubs:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.TenOfClubs:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.JackOfClubs:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.QueenOfClubs:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.KingOfClubs:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                case Card.Joker:
                    Console.WriteLine($"You picked {card.ToString()}");
                    break;
                default:
                    Console.WriteLine("You picked Outside The Choices. Nerd!");
                    break;
            }
        }
    }
}

