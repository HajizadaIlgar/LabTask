namespace WeaponTask;

class Program
{
    static void Main()
    {
        PrintInfo();
        Weapon MyGun = new Weapon(65, 24, 30, true, false);
        bool isContinue = true;
        while (isContinue)
        {
            int info = int.Parse(Console.ReadLine());
            switch (info)
            {
                case 1:
                    MyGun.Shoot();
                    break;
                case 2:
                    MyGun.Fire();
                    break;
                case 3:
                    Console.WriteLine(MyGun.GetRemainBulletCount());
                    break;
                case 4:
                    MyGun.Reload();
                    break;
                case 5:
                    MyGun.ChangeFireMode(Convert.ToBoolean(Console.ReadLine()));
                    break;
                case 6:
                    isContinue = false;
                    break;
                default:
                    Console.WriteLine("Zehmet olmasa deyeri duzgun daxil edin");
                    PrintInfo();
                    break;
            }
        }
    }
    static void PrintInfo()
    {
        Console.WriteLine("""
                    1 - Shoot metodu üçün
                    2 - Fire metodu üçün
                    3 - GetRemainBulletCount metodu üçün
                    4 - Reload metodu üçün
                    5 - ChangeFireMode metodu üçün
                    6 - Proqramdan dayandırmaq üçün
                    
                    """);
    }

}

