using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    public interface ICartRepo
    {
        IEnumerable<Cart> GetList();

        bool IsExists(int id);

        Cart GetById(int id);

        void Create(Cart cart);

        void Clear(Cart cart);

        void AddToCart(Cart cart, CartItem item);

        void RemoveFromCart(Cart cart, CartItem item);
    }
}
