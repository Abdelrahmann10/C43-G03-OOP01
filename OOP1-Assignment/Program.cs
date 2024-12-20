using System.Security.Cryptography.X509Certificates;

namespace Assignment_5
{
    internal class Program
    {
        #region WeekDays
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        #endregion
        #region Person

        public struct Person
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
        #endregion
        #region Season
        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }


        #endregion
        #region Permission
        // Ask Eng"Radwa
        #endregion
        #region Colors
        public enum Colors
        {
            Red, Green, Blue
        }
        #endregion
        #region Point
        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

        }
        static double CalDistance(Point p1, Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            double Result = Math.Sqrt(dx * dx + dy * dy);
            return Result;
        }
        #endregion
        #region OldPerson
        // The struct Person is already defiend in Q2
        static Person FindOldest(Person[] People)
        {

            Person oldperson = People[0];

            for (int i = 0; i < People.Length; i++)
            {
                if (People[i].Age > oldperson.Age)
                    oldperson = People[i];
            }
            return oldperson;
        }
        #endregion
        static void Main(string[] args)
        {
            #region 1) WeekDays
            //foreach (WeekDays days in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(days);
            //}
            #endregion
            #region 2) Person
            //Person[] P = new Person[3];
            //P[0] = new Person { Age = 22, Name = "Abdelrahman"};
            //P[1] = new Person { Age = 40, Name = "Sherif" };
            //P[2] = new Person { Age = 34, Name = "Said" };
            //foreach (Person person in P)
            //{
            //    Console.WriteLine($"Name : {person.Name} , Age : {person.Age}");
            //}
            #endregion
            #region 3) Season
            //Console.WriteLine("Enetr a Season");
            //string SeasonMonth = Console.ReadLine();
            //if (Enum.TryParse<Season>(SeasonMonth, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring -> March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer -> June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn -> September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter -> December to February");
            //            break;
            //        // didn't write a default because i add "else" as a condition if there is an error
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid :(");
            //}
            #endregion
            #region 4) Permissions
            // Ask Eng"Radwa
            #endregion
            #region 5) Colors
            //Console.WriteLine("Enter Color");
            //string ColorInput = Console.ReadLine();
            //if(Enum.TryParse(ColorInput,out Colors color))
            //{
            //    Console.WriteLine("Primay");
            //}
            //else
            //    Console.WriteLine("Not Primay");
            #endregion
            #region 6) Point
            //Point Point1 = new Point();
            //Point Point2 = new Point();
            //Console.WriteLine("Enetr P1");
            //Point1.X = double.Parse(Console.ReadLine());
            //Point1.Y = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enetr P2");
            //Point2.X = double.Parse(Console.ReadLine());
            //Point2.Y = double.Parse(Console.ReadLine());
            //double Distance = CalDistance(Point1, Point2);
            //Console.WriteLine(Distance);
            #endregion
            #region 7) Person
            //Person[] P1 = new Person[3];
            //P1[0] = new Person { Age = 22, Name = "Abdelrahman" };
            //P1[1] = new Person { Age = 40, Name = "sherif" };
            //P1[2] = new Person { Age = 34, Name = "said" };

            //Person oldPerson = FindOldest(P1);

            //Console.WriteLine(oldPerson.Name);
            #endregion
        }
    }
}