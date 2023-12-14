
using System.Security.Cryptography.X509Certificates;
using System;
using Employee.CSharp.Library;

namespace Employee.CSharp.Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee1 e =new Employee1();
            Console.WriteLine(e.Accept(201, "Purusothaman", "9940225651", 30000));
        }
    }
}
