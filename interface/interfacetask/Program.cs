namespace interfacetask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Word MyWord = new Word();
            MyWord.Write("salam");

            MyWord.Save();
            MyWord.SaveAndClose("ilqar");

        }
    }
}
