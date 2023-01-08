using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCar : ICarRepo
    {
        private readonly ICategoryRepo categoryRepo = new MockCategory();

        public IEnumerable<Car> List 
        {
            get
            {
                return new Car[]
                    {
                        new Car
                        {
                            Name = "Car_1",
                            ShortDescription = "sd",
                            LongDescription = "ld",
                            Img = "img",
                            Price = 11000,
                            IsFavorite = true,
                            Available = true,
                            Category = categoryRepo.List.First()
                        },
                        new Car
                        {
                            Name = "Car_2",
                            ShortDescription = "sd",
                            LongDescription = "ld",
                            Img = "img",
                            Price = 16000,
                            IsFavorite = true,
                            Available = true,
                            Category = categoryRepo.List.ElementAt(1)
                        },
                        new Car
                        {
                            Name = "Car_3",
                            ShortDescription = "sd",
                            LongDescription = "ld",
                            Img = "img",
                            Price = 23000,
                            IsFavorite = false,
                            Available = true,
                            Category = categoryRepo.List.ElementAt(2)
                        },
                        new Car
                        {
                            Name = "Car_4",
                            ShortDescription = "sd",
                            LongDescription = "ld",
                            Img = "img",
                            Price = 11000,
                            IsFavorite = true,
                            Available = false,
                            Category = categoryRepo.List.Last()
                        },
                        new Car
                        {
                            Name = "Car_5",
                            ShortDescription = "sd",
                            LongDescription = "ld",
                            Img = "img",
                            Price = 44000,
                            IsFavorite = true,
                            Available = true,
                            Category = categoryRepo.List.First()
                        }
                    };

            }
        }

        public IEnumerable<Car> FavoriteCars { get; set; }

        public Car CarById(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Car car)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
