using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemeory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
              new Product{ProductId=1,BrandId=1,ColorId=3,ModelYear="2011",DailyPrice=390,Description="klimalı ve otomatik"},
               new Product{ProductId=2,BrandId=6,ColorId=2,ModelYear="2017",DailyPrice=340,Description="klimalı ve düz"},
               new Product{ProductId=3,BrandId=5,ColorId=3,ModelYear="2015",DailyPrice=345,Description="klimalı ve düz"},
               new Product{ProductId=4,BrandId=4,ColorId=3,ModelYear="2013",DailyPrice=320,Description="klimasız ve otomatik"},
               new Product{ProductId=5,BrandId=3,ColorId=1,ModelYear="2012",DailyPrice=310,Description="klimasız ve düz"}
            };
        }
        public void Add(Product product) 
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(product);
        }

        public List<Product> GetAll()
        {
           return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;
            productToUpdate.ModelYear = product.ModelYear;
        }
        public List<Product> GetAllById(int brandId)
        {
           return _products.Where(p => p.BrandId == brandId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
