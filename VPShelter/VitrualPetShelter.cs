using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VitrualPetShelter: VirtualPet
    {
        //private string manager;
        //private string volunteer;
        public void VirtualPetShelter()
        {
            //default
        }
        
        private List<NewPets> petList = new List<NewPets>() {new NewPets("Pete","Dragon", "Carnivore", 5, 5, 5),
            new NewPets("Bork", "Dog", "Omnivore", 5, 5, 5),
            new NewPets("Dan","Goat", "Omnivore", 5, 5, 5),
            new NewPets("bastet","Cat", "Carnivore", 5, 5, 5),
            

        };
        
        List<Employee> workerList = new List<Employee>(){new Manager(),
            new Volunteer()
        };
        
        internal List<NewPets> PetList { get => petList; set => petList = value; }
    }//class end
}//namespace end

