using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter 
{
    class NewPets : VirtualPet
    {
        private string petType;
        private string petDiet;
      

        public string PetType { get; set; }
        public string PetDiet { get; set; }
        

        public NewPets()
        {
            //default
        }

        public NewPets(string name, string petType, string petDiet, int hunger, int thirst, int boredom)
        {
            this.PetType = petType;
            this.PetDiet = petDiet;
            this.Name = name;
            this.Hunger = hunger;
            this.Thirst = thirst;
            this.Boredom = boredom;
            
        }

    }
}
