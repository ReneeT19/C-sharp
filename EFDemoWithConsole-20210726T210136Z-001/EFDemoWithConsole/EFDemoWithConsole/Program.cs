using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoWithConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            EMPCOGNIXIAEntities dbcontext = new EMPCOGNIXIAEntities();
            //Add record into DeptInfo
            int code =Convert.ToInt32( Console.ReadLine());
            string name = Console.ReadLine();
            DeptInfo dept = new DeptInfo {DepCode=code,DeptName=name };
            dbcontext.DeptInfoes.Add(dept);
            dbcontext.SaveChanges();
            Console.WriteLine("Department is Added");

            //Add record into EmpProfile
            EmpProfile emp = new EmpProfile {EmpCode=101,DeptCode=4,EmpName="smith",DateOfBirth=new DateTime(1982,10,02) };
            dbcontext.EmpProfiles.Add(emp);
            dbcontext.SaveChanges();
            Console.WriteLine("Ëmployee addedd successfully");
            

            Console.ReadLine();
        }
    }
}
