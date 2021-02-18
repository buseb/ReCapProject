using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,RentaCarContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using(RentaCarContext context = new RentaCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.CarBrandId equals b.CarBrandId
                             join r in context.Colors
                             on c.CarColorId equals r.CarColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 CarBrandName = b.CarBrandName,
                                 CarColorName = r.CarColorName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear
                             };
                return result.ToList();
            }
        }//CarName, BrandName, ColorName, DailyPrice
    }
}
