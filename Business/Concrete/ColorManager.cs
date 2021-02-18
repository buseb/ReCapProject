using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Colors color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Add(Color color)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Colors>> GetAllColors()
        {
            var result = _colorDal.GetAll();
            return new SuccessDataResult<List<Colors>>(result,Messages.CarsListed);
        }

        public IDataResult<Colors> GetColorById(int id)
        {
            var result = _colorDal.Get(p => p.CarColorId == id);
            return new SuccessDataResult<Colors>(result, Messages.CarsListed);
        }

        IDataResult<List<Color>> IColorService.GetAllColors()
        {
            throw new NotImplementedException();
        }

        IDataResult<Color> IColorService.GetColorById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
