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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(int customerId)
        {
            var result = _customerDal.Get(c => c.UserId == customerId);
            _customerDal.Delete(result);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            var result = _customerDal.GetAll();
            return new SuccessDataResult<List<Customer>>(result, Messages.CarsListed);
        }

        public IDataResult<Customer> GetCustomerById(int customerId)
        {
            var result = _customerDal.Get(p => p.UserId == customerId);
            return new SuccessDataResult<Customer>(result, Messages.CarsListed);
        }

        public IResult Update(int customerId)
        {
            var result = _customerDal.Get(p => p.UserId == customerId);
            _customerDal.Update(result);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
