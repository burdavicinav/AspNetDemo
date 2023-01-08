using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICategoryRepo categoryRepo;

        private readonly ICarRepo carRepo;

        private const string key = "test";

        public CarsController(ICategoryRepo categoryRepo, ICarRepo carRepo, IServiceProvider services)
        {
            this.categoryRepo = categoryRepo;
            this.carRepo = carRepo;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Test Title";

            var cars = carRepo.List;

            return View(cars);
        }

        public ViewResult Add()
        {
            carRepo.Create(
                new Car
                {
                    Name = "Car_1",
                    ShortDescription = "sd",
                    LongDescription = "ld",
                    Img = "img",
                    Price = 11000,
                    IsFavorite = true,
                    Available = true,
                    Category = new Category { Name = "Category_1", Description = "Desc_1" }
                });

            carRepo.SaveChanges();

            ViewBag.Title = "Add car";
            
            var cars = carRepo.List;

            return View(cars);
        }
    }
}
