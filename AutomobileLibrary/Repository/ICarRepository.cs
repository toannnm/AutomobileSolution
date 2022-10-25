﻿

using AutomobileLibrary.BussinessObject;
using System.Collections;
namespace AutomobileLibrary.Repository
{
    public interface ICarRepository

    {
        IEnumerable<Car> GetCars();
        Car GetCarByID(int carId);
        void InsertCar(Car car);
        void DeleteCar(int carID);
        void UpdateCar(Car car);
    }
}
