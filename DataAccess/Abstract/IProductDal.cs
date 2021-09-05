﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Car> GetAll();
        Car GetById(int id);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
