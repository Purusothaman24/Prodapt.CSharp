using System;
using Prodapt.CSharp.Library;

namespace Prodapt.CSharp.Day4
{
    internal class Example
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello");
            Login obj = new Login();
            var result = obj.validation("admn", "admin@123");
            Console.WriteLine(result ?"Valid User":"invalid User");
        }
    }
}
