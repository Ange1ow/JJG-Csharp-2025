using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_C_
{
    internal class RegularUser : User
    {
        public RegularUser(string userName, string email, string password) : base(userName, email, password) {
        
        }

        public void PostComment()
        {
            Console.WriteLine("Comment uploaded");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Role: RegularUser");
        }
    }
}
