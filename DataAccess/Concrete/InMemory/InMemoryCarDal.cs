using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,CarBrandId=10,CarColorId=10,ModelYear=2015,DailyPrice=1000,Description=""},
                new Car{CarId=2,CarBrandId=11,CarColorId=11,ModelYear=2019,DailyPrice=1500,Description=""},
                new Car{CarId=3,CarBrandId=12,CarColorId=12,ModelYear=2020,DailyPrice=1600,Description=""},
                new Car{CarId=4,CarBrandId=13,CarColorId=13,ModelYear=2021,DailyPrice=1800,Description=""},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        public Car GetById(int id)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.CarId == id);
            return carToDelete;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToDelete.CarId = car.CarId;
            carToDelete.CarBrandId = car.CarBrandId;
            carToDelete.CarColorId = car.CarColorId;
            carToDelete.DailyPrice = car.DailyPrice;
            carToDelete.ModelYear = car.ModelYear;
            carToDelete.Description = car.Description;
        }
    }

    
}
