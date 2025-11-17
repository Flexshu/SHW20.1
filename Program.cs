using HW20_Models;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var context = new AppDbContext();
            context.Cars.RemoveRange(context.Cars);
            context.SaveChanges();

            var cars = new[]
            {
                new Car { Producer = "Ferrari", Model = "Stradale", TopSpeed = 340, Accelaration = 2, Price = 250000 },
                new Car { Producer = "McLaren", Model = "P1", TopSpeed = 350, Accelaration = 2, Price = 1150000 },
                new Car { Producer = "Bugatti", Model = "Bolid", TopSpeed = 500, Accelaration = 1, Price = 4200000 },
                new Car { Producer = "Apollo", Model = "IE", TopSpeed = 350, Accelaration = 2, Price = 2200000 },
                new Car { Producer = "Chevrolet", Model = "Corvette ZR1", TopSpeed = 338, Accelaration = 3, Price = 120000 }
            };
            context.Cars.AddRange(cars);
            context.SaveChanges();

            var fastCars = context.Cars
                .Where(c => c.TopSpeed >= 350)
                .OrderByDescending(c => c.TopSpeed)
                .ToList();

            Console.WriteLine("Fast cars:");
            foreach (var car in fastCars)
            {
                Console.WriteLine($"{car.Producer} {car.Model} - {car.TopSpeed} km/h");
            }
        }
    }
}