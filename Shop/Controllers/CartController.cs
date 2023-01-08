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
    public class CartController : Controller
    {
        private ICartRepo cartRepo;

        private readonly ISession session;

        private const string sessionKey = "cart";

        public CartController(ICartRepo cartRepo, IServiceProvider services)
        {
            this.cartRepo = cartRepo;
            session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
        }

        public ViewResult Obj()
        {
            int? id = session.GetInt32(sessionKey);

            Cart cart;

            if (id.HasValue)
            {
                cart = cartRepo.GetById(id.Value);
            }
            else
            {
                cart = new Cart() { CreateDate = DateTime.Now };

                cartRepo.Create(cart);

                session.SetInt32(sessionKey, cart.Id);
            }

            return View(cart);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            return RedirectToAction("obj");
        }
    }
}
