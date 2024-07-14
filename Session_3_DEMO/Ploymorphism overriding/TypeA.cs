using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_DEMO.Ploymorphism_overriding
{
    internal class TypeA
    {
        public int A { get; set; } // Automatic Property

        public TypeA(int a)
        {
            A = a;
        }

        // Object Member Functions [Non-Static Functions]
        public  void MyFun01()
        {
            Console.WriteLine("I am Base [Parent]");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }



    }
}
