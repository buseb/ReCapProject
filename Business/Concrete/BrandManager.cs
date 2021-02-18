using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<Brand>> GetAllBrands()
        {
            var result = _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(result,Messages.CarsListed);
            
        }

        public IDataResult<Brand> GetBrandById(int id)
        {
            var result = _brandDal.Get(p => p.CarBrandId == id);
            return new SuccessDataResult<Brand>(result, Messages.CarsListed);
        }

        public Brand GetCarsByBrandId(int BrandId)
        {
            return _brandDal.Get(c => c.CarBrandId == BrandId);
        }

    }
}
