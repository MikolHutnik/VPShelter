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
            //first attempt
            //VitrualPetShelter VPS = new VitrualPetShelter();
            //Console.WriteLine("Welcome to the Virtual Pet Shelter! What type of employee are you?");
            //Console.WriteLine("Please type 1 for Manager or 2 for Volunteer.");
            //int userChoice = int.Parse(Console.ReadLine());
            //while (userChoice.Equals(1))
            //{
            //    Console.WriteLine("Please select from a number form the following menue.");

            //    Console.WriteLine("1. Adopt a pet." );
            //    Console.WriteLine("2. Feed all pets.");
            //    Console.WriteLine("3. Play with a pet");
            //    Console.WriteLine("4. Pay the Bills");
            //    int numChoice = int.Parse(Console.ReadLine());
            //    if (numChoice == 1)
            //    {
            //        switch (numChoice)
            //        {
            //            case 1:
            //                Manager.Adoption(VPS);

            //                break;

            //            case 2:
            //                VirtualPet.Hunger(VPS);
            //                break;

            //            case 3:
            //                VirtualPet.Thirst(VPS);
            //                break;

            //        }
            //    }



            VirtualPet VPSOne = new VirtualPet("Pete", "Dragon", 26, 26, 26);
            VirtualPet VPSTwo = new VirtualPet("Bork", "Dog", 26, 26, 26);
            VirtualPet VPSThree = new VirtualPet("Dan", "Goat", 26, 26, 26);
            VirtualPet VPSFour = new VirtualPet("Bastet", "CatGod", 26, 26, 26);
            

            Console.WriteLine("Welcome to the VirtualShelter Program");
                Console.WriteLine("Please type Yes to manage the Shelter!");
                string userResponse = Console.ReadLine().ToLower();
                while (userResponse.Equals("yes"))
                {

                    Console.WriteLine("please select from the options below!");
                    Console.WriteLine("Select 1 for Manager.");
                    Console.WriteLine("Select 2 for Volunteer.");
                    int userChoice = int.Parse(Console.ReadLine());

                    switch (userChoice)
                    {
                        case 1:
                            
                            if (userChoice == 1)
                            {
                                Console.WriteLine("Please select from the following options.");
                                Console.WriteLine("1. Feed all pets");
                                Console.WriteLine("2. Water all pets");
                                Console.WriteLine("3. Adopt a pet.");
                                Console.WriteLine("4. Pay Bills");
                                int userNum = int.Parse(Console.ReadLine());
                                
                                 switch (userNum)
                                 {
                                    case 1:
                                    Console.WriteLine("You have fed all pets.");
                                    break;

                                    case 2:
                                    Console.WriteLine("you have watered all pets.");
                                    break;

                                    case 3:
                                    //Console.WriteLine(Manager.Adopt(VPS);
                                    Console.WriteLine("Please select from the following options.");
                                    Console.WriteLine("1. Adopt Pete");
                                    Console.WriteLine("2. Adopt Bork");
                                    Console.WriteLine("3. Adopt Dan");
                                    Console.WriteLine("4. Adopt Bastet");
                                    int userPick = int.Parse(Console.ReadLine());
                                    if (userPick == 1)
                                    {
                                        Console.WriteLine("You have adopted Pete");
                                    }
                                    if (userPick == 2)
                                    {
                                        Console.WriteLine("You have adopted Bork");
                                    }
                                    if (userPick == 3)
                                    {
                                        Console.WriteLine("You have adopted Dan");
                                    }
                                    if (userPick == 4)
                                    {
                                        Console.WriteLine("You have adopted Bastet");
                                    }
                                    break;

                                    case 4:
                                    Console.WriteLine("You have paid all bills");
                                    break;

                                    default:
                                    break;
                                 }break;

                            }break;

                          case 2:
                        if (userChoice == 2)
                        {
                            Console.WriteLine("Name    Description  Hunger  Thirst  Boredom");
                            Console.WriteLine("{0}     {1}      {2}      {3}      {4}",VPSOne.Name,VPSOne.Description, VPSOne.Hunger,VPSOne.Thirst,VPSOne.Boredom);
                            Console.WriteLine("{0}     {1}         {2}      {3}      {4}", VPSTwo.Name, VPSTwo.Description, VPSTwo.Hunger, VPSTwo.Thirst, VPSTwo.Boredom);
                            Console.WriteLine("{0}      {1}        {2}      {3}      {4}", VPSThree.Name, VPSThree.Description, VPSThree.Hunger, VPSThree.Thirst, VPSThree.Boredom);
                            Console.WriteLine("{0}   {1}      {2}      {3}      {4}", VPSFour.Name, VPSFour.Description, VPSFour.Hunger, VPSFour.Thirst, VPSFour.Boredom);
                            Console.WriteLine("Please select from the following options.");
                            Console.WriteLine("1. Feed all pets");
                            Console.WriteLine("2. Water all pets");
                            Console.WriteLine("3. Play with a pet.");

                            int userNum = int.Parse(Console.ReadLine());

                            switch (userNum)
                            {
                                case 1:
                                    Console.WriteLine("You have fed all pets.");
                                    break;

                                case 2:
                                    Console.WriteLine("you have watered all pets.");
                                    break;

                                case 3:
                                    Console.WriteLine("Please choose a pet to play with.");
                                    Console.WriteLine("1. Pete");
                                    Console.WriteLine("2. Bork");
                                    Console.WriteLine("3. Dan");
                                    Console.WriteLine("4. Bastet");
                                    int petChoice = int.Parse(Console.ReadLine());
                                    switch (petChoice)
                                    {
                                        case 1:
                                            Console.WriteLine("You have played with Pete");
                                            break;
                                        case 2:
                                            Console.WriteLine("You have played with Bork");
                                            break;
                                        case 3:
                                            Console.WriteLine("You have played with Dan");
                                            break;
                                        case 4:
                                            Console.WriteLine("You have played with Bastet");
                                            break;
                                        default:
                                            break;
                                    }
                                    break;

                                default:
                                    break;


                            }
                            break;


                        }
                        break;
                    default:
                        break;



                        //Dragon.Tick();
                        //Console.WriteLine("Please type Yes to manage your {0}!", Dragon.Name);
                        //userResponse = Console.ReadLine().ToLower();
                }//switch1end
                }//while end

        }//main end
    }//class end
}//namespace end
