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
    public class UserManager : IUserService

    {
        IUserDal _userDal;

        public UserManager(IUserDal userService)
        {
            _userDal = userService;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(int userId)
        {
            var result = _userDal.Get(p => p.Id == userId);
            _userDal.Delete(result);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            var result = _userDal.GetAll();
            return new SuccessDataResult<List<User>>(result, Messages.CarsListed);
        }

        public IDataResult<User> GetUserId(int userId)
        {
            var result = _userDal.Get(p => p.Id == userId);
            return new SuccessDataResult<User>(result, Messages.CarDeleted);
        }

        public IResult Update(int userId)
        {
            var result = _userDal.Get(p => p.Id == userId);
            _userDal.Update(result);
            return new SuccessDataResult<User>(result, Messages.CarDeleted);
        }
    }
}
