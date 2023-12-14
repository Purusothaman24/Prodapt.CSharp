using Prodapt.StudentLibrary;
namespace Prodapt.StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s.StudentData(101,"Purusoth","Chennai",457));
        }
    }
}
