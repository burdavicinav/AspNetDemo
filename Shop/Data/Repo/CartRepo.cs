using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repo
{
    public class CartRepo : ICartRepo
    {
        private readonly ApplicationContext context;

        public CartRepo(ApplicationContext context)
        {
            this.context = context;
        }

        public void AddToCart(Cart cart, CartItem item)
        {
            throw new NotImplementedException();
        }

        public void Clear(Cart cart)
        {
            throw new NotImplementedException();
        }

        public void Create(Cart cart)
        {
            context.Cart.Add(cart);
            context.SaveChanges();
        }

        public bool IsExists(int id)
        {
            return GetById(id).Id != 0;
        }

        public Cart GetById(int id)
        {
            return context.Cart
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public IEnumerable<Cart> GetList()
        {
            return context.Cart;
        }

        public void RemoveFromCart(Cart cart, CartItem item)
        {
            throw new NotImplementedException();
        }
    }
}
