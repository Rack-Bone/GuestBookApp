using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GuestBook
{
    internal class Methods

    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to MADcom.");
            Console.WriteLine("Missile bays are initialized and waiting for your command...");
            Console.WriteLine("************************************************************");
        }
        public static string StrikeLocation()
        {
            Console.Write("What is the destination of the missile barrage: ");
            string location = Console.ReadLine();
            return location;

        }
        public static int StrikeAmount()
        {
            bool missile = false;
            int missiles;
            do
            {
                Console.Write("How many missiles are you launching: ");
                string amount = Console.ReadLine();
                missile = int.TryParse(amount, out missiles);

            } while (missile == false);

            return missiles;
        }
        public static bool AskContinue()
        {
            Console.Write("Would you like to hit any more locations? (yes/no) ");
            string continueLocation = Console.ReadLine();
            bool output = (continueLocation.ToLower() == "yes");
            return output;
        }
        public static (List<string> locations, int total) StrikeListContinue()
        {
            int missiles = 0;
            //string continueLocation;
            List<string> locations = new List<string>();
            
            do
            {
               locations.Add(Methods.StrikeLocation());
               missiles += (Methods.StrikeAmount());
            } while (AskContinue());
              return (locations, missiles);
        }
        public static void Totals(List<string> locations)
        {
            Console.WriteLine("Here are the targets hit: ");
            foreach (string location in locations)
            {
                Console.WriteLine(location);
            }

        }
        public static void MissilesLaunched(int missiles)
        {
            Console.WriteLine("****************************************************");
            Console.Write("Here are the total missiles fired: ");
            Console.WriteLine(missiles);
        }

    }
}
