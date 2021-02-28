using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.Utilities.ResultManager;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarManager(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            _carRepository.Add(car);
            return new SuccessResult(Message.CarAdd);
        }

        public IDataResult<List<Car>> GetAll()
        {
            var data = _carRepository.GetList();
            return new SuccessDataResult<List<Car>>(data, Message.GetAllCar);
        }

        public IDataResult<Car> GetById(int id)
        {
            var data = _carRepository.GetById(p=>p.Id==id);
            return new SuccessDataResult<Car>(data, Message.GetByCarId);

        }

        public IDataResult<List<Car>> GetListByBrandId(int brandid)
        {
            var data = _carRepository.GetList(p => p.BrandId == brandid);
            return new SuccessDataResult<List<Car>>(data, Message.GetByBrandId);
        }

        public IDataResult<List<Car>> GetListByColorId(int colorid)
        {
            var data = _carRepository.GetList(p => p.ColorId == colorid);
            return new SuccessDataResult<List<Car>>(data, Message.GetListByColorId);
        }

        public IResult Remove(Car car)
        {
            _carRepository.Delete(car);
            return new SuccessResult(Message.CarDelete);
        }

        public IResult Update(Car car)
        {
            _carRepository.Update(car);
            return new SuccessResult(Message.CarUpdate);
        }
    }
}
