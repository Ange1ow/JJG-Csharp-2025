using Lab_3;

namespace Laboratorna_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bullet bullet = new Bullet(10);
            Enemy enemy = new Enemy(5);
            BreakableWall wall = new BreakableWall(15);

            List<IAttachment> attachments = new List<IAttachment>();

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Fire into the enemy");
                Console.WriteLine("2. Fire into the wall");
                Console.WriteLine("3. Attach compensator");
                Console.WriteLine("4. Attach suppressor");
                Console.WriteLine("5. Attach muzzle brake");
                Console.WriteLine("6. Check bullet status");
                Console.WriteLine("7. Exit");
                Console.Write("Виберіть опцію: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        bullet.HitTarget(enemy);
                        break;
                    case "2":
                        bullet.HitTarget(wall);
                        break;
                    case "3":
                        var compensator = new Compensator();
                        bullet.Attach(compensator);
                        attachments.Add(compensator);
                        break;
                    case "4":
                        var suppressor = new Suppressor();
                        bullet.Attach(suppressor);
                        attachments.Add(suppressor);
                        break;
                    case "5":
                        var muzzleBrake = new MuzzleBrake();
                        bullet.Attach(muzzleBrake);
                        attachments.Add(muzzleBrake);
                        break;
                    case "6":
                        Console.WriteLine("\nBullet status:");
                        Console.WriteLine($"Damage: {bullet.Damage}");
                        Console.WriteLine($"Silent: {(bullet.IsSilent ? "Yes" : "No")}");
                        Console.WriteLine($"Recoil Reduction: {bullet.RecoilReduction}");
                        Console.WriteLine($"Attachments: {(attachments.Count > 0 ? string.Join(", ", attachments.Select(a => a.GetType().Name)) : "None")}");
                        break;
                    case "7":
                        isRunning = false;
                        Console.WriteLine("Вихід з програми...");
                        break;
                    default:
                        Console.WriteLine("Некоректний вибір! Спробуйте ще раз.");
                        break;
                }
            }
        }
    }
}
