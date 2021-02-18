using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUserId(int userId);
        IResult Add(User user);
        IResult Update(int userId);
        IResult Delete(int userId);
    }
}
