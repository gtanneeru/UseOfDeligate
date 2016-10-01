using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfDeligate
{
   delegate bool isPromoted(Employee empl);
    class Employee
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int experience { get; set; }
        public int salary { get; set; }

       

        public void getPromoted(List<Employee> employeeList, isPromoted whenEligible)
        {
            foreach(Employee emp in employeeList)
            {
                if(whenEligible(emp))
                {
                    Console.WriteLine(emp.name + " is promoted");
                }
            }
        }
    }
}
