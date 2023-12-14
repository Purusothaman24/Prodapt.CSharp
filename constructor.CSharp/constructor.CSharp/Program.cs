namespace constructor.CSharp1
{
    public class Emp
    {
        int empId;
        string empName;
        string city;

        public Emp()
        {
            empId =1001;
            empName = "Sowmya";
            city = "Chennai";
        }
        public Emp(int empId, string empName)
        {
            this.empId = empId;
            this.empName = empName;
        }
        static void Main(string[] args)
        {
            Emp emp = new Emp(101, "kavin");
            Console.WriteLine($"Id={emp.empId},Name={emp.empName},City ={emp.city}");
        }
    }
}
