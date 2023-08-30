using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop.Data;
using MyShop.Data.Entities;

namespace MyShopConsole.Services
{
public class ProductService
    {
        private ShopDataContext _context;

        public ProductService()
        {
            _context = new ShopDataContext();
        }

        public void Add(Product product,bool isSaveChange=true) 
        {
            _context.Products.Add(product);
            if (isSaveChange)
            {
                _context.SaveChanges();
            }
        }
        public Product GetById(int Id)
        {
            return _context.Products.Where( p=> p.Id == Id).FirstOrDefault();
          

        }
        
    }
}
