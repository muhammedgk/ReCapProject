using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carmanager = new CarManager(new InMemoryCarDal());
            foreach (var cars in carmanager.GetAll())
            {
                Console.WriteLine(cars.Description);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
