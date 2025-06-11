namespace Laboratorna_3
{
    public abstract class Projectile
    {
        public int Damage { get; set; }

        public Projectile(int damage)
        {
            Damage = damage;
        }

        public abstract void HitTarget(IDamageable target);
    }
}
