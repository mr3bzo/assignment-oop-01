using System.Drawing;

namespace assignment_01 {
    class program
    {
        static void mian(string[]args) {


            #region 01

            //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //  enum WeekDays
            //{
            //    Monday,
            //    Tuesday,
            //    Wednesday,
            //    Thursday,
            //    Friday,
            //    Saturday,
            //    Sunday
            //}

            //static void Main()
            //{
            //    Console.WriteLine("Days of the week:");

            //    Array days = Enum.GetValues(typeof(WeekDays));
            //    for (int i = 0; i < days.Length; i++)
            //    {
            //        Console.WriteLine(days.GetValue(i));   

            #endregion

            #region 02

            //Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //enum Season
            //{
            //    Spring,
            //    Summer,
            //    Autumn,
            //    Winter
            //}

            //static void Main()
            //{
            //    Console.Write("Enter a season: ");
            //    string userInput = Console.ReadLine();

            //    if (Enum.TryParse(userInput, true, out Season season))
            //    {
            //        if (season == Season.Spring)
            //        {
            //            Console.WriteLine(" March to May");
            //        }
            //        else if (season == Season.Summer)
            //        {
            //            Console.WriteLine(" June to August");
            //        }
            //        else if (season == Season.Autumn)
            //        {
            //            Console.WriteLine("September to November");
            //        }
            //        else if (season == Season.Winter)
            //        {
            //            Console.WriteLine(" December to February");
            //        }
            //    }
            //
            #endregion


            #region 03

            //Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            //        [Flags]
            //enum Permissions
            //    {
            //        Read = 1,
            //        Write = 2,
            //        Delete = 4,
            //        Execute = 8
            //    }

            //    static void Main()
            //    {
            //        Permissions userPerms = Permissions.Read | Permissions.Write | Permissions.Execute;

            //        if ((userPerms & Permissions.Write) == Permissions.Write)
            //        {
            //            Console.WriteLine("Write permission exists");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Write permission does not exist");
            //        }

            //        userPerms = userPerms ^ Permissions.Write;
            //        Console.WriteLine(userPerms);

            //        userPerms = userPerms | Permissions.Execute;
            //        Console.WriteLine(userPerms);
            //    }





            #endregion


            #region 04
            //Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.


            // enum Colors
            //{
            //    Red,
            //    Green,
            //    Blue
            //}

            //static void Main()
            //{
            //    Console.Write("Enter a color (Red/Green/Blue): ");
            //    string userInput = Console.ReadLine();

            //    if (Enum.TryParse(userInput, true, out Colors color))
            //    {
            //        // All colors in this enum are primary colors
            //        Console.WriteLine($"{color} is a primary color!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("That's not a valid color in our list!");
            //    }
            //} 

            #endregion

            #region 05
            // Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.


            // Point point01;
            //Console.WriteLine("Enter the coordinates for the first point : ");
            //Console.Write($"Enter X : ");
            //point01.X = int.Parse(Console.ReadLine());
            //Console.Write($"Enter Y : ");
            //point01.Y = int.Parse(Console.ReadLine());

            //Point point02;
            //Console.WriteLine("Enter the coordinates for the Second point : ");
            //Console.Write($"Enter X : ");
            //point02.X = int.Parse(Console.ReadLine());
            //Console.Write($"Enter Y : ");
            //point02.Y = int.Parse(Console.ReadLine());

            //double Distance = Math.Sqrt(Math.Pow((point02.X - point01.X), 2) + Math.Pow((point02.Y - point01.Y), 2));
            //Console.WriteLine($"The distance between the two points is : {Distance}");

            #endregion







        }
    }
}