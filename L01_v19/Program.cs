using System;

namespace L01_v19
{
    class Program
    {
        static void Main(string[] args)
        {
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
            #region
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());

            Circle circle = new(x, y, r);
            Console.WriteLine($"Квадрант кола: {circle.Quadrant};\nПлоща кола: {circle.Area};\nДовжина кола: {circle.Perimeter}.");
            #endregion
        }
    }
}
