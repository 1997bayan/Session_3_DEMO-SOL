using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_3_DEMO.Binding
{
    internal class PartTimeEmployee :Employee
    {
        public int CountOfHours { get; set; }
        public decimal HourRate { get; set; }


        public new void GetEmployeeType()
        {
            Console.WriteLine("I am part time Employee");

        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"Full time Employee : Id = {Id} , Name = {Name} , Age = {Age} ,Count Of Hours = {CountOfHours} , Hour Rate = {HourRate}  ");
        }


    }
}
