namespace practiceternary;

public class Program
{
    static void Main(string[] args)
    {
        int? num = null;
        //if (num is not null)
        //{
        //    throw new Exception("num is not null");
        //}
        //else
        //{
        //    num = 10;
        //    Console.WriteLine(num);
        //}

        //object a = (null == num) ? 22 / 2 : 23;
        //Console.WriteLine(a);

        string name = null;
        string defaultName = "Revan";
        //if (name == defaultName)
        //{
        //    Console.WriteLine("True");
        //}
        //else
        //{
        //    Console.WriteLine("False");
        //}

        name ??= defaultName
    }
}