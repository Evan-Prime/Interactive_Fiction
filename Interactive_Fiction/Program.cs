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
        
        

        static void Main(string[] args)
        {
            Console.WriteLine("I.F. Story");
            Console.WriteLine();

            //story = System.IO.File.ReadAllLines(@"Story.txt");
            //Reading Files
            string storyText = "You are in the woods and see a tree and a river.;You climb the tree.;You cross the river.;2;3";
            string[] story = storyText.Split(';');

            DisplayCurrentPage(story);
            /*
            for (int i = 0; i < story.GetLength(0); i++)
            {
                Console.WriteLine(story[i]);  
            }
            */

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }

        static void DisplayCurrentPage(string[] story)
        {
            string MainText = story[0];
            string FirstChoice = story[1];
            string SecondChoice = story[2];
            string FirstPage = story[3];
            string SecondPage = story[4];
            Console.Clear();
            Console.WriteLine(MainText);
            Console.WriteLine();
            Console.WriteLine("Q - " + FirstChoice);
            Console.WriteLine("E - " + SecondChoice);
            Console.WriteLine();
            Console.Write("Choose your option: ");
            Console.ReadKey(false);
        }

        static void InputSystem()
        {
            ConsoleKeyInfo
        }

    }
}
