using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService 
    { 

        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
           //business codes

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(int carId)
        {
            var result = _carDal.Get(p => p.CarId == carId);
            _carDal.Delete(result);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            var result = _carDal.GetCarDetails();
            return new SuccessDataResult<List<CarDetailDto>>(result, Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            var GetCarId = _carDal.GetAll(p => p.CarId == brandId).ToList();
            return new SuccessDataResult<List<Car>>(GetCarId, Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            var GetCar = _carDal.GetAll(c => c.CarColorId == colorId).ToList();
            return new SuccessDataResult<List<Car>>(GetCar, Messages.CarsListed);
        }

        public IResult Update(int carId)
        {
            var result = _carDal.Get(p => p.CarId == carId);
            _carDal.Update(result);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
