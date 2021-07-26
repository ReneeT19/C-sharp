using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ModifyEntityDemo
    {
        static void Main()
        {
            using (EMPCOGNIXIAEntities dbcontext = new EMPCOGNIXIAEntities())
            {
                var emp = dbcontext.EmpProfiles.Where(x => x.EmpCode == 101).FirstOrDefault();
                if (emp != null)
                {
                    emp.EmpName = "Adam";
                    emp.DateOfBirth = new DateTime(1980, 01, 01);
                    dbcontext.SaveChanges();
                    Console.WriteLine("Employee information is updated");
                }
            }
            Console.ReadLine();
        }
    }
}
