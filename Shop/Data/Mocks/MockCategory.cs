using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICategoryRepo
    {
        public IEnumerable<Category> List
        {
            get
            {
                return new Category[] {
                    new Category { Name = "Category_1", Description = "Desc_1"},
                    new Category { Name = "Category_2", Description = "Desc_2"},
                    new Category { Name = "Category_3", Description = "Desc_3"}
                };
            }
        }
    }
}
