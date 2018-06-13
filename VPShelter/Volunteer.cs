using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer : Employee
    {
        private string treat;

        public string Treat { get; set; }

        public void Water(VitrualPetShelter name)
        {
            foreach (var item in name.PetList)
            {
                item.Thirst = 0;
            }
        }
        public void Hunger(VitrualPetShelter name)
        {
            foreach (var item in name.PetList)
            {
                item.Hunger = 0;
            }
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
