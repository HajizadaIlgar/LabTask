namespace tskclass1
{
    internal class Program
    {
        static void Main()
        {
            Grade[] mygrades = {new Grade(35,"math",7), new Grade(67, "physicfv", 17) , new Grade(54, "dfsdfsfd", 87) };
            Student ilqar = new Student("ilqar","ajgkljga",mygrades);
            ilqar.GetAvgrageGrate();
           }

    }
}
