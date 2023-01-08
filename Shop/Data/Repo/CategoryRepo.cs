using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repo
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly ApplicationContext context;

        public CategoryRepo(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Category> List
        {
            get
            {
                return context.Category;
            }
        }
    }
}
