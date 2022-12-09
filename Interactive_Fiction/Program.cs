using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Fiction
{
    internal class Program
    {
        static string[] storyText;
        static string[] story;
        static int pageNum = 1;
        static int reset = 1;
        static bool inPlay = true;


        static void Main(string[] args)
        {
            Console.WriteLine("I.F. Story");
            Console.WriteLine();

            //story = System.IO.File.ReadAllLines(@"Story.txt");
            //Reading Files
            string[] storyTxt = System.IO.File.ReadAllLines(@"Story.txt");
            //storyText = storyTxt[pageNum].Split('%');
            storyText = storyTxt;
            story = storyText[pageNum].Split(';');

            while (inPlay == true)
            {
                DisplayCurrentPage(story);
                
            }
            /*
            for (int i = 0; i < story.GetLength(0); i++)
            {
                Console.WriteLine(story[i]);  
            }
            */
        }

        static void DisplayCurrentPage(string[] story)
        {
            if (story.Length == 1)
            {
                string MainText = story[0];
                Console.Clear();
                Console.WriteLine(MainText);
                Console.WriteLine();
                Console.WriteLine("Press [R] to reset the story.");
                Console.WriteLine("Press [Esc] to exit.");
                InputSystem();
            }
            else
            {
                string MainText = story[0];
                string FirstChoice = story[1];
                string SecondChoice = story[2];

                Console.Clear();
                Console.WriteLine(MainText);
                Console.WriteLine();
                Console.WriteLine("[Q] - " + FirstChoice);
                Console.WriteLine("[E] - " + SecondChoice);
                Console.WriteLine();
                Console.Write("Choose your option: ");
                InputSystem();
                Console.ReadKey(false);
            }
        }
        
        static void InputSystem()
        {
            ConsoleKeyInfo ChoiceKey;
            ChoiceKey = Console.ReadKey(true);

            if (story.Length == 1)
            {
                if (ChoiceKey.Key == ConsoleKey.R)
                {
                    story = storyText[reset].Split(';');
                }
                else if (ChoiceKey.Key == ConsoleKey.Escape)
                {
                    inPlay = false;
                }
            }
            else
            {
                string FirstPage = story[3];
                string SecondPage = story[4];

                if (ChoiceKey.Key == ConsoleKey.Q)
                {
                    pageNum = int.Parse(FirstPage);
                    story = storyText[pageNum].Split(';');
                }
                else if (ChoiceKey.Key == ConsoleKey.E)
                {
                    pageNum = int.Parse(SecondPage);
                    story = storyText[pageNum].Split(';');
                }
            }
        }
        
    }
}
