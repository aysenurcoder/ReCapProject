using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemeory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            if (product.DailyPrice > 0)
            {
                _productDal.Add(product);
                Console.WriteLine("Araba eklendi");
            }
            else
            {
                Console.WriteLine("Arabanın günlük fiyatı 0 dan büyük olmalıdır.Girdiğiz değer:" +(product.DailyPrice));
            }
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetByDailyPice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByColorId(int id)
        {
            return _productDal.GetAll(c => c.ColorId == id);
        }

    }
        
}
