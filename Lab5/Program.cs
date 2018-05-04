using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{ /*Task: Create an application that simulates dice rolling.
	The application will:
	1. Ask the user to enter the number of sides for a pair of dice.
	2. "Roll" two 6-sided dice, display the results of each, and then ask the user if he/she wants to roll the dice again.
	Build specifications:
	1. Experiment with the Random number generator.
  */
	class Program
	{
		static void Main(string[] args)
		{
			bool run = true;
			while (run == true)
			{
				Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (yes/no)");
				string input = Console.ReadLine();

				if (input == "yes" || input == "YES")
				{
					Console.WriteLine("\nHow many sides should each dice have?");
					int sidesDice = Int32.Parse(Console.ReadLine());

					if (sidesDice == 6)
					{
						var rand = new Random();
						var r1 = rand.Next(1, 7);
						var r2 = rand.Next(1, 7);

						Console.WriteLine("\nRoll 1:\n" + r1 + "\n" + r2);
						Console.Read();

						LoggingSpecialRolls(r1, r2);
					}
					else if (sidesDice != 6)
					{
						Console.WriteLine("Are you sure dice have " + sidesDice + " sides? Please try again.");
					}
				}
				else if (input == "no" || input == "NO")
				{
					Console.WriteLine("Thanks for visiting anyways."); //figure how to close console after this execution
				}
			}
			run = Continue(); //console restarts application before hitting this method
		}
		public static void LoggingSpecialRolls(int r1, int r2)
		{
			Console.WriteLine();
			if (r1 == 1 && r2 == 1)
			{
				Console.WriteLine("You rolled snake eyes, or two 1's.");
			}
			else if (r1 == 6 && r2 == 6)
			{
				Console.WriteLine("You rolled boxed cars, or two 6's.");
			}
			else if (r2 == r1 + 1)
			{
				Console.WriteLine("You rolled craps!");
			}
		}
		public static bool Continue()
		{
			Console.WriteLine("Do you wish to continue? y/n");
			string input = Console.ReadLine();
			input = input.ToLower();
			bool goOn;
			if (input == "y")
			{
				goOn = true;
			}
			else if (input == "n")
			{
				goOn = false;
			}
			else
			{
				Console.WriteLine("I don't understand that, let's try again");
				goOn = Continue();
			}
			return goOn;
		}
	}
}
	

