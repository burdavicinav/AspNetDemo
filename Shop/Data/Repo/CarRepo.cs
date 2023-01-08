using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repo
{
    public class CarRepo : ICarRepo
    {
        ApplicationContext context;

        public CarRepo(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Car> List
        {
            get
            {
                return context.Car.Include(x => x.Category);
            }
        }

        public IEnumerable<Car> FavoriteCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car CarById(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Car car)
        {
            context.Add(car);
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }

        public void Remove(Car car)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
