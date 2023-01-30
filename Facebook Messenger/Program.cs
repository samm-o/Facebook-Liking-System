using System;
using System.Collections.Generic;

namespace Facebook_Messenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>() {};
            while (true)
            {
                Console.Write("Please enter a name: ");
                var input = Console.ReadLine();
                names.Add(input);
                var others = (names.Count) - 3;

                var isEmpty = string.IsNullOrEmpty(input);

                if (isEmpty == true)
                {
                    if (names.Count == 2)
                    {
                        Console.WriteLine(names[0] + " liked your post.");
                        break;
                    }
                    else if (names.Count == 3)
                    {
                        Console.WriteLine(names[0] + " and " + names[1] + " liked your post.");
                        break;
                    }
                    else if (names.Count == 1)
                    {
                        Console.WriteLine("No one liked your post. Loser.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(names[0] + ", " + names[1] + " and " + others + " others liked your post.");
                        break;
                    }
                }
            }
                

        }
    }
}

