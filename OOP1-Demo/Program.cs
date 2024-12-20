using common;
namespace OOP1_Demo
{

    enum Grades
    {
        // Labels
        A, B, C, D, E, F
    }
    enum Gender
    {
        Male=1, Female=2, M=1, F=2
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What is Access Modifiers
            //TypeA obj = new TypeA();
            //obj.x = 10; //Invalid
            //obj.y = 20; //Invalid
            //obj.z = 30; //Valid
            #endregion
            #region Enum
            //Grades grade = Grades.A;
            //if (grade == Grades.A)
            //{
            //    Console.WriteLine("Congratulations A+");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry :( ");
            //}
            #endregion
            #region Struct
            //Point P1 = new Point(4,2);
            //"new" is juct for constructor selection
            //Declare for object from type "Point"
            // CLR will allocate 8 bytes uninitialized at stack
            //Console.WriteLine(P1);
            #endregion
            #region What Is OOP

            #endregion
            #region Encapsulation

            //Employee emp = new Employee(10,"Abdelrahman",20000);
            //emp.Salary = 30000; //Set
            //Console.WriteLine(emp.Salary); //Get


            //emp.SetName("Omar");
            //Console.WriteLine(emp.GetName());


            //emp.id = 20;
            //Console.WriteLine(emp);
            #endregion
        }
    }
}
