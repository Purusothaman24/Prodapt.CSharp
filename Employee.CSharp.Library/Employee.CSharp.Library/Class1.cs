using System.Data;

namespace Employee.CSharp.Library
{
    public class Employee1
    {
        int EmployeeId;
        string name, mobileNo;
        double salary;
        public string Accept(int EmpId, string name, string mobileNo, double salary)
        {
            EmployeeId = EmpId;
            this.name=name;
            this.mobileNo = mobileNo;
            this.salary = salary;
            return $"Id={EmployeeId},Name={name},MobileNo={mobileNo},Salary={salary}";
        }
     
    }
}
