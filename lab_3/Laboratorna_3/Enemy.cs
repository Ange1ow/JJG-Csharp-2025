using Laboratorna_3;

public class Enemy : IDamageable
{
    private int health;
    private static Random random = new Random();
    private bool isSilentShot; 

    public Enemy(int health)
    {
        this.health = health;
    }

    public int Health => health;

    public void SetSilentShot(bool isSilent) 
    {
        isSilentShot = isSilent;
    }

    public void TakeDamage(int amount)
    {
        if (!isSilentShot && random.Next(100) < 70)
        {
            Console.WriteLine("Enemy dodged the attack!\n");
            return;
        }

        health -= amount;
        if (health < 0) health = 0;
        Console.WriteLine($"Enemy takes {amount} damage. Health left: {health}");

        Console.WriteLine(health <= 0 ? "Enemy is dead\n" : "Enemy is alive\n");
    }
}
