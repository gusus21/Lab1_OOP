using System;

namespace L01_v19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            #region
            /*
             Address address = new Address();
             address.Index = 9018;
             address.Country = "Ukraine";
             address.City = "Cherkasy";
             address.Street = "Smilyanska";
             address.House = 25;
             address.Apartment = 12;

             Console.WriteLine(address);*/
            #endregion
            //Task 2
            #region
            /*
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());

            Circle circle = new(x, y, r);
            Console.WriteLine($"Квадрант кола: {circle.Quadrant};\nПлоща кола: {circle.Area};\nДовжина кола: {circle.Perimeter}.");*/
            #endregion
            //Task 3
            #region
            /*
            int length = int.Parse(Console.ReadLine());
            int x;
            int y;
            string name;
            string[] data;
            Point[] points = new Point[length];
            Console.WriteLine("Дані: х, у, ім'я");
            for (int i = 0; i < length; i++)
            {
                data = Console.ReadLine().Trim().Split();
                x = int.Parse(data[0]);
                y = int.Parse(data[1]);
                name = data[2];
                points[i] = new(x, y, name);
            }
            Figure figure = new(points[0], points[1], points[2]);
            switch (points.Length)
            {
                case 4: figure = new(points); break;
                case 5: figure = new(points, points[4]); break;
            }
            Console.WriteLine("Фігура: {0}", figure.TypeOfFigure());
            figure.PerimeterCalculator();*/
            #endregion
            //Task 4
            #region
            /*  int amount = int.Parse(Console.ReadLine());
              User[] users = new User[amount];
              Fill(users);
              int i = int.Parse(Console.ReadLine());
              if(i - 1 >= 0 && i - 1 < amount)
              Console.WriteLine(users[i]);*/
            #endregion
            //Task 5
            #region
            double money = double.Parse(Console.ReadLine()); 

            #endregion
        }
        static void Fill(User[] users)
        {
            string name, password, date;
            for(int i = 0; i < users.Length;i++)
            {
                name = Console.ReadLine();
                password = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                date = Console.ReadLine();
                users[i] = new User(name, password, age, date);
            }
        }
    }
}
