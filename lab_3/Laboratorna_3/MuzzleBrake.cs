using System;

namespace Laboratorna_3
{
    public class MuzzleBrake : IAttachment
    {
        public void ModifyBullet(Bullet bullet)
        {
            bullet.Damage += 6;
            Console.WriteLine("Muzzle Brake equipped: Recoil reduced.");
        }
    }
}
