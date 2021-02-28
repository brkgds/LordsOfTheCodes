using Core.Utilities.ResultManager;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        // Result Management
        // n-layered
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetListByBrandId(int brandid);
        IDataResult<List<Car>> GetListByColorId(int colorid);
        IResult Add(Car car);
        IResult Remove(Car car);
        IResult Update(Car car);

    }
}
