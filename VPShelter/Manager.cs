using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager : Employee
    {
        private bool clockedIn;

        public bool ClockedIn { get; set; }

        public void Adopt(VitrualPetShelter test, NewPets name)
        {
            
           test.PetList.Remove(name);
        }

        public override void ActiveDuty()
        {
            throw new NotImplementedException();
        }

        public override void Age()
        {
            throw new NotImplementedException();
        }
    }
}
