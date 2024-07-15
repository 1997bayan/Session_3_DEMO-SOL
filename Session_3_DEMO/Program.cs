using Session_3_DEMO.Binding;
using Session_3_DEMO.Ploymorphism_overriding;

namespace Session_3_DEMO
{
    internal class Program
    {
        static void EmployeeProcess(Employee employee)
        {

            //Employee employee can refernce to :
            // 1- object Employee
            // 2- OBJECT CLASS inherit from Employee [FullTimeEmployee - PartTimeEmployee]

            if (employee is not null)
            {
                employee.GetEmployeeType();
                employee.GetEmployeeData();
            }
        }
        static void Main(string[] args)
        {
            #region Polymorphism [Overriding]
            //TypeA typeA = new TypeA(3);

            //typeA.A = 10;
            //typeA.MyFun01();  //I am Base[Parent]
            //typeA.MyFun02(); // TypeA : A = 10 

            //Console.WriteLine("------------------------------");

            //TypeB typeB = new TypeB  (1, 3);
            //typeB.A = 11;
            //typeB.B = 12;
            //typeB.MyFun01();
            //typeB.MyFun02();

            #endregion

            #region Binding
            //Ref from parent => point on => Object from child
            // TypeA refBase;
            //Declare for ref from Type "TypeA"
            //refBase Refer to am object from Type "TypeA"
            // Or refer to an object from any class [inherit from TypeA]

            // refBase = new TypeB(1, 3); // ==> this is binding
            // refBase.A = 120;
            //refBase.B = 1233;// Invalid: B is not accessible from TypeA reference

            //refBase.MyFun01 ();// I am Base [Parent] // The hidden method MyFun01 is called from the TypeA implementation when accessed through a TypeA reference.
            // refBase.MyFun02();// TypeB : A = 120 , B = 3 //The overridden method MyFun02 is called from the TypeB implementation.

            #endregion

            #region Not Binding
            //Ref from child => Point to =>Object from parent
            //TypeB ChildRef = (TypeB)new TypeA(3); //This is not binding this is explicit casting
            //Unsafe casting

            // TypeA typeAa = new TypeA  (3);
            // TypeB typeBb = (TypeB)typeAa; //explicit casting // (TypeB) casting operator this is a function

            // Console.WriteLine(typeBb.A ); ///
            // Console.WriteLine(typeBb.B);  /// ==> invalid

            //TypeA typeAa = new TypeB(10,299);
            //TypeB typeBb = (TypeB) typeAa;
            // Console.WriteLine(typeBb.A ); ///valid 
            // Console.WriteLine(typeBb.B); 


            #endregion

            #region Binding EX01

            FullTimeEmployee FullEmp = new FullTimeEmployee(10 ,"Bayan" , 26,7000);
            EmployeeProcess(FullEmp);

            PartTimeEmployee partTimeEmp = new PartTimeEmployee()
            {
                Id = 1,
                Name = "Mohsen",
                Age = 40,
                HourRate = 10,
                CountOfHours = 10,
            };

            EmployeeProcess(partTimeEmp);


            // partTimeEmp.Id = 2;

            #endregion
            #region Binding EX02

            //Biinding: ref parent = object from Grand Child
            //TypeA typeA = new TypeC(1,2,3);

            //typeA.A = 12; // valid beacuse the ref typeA point on typeA only 
            ////typeA.B = 11; // invalid beacuse ref typeA dont point on B beacuse it dont exist in typeA
            ////typeA.C =123l; // invalid beacuse ref typeA dont point on C beacuse it dont exist in typeA

            //typeA.MyFun01(); //new => static binding => refernce

            //typeA.MyFun02();//overrid => dynamic binding => object

            TypeA typeA;
            TypeB typeB;
            TypeC typeC;

            typeA = new Type_E(1,2,3,4,5);        //INDIRECT PARENT 
            typeB = new Type_E(1, 2, 3, 4, 5);   //INDIRECT PARENT 
            typeC = new Type_E(1, 2, 3, 4, 5);  //INDIRECT PARENT 

            typeA.MyFun02(); // override go to the last override
            typeB.MyFun02(); // override go to the last override
            typeC.MyFun02();// override go to the last override

            TypeD typeD = new Type_E(2,23,4,5,6);
            typeD.MyFun02();











            #endregion

        }
    }
}
