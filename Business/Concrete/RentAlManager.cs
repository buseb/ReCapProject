using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentAlManager : IRentAlService
    {
        IRentAlDal _rentalDal;

        public RentAlManager(IRentAlDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(RentAl rentAl)
        {
            if (rentAl.ReturnDate == null)
            {
                return new SuccessResult(Messages.ErrorMessage);
            }
            _rentalDal.Add(rentAl);
            return new SuccessResult(Messages.MaintenanceTime);
        }

        public IResult Delete(int rentalId)
        {
            var result = _rentalDal.Get(p => p.Id == rentalId);
            if (result.RentDate == result.ReturnDate)
            {
                _rentalDal.Delete(result);
                return new SuccessResult(Messages.CarDeleted);
            }
            return new ErrorResult(Messages.ErrorMessage);
        }

        public IDataResult<List<RentAl>> GetAll()
        {
            var result = _rentalDal.GetAll();
            return new SuccessDataResult<List<RentAl>>(result, Messages.CarsListed);
        }

        public IDataResult<RentAl> GetRentAlById(int rentalId)
        {
            var result = _rentalDal.Get(p => p.Id == rentalId);
            //Gelen Kiralamanın ne zaman kiralandığı ve ne zaman getirilmesi gerektiğini gösteriyor
            Console.WriteLine(result.RentDate);
            Console.WriteLine(result.ReturnDate);
            return new SuccessDataResult<RentAl>(result, Messages.CarsListed);
        }

        public IResult Update(int rentalId)
        {
            var result = _rentalDal.Get(p => p.Id == rentalId);

            if (result != null)
            {
                if (result.ReturnDate == null)
                {
                    //geri getiriliş tarihini şimdiye ayarlıyor
                    _rentalDal.Update(result);
                    Console.WriteLine("Aracınız geri teslim edilmiştir");
                    return new SuccessResult(Messages.CarUpdated);
                }
            }

            return new ErrorResult(Messages.ErrorMessage);
        }
    }
}
