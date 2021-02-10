using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> GetProductsByColorId(int id);
        List<Product> GetByDailyPice(decimal min, decimal max);

       
    } 
}
