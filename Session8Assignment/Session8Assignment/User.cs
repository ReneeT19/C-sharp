using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8Assignment
{
    class User
    {
        private long Id { get; set; }
        private string Name  { get; set; }
        private string EmailId { get; set; }
        private string DateOfBirth { get; set; }


        public User()
        {
            Console.WriteLine("This is the default constructor of Forum");
        }

        public User(long id, string name, string emailId, string dateOfBirth)
        {
            this.Id = id;
            this.Name = name;
            this.EmailId = emailId;
            this.DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nEmailId: {EmailId}\nDateOfBirth: {DateOfBirth}\n";
        }

    }
}
