using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7Assignment
{
    struct Students
    {
        //fields
        int RollNo;
        string Name;
        string Gender;
        int MobileNo;

        //constructor
        public Students (int RollNo,string Name,string Gender,int MobileNo)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.Gender = Gender;
            this.MobileNo = MobileNo;
        }

        //display function
        public string Print()
        {
            return $"The student's RollNo is {RollNo}, Name is {Name}, Gender is {Gender}, and MobileNo is {MobileNo}";
        }

    }
}
