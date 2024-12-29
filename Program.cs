using Common;
using Enums;
namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exception Handling
            //DoSomeCode();

            //Exceptions
            // 1. System.Exception
            // 1.1 format exception
            // 1.2 index out of range exception
            // 1.3 null reference exception
            // 1.4 invalid operation exception
            // 1.5 Arithmetic exception
            // 1.5.1 divide by zero exception
            // 1.5.2 overflow exception
            // 2. Application exception
            //try
            //{
            //    DoSomeCodeProtictive();
            //    //throw new Exception();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    // Close - free - delete- deallocate unmanged resources
            //    //Open File
            //    //Open Connection Database
            //    Console.WriteLine("Finally"); //Exception or not will run
            //}
            //// DoSomeCodeProtictive();
            //// throw new Exception();
            //Console.WriteLine("After Try Catch");

            #endregion

            #region Access Modifier
            //TypeA typeA = new TypeA();
            //TypeB typeB = new TypeB(); 
            #endregion

            #region Enum
            #region EX01
            //string Day = "Hamo";
            //Days day = Days.Fri;
            //Grades grade = Grades.A;
            //switch (grade)
            //{
            //    case Grades.A:
            //        Console.WriteLine("Excellent");
            //        break;
            //    case Grades.B:
            //        Console.WriteLine("Very Good");
            //        break;
            //    case Grades.C:
            //        Console.WriteLine("Good");
            //        break;
            //    case Grades.D:
            //        Console.WriteLine("Pass");
            //        break;
            //    case Grades.F:
            //        Console.WriteLine("Fail");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Grade");
            //        break;
            //}
            #endregion

            #region EX02
            //Grades grades = (Grades)2;
            //Grades grades = (Grades)10;
            //Console.WriteLine(grades);
            #endregion

            #region Ex03
            //Grades grades = (Grades)Enum.Parse(typeof(Grades),Console.ReadLine());
            //Console.WriteLine(grades);
            //Enum.TryParse(typeof(Grades), Console.ReadLine(), out object result);
            //Grades grade = (Grades)result;
            //Console.WriteLine(result);
            #endregion

            #region EX04
            //string gender = "male";
            ////Enum.TryParse(typeof(Gender), gender, out object result);
            ////Console.WriteLine(result);

            //Enum.TryParse<Gender>(gender,true,out Gender result);
            //Console.WriteLine(result);

            //Gender gender = new Gender();
            //Console.WriteLine(gender);  //Male becuase default value = 0 and male = 0
            #endregion


            #endregion

            #region Permissions
            Employee employee = new Employee();
            employee.name = "Ali";
            employee.age = 20;
            employee.Permissions = (Permissions)3;

            Console.WriteLine(employee.Permissions); //Execute , Delete

            //XOR

            employee.Permissions = employee.Permissions ^ Permissions.read;

            Console.WriteLine(employee.Permissions); //delete ,execute ,read

            employee.Permissions = employee.Permissions ^ Permissions.read;

            Console.WriteLine(employee.Permissions); //delete , execute

            //&
            if ((employee.Permissions & Permissions.read) == Permissions.read)
            {
                Console.WriteLine("read is exist");
            }
            else
            {
                employee.Permissions = employee.Permissions ^ Permissions.read;
            }
            Console.WriteLine(employee.Permissions);

            //OR
            employee.Permissions = employee.Permissions | Permissions.write;
            Console.WriteLine(employee.Permissions);
            #endregion
        }
        public static void DoSomeCode()
        {
            try
            {
                int x, y, z;
                x = int.Parse(Console.ReadLine()); //FormatException
                y = int.Parse(Console.ReadLine());

                z = x / y; //DivideByZeroException

                int[] Numbers = { 1, 2, 3 };

                Numbers[100] = 77; //IndexOutOfRangeException

            }
            //ClR Create Object From EXception
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Log In File
                // Store in Database
            }
        }
        public static void DoSomeCodeProtictive()
        {
            int x, y, z;
            bool flag;
            do
            {
                Console.Write("Enter X : ");
                flag = int.TryParse(Console.ReadLine(), out x);

            }while (!flag);

            do
            {
                Console.Write("Enter Y : ");
                flag = int.TryParse(Console.ReadLine(), out y);

            } while (!flag | y == 0);

            z= x / y;

            int[] Numbers = { 1, 2, 3 };

            if(Numbers?.Length > 100)
            {
                Numbers[100] = 77;
            }

        }
    }
}
