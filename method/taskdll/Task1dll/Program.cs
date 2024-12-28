using Model;
namespace Task1dll
{
    public class Program
    {
        static void Main()
        {
            Employee employee = new Employee("ilqar", false, 200);
            Assistant assistant = new Assistant();
            assistant.GetFeedBack(employee);

            Console.WriteLine($"{employee.Name},{employee.IsSuccesfull},{employee.Salary}");
        }
    }
}
