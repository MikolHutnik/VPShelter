using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {

            VitrualPetShelter VPS = new VitrualPetShelter();
            Console.WriteLine("Welcome to the Virtual Pet Shelter! What type of employee are you?");
            Console.WriteLine("Please type 1 for Manager or 2 for Volunteer.");
            int userChoice = int.Parse(Console.ReadLine());
            while (userChoice.Equals(1))
            {
                Console.WriteLine("Please select from a number form the following menue.");

                Console.WriteLine("1. Adopt a pet." );
                Console.WriteLine("2. Feed all pets.");
                Console.WriteLine("3. Play with a pet");
                Console.WriteLine("4. Pay the Bills");
                int numChoice = int.Parse(Console.ReadLine());

                switch (numChoice)
                {
                    case 1:
                        Manager.GetStatus();

                }
            }

        }//main end
    }//class end
}//namespace end
