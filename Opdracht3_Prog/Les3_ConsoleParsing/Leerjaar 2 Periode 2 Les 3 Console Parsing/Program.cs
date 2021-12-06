using System;

namespace Leerjaar_2_Periode_2_Les_3_Console_Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create the framework
            Activity story = new Activity();

            //create websites
            Websites Youtube = new Websites("Youtube", "You scroll around and watch some youtube video's");
            Websites GameJolt = new Websites("GameJolt", "You posted some funny memes on GameJolt and posted a devlog on your game that will never be released");
            Websites Twitter = new Websites("Twitter", "You Looked at twitter then you remembered you hated twitter...");
            Websites YourOwnWebsite = new Websites("Your Own Website", "You looked at your screen and then you remembered you haven't made a website for yourself");
            Websites Itch = new Websites("Itch.io", "You watched some games that were on sale on Itch, but there weren't any to play");
            Websites ExitComputer = new Websites("Exiting Your Computer", "You putted the computer off, never to open agian.");

            //Add the destinations to the rooms
            Youtube.AddWebsites(GameJolt);
            Youtube.AddWebsites(Itch);
            Youtube.AddWebsites(Twitter);
            Youtube.AddWebsites(YourOwnWebsite);
            Youtube.AddWebsites(ExitComputer);
            GameJolt.AddWebsites(Youtube);
            GameJolt.AddWebsites(Twitter);
            GameJolt.AddWebsites(YourOwnWebsite);
            GameJolt.AddWebsites(Itch);
            GameJolt.AddWebsites(ExitComputer);
            Twitter.AddWebsites(Youtube);
            Twitter.AddWebsites(GameJolt);
            Twitter.AddWebsites(YourOwnWebsite);
            Twitter.AddWebsites(Itch);
            Twitter.AddWebsites(ExitComputer);
            YourOwnWebsite.AddWebsites(Youtube);
            YourOwnWebsite.AddWebsites(GameJolt);
            YourOwnWebsite.AddWebsites(Twitter);
            YourOwnWebsite.AddWebsites(Itch);
            YourOwnWebsite.AddWebsites(ExitComputer);
            Itch.AddWebsites(Youtube);
            Itch.AddWebsites(GameJolt);
            Itch.AddWebsites(Twitter);
            Itch.AddWebsites(YourOwnWebsite);
            Itch.AddWebsites(ExitComputer);
            
            
            

            //define the starting room
            story.StartWebsite = Youtube;




            while (true)
            {
                //run the story with int input
                //story.Run();
                story.RunArrowInput();
            }
        }
    }
}
