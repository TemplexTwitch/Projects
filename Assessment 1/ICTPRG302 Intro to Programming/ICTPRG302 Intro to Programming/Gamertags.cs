using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ICTPRG302_Intro_to_Programming
{
    internal class Gamertags
    {
        private string[] gamerTagList = { };


        public void LoadGamertags() 
        {
            gamerTagList = File.ReadAllLines("../Gamertags.txt");
        }


        public void PrintAllGamertags() 
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("All Gamertags");
            Console.WriteLine("---------------------------");

            int lineNumber = 1; 
            foreach (string s in gamerTagList) 
            {
                Console.WriteLine(lineNumber.ToString() + ") " + s);

                lineNumber = lineNumber + 1;
            }

            //Display message to user and wait for a keypress

            Console.WriteLine("Press any Key to continue...");
            Console.ReadKey();

        }




        //Display Gamertags Ending With Number

        public void PrintGamertagsEndingWithNumber() 
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Gamertags Ending With Number");
            Console.WriteLine("====================");


            int lineNumber = 1;
            foreach (string s in gamerTagList) 
            {
                if ((s.Length > 0) && Char.IsNumber(s, s.Length - 1)) 
                {
                    Console.WriteLine(lineNumber.ToString() + ") " + s);

                    lineNumber = lineNumber + 1;
                }
            }

            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();

        }


        /// <summary>
        /// Pring tags
        /// </summary>
        public void PrintGamertagsNOTEndingWithNumberOrLetter()
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Gamertags Not Ending With Number Or Letter");
            Console.WriteLine("====================");


            int lineNumber = 1;
            foreach (string s in gamerTagList)
            {
                if ((s.Length > 0) && Char.IsLetterOrDigit(s[0]) == false)
                {
                    Console.WriteLine(lineNumber.ToString() + ") " + s);

                    lineNumber = lineNumber + 1;
                }
            }

            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();

        }

        
        public void WelcomeScreen() 
        {
            Console.Clear();
            
            Console.WriteLine("===============");
            Console.WriteLine("Welcome To The Gamertag Database");
            Console.WriteLine("Press |SpaceBar to See All Gamertags| Press |A to See Gamertags Ending With Number| Press |S to See Gamertags Not Ending With A Number Or Letter}| To Add A Username Press N|");
            Console.WriteLine("===============");

        }

        public void AddTag(string s)
        {
            StreamWriter sw = File.AppendText("../Gamertags.txt");

            sw.WriteLine(s);

            sw.Close();
        }

    }
}
