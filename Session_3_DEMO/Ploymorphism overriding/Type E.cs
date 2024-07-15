using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_DEMO.Ploymorphism_overriding
{
    internal class Type_E : TypeD
    {
       

        public int E { get; set; }
        public Type_E(int a, int b, int c, int d , int e) : base(a, b, c, d)
        {
            E = e;
        }

        public override void MyFun02() /// NEW => END sequence //virtal => start new squence
        {
            Console.WriteLine($"TypeE : A = {A} , B = {B} , C = {C} , D = {D} , E = {E}" );
        }

    }
}
