using System;

namespace Laboratorna_3
{
    public class Bullet : Projectile
    {
        public bool IsSilent { get; set; }
        public int RecoilReduction { get; set; }
        private IAttachment currentAttachment; // Зберігає поточний обвіс

        public Bullet(int damage) : base(damage) { }

        public void Attach(IAttachment attachment)
        {
            if (currentAttachment != null)
            {
                Console.WriteLine($"Removed attachment: {currentAttachment.GetType().Name}");
            }

            currentAttachment = attachment;
            attachment.ModifyBullet(this);
            Console.WriteLine($"New attachment equipped: {attachment.GetType().Name}");
        }

        public override void HitTarget(IDamageable target)
        {
            Console.WriteLine(IsSilent ? "Silent shot fired!" : "Bullet fired!");

            if (target is Enemy enemy)
            {
                enemy.SetSilentShot(IsSilent); // Викликаємо метод, щоб оновити статус
            }

            target.TakeDamage(Damage);
        }

        public void ShowAttachmentStatus()
        {
            Console.WriteLine($"Current attachment: {(currentAttachment != null ? currentAttachment.GetType().Name : "None")}");
        }
    }
}
