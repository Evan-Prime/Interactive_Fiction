using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Fiction
{
    internal class Program
    {
        static string[] story;
        

        static void Main(string[] args)
        {
            Console.WriteLine("I.F. Story");
            Console.WriteLine();

            //story = System.IO.File.ReadAllLines(@"Story.txt");
            //Reading Files
            String Snack = "You are in the woods and see a tree and a river.;You climb the tree.;You cross the river.;2;3";
            story = Snack.Split(';');

            for (int i = 0; i < story.GetLength(0); i++)
            {
                Console.WriteLine(story[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }


    }
}
