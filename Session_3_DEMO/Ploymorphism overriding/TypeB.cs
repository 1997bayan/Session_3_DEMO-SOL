using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_DEMO.Ploymorphism_overriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int a ,int b) : base (a)
        {
            B = b;
        }

        // Overriding 
        // 1.Using new KeyWord 
        // 2.Using overriding keyword


        //1-Overriding functions Using new KeyWord 
        public new void MyFun01() // NEW => NEW  VERSION FROM MyFun01
        {
            Console.WriteLine("I am Dervied  [Child]");
        }

        //1-Overriding functions Using new overriding 
        public override void MyFun02()
        {
            Console.WriteLine($"TypeB : A = {A} , B = {B}" );
        }
       


    }
}
