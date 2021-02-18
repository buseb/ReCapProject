using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentAlService
    {
        IDataResult<List<RentAl>> GetAll();
        IDataResult<RentAl> GetRentAlById(int rentalId);
        IResult Add(RentAl rentAl);
        IResult Delete(int rentalId);
        IResult Update(int rentalId);
    }
}
