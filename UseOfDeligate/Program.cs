using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfDeligate
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee() { ID = 101, name = "Mary", experience = 5, salary = 5000 });
            employee.Add(new Employee() { ID = 102, name = "John", experience = 2, salary = 4000 });
            employee.Add(new Employee() { ID = 103, name = "Philips", experience = 6, salary = 6000 });
            employee.Add(new Employee() { ID = 104, name = "Mark", experience = 4, salary = 5000 });


           // isPromoted isPromotable = new isPromoted(promote);
           // emp.getPromoted(employee,isPromotable);
            // Instead of creating a bool function and an instance, we can use lambda expression, mainly used for deligates and linq coding.

            emp.getPromoted(employee, empl => empl.experience >= 5);

            Console.ReadKey();
        }

       
         public static bool promote(Employee empl)
         {
            return (empl.experience >= 5) ? true : false;
        }
    }
}
