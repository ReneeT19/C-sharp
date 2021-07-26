using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoWithConsole
{
    class QueryingEntityDemo
    {
        static void Main()
        {
            using (EMPCOGNIXIAEntities dbcontext =new EMPCOGNIXIAEntities())
            {
                // var emp = dbcontext.EmpProfiles.Find(101);
                //var emp = dbcontext.EmpProfiles.Where(x=>x.EmpName=="Adam").FirstOrDefault();
                // Console.WriteLine($"Code={emp.EmpCode} Name={emp.EmpName} Date of Birth={emp.DateOfBirth.ToString("dd-MMM-yyyy")}");

                var emplist = dbcontext.EmpProfiles.ToList();
                foreach(var emp in emplist)
                {
                    Console.WriteLine($"Code={emp.EmpCode} Name={emp.EmpName} Date of Birth={emp.DateOfBirth.ToString("dd-MMM-yyyy")}");
                }
            }
            Console.ReadLine();
        }
    }
}
