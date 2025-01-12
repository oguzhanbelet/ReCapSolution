﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarForRentContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarForRentContext context = new CarForRentContext())
            {
                var result = from c in context.Cars
                             join br in context.Brands
                             on c.BrandId equals br.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto { CarId = c.CarId, BrandName = br.BrandName, ColorName = co.ColorName, ModelYear = c.ModelYear, DailyPrice = c.DailyPrice};
                return result.ToList();
                             
                             
            }
        }
    }
}
