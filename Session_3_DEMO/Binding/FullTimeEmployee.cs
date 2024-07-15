using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_DEMO.Binding
{
    internal class FullTimeEmployee : Employee
    {
       

        public decimal Salary { get; set; }

        public FullTimeEmployee(int id, string name, int age , decimal _salary) : base(id, name, age)
        {
            Salary = _salary;
        }

        public new void GetEmployeeType()
        {
            Console.WriteLine("I am full time Employee");

        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"Full time Employee : Id = {Id} , Name = {Name} , Age = {Age} ,Salart = {Salary}");
        }

    }
}
