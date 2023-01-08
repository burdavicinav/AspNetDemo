using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    public interface ICarRepo
    {
        IEnumerable<Car> List { get; }

        IEnumerable<Car> FavoriteCars { get; set; }

        Car CarById(int id);

        void Create(Car car);

        void Update(Car car);

        void Remove(Car car);

        void SaveChanges();
    }
}
