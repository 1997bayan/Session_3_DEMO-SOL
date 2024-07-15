using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_DEMO.Ploymorphism_overriding
{
    internal class TypeC : TypeB
    {
        //Type C ===> Direct Parent "TypeB"
        //Type c ===> InDirect Parent "TypeA"
        public int C { get; set; }
        public TypeC(int a, int b, int c) : base(a, b)
        {
            C = c;
        }

        public new void MyFun01() // NEW => NEW  VERSION FROM MyFun01
        {
            Console.WriteLine("I am Dervied  [Grand Child]");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"TypeC : A = {A} , B = {B} , C = {C}" );
        }
    }
   
}
