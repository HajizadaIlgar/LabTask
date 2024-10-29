namespace WeaponTask;

class Weapon
{
    public int BulletCapacity;         //gulle tutumu
    public int BulletNum;             //gulle sayi
    public int CompDistanceSecond;   //bosalma saniyesi
    public bool FireMode;           //atismodu (tekli ve ya oto)
    public bool Auto;
    public Weapon(int bulletcapacity, int bulletnum, int copmdistancesecond, bool firemode, bool auto)
    {
        BulletCapacity = bulletcapacity;
        BulletNum = bulletnum;
        CompDistanceSecond = copmdistancesecond;
        FireMode = firemode;
        Auto = false;
    }
    public void Shoot()
    {
        BulletNum--;
        Console.WriteLine("Bir gulle atti");
    }
    public void Fire()
    {
        if (BulletNum != 0)
        {
            int DaraginBosalmaSaniyesi;
            DaraginBosalmaSaniyesi = BulletNum / CompDistanceSecond;
            Console.WriteLine(DaraginBosalmaSaniyesi + " " + "Saniyeye Gulle bitmisdir");
        }
        else
        {
            Console.WriteLine("Darag bosdur");
        }
    }
    public int GetRemainBulletCount()
    {
        int NeedForMaxBullet = 0;
        if (BulletCapacity != BulletNum)
        {
            NeedForMaxBullet = BulletCapacity - BulletNum;
        }
        return NeedForMaxBullet;
    }
    public void Reload()
    {
        if (BulletCapacity > BulletNum)
        {
            BulletNum = BulletCapacity;
        }

    }
    public void ChangeFireMode(bool auto)
    {
        Auto = auto;
        if (Auto)
        {
            Auto = true;
            Console.WriteLine("Atis modu deyisdirildi:Auto ates");
        }
        else
        {
            Console.WriteLine("Atis modu deyisdirildi:Single ates");
        }
    }
}

