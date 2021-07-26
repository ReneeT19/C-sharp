using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoWithConsole
{
    class DeleteEntityDemo
    {
        static void Main()
        {
            EMPCOGNIXIAEntities dbcontext = new EMPCOGNIXIAEntities();
            var emp = dbcontext.EmpProfiles.Where(x => x.EmpCode == 110).FirstOrDefault();
            if (emp != null)
            {
                dbcontext.EmpProfiles.Remove(emp);
                dbcontext.SaveChanges();
                Console.WriteLine("Employee is deleted");
            }
            else
            {
                Console.WriteLine("Employee does not exist");
            }
            Console.ReadLine();
        }
    }
}
