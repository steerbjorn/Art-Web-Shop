using ArtWebshop.Data;
using ArtWebshop.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Models
{
    public class ShoppingCart
    {
        private readonly ProductDbContext _productDbContext;
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        
        private IHttpContextAccessor _contextAccessor;

        public string ShoppingCartId { get; set; }

        public ShoppingCart(ProductDbContext productDbContext, IHttpContextAccessor contextAccessor)
        {
            _productDbContext = productDbContext;
            _contextAccessor = contextAccessor;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<ProductDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);
            

            return new ShoppingCart(context, services.GetRequiredService<IHttpContextAccessor>()) { ShoppingCartId = cartId };
        }

        public void AddToCart(Product product)
        {
            ShoppingCartItem item;
            
            if (SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(_contextAccessor.HttpContext.Session, "ShoppingCartItems") != null)
            {
                ShoppingCartItems = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(_contextAccessor.HttpContext.Session, "ShoppingCartItems");

            }
            else
            {
                ShoppingCartItems = new List<ShoppingCartItem>();
            }

            if (ShoppingCartItems.Exists(i => i.Product.ProductId == product.ProductId))//.FirstOrDefault(i => i.Product.ProductId == product.ProductId) == null)
            {
                item = ShoppingCartItems.FirstOrDefault(i => i.Product.ProductId == product.ProductId);
                item.Amount++;

            }
            else
            {
                item = new ShoppingCartItem()
                {
                    Product = product,
                    Amount = 1,
                    ShoppingCartId = ShoppingCartId
                };
                ShoppingCartItems.Add(item);
            }
            
            SessionHelper.SetObjectAsJson(_contextAccessor.HttpContext.Session, "ShoppingCartItems", ShoppingCartItems);
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(_contextAccessor.HttpContext.Session, "ShoppingCartItems");
        }

        public decimal GetShoppingCartTotal()
        {
            var items = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(_contextAccessor.HttpContext.Session, "ShoppingCartItems");
            var total = items.Select(i => i.Product.Price * i.Amount).Sum();
            return total;
        }
    }
}
