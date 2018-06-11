using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
      public abstract class Employee
      {
        private double employeeNum;
       
        

        public double EmployeeNum { get; set; }
        
        

        public Employee()
        {
            //default
        }

        public Employee(double employeeNum)
        {
            this.EmployeeNum = employeeNum;
            
        }

       
        public void Boredom(VitrualPetShelter name)
        {
            foreach (var item in name.PetList)
            {
                item.Boredom = 0;
            }
        }



        public abstract void ActiveDuty();

        public abstract void Age();

      }
}
