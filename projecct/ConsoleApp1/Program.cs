internal class Program
{
    static void Main(string[] args)
    {
        FileHelper nameManager = new FileHelper(@"C:\Users\Whosein\Desktop\hometask\hometask31124\names\names.json");
        nameManager.Add("Musa<3");
        nameManager.Add("Selcan");
        nameManager.Add("Seid");
        nameManager.Add("HITler");

        Console.WriteLine(nameManager.Exist("Seid"));

        nameManager.Update(2, "Aghaseph");
        nameManager.Delete(2);
    }
}


/*
 * List<string> yaradırsınız. Bunu names.json adlı jsona yazırsınız.
void Add(string name)
bool Exist(stiring name)
void Update(int index, string name)
void Delete(int index)
Metodlarını adlarına uyğun olaraq yazın
*/
