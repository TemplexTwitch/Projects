using System;
using System.IO;
using System.Web;

namespace ICTPRG302_Intro_to_Programming
{
	class Program
	{
		/// <summary>
		/// This is the starting location for the program.
		/// </summary>
		/// <param name="args">
		/// A list of strings passed in to the program
		/// from the command-line when it was started
		/// </param>
		static void Main(string[] args)
		{
			bool isRunning = true;

            while (isRunning) 
			{
                Gamertags gamertags = new Gamertags();
                gamertags.WelcomeScreen();
                gamertags.LoadGamertags();
                ConsoleKeyInfo keyInfo = Console.ReadKey();

	


                if (keyInfo.Key == ConsoleKey.Spacebar)
				{
					gamertags.PrintAllGamertags();
				}
				else if (keyInfo.Key == ConsoleKey.A)
				{
					gamertags.PrintGamertagsEndingWithNumber();

				}
				else if (keyInfo.Key == ConsoleKey.S)
				{
					gamertags.PrintGamertagsNOTEndingWithNumberOrLetter();
				}
				else if(keyInfo.Key == ConsoleKey.N)
				{
                    Console.Write("what would you like to add? ");
                    string s = Console.ReadLine();
                    gamertags.AddTag(s);
                }
					
				
				     
				Console.Clear();
				Console.WriteLine("Would You Like To View The Gamertags Again (y/n)?");

				if (Console.ReadKey().Key == ConsoleKey.Y)
					isRunning = true;
				else
					isRunning = false; 
			}


		}
	}
}
