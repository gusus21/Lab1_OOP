using System;

namespace L01_v19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task (1 - 6):");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1: Task1(); break;
                case 2: Task2(); break;
                case 3: Task3(); break;
                case 4: Task4(); break;
                case 5: Task5(); break;
                case 6: Task6(); break;
                default: Console.WriteLine("Error"); break;
            }
        }
        //Task 1
        #region
        static void Task1()
        {
            Console.WriteLine("Input data: addr, idx, cntr, ct, strt, hs");
            Address address = new Address();
            address.Index = int.Parse(Console.ReadLine());
            address.Country = Console.ReadLine();
            address.City = Console.ReadLine();
            address.Street = Console.ReadLine();
            address.House = int.Parse(Console.ReadLine());
            Console.WriteLine("apps? 1 - yes, 2 - no");
            byte a = byte.Parse(Console.ReadLine());
            switch (a)
            {
                case 1: address.Apartment = int.Parse(Console.ReadLine()); break;
                case 2: address.Apartment = 0; break;
            }
            Console.WriteLine(address); 
        }
        #endregion
        //Task 2
        #region
        static void Task2()
        {
            Console.WriteLine("Input x, y, r");
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float r = float.Parse(Console.ReadLine());

            Circle circle = new(x, y, r);
            Console.WriteLine($"Квадрант кола: {circle.Quadrant};\nПлоща кола: {circle.Area};\nДовжина кола: {circle.Perimeter}.");
        }
        #endregion
        //Task 3
        #region
        static void Task3()
        {
            Console.WriteLine("Length");
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
            figure.PerimeterCalculator();
        }
        #endregion
        //Task 4
        #region
        static void Task4()
        {
            Console.WriteLine("amount");
          int amount = int.Parse(Console.ReadLine());
          User[] users = new User[amount];
            Console.WriteLine("Input name pass date");
          Fill(users);
          int i = int.Parse(Console.ReadLine());
          if(i - 1 >= 0 && i - 1 < amount)
          Console.WriteLine(users[i]);
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
        #endregion
        //Task 5
        #region
        static void Task5()
        {
            Console.WriteLine("input money, and two valutes");
            float money = float.Parse(Console.ReadLine());
            float val1 = float.Parse(Console.ReadLine());
            float val2 = float.Parse(Console.ReadLine());
            Converter converter = new Converter(val1, val2);
            Console.WriteLine("Type of operation:\n1 - uah to val 1\n2 - uah to val 2\n3 - val 1 to uah\n4 - val 2 to uah");
            byte tp = byte.Parse(Console.ReadLine());
            switch (tp)
            {
                case 1: Console.WriteLine(money / converter.Vallet1); break;
                case 2: Console.WriteLine(money / converter.Vallet2); break;
                case 3: Console.WriteLine(money * converter.Vallet1); break;
                case 4: Console.WriteLine(money * converter.Vallet2); break;
                default: Console.WriteLine("Error"); break;
            }
        }
        #endregion
        //Task 6
        #region
        static void Task6()
        {
            Console.WriteLine("The min x, max x and size of step");
            double x = double.Parse(Console.ReadLine());
            double endX = double.Parse(Console.ReadLine());
            if (endX < x)
                Console.WriteLine("Error");
            else
            {
                Function function = new Function(x, endX);
                function.ShowXYPairs();
            }
        }   
    #endregion
    }
}
