using Session_3_DEMO.Ploymorphism_overriding;

namespace Session_3_DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Polymorphism [Overriding]
            TypeA typeA = new TypeA(3);

            typeA.A = 10;
            typeA.MyFun01();  //I am Base[Parent]
            typeA.MyFun02(); // TypeA : A = 10 

            Console.WriteLine("------------------------------");

            TypeB typeB = new TypeB  (1, 3);
            typeB.A = 11;
            typeB.B = 12;
            typeB.MyFun01();
            typeB.MyFun02();




            #endregion

        }
    }
}
