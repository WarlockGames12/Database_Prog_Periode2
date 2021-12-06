using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leerjaar_2_Periode_2_Les_3_Console_Parsing
{
    class Activity
    {
        public Websites StartWebsite { get; set; }
        public Websites currentWebsite { get; private set; }

        private int selectionArrowIndex = 0;
        public Activity()
        {

        }

        public void RunTheCode()
        {
            if (currentWebsite == null)
            {
                currentWebsite = StartWebsite;
            }
            Console.WriteLine($"You're on {currentWebsite.websitename}\n website");
            Console.WriteLine(currentWebsite.story + "\n");
            Console.WriteLine("Which website do you want to go?");
            for (int i = 0; i < currentWebsite.websitesdestinations.Count; i++)
            {
                Console.WriteLine($"{i} - {currentWebsite.websitesdestinations[i].websitename}");
            }
            int choice = AskForInput(currentWebsite.websitesdestinations.Count);
            currentWebsite = currentWebsite.websitesdestinations[choice];

        }

        public void RunArrowInput()
        {
            if (currentWebsite == null)
            {
                currentWebsite = StartWebsite;
            }
            Console.WriteLine($"You're on {currentWebsite.websitename}\n website");
            Console.WriteLine(currentWebsite.story);
            Console.WriteLine("Which website do you want to go?");
            for (int i = 0; i < currentWebsite.websitesdestinations.Count; i++)
            {
                if (i == selectionArrowIndex)
                {
                    Console.Write("->");
                }
                Console.Write($"\t{currentWebsite.websitesdestinations[i].websitename}\n");
            }
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    if (selectionArrowIndex == 0)
                    {
                        selectionArrowIndex = currentWebsite.websitesdestinations.Count - 1;
                    }
                    else
                    {
                        selectionArrowIndex--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (selectionArrowIndex < currentWebsite.websitesdestinations.Count - 1)
                    {
                        selectionArrowIndex++;
                    }
                    else
                    {
                        selectionArrowIndex = 0;
                    }
                    break;
                case ConsoleKey.Enter:
                    currentWebsite = currentWebsite.websitesdestinations[selectionArrowIndex];
                    selectionArrowIndex = 0;
                    break;
            }
            Console.Clear();
        }

        private int AskForInput(int maxNumber)
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input < maxNumber)
                {
                    return input;
                }
                Console.WriteLine("This option is not avalable");
            }
            else
            {
                Console.WriteLine("Please insert a number");
            }
            return AskForInput(maxNumber);
        }

    }
}
