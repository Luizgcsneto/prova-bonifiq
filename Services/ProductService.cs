﻿using ProvaPub.Models;
using ProvaPub.Repository;
using ProvaPub.Services.Interfaces;

namespace ProvaPub.Services
{
    public class ProductService : IProductService
    {
        TestDbContext _ctx;

        public ProductService(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public ProductList ListProducts(int page)
        {
            return new ProductList() { Products = _ctx.Products.Skip(--page * 10).Take(10).ToList() };
        }

    }
}
