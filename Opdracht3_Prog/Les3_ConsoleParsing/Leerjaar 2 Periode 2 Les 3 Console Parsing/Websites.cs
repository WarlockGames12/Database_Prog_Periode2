using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leerjaar_2_Periode_2_Les_3_Console_Parsing
{
    class Websites
    {
        //a list of destinations
        public List<Websites> websitesdestinations { get; private set; }

        //The story of the room
        public string story { get; private set; }

        //the name of the room
        public string websitename { get; private set; }

        public Websites(string aName, string aStory)
        {
            websitesdestinations = new List<Websites>();
            websitename = aName;
            story = aStory;
        }

        public void AddWebsites(Websites website)
        {
            websitesdestinations.Add(website);
        }

    }
}
