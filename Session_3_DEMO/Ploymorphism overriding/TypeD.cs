using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_DEMO.Ploymorphism_overriding
{
    internal class TypeD : TypeC
    {

        //Type D ===> Direct Parent "TypeC"
        //Type D ===> InDirect Parent "TypeB"
        //Type D ===> InDirect Parent "TypeA"


        public int D { get; set; }
        public TypeD(int a, int b, int c, int d) : base(a, b, c)
        {
            D = d;

        }
        public new void MyFun01() // NEW => NEW  VERSION FROM MyFun01
        {
            Console.WriteLine("I am Dervied  [CHILD Grand Child]");
        }

        public  new virtual void MyFun02() /// NEW => END sequence //virtal => start new squence
        {
            Console.WriteLine($"TypeD : A = {A} , B = {B} , C = {C} , D = {D}");
        }

    }
}
