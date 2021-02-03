using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car> { 
            new Car{Id=1,ColorId=1,BrandId=1, DailyPrice= 500000 ,  ModelYear="2020", Description= "1. araba"},
            new Car{Id=2,ColorId=3,BrandId=1, DailyPrice= 400000 ,  ModelYear="2017", Description= "2. araba"},
            new Car{Id=3,ColorId=2,BrandId=2, DailyPrice= 300000 ,  ModelYear="2018", Description= "3. araba"},
            new Car{Id=4,ColorId=2,BrandId=2, DailyPrice= 600000 ,  ModelYear="2022", Description= "4. araba"},
            new Car{Id=5,ColorId=3,BrandId=1, DailyPrice= 700000 ,  ModelYear="2021", Description= "5. araba"},

            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c=> c.Id==car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id== car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
