
using System;

using Bussiness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetlAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }

    
}
