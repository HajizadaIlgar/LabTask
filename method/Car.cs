namespace method
{
    public class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelCapacity;
        public int FuelForKm;
        public int CurrentFuel;
        public Car(string Brand, string Model, int FuelCapacity, int FuelForKm, int Year) : base(Year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.FuelCapacity = FuelCapacity;
            this.FuelForKm = FuelForKm;
            CurrentFuel = FuelCapacity;
        }
        public void ShowInfo()
        {
            Console.WriteLine(Year);
            Console.WriteLine(Color);
            Console.WriteLine(Brand);
            Console.WriteLine(Model);
            Console.WriteLine(FuelCapacity);
            Console.WriteLine(FuelForKm);
            Console.WriteLine(CurrentFuel);
        }
        public void Drive(int distance)
        {

            if (CurrentFuel > distance * FuelForKm)
            {
                Console.WriteLine(CurrentFuel);
            }
        }
    }
}
