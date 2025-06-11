using System;

namespace Laboratorna_3
{
    public class Suppressor : IAttachment
    {
        public void ModifyBullet(Bullet bullet)
        {
            bullet.IsSilent = true;
            Console.WriteLine("Suppressor equipped: Shot is silent.");
        }
    }
}
