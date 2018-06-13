using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPet
    {
         // fields
        private int hunger;
        private int thirst;
        private int boredom;
        private bool hungerAlert;
        private bool thirstAlert;
        private bool boredomAlert;
        private string name;
        private string description;
        

        // properties
        public string Description { get; set; }
      

        public bool HungerAlert
        {
            get { return this.hungerAlert; }
            set { this.hungerAlert = value; }
        }

        public bool ThirstAlert
        {
            get { return this.thirstAlert; }
            set { this.thirstAlert = value; }
        }

        public bool BoredomAlert
        {
            get { return this.boredomAlert; }
            set { this.boredomAlert = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public VirtualPet()
        {
            //default constructor
        }

        public VirtualPet(string name, string description, int hunger, int thirst, int boredom)
        {
            this.Name = name;
            this.Hunger = hunger;
            this.Thirst = thirst;
            this.Boredom = boredom;
            this.Description = description;
        }
       
        public VirtualPet(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        // Tick 
        public void Tick()
        {
            Hunger++;
            if (Hunger > 35)
            {
                StarveAlert(true);
            }
            else
            {
                StarveAlert(false);
            }

            Thirst++;
            if (Thirst > 35)
            {
                DehydrationAlert(true);
            }
            else
            {
                DehydrationAlert(false);
            }

            Boredom++;
            if (Boredom > 35)
            {
                BoredAlert(true);
            }
            else
            {
                BoredAlert(false);
            }
        }//tick end
     
       
        public bool StarveAlert(bool status)
        {
            HungerAlert = status;
            return HungerAlert;
        }

        public bool DehydrationAlert(bool status)
        {
            ThirstAlert = status;
            return ThirstAlert;
        }

        public bool BoredAlert(bool status)
        {
            BoredomAlert = status;
            return BoredomAlert;
        }

        public int SetHunger(int num)
        {
            this.Hunger = num;
            return Hunger;
        }
        public int SetThirst(int num)
        {
            this.Thirst = num;
            return Thirst;
        }

        public int SetBoredom(int num)
        {
            this.Boredom = num;
            return Boredom;
        }

        public string SetName(string name)
        {
            this.Name = name;
            return Name;
        }

        public string SetDescription(string description)
        {
            this.Description = description;
            return Description;
        }

        //public void Status();


        public void DragonPic()
        {

            Console.WriteLine(@"//                     ___====-_  _-====___                        //");
            Console.WriteLine(@"//              __--^^^      //     \\     ^^^--_                  //");
            Console.WriteLine(@"//             _-^         // (    ) \\         ^-_                //");
            Console.WriteLine(@"//            -           //  |\^^/|  \\           -               //");
            Console.WriteLine(@"//          _/           //   (0::0)   \\            \_            //");
            Console.WriteLine(@"//         /            ((     \\//     ))             \           //");
            Console.WriteLine(@"//       -               \\    (oo)    //               -          //");
            Console.WriteLine(@"//      -                 \\  / \/ \  //                 -         //");
            Console.WriteLine(@"//     -                   \\/      \//                   -        //");
            Console.WriteLine(@"//   / /|           /\      (        )      /\           |\ \      //");
            Console.WriteLine(@"//   |/ | /\_/\_/\_/  \_/\  (   /\   )  /\_/  \_/\_/\_/\ | \|      //");
            Console.WriteLine(@"//   `  |/  V  V  `    V  \_(| |  | |)_/  V    '  V  V  \|  '      //");
            Console.WriteLine(@"//      `   `  `       `   / | |  | | \   '       '  '   '         //");
            Console.WriteLine(@"//                       <(  | |  | |  )>                          //");
            Console.WriteLine(@"//                      <__\_| |  | |_\__>                         //");
            Console.WriteLine(@"//                      ^^^^ ^^^  ^^^ ^^^^^                        //");

        }

    }//class end
}//namespace end
   
