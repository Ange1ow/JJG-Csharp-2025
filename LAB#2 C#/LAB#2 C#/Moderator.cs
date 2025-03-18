﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_C_
{
    internal class Moderator : User
    {

        public Moderator(string userName, string email, string password) : base(userName, email, password) 
        {
        
        }

        public void ModerateContent()
        {
            Console.WriteLine("Content updated");
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Role: Moderator");
        }
    }
}
