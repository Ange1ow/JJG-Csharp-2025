using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorna_3;

namespace Lab_3
{
    internal class Compensator : IAttachment
    {
        public void ModifyBullet(Bullet bullet)
        {
            bullet.Damage += 2;
            Console.WriteLine("Compensator equipped: Damage increased.");
        }
    }
}
