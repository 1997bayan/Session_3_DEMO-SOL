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

            #region Binding
            //Ref from parent => point on => Object from child
            TypeA refBase;
            //Declare for ref from Type "TypeA"
            //refBase Refer to am object from Type "TypeA"
            // Or refer to an object from any class [inherit from TypeA]

            refBase = new TypeB(1, 3); // ==> this is binding
            refBase.A = 120;
            //refBase.B = 1233;// Invalid: B is not accessible from TypeA reference

            refBase.MyFun01 ();// I am Base [Parent] // The hidden method MyFun01 is called from the TypeA implementation when accessed through a TypeA reference.
            refBase.MyFun02();// TypeB : A = 120 , B = 3 //The overridden method MyFun02 is called from the TypeB implementation.



            #endregion

        }
    }
}
