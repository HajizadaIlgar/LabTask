using LibraryTask;
using System.Text;

namespace LibraryManagementTask;

public class Librarian : Person
{

    public DateTime HireDate { get; set; }
    public Librarian(string name) : base(name) { }
}
sealed class LibraryMember : Person
{
    public DateTime MembershipDate { get; set; }
    public LibraryMember(string name) : base(name) { }
}
abstract class LibraryItem
{
    public Librarian Librarian { get; set; }
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    public abstract void DisplayInfo();

}
public struct LibraryLocation
{
    public int Aisle;
    public int Self;
    public LibraryLocation(int aisle, int self)
    {
        Aisle = aisle;
        Self = self;
    }
}
enum BookGenre
{
    Fiction,
    NonFiction,
    Science,
    Art
}

class Book : LibraryItem
{
    public BookGenre Genre { get; set; }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Kitabimiz {Genre} Janrinda yazilmisdir.");
        Console.WriteLine($"Kitabin Adi :{Title}");
        Console.WriteLine($"Nesr olundugu il: {PublicationYear}");
    }
}
class Magazine : LibraryItem
{
    public override void DisplayInfo()
    {
        bool IsStatus = true;
        Console.WriteLine($"Title:{Title}");
        switch (IsStatus)
        {
            case true:
                Console.WriteLine("Magazinler yenidir");
                break;
            default:
                Console.WriteLine("Magazinler kohnedir");
                break;
        }
    }
}
class DVD : LibraryItem
{
    bool IsStatus = true;
    public override void DisplayInfo()
    {
        Console.WriteLine($"Title:{Title}");
        if (IsStatus) Console.WriteLine("Disk islek veziyyetdedi");
        else Console.WriteLine("Disk Ciziglidi");
    }
}
static class LibraryHelper
{
    public static int CalculateAge(this LibraryItem item)
    {
        DateTime today = DateTime.Today;
        return today.Year - item.PublicationYear;
    }
    public static string ToTitleCase(this LibraryItem item)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(item.Title);
        if (sb[0] > 96 || sb[0] < 123) sb[0] = (char)(sb[0] - 32);
        for (int i = 1; i < sb.Length; i++)
        {
            if (sb[0] > 64 || sb[0] < 91) sb[0] = (char)(sb[0] + 32);
        }
        return sb.ToString();
    }
}
class LibraryCatalog
{
    public int Aisle { get; set; }
    public int Shelf { get; set; }
    public int this[int index]
    {
        get { return index; }

        set { index = value; }
    }
}

